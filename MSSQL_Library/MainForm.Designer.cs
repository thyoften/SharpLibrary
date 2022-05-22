namespace MSSQL_Library
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioAnyBeforeAfter = new System.Windows.Forms.RadioButton();
            this.radioAnyAfter = new System.Windows.Forms.RadioButton();
            this.radioAnyBefore = new System.Windows.Forms.RadioButton();
            this.radioExact = new System.Windows.Forms.RadioButton();
            this.tbSearchString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchYearBirth = new System.Windows.Forms.Button();
            this.btnSearchYear = new System.Windows.Forms.Button();
            this.btnSearchUserSurname = new System.Windows.Forms.Button();
            this.btnSearchUserName = new System.Windows.Forms.Button();
            this.btnSearchTitle = new System.Windows.Forms.Button();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1377, 189);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.btnLogout);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1369, 156);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Activities";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(449, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 144);
            this.button4.TabIndex = 5;
            this.button4.Text = "View rentals";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(1220, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(141, 144);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(302, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 144);
            this.button3.TabIndex = 3;
            this.button3.Text = "New rental";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(155, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 144);
            this.button2.TabIndex = 2;
            this.button2.Text = "Register user";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(8, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 144);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioAnyBeforeAfter);
            this.tabPage2.Controls.Add(this.radioAnyAfter);
            this.tabPage2.Controls.Add(this.radioAnyBefore);
            this.tabPage2.Controls.Add(this.radioExact);
            this.tabPage2.Controls.Add(this.tbSearchString);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1369, 156);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioAnyBeforeAfter
            // 
            this.radioAnyBeforeAfter.AutoSize = true;
            this.radioAnyBeforeAfter.Location = new System.Drawing.Point(233, 115);
            this.radioAnyBeforeAfter.Name = "radioAnyBeforeAfter";
            this.radioAnyBeforeAfter.Size = new System.Drawing.Size(457, 24);
            this.radioAnyBeforeAfter.TabIndex = 7;
            this.radioAnyBeforeAfter.Text = "Any characters before && after (or between year and current year)";
            this.radioAnyBeforeAfter.UseVisualStyleBackColor = true;
            // 
            // radioAnyAfter
            // 
            this.radioAnyAfter.AutoSize = true;
            this.radioAnyAfter.Location = new System.Drawing.Point(233, 85);
            this.radioAnyAfter.Name = "radioAnyAfter";
            this.radioAnyAfter.Size = new System.Drawing.Size(203, 24);
            this.radioAnyAfter.TabIndex = 6;
            this.radioAnyAfter.Text = "Any characters after (or >)";
            this.radioAnyAfter.UseVisualStyleBackColor = true;
            // 
            // radioAnyBefore
            // 
            this.radioAnyBefore.AutoSize = true;
            this.radioAnyBefore.Location = new System.Drawing.Point(8, 115);
            this.radioAnyBefore.Name = "radioAnyBefore";
            this.radioAnyBefore.Size = new System.Drawing.Size(216, 24);
            this.radioAnyBefore.TabIndex = 5;
            this.radioAnyBefore.Text = "Any characters before (or <)";
            this.radioAnyBefore.UseVisualStyleBackColor = true;
            // 
            // radioExact
            // 
            this.radioExact.AutoSize = true;
            this.radioExact.Checked = true;
            this.radioExact.Location = new System.Drawing.Point(8, 85);
            this.radioExact.Name = "radioExact";
            this.radioExact.Size = new System.Drawing.Size(110, 24);
            this.radioExact.TabIndex = 4;
            this.radioExact.TabStop = true;
            this.radioExact.Text = "Exact match";
            this.radioExact.UseVisualStyleBackColor = true;
            // 
            // tbSearchString
            // 
            this.tbSearchString.Location = new System.Drawing.Point(6, 52);
            this.tbSearchString.Name = "tbSearchString";
            this.tbSearchString.Size = new System.Drawing.Size(874, 27);
            this.tbSearchString.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search string:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearchYearBirth);
            this.groupBox1.Controls.Add(this.btnSearchYear);
            this.groupBox1.Controls.Add(this.btnSearchUserSurname);
            this.groupBox1.Controls.Add(this.btnSearchUserName);
            this.groupBox1.Controls.Add(this.btnSearchTitle);
            this.groupBox1.Controls.Add(this.btnSearchAuthor);
            this.groupBox1.Location = new System.Drawing.Point(886, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search types";
            // 
            // btnSearchYearBirth
            // 
            this.btnSearchYearBirth.Location = new System.Drawing.Point(235, 96);
            this.btnSearchYearBirth.Name = "btnSearchYearBirth";
            this.btnSearchYearBirth.Size = new System.Drawing.Size(223, 29);
            this.btnSearchYearBirth.TabIndex = 5;
            this.btnSearchYearBirth.Text = "Search year of birth";
            this.btnSearchYearBirth.UseVisualStyleBackColor = true;
            // 
            // btnSearchYear
            // 
            this.btnSearchYear.Location = new System.Drawing.Point(6, 96);
            this.btnSearchYear.Name = "btnSearchYear";
            this.btnSearchYear.Size = new System.Drawing.Size(223, 29);
            this.btnSearchYear.TabIndex = 4;
            this.btnSearchYear.Text = "Search year";
            this.btnSearchYear.UseVisualStyleBackColor = true;
            this.btnSearchYear.Click += new System.EventHandler(this.btnSearchYear_Click);
            // 
            // btnSearchUserSurname
            // 
            this.btnSearchUserSurname.Location = new System.Drawing.Point(235, 61);
            this.btnSearchUserSurname.Name = "btnSearchUserSurname";
            this.btnSearchUserSurname.Size = new System.Drawing.Size(223, 29);
            this.btnSearchUserSurname.TabIndex = 3;
            this.btnSearchUserSurname.Text = "Search reader surname";
            this.btnSearchUserSurname.UseVisualStyleBackColor = true;
            // 
            // btnSearchUserName
            // 
            this.btnSearchUserName.Location = new System.Drawing.Point(235, 26);
            this.btnSearchUserName.Name = "btnSearchUserName";
            this.btnSearchUserName.Size = new System.Drawing.Size(223, 29);
            this.btnSearchUserName.TabIndex = 2;
            this.btnSearchUserName.Text = "Search reader name";
            this.btnSearchUserName.UseVisualStyleBackColor = true;
            // 
            // btnSearchTitle
            // 
            this.btnSearchTitle.Location = new System.Drawing.Point(6, 26);
            this.btnSearchTitle.Name = "btnSearchTitle";
            this.btnSearchTitle.Size = new System.Drawing.Size(223, 29);
            this.btnSearchTitle.TabIndex = 0;
            this.btnSearchTitle.Text = "Search book title";
            this.btnSearchTitle.UseVisualStyleBackColor = true;
            this.btnSearchTitle.Click += new System.EventHandler(this.btnSearchTitle_Click);
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.Location = new System.Drawing.Point(6, 61);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(223, 29);
            this.btnSearchAuthor.TabIndex = 1;
            this.btnSearchAuthor.Text = "Search author";
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearchAuthor_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(0, 189);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.Size = new System.Drawing.Size(1377, 559);
            this.dgvResults.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 748);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnLogout;
        private Button button4;
        private TabPage tabPage2;
        private Button btnSearchAuthor;
        private Button btnSearchTitle;
        private GroupBox groupBox1;
        private Button btnSearchYearBirth;
        private Button btnSearchYear;
        private Button btnSearchUserSurname;
        private Button btnSearchUserName;
        private TextBox tbSearchString;
        private Label label1;
        private RadioButton radioAnyBeforeAfter;
        private RadioButton radioAnyAfter;
        private RadioButton radioAnyBefore;
        private RadioButton radioExact;
        private DataGridView dgvResults;
    }
}