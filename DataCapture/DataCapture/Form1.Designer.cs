namespace DataCapture
{
    partial class DataCapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.plotTemp = new OxyPlot.WindowsForms.PlotView();
            this.plotPressure = new OxyPlot.WindowsForms.PlotView();
            this.plotAltitude = new OxyPlot.WindowsForms.PlotView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.connectBtn = new System.Windows.Forms.Button();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.captureBtn = new System.Windows.Forms.Button();
            this.filepathBox = new System.Windows.Forms.TextBox();
            this.fileSelectBtn = new System.Windows.Forms.Button();
            this.resampleBox = new System.Windows.Forms.TextBox();
            this.averageBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.applyBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.presLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.altLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Location = new System.Drawing.Point(0, 770);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1783, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1783, 678);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.plotAltitude, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.plotPressure, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.plotTemp, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1783, 678);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // plotTemp
            // 
            this.plotTemp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plotTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotTemp.Location = new System.Drawing.Point(597, 3);
            this.plotTemp.Name = "plotTemp";
            this.plotTemp.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotTemp.Size = new System.Drawing.Size(588, 672);
            this.plotTemp.TabIndex = 1;
            this.plotTemp.Text = "plotView1";
            this.plotTemp.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotTemp.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotTemp.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotPressure
            // 
            this.plotPressure.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plotPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotPressure.Location = new System.Drawing.Point(3, 3);
            this.plotPressure.Name = "plotPressure";
            this.plotPressure.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotPressure.Size = new System.Drawing.Size(588, 672);
            this.plotPressure.TabIndex = 0;
            this.plotPressure.Text = "plotView1";
            this.plotPressure.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotPressure.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotPressure.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotAltitude
            // 
            this.plotAltitude.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plotAltitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotAltitude.Location = new System.Drawing.Point(1191, 3);
            this.plotAltitude.Name = "plotAltitude";
            this.plotAltitude.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotAltitude.Size = new System.Drawing.Size(589, 672);
            this.plotAltitude.TabIndex = 2;
            this.plotAltitude.Text = "plotView2";
            this.plotAltitude.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotAltitude.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotAltitude.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.altLabel);
            this.panel2.Controls.Add(this.tempLabel);
            this.panel2.Controls.Add(this.presLabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.applyBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.averageBox);
            this.panel2.Controls.Add(this.resampleBox);
            this.panel2.Controls.Add(this.fileSelectBtn);
            this.panel2.Controls.Add(this.filepathBox);
            this.panel2.Controls.Add(this.captureBtn);
            this.panel2.Controls.Add(this.portComboBox);
            this.panel2.Controls.Add(this.connectBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1783, 92);
            this.panel2.TabIndex = 0;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(143, 12);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(88, 23);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Poveži";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // portComboBox
            // 
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(12, 12);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(121, 21);
            this.portComboBox.TabIndex = 1;
            // 
            // captureBtn
            // 
            this.captureBtn.Location = new System.Drawing.Point(143, 41);
            this.captureBtn.Name = "captureBtn";
            this.captureBtn.Size = new System.Drawing.Size(88, 23);
            this.captureBtn.TabIndex = 2;
            this.captureBtn.Text = "Začni zajem";
            this.captureBtn.UseVisualStyleBackColor = true;
            this.captureBtn.Click += new System.EventHandler(this.captureBtn_Click);
            // 
            // filepathBox
            // 
            this.filepathBox.Enabled = false;
            this.filepathBox.Location = new System.Drawing.Point(342, 14);
            this.filepathBox.Name = "filepathBox";
            this.filepathBox.Size = new System.Drawing.Size(192, 20);
            this.filepathBox.TabIndex = 3;
            // 
            // fileSelectBtn
            // 
            this.fileSelectBtn.Location = new System.Drawing.Point(247, 12);
            this.fileSelectBtn.Name = "fileSelectBtn";
            this.fileSelectBtn.Size = new System.Drawing.Size(89, 23);
            this.fileSelectBtn.TabIndex = 4;
            this.fileSelectBtn.Text = "Izberi datoteko";
            this.fileSelectBtn.UseVisualStyleBackColor = true;
            this.fileSelectBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // resampleBox
            // 
            this.resampleBox.Location = new System.Drawing.Point(680, 17);
            this.resampleBox.Name = "resampleBox";
            this.resampleBox.Size = new System.Drawing.Size(100, 20);
            this.resampleBox.TabIndex = 5;
            this.resampleBox.Text = "2";
            // 
            // averageBox
            // 
            this.averageBox.Location = new System.Drawing.Point(680, 43);
            this.averageBox.Name = "averageBox";
            this.averageBox.Size = new System.Drawing.Size(100, 20);
            this.averageBox.TabIndex = 6;
            this.averageBox.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vzorči vsakih # vzorcev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Povpreči # vzorcev";
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(786, 15);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 9;
            this.applyBtn.Text = "Uporabi";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(929, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pritisk:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(876, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Temperatura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(929, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Višina:";
            // 
            // presLabel
            // 
            this.presLabel.AutoSize = true;
            this.presLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presLabel.Location = new System.Drawing.Point(998, 15);
            this.presLabel.Name = "presLabel";
            this.presLabel.Size = new System.Drawing.Size(50, 20);
            this.presLabel.TabIndex = 13;
            this.presLabel.Text = "0 hPa";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.Location = new System.Drawing.Point(998, 39);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(33, 20);
            this.tempLabel.TabIndex = 14;
            this.tempLabel.Text = "0 C";
            // 
            // altLabel
            // 
            this.altLabel.AutoSize = true;
            this.altLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altLabel.Location = new System.Drawing.Point(998, 65);
            this.altLabel.Name = "altLabel";
            this.altLabel.Size = new System.Drawing.Size(35, 20);
            this.altLabel.TabIndex = 15;
            this.altLabel.Text = "0 m";
            // 
            // DataCapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1783, 795);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DataCapForm";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private OxyPlot.WindowsForms.PlotView plotAltitude;
        private OxyPlot.WindowsForms.PlotView plotPressure;
        private OxyPlot.WindowsForms.PlotView plotTemp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox averageBox;
        private System.Windows.Forms.TextBox resampleBox;
        private System.Windows.Forms.Button fileSelectBtn;
        private System.Windows.Forms.TextBox filepathBox;
        private System.Windows.Forms.Button captureBtn;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label altLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label presLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

