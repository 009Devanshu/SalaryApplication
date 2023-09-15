namespace EmployeesApplication
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            contextMenuStrip1 = new ContextMenuStrip(components);
            pdfstriptool = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            yearToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox2 = new ToolStripComboBox();
            attendanceToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox3 = new ToolStripComboBox();
            btnsearch2 = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panel3 = new Panel();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { pdfstriptool });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(212, 28);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;
            // 
            // pdfstriptool
            // 
            pdfstriptool.Name = "pdfstriptool";
            pdfstriptool.Size = new Size(211, 24);
            pdfstriptool.Text = "Generate Salary Slip";
            pdfstriptool.Click += pdfstriptool_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox1 });
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(210, 24);
            printToolStripMenuItem.Text = "Month";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Items.AddRange(new object[] { "Janaury", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            // 
            // yearToolStripMenuItem
            // 
            yearToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox2 });
            yearToolStripMenuItem.Name = "yearToolStripMenuItem";
            yearToolStripMenuItem.Size = new Size(210, 24);
            yearToolStripMenuItem.Text = "Year";
            // 
            // toolStripComboBox2
            // 
            toolStripComboBox2.Items.AddRange(new object[] { "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030" });
            toolStripComboBox2.Name = "toolStripComboBox2";
            toolStripComboBox2.Size = new Size(121, 28);
            // 
            // attendanceToolStripMenuItem
            // 
            attendanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox3 });
            attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            attendanceToolStripMenuItem.Size = new Size(210, 24);
            attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // toolStripComboBox3
            // 
            toolStripComboBox3.Name = "toolStripComboBox3";
            toolStripComboBox3.Size = new Size(121, 28);
            // 
            // btnsearch2
            // 
            btnsearch2.Anchor = AnchorStyles.Left;
            btnsearch2.Location = new Point(305, 25);
            btnsearch2.Name = "btnsearch2";
            btnsearch2.Size = new Size(271, 27);
            btnsearch2.TabIndex = 5;
            btnsearch2.TextChanged += btnsearch2_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.AntiqueWhite;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 205);
            dataGridView1.Margin = new Padding(3, 91, 3, 3);
            dataGridView1.MaximumSize = new Size(5000, 5000);
            dataGridView1.MinimumSize = new Size(0, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1426, 351);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellMouseClick += rightMouse_Click;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnsearch2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(11, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 65);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(0, 25);
            label2.Name = "label2";
            label2.Size = new Size(296, 27);
            label2.TabIndex = 6;
            label2.Text = "Search Record By Name";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button1);
            panel2.Location = new Point(1218, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 67);
            panel2.TabIndex = 9;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Gray;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(6, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(2);
            button1.Size = new Size(202, 51);
            button1.TabIndex = 0;
            button1.Text = "Add Or Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelControl1.Appearance.ForeColor = Color.IndianRed;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            labelControl1.Location = new Point(-9, 3);
            labelControl1.Name = "labelControl1";
            labelControl1.Padding = new Padding(821, 11, 600, 0);
            labelControl1.Size = new Size(1956, 52);
            labelControl1.TabIndex = 10;
            labelControl1.Text = "ATF EMPLOYEES MANAGEMENT";
            labelControl1.Click += labelControl1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(labelControl1);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1426, 209);
            panel3.TabIndex = 11;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.AliceBlue;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1427, 560);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnsearch;
        private TextBox txtname;
        private Button btnprint;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem yearToolStripMenuItem;
        private ToolStripMenuItem attendanceToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox3;
        private ToolStripMenuItem pdfstriptool;
        private ToolStripComboBox toolStripComboBox2;
        private TextBox btnsearch2;
        public DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Label label2;
        private Button button1;
        private Panel panel3;
    }
}