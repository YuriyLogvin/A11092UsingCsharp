namespace TestSensors
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCurrSens1Curr = new System.Windows.Forms.TextBox();
            this.checkBoxCurrSens1Have = new System.Windows.Forms.CheckBox();
            this.textBoxCurrSens1Temp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerPollingDevices = new System.Windows.Forms.Timer(this.components);
            this.buttonPoll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detected devices:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCurrSens1Temp);
            this.groupBox1.Controls.Add(this.checkBoxCurrSens1Have);
            this.groupBox1.Controls.Add(this.textBoxCurrSens1Curr);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 44);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current sensor 1";
            // 
            // textBoxCurrSens1Curr
            // 
            this.textBoxCurrSens1Curr.Enabled = false;
            this.textBoxCurrSens1Curr.Location = new System.Drawing.Point(109, 16);
            this.textBoxCurrSens1Curr.Name = "textBoxCurrSens1Curr";
            this.textBoxCurrSens1Curr.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrSens1Curr.TabIndex = 0;
            // 
            // checkBoxCurrSens1Have
            // 
            this.checkBoxCurrSens1Have.AutoSize = true;
            this.checkBoxCurrSens1Have.Location = new System.Drawing.Point(13, 19);
            this.checkBoxCurrSens1Have.Name = "checkBoxCurrSens1Have";
            this.checkBoxCurrSens1Have.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCurrSens1Have.TabIndex = 1;
            this.checkBoxCurrSens1Have.UseVisualStyleBackColor = true;
            // 
            // textBoxCurrSens1Temp
            // 
            this.textBoxCurrSens1Temp.Enabled = false;
            this.textBoxCurrSens1Temp.Location = new System.Drawing.Point(263, 16);
            this.textBoxCurrSens1Temp.Name = "textBoxCurrSens1Temp";
            this.textBoxCurrSens1Temp.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrSens1Temp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "current";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "temp";
            // 
            // timerPollingDevices
            // 
            this.timerPollingDevices.Interval = 1000;
            this.timerPollingDevices.Tick += new System.EventHandler(this.timerPollingDevices_Tick);
            // 
            // buttonPoll
            // 
            this.buttonPoll.Location = new System.Drawing.Point(285, 13);
            this.buttonPoll.Name = "buttonPoll";
            this.buttonPoll.Size = new System.Drawing.Size(75, 23);
            this.buttonPoll.TabIndex = 4;
            this.buttonPoll.Text = "Poll";
            this.buttonPoll.UseVisualStyleBackColor = true;
            this.buttonPoll.Click += new System.EventHandler(this.buttonPoll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 347);
            this.Controls.Add(this.buttonPoll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Device Processor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCurrSens1Temp;
        private System.Windows.Forms.CheckBox checkBoxCurrSens1Have;
        private System.Windows.Forms.TextBox textBoxCurrSens1Curr;
        private System.Windows.Forms.Timer timerPollingDevices;
        private System.Windows.Forms.Button buttonPoll;
    }
}

