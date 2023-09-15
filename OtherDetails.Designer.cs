namespace EmployeesApplication
{
    partial class OtherDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherDetails));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxAttendance = new TextBox();
            comboBoxMonth = new ComboBox();
            comboBoxYear = new ComboBox();
            buttonprint2 = new Button();
            label5 = new Label();
            radioyes = new RadioButton();
            radiono = new RadioButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 96);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 0;
            label1.Text = "Month";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 145);
            label2.Name = "label2";
            label2.Size = new Size(35, 19);
            label2.TabIndex = 1;
            label2.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(51, 184);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 2;
            label3.Text = "Attendance";
            // 
            // textBoxAttendance
            // 
            textBoxAttendance.Location = new Point(182, 186);
            textBoxAttendance.Name = "textBoxAttendance";
            textBoxAttendance.Size = new Size(164, 23);
            textBoxAttendance.TabIndex = 3;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBoxMonth.Location = new Point(182, 92);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(164, 23);
            comboBoxMonth.TabIndex = 4;
            comboBoxMonth.SelectedIndexChanged += comboBoxMonth_SelectedIndexChanged;
            // 
            // comboBoxYear
            // 
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Items.AddRange(new object[] { "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030" });
            comboBoxYear.Location = new Point(182, 141);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(164, 23);
            comboBoxYear.TabIndex = 5;
            comboBoxYear.SelectedIndexChanged += comboBoxYear_SelectedIndexChanged;
            // 
            // buttonprint2
            // 
            buttonprint2.BackColor = Color.White;
            buttonprint2.Cursor = Cursors.Hand;
            buttonprint2.FlatStyle = FlatStyle.Popup;
            buttonprint2.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonprint2.ForeColor = Color.Red;
            buttonprint2.Location = new Point(182, 276);
            buttonprint2.Name = "buttonprint2";
            buttonprint2.Size = new Size(111, 32);
            buttonprint2.TabIndex = 6;
            buttonprint2.Text = "GENERATE PDF";
            buttonprint2.UseVisualStyleBackColor = false;
            buttonprint2.Click += buttonprint2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(51, 224);
            label5.Name = "label5";
            label5.Size = new Size(114, 38);
            label5.TabIndex = 8;
            label5.Text = "TDS on the basis\r\nof attendance?";
            // 
            // radioyes
            // 
            radioyes.AutoSize = true;
            radioyes.Location = new Point(182, 238);
            radioyes.Margin = new Padding(3, 2, 3, 2);
            radioyes.Name = "radioyes";
            radioyes.Size = new Size(42, 19);
            radioyes.TabIndex = 9;
            radioyes.TabStop = true;
            radioyes.Text = "yes";
            radioyes.UseVisualStyleBackColor = true;
            radioyes.CheckedChanged += radioyes_CheckedChanged;
            // 
            // radiono
            // 
            radiono.AutoSize = true;
            radiono.Location = new Point(232, 238);
            radiono.Margin = new Padding(3, 2, 3, 2);
            radiono.Name = "radiono";
            radiono.Size = new Size(39, 19);
            radiono.TabIndex = 10;
            radiono.TabStop = true;
            radiono.Text = "no";
            radiono.UseVisualStyleBackColor = true;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.ForeColor = Color.IndianRed;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            labelControl1.Location = new Point(95, 16);
            labelControl1.Margin = new Padding(3, 2, 3, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Padding = new Padding(35, 0, 35, 0);
            labelControl1.Size = new Size(251, 25);
            labelControl1.TabIndex = 12;
            labelControl1.Text = "Enter Below Details";
            // 
            // OtherDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(408, 366);
            Controls.Add(labelControl1);
            Controls.Add(radiono);
            Controls.Add(radioyes);
            Controls.Add(label5);
            Controls.Add(buttonprint2);
            Controls.Add(comboBoxYear);
            Controls.Add(comboBoxMonth);
            Controls.Add(textBoxAttendance);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(345, 300);
            MaximizeBox = false;
            Name = "OtherDetails";
            StartPosition = FormStartPosition.Manual;
            Text = "OtherDetails";
            Load += OtherDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonprint2;
        internal ComboBox comboBoxMonth;
        internal ComboBox comboBoxYear;
        internal TextBox textBoxAttendance;
        private Label label5;
        private RadioButton radioyes;
        private RadioButton radiono;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}