namespace MSSQL_Library
{
    partial class RentalViewer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioAnyBeforeAfter = new System.Windows.Forms.RadioButton();
            this.radioAnyAfter = new System.Windows.Forms.RadioButton();
            this.radioAnyBefore = new System.Windows.Forms.RadioButton();
            this.radioExact = new System.Windows.Forms.RadioButton();
            this.btnSearchTitle = new System.Windows.Forms.Button();
            this.tbSearchString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1387, 161);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioAnyBeforeAfter);
            this.tabPage1.Controls.Add(this.radioAnyAfter);
            this.tabPage1.Controls.Add(this.radioAnyBefore);
            this.tabPage1.Controls.Add(this.radioExact);
            this.tabPage1.Controls.Add(this.btnSearchTitle);
            this.tabPage1.Controls.Add(this.tbSearchString);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1379, 128);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioAnyBeforeAfter
            // 
            this.radioAnyBeforeAfter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioAnyBeforeAfter.AutoSize = true;
            this.radioAnyBeforeAfter.Location = new System.Drawing.Point(254, 89);
            this.radioAnyBeforeAfter.Name = "radioAnyBeforeAfter";
            this.radioAnyBeforeAfter.Size = new System.Drawing.Size(225, 24);
            this.radioAnyBeforeAfter.TabIndex = 12;
            this.radioAnyBeforeAfter.Text = "Any characters before && after";
            this.radioAnyBeforeAfter.UseVisualStyleBackColor = true;
            // 
            // radioAnyAfter
            // 
            this.radioAnyAfter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioAnyAfter.AutoSize = true;
            this.radioAnyAfter.Location = new System.Drawing.Point(254, 59);
            this.radioAnyAfter.Name = "radioAnyAfter";
            this.radioAnyAfter.Size = new System.Drawing.Size(161, 24);
            this.radioAnyAfter.TabIndex = 11;
            this.radioAnyAfter.Text = "Any characters after";
            this.radioAnyAfter.UseVisualStyleBackColor = true;
            // 
            // radioAnyBefore
            // 
            this.radioAnyBefore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioAnyBefore.AutoSize = true;
            this.radioAnyBefore.Location = new System.Drawing.Point(8, 89);
            this.radioAnyBefore.Name = "radioAnyBefore";
            this.radioAnyBefore.Size = new System.Drawing.Size(174, 24);
            this.radioAnyBefore.TabIndex = 10;
            this.radioAnyBefore.Text = "Any characters before";
            this.radioAnyBefore.UseVisualStyleBackColor = true;
            // 
            // radioExact
            // 
            this.radioExact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioExact.AutoSize = true;
            this.radioExact.Checked = true;
            this.radioExact.Location = new System.Drawing.Point(8, 59);
            this.radioExact.Name = "radioExact";
            this.radioExact.Size = new System.Drawing.Size(110, 24);
            this.radioExact.TabIndex = 9;
            this.radioExact.TabStop = true;
            this.radioExact.Text = "Exact match";
            this.radioExact.UseVisualStyleBackColor = true;
            // 
            // btnSearchTitle
            // 
            this.btnSearchTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchTitle.Location = new System.Drawing.Point(1148, 84);
            this.btnSearchTitle.Name = "btnSearchTitle";
            this.btnSearchTitle.Size = new System.Drawing.Size(223, 29);
            this.btnSearchTitle.TabIndex = 8;
            this.btnSearchTitle.Text = "Search book title";
            this.btnSearchTitle.UseVisualStyleBackColor = true;
            this.btnSearchTitle.Click += new System.EventHandler(this.btnSearchTitle_Click);
            // 
            // tbSearchString
            // 
            this.tbSearchString.Location = new System.Drawing.Point(8, 26);
            this.tbSearchString.Name = "tbSearchString";
            this.tbSearchString.Size = new System.Drawing.Size(874, 27);
            this.tbSearchString.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book title:";
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(0, 161);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.Size = new System.Drawing.Size(1387, 568);
            this.dgvResults.TabIndex = 1;
            // 
            // RentalViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 729);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.tabControl1);
            this.Name = "RentalViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental Viewer";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TextBox tbSearchString;
        private RadioButton radioAnyBeforeAfter;
        private RadioButton radioAnyAfter;
        private RadioButton radioAnyBefore;
        private RadioButton radioExact;
        private Button btnSearchTitle;
        private DataGridView dgvResults;
    }
}