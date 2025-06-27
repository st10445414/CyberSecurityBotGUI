namespace CyberSecurityBotGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstChatHistory = new System.Windows.Forms.ListBox();
            this.grpQuiz = new System.Windows.Forms.GroupBox();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.rdoD = new System.Windows.Forms.RadioButton();
            this.rdoC = new System.Windows.Forms.RadioButton();
            this.rdoB = new System.Windows.Forms.RadioButton();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lstActivityLog = new System.Windows.Forms.ListBox();
            this.txtLogSearch = new System.Windows.Forms.TextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnExportLog = new System.Windows.Forms.Button();
            this.grpQuiz.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TaskTiltle";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(32, 198);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Set remainder";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 262);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(32, 323);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete Task";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(539, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Mark Complete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(539, 47);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(100, 26);
            this.txtUserInput.TabIndex = 10;
            this.txtUserInput.Text = "txtuserinput";
            this.txtUserInput.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(539, 105);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "btnsend";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // lstChatHistory
            // 
            this.lstChatHistory.FormattingEnabled = true;
            this.lstChatHistory.ItemHeight = 20;
            this.lstChatHistory.Location = new System.Drawing.Point(699, 47);
            this.lstChatHistory.Name = "lstChatHistory";
            this.lstChatHistory.Size = new System.Drawing.Size(120, 84);
            this.lstChatHistory.TabIndex = 12;
            this.lstChatHistory.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // grpQuiz
            // 
            this.grpQuiz.Controls.Add(this.btnNextQuestion);
            this.grpQuiz.Controls.Add(this.btnSubmitAnswer);
            this.grpQuiz.Controls.Add(this.lblFeedback);
            this.grpQuiz.Controls.Add(this.rdoD);
            this.grpQuiz.Controls.Add(this.rdoC);
            this.grpQuiz.Controls.Add(this.rdoB);
            this.grpQuiz.Controls.Add(this.rdoA);
            this.grpQuiz.Controls.Add(this.lblQuestion);
            this.grpQuiz.Location = new System.Drawing.Point(687, 185);
            this.grpQuiz.Name = "grpQuiz";
            this.grpQuiz.Size = new System.Drawing.Size(395, 352);
            this.grpQuiz.TabIndex = 13;
            this.grpQuiz.TabStop = false;
            this.grpQuiz.Text = "Cybersecurity Quiz";
            this.grpQuiz.Enter += new System.EventHandler(this.grpQuiz_Enter);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(125, 301);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnNextQuestion.TabIndex = 7;
            this.btnNextQuestion.Text = "Next";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Location = new System.Drawing.Point(21, 301);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitAnswer.TabIndex = 6;
            this.btnSubmitAnswer.Text = "Submit";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(17, 246);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(51, 20);
            this.lblFeedback.TabIndex = 5;
            this.lblFeedback.Text = "label3";
            this.lblFeedback.Click += new System.EventHandler(this.lblFeedback_Click);
            // 
            // rdoD
            // 
            this.rdoD.AutoSize = true;
            this.rdoD.Location = new System.Drawing.Point(17, 197);
            this.rdoD.Name = "rdoD";
            this.rdoD.Size = new System.Drawing.Size(126, 24);
            this.rdoD.TabIndex = 4;
            this.rdoD.TabStop = true;
            this.rdoD.Text = "radioButton4";
            this.rdoD.UseVisualStyleBackColor = true;
            this.rdoD.CheckedChanged += new System.EventHandler(this.rdoD_CheckedChanged);
            // 
            // rdoC
            // 
            this.rdoC.AutoSize = true;
            this.rdoC.Location = new System.Drawing.Point(17, 159);
            this.rdoC.Name = "rdoC";
            this.rdoC.Size = new System.Drawing.Size(126, 24);
            this.rdoC.TabIndex = 3;
            this.rdoC.TabStop = true;
            this.rdoC.Text = "radioButton3";
            this.rdoC.UseVisualStyleBackColor = true;
            this.rdoC.CheckedChanged += new System.EventHandler(this.rdoC_CheckedChanged);
            // 
            // rdoB
            // 
            this.rdoB.AutoSize = true;
            this.rdoB.Location = new System.Drawing.Point(17, 114);
            this.rdoB.Name = "rdoB";
            this.rdoB.Size = new System.Drawing.Size(126, 24);
            this.rdoB.TabIndex = 2;
            this.rdoB.TabStop = true;
            this.rdoB.Text = "radioButton2";
            this.rdoB.UseVisualStyleBackColor = true;
            this.rdoB.CheckedChanged += new System.EventHandler(this.rdoB_CheckedChanged);
            // 
            // rdoA
            // 
            this.rdoA.AutoSize = true;
            this.rdoA.Location = new System.Drawing.Point(17, 77);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(21, 20);
            this.rdoA.TabIndex = 1;
            this.rdoA.TabStop = true;
            this.rdoA.UseVisualStyleBackColor = true;
            this.rdoA.CheckedChanged += new System.EventHandler(this.rdoA_CheckedChanged);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(13, 39);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(0, 20);
            this.lblQuestion.TabIndex = 0;
            // 
            // lstActivityLog
            // 
            this.lstActivityLog.FormattingEnabled = true;
            this.lstActivityLog.ItemHeight = 20;
            this.lstActivityLog.Location = new System.Drawing.Point(32, 440);
            this.lstActivityLog.Name = "lstActivityLog";
            this.lstActivityLog.Size = new System.Drawing.Size(120, 84);
            this.lstActivityLog.TabIndex = 14;
            // 
            // txtLogSearch
            // 
            this.txtLogSearch.Location = new System.Drawing.Point(32, 560);
            this.txtLogSearch.Name = "txtLogSearch";
            this.txtLogSearch.Size = new System.Drawing.Size(100, 26);
            this.txtLogSearch.TabIndex = 15;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(32, 628);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 16;
            this.btnClearLog.Text = "button4";
            this.btnClearLog.UseVisualStyleBackColor = true;
            // 
            // btnExportLog
            // 
            this.btnExportLog.Location = new System.Drawing.Point(153, 628);
            this.btnExportLog.Name = "btnExportLog";
            this.btnExportLog.Size = new System.Drawing.Size(75, 23);
            this.btnExportLog.TabIndex = 17;
            this.btnExportLog.Text = "button5";
            this.btnExportLog.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 737);
            this.Controls.Add(this.btnExportLog);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.txtLogSearch);
            this.Controls.Add(this.lstActivityLog);
            this.Controls.Add(this.grpQuiz);
            this.Controls.Add(this.lstChatHistory);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpQuiz.ResumeLayout(false);
            this.grpQuiz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstChatHistory;
        private System.Windows.Forms.GroupBox grpQuiz;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.RadioButton rdoD;
        private System.Windows.Forms.RadioButton rdoC;
        private System.Windows.Forms.RadioButton rdoB;
        private System.Windows.Forms.RadioButton rdoA;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.ListBox lstActivityLog;
        private System.Windows.Forms.TextBox txtLogSearch;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnExportLog;
    }
}

