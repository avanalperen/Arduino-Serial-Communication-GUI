namespace Arduino_Serial_Communication_GUI
{
    partial class ArduinoSerialComGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxParityBits = new ComboBox();
            comboBoxStopBits = new ComboBox();
            comboBoxDataBits = new ComboBox();
            comboBoxBaudRate = new ComboBox();
            comboBoxComPort = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            buttonClose = new Button();
            buttonOpen = new Button();
            progressBar1 = new ProgressBar();
            buttonSendData = new Button();
            textBoxDataOutput = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxParityBits);
            groupBox1.Controls.Add(comboBoxStopBits);
            groupBox1.Controls.Add(comboBoxDataBits);
            groupBox1.Controls.Add(comboBoxBaudRate);
            groupBox1.Controls.Add(comboBoxComPort);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(25, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 273);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Communication Port Control";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(35, 231);
            label5.Margin = new Padding(10);
            label5.Name = "label5";
            label5.Size = new Size(93, 21);
            label5.TabIndex = 8;
            label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(47, 182);
            label4.Margin = new Padding(10);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 7;
            label4.Text = "STOP BITS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(47, 133);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 6;
            label3.Text = "DATA BITS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(38, 84);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 5;
            label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(40, 35);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 1;
            label1.Text = "COM PORT";
            // 
            // comboBoxParityBits
            // 
            comboBoxParityBits.Font = new Font("Segoe UI", 12F);
            comboBoxParityBits.FormattingEnabled = true;
            comboBoxParityBits.Items.AddRange(new object[] { "None", "Odd", "Even" });
            comboBoxParityBits.Location = new Point(148, 228);
            comboBoxParityBits.Margin = new Padding(10);
            comboBoxParityBits.Name = "comboBoxParityBits";
            comboBoxParityBits.Size = new Size(121, 29);
            comboBoxParityBits.TabIndex = 4;
            // 
            // comboBoxStopBits
            // 
            comboBoxStopBits.Font = new Font("Segoe UI", 12F);
            comboBoxStopBits.FormattingEnabled = true;
            comboBoxStopBits.Items.AddRange(new object[] { "One ", "Two" });
            comboBoxStopBits.Location = new Point(148, 179);
            comboBoxStopBits.Margin = new Padding(10);
            comboBoxStopBits.Name = "comboBoxStopBits";
            comboBoxStopBits.Size = new Size(121, 29);
            comboBoxStopBits.TabIndex = 3;
            // 
            // comboBoxDataBits
            // 
            comboBoxDataBits.Font = new Font("Segoe UI", 12F);
            comboBoxDataBits.FormattingEnabled = true;
            comboBoxDataBits.Items.AddRange(new object[] { "6", "7", "8" });
            comboBoxDataBits.Location = new Point(148, 130);
            comboBoxDataBits.Margin = new Padding(10);
            comboBoxDataBits.Name = "comboBoxDataBits";
            comboBoxDataBits.Size = new Size(121, 29);
            comboBoxDataBits.TabIndex = 2;
            // 
            // comboBoxBaudRate
            // 
            comboBoxBaudRate.Font = new Font("Segoe UI", 12F);
            comboBoxBaudRate.FormattingEnabled = true;
            comboBoxBaudRate.Items.AddRange(new object[] { "2400", "4800", "9600" });
            comboBoxBaudRate.Location = new Point(148, 81);
            comboBoxBaudRate.Margin = new Padding(10);
            comboBoxBaudRate.Name = "comboBoxBaudRate";
            comboBoxBaudRate.Size = new Size(121, 29);
            comboBoxBaudRate.TabIndex = 1;
            // 
            // comboBoxComPort
            // 
            comboBoxComPort.Font = new Font("Segoe UI", 12F);
            comboBoxComPort.FormattingEnabled = true;
            comboBoxComPort.Location = new Point(148, 32);
            comboBoxComPort.Margin = new Padding(10);
            comboBoxComPort.Name = "comboBoxComPort";
            comboBoxComPort.Size = new Size(121, 29);
            comboBoxComPort.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonClose);
            groupBox2.Controls.Add(buttonOpen);
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Location = new Point(25, 323);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(196, 150);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // buttonClose
            // 
            buttonClose.AutoSize = true;
            buttonClose.Font = new Font("Segoe UI", 12F);
            buttonClose.Location = new Point(108, 29);
            buttonClose.Margin = new Padding(10);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 31);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.AutoSize = true;
            buttonOpen.Font = new Font("Segoe UI", 12F);
            buttonOpen.Location = new Point(13, 29);
            buttonOpen.Margin = new Padding(10);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(75, 31);
            buttonOpen.TabIndex = 2;
            buttonOpen.Text = "Open";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(13, 80);
            progressBar1.Margin = new Padding(10);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(170, 40);
            progressBar1.TabIndex = 2;
            // 
            // buttonSendData
            // 
            buttonSendData.AutoSize = true;
            buttonSendData.Font = new Font("Segoe UI", 12F);
            buttonSendData.Location = new Point(231, 323);
            buttonSendData.Margin = new Padding(10);
            buttonSendData.Name = "buttonSendData";
            buttonSendData.Size = new Size(91, 150);
            buttonSendData.TabIndex = 4;
            buttonSendData.Text = "Send Data";
            buttonSendData.UseVisualStyleBackColor = true;
            buttonSendData.Click += buttonSendData_Click;
            // 
            // textBoxDataOutput
            // 
            textBoxDataOutput.Location = new Point(335, 32);
            textBoxDataOutput.Multiline = true;
            textBoxDataOutput.Name = "textBoxDataOutput";
            textBoxDataOutput.Size = new Size(203, 441);
            textBoxDataOutput.TabIndex = 5;
            // 
            // ArduinoSerialComGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 511);
            Controls.Add(textBoxDataOutput);
            Controls.Add(buttonSendData);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ArduinoSerialComGUI";
            Text = "ArduinoSerialComGUI";
            Load += ArduinoSerialComGUI_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBoxParityBits;
        private ComboBox comboBoxStopBits;
        private ComboBox comboBoxDataBits;
        private ComboBox comboBoxBaudRate;
        private ComboBox comboBoxComPort;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private ProgressBar progressBar1;
        private Button buttonClose;
        private Button buttonOpen;
        private Button buttonSendData;
        private TextBox textBoxDataOutput;
    }
}
