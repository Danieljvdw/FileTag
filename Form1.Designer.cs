namespace FileTag
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvTags = new System.Windows.Forms.DataGridView();
            this.clmTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.clmFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tag";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dgvTags
            // 
            this.dgvTags.AllowUserToAddRows = false;
            this.dgvTags.AllowUserToDeleteRows = false;
            this.dgvTags.AllowUserToResizeColumns = false;
            this.dgvTags.AllowUserToResizeRows = false;
            this.dgvTags.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTags});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvTags, 3);
            this.dgvTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTags.Location = new System.Drawing.Point(3, 46);
            this.dgvTags.Name = "dgvTags";
            this.dgvTags.ReadOnly = true;
            this.dgvTags.RowHeadersVisible = false;
            this.dgvTags.RowHeadersWidth = 62;
            this.dgvTags.RowTemplate.Height = 28;
            this.dgvTags.Size = new System.Drawing.Size(291, 1091);
            this.dgvTags.TabIndex = 3;
            this.dgvTags.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTags_CellDoubleClick);
            this.dgvTags.SelectionChanged += new System.EventHandler(this.DgvTags_SelectionChanged);
            // 
            // clmTags
            // 
            this.clmTags.HeaderText = "Tag";
            this.clmTags.MinimumWidth = 8;
            this.clmTags.Name = "clmTags";
            this.clmTags.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Directory";
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(378, 0);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(17, 20);
            this.lblDirectory.TabIndex = 5;
            this.lblDirectory.Text = "\\\\";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.AllowUserToResizeColumns = false;
            this.dgvFiles.AllowUserToResizeRows = false;
            this.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFile});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvFiles, 3);
            this.dgvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFiles.Location = new System.Drawing.Point(300, 46);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RowHeadersVisible = false;
            this.dgvFiles.RowHeadersWidth = 62;
            this.dgvFiles.RowTemplate.Height = 28;
            this.dgvFiles.Size = new System.Drawing.Size(923, 1091);
            this.dgvFiles.TabIndex = 7;
            this.dgvFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFiles_CellClick);
            // 
            // clmFile
            // 
            this.clmFile.HeaderText = "File";
            this.clmFile.MinimumWidth = 8;
            this.clmFile.Name = "clmFile";
            this.clmFile.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvFiles, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvTags, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDirectory, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1226, 1140);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 1140);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "FileTag";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvTags;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTags;
    }
}

