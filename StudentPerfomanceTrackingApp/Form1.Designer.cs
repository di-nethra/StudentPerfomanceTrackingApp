namespace StudentPerfomanceTrackingApp
{
    partial class Form1
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
            buttonSaveSession = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            labelDuration = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelDateTime = new Label();
            progressBar1 = new ProgressBar();
            comboBox2 = new ComboBox();
            labelKnowladge = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSaveSession
            // 
            buttonSaveSession.Location = new Point(251, 719);
            buttonSaveSession.Name = "buttonSaveSession";
            buttonSaveSession.Size = new Size(745, 73);
            buttonSaveSession.TabIndex = 0;
            buttonSaveSession.Text = "Save Session";
            buttonSaveSession.UseVisualStyleBackColor = true;
            buttonSaveSession.Click += buttonSaveSession_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-11, 5);
            tabControl1.Margin = new Padding(10);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1981, 875);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightCyan;
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(labelDuration);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(labelDateTime);
            tabPage1.Controls.Add(progressBar1);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(labelKnowladge);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(buttonSaveSession);
            tabPage1.ForeColor = SystemColors.ActiveCaptionText;
            tabPage1.Location = new Point(8, 46);
            tabPage1.Margin = new Padding(10);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1965, 821);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create Session";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(596, 402);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 39);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 481);
            label2.Name = "label2";
            label2.Size = new Size(77, 32);
            label2.TabIndex = 10;
            label2.Text = "Notes";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(596, 481);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(400, 187);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Location = new Point(251, 402);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(188, 32);
            labelDuration.TabIndex = 8;
            labelDuration.Text = "Duration (hours)";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(596, 315);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 7;
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Location = new Point(251, 315);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(171, 32);
            labelDateTime.TabIndex = 6;
            labelDateTime.Text = "Date and Time";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(251, 247);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(275, 18);
            progressBar1.TabIndex = 5;
            progressBar1.Value = 30;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(596, 212);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(242, 40);
            comboBox2.TabIndex = 4;
            // 
            // labelKnowladge
            // 
            labelKnowladge.AutoSize = true;
            labelKnowladge.Location = new Point(251, 212);
            labelKnowladge.Name = "labelKnowladge";
            labelKnowladge.Size = new Size(287, 32);
            labelKnowladge.TabIndex = 3;
            labelKnowladge.Text = "Current Knowledge Level:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(596, 125);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 125);
            label1.Name = "label1";
            label1.Size = new Size(224, 32);
            label1.TabIndex = 1;
            label1.Text = "Select your Subject:";
          
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1965, 821);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Edit Session";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(10);
            tabPage3.Size = new Size(1965, 821);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Delete Session";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 948);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSaveSession;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label labelKnowladge;
        private ComboBox comboBox1;
        private Label label1;
        private Label labelDateTime;
        private ProgressBar progressBar1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label labelDuration;
    }
}
