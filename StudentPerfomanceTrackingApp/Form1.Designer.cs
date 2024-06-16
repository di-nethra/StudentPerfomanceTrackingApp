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
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            richTextBox2 = new RichTextBox();
            checkBox2 = new CheckBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSaveSession
            // 
            buttonSaveSession.Location = new Point(1105, 593);
            buttonSaveSession.Name = "buttonSaveSession";
            buttonSaveSession.Size = new Size(816, 87);
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
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
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
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(467, 348);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(477, 47);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(56, 433);
            label2.Name = "label2";
            label2.Size = new Size(109, 41);
            label2.TabIndex = 10;
            label2.Text = "Notes:";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 11F);
            richTextBox1.Location = new Point(467, 433);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(477, 101);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelDuration.Location = new Point(56, 348);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(260, 41);
            labelDuration.TabIndex = 8;
            labelDuration.Text = "Duration (hours):";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 11F);
            dateTimePicker1.Location = new Point(467, 267);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(477, 47);
            dateTimePicker1.TabIndex = 7;
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelDateTime.Location = new Point(56, 267);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(231, 41);
            labelDateTime.TabIndex = 6;
            labelDateTime.Text = "Date and Time:";
            labelDateTime.Click += labelDateTime_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(66, 204);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(349, 11);
            progressBar1.TabIndex = 5;
            progressBar1.Value = 30;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 11F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(467, 168);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(477, 48);
            comboBox2.TabIndex = 4;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // labelKnowladge
            // 
            labelKnowladge.AutoSize = true;
            labelKnowladge.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelKnowladge.Location = new Point(56, 160);
            labelKnowladge.Name = "labelKnowladge";
            labelKnowladge.Size = new Size(379, 41);
            labelKnowladge.TabIndex = 3;
            labelKnowladge.Text = "Current Knowledge Level:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(467, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(477, 48);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(56, 84);
            label1.Name = "label1";
            label1.Size = new Size(295, 41);
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            checkBox1.Location = new Point(56, 560);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(381, 45);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Recurring study session";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MediumPurple;
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(labelDuration);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(labelDateTime);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(labelKnowladge);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(71, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(973, 647);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Study Session";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.MediumPurple;
            groupBox2.Controls.Add(dateTimePicker3);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(richTextBox2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 11F);
            groupBox2.Location = new Point(1105, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(816, 491);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Breaks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(56, 86);
            label3.Name = "label3";
            label3.Size = new Size(173, 41);
            label3.TabIndex = 0;
            label3.Text = "Start Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(56, 169);
            label4.Name = "label4";
            label4.Size = new Size(157, 41);
            label4.TabIndex = 1;
            label4.Text = "End Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(56, 255);
            label5.Name = "label5";
            label5.Size = new Size(126, 41);
            label5.TabIndex = 2;
            label5.Text = "Reason:";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(271, 255);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(477, 101);
            richTextBox2.TabIndex = 13;
            richTextBox2.Text = "";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            checkBox2.Location = new Point(56, 393);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(275, 45);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "Recurring Break";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(271, 169);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(477, 47);
            dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(271, 86);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(477, 47);
            dateTimePicker3.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1952, 928);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private CheckBox checkBox2;
        private RichTextBox richTextBox2;
    }
}
