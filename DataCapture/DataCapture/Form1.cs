using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataCapture
{
    public partial class DataCapForm : Form
    {
        StreamWriter writer;
        SerialPort serialPort;
        bool isCapturing = false;
        Stopwatch sw;

        SerialDataReceivedEventHandler serialHandler;

        PlotModel presPlotModel;
        PlotModel tempPlotModel;
        PlotModel altPlotModel;

        LineSeries presSeries;
        LineSeries tempSeries;
        LineSeries altSeries;

        int counter = 0;


        public DataCapForm()
        {
            InitializeComponent();

            serialHandler = new SerialDataReceivedEventHandler(port_DataRcvd);

            initPortComboBox();

            
            presPlotModel = new PlotModel { Title = "Graf zračnega pritiska [hPa]" };
            plotPressure.Model = presPlotModel;

            presSeries = new LineSeries();
            presSeries.Color = OxyColors.Blue;
            plotPressure.Model.Series.Add(presSeries);
            
            

            //////

            tempPlotModel = new PlotModel { Title = "Graf temperature [°C]" };
            plotTemp.Model = tempPlotModel;


            tempSeries = new LineSeries();
            tempSeries.Color = OxyColors.Red;
            plotTemp.Model.Series.Add(tempSeries);

            //////

            altPlotModel = new PlotModel { Title = "Graf nadmorske višine [m]" };
            plotAltitude.Model = altPlotModel;
         

            altSeries = new LineSeries();
            altSeries.Color = OxyColors.Black;
            plotAltitude.Model.Series.Add(altSeries);

            applyBtn_Click(null, null);

        }

        private void initPortComboBox()
        {
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                portComboBox.Items.Add(s);
            }

            portComboBox.SelectedIndex = 0;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Select location to store CSV capture data.";
            saveFileDialog.Filter = "CSV files |*.csv";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "data_capture.csv";

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                writer = new StreamWriter(saveFileDialog.FileName);
                filepathBox.Text = saveFileDialog.FileName;
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (serialPort == null)
            {
                string portName = (string)portComboBox.SelectedItem;
                serialPort = new SerialPort(portName, 57600);
              
                tryConnect();

            }
            else if (!serialPort.IsOpen)
            {
                tryConnect();
            } else
            {
                serialPort.Close();
                connectBtn.Text = "Poveži";
            }
        }

        private void tryConnect()
        {
            try
            {
                Debug.WriteLine("Opening port " + serialPort.PortName);
                serialPort.Open();
                connectBtn.Text = "Ustavi";
            }
            catch (Exception e)
            {
                MessageBox.Show("Error opening port " + serialPort.PortName + ": " + e.Message);
                connectBtn.Text = "Poveži";
            }
        }

        private void captureBtn_Click(object sender, EventArgs e)
        {
            if (!isCapturing)
            {
                if (sw == null)
                {
                    sw = new Stopwatch();
                    sw.Start();
                }
                counter = 0;
                serialPort.DataReceived += serialHandler;
                serialPort.Write("S");
                captureBtn.Text = "Ustavi zajem";
                isCapturing = true;
            } else
            {
                //sw.Stop();
                serialPort.Write("P");
                serialPort.DataReceived -= serialHandler;
                captureBtn.Text = "Začni zajem";
                isCapturing = false;
            }
        }

        int resampleN = 5;
        int averageN = 5;
        List<double[]> buffer = new List<double[]>();

        private void port_DataRcvd(object sender, SerialDataReceivedEventArgs e)
        {
           

            byte[] bytes = new byte[32];
            serialPort.Read(bytes, 0, 32);

            byte[] presBytes = SubArray(bytes, 22 ,4);

            byte[] tempBytes = SubArray(bytes, 26, 4);


            Array.Reverse(tempBytes);

            Array.Reverse(presBytes);

            double pres = BitConverter.ToInt32(presBytes, 0) /100.0;

            double temp = BitConverter.ToInt32(tempBytes, 0) / 100.0;

            if (pres > 1200 || (pres == 0 && temp == 0) ) return;

            double altitude = calculate_altitude(pres,temp);

            double[] cap =  { sw.ElapsedMilliseconds, pres, temp, altitude};



            counter++;

            if (counter%resampleN != 0)
            {
                return;
            }

            if (buffer.Count >= averageN)
            {
                cap = makeAvg(buffer);
                buffer.Clear();
            } else
            {
                buffer.Add(cap);
                return;
            }

            saveData(cap);

            Debug.WriteLine(cap[1] + " " + cap[2] + " " + cap[3]);

            renderData(cap);
        }

        private double[] makeAvg(List<double[]> buffer)
        {
            double[] avg = new double[4];

            foreach(double[] cap in buffer)
            {
                for(int i = 0; i < 4; i++)
                {
                    avg[i] += cap[i];
                }
            }

            for (int i = 0; i < 4; i++)
            {
                avg[i] = avg[i]/ buffer.Count;
            }

            return avg;


        }

        private void renderData(double[] cap)
        {
            updateChart(cap);

        }

        private delegate void updateChartDelegate(double[] cap);

        void updateChart(double[] cap)
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new updateChartDelegate(updateChart), cap);
            } else
            {
                presSeries.Points.Add(new DataPoint(cap[0]/1000, cap[1]));
                tempSeries.Points.Add(new DataPoint(cap[0]/1000, cap[2]));
                altSeries.Points.Add(new DataPoint(cap[0]/1000, cap[3]));

                presPlotModel.InvalidatePlot(true);
                tempPlotModel.InvalidatePlot(true);
                altPlotModel.InvalidatePlot(true);

                altLabel.Text = String.Format("{0:0.00} m",cap[3]);
                presLabel.Text = String.Format("{0:0.00} hPa", cap[1]); ;
                tempLabel.Text = String.Format("{0:0.00}°C", cap[2]); ;

                presPlotModel.DefaultYAxis.Title = "Zračni pritisk [hPa]";

                altPlotModel.DefaultYAxis.Title = "Nadmorska višina [m]";

                tempPlotModel.DefaultYAxis.Title = "Temperatura [°C]";

                presPlotModel.DefaultXAxis.Title = "Čas [s]";

                altPlotModel.DefaultXAxis.Title = "Čas [s]";

                tempPlotModel.DefaultXAxis.Title = "Čas [s]";

            }
        }

        private void saveData(double[] cap)
        {
            if (writer == null) return;
            writer.WriteLine(String.Join(",",cap));
            writer.Flush();
        }

        private double calculate_altitude(double pres, double temp)
        {
            double REF_PRES = 1013.25 / pres;
            double exp = 1.0 / 5.257;


            double alt = Math.Pow(REF_PRES, exp) -1;
            alt = alt * (temp + 273.15);
            alt = alt / 0.0065;

            return alt;
        }

        public T[] SubArray<T>(T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {

            if (averageBox.Text == "") averageBox.Text = averageN.ToString();
            if (resampleBox.Text == "") resampleBox.Text = resampleN.ToString();
            averageN = int.Parse(averageBox.Text);
            resampleN = int.Parse(resampleBox.Text);

        }
    }
}
