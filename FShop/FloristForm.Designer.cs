namespace FShop
{
    partial class FloristForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FloristIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteFlorist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FloristIdColumn,
            this.FirstNameColumn,
            this.LastNameColumn,
            this.SalaryColumn,
            this.PhoneColumn,
            this.EmailColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // FloristIdColumn
            // 
            this.FloristIdColumn.HeaderText = "ID";
            this.FloristIdColumn.MinimumWidth = 6;
            this.FloristIdColumn.Name = "FloristIdColumn";
            this.FloristIdColumn.Width = 125;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.HeaderText = "Имя";
            this.FirstNameColumn.MinimumWidth = 6;
            this.FirstNameColumn.Name = "FirstNameColumn";
            this.FirstNameColumn.Width = 125;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.HeaderText = "Фамилия";
            this.LastNameColumn.MinimumWidth = 6;
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.Width = 125;
            // 
            // SalaryColumn
            // 
            this.SalaryColumn.HeaderText = "Зарплата";
            this.SalaryColumn.MinimumWidth = 6;
            this.SalaryColumn.Name = "SalaryColumn";
            this.SalaryColumn.Width = 125;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.HeaderText = "Телефон Номер";
            this.PhoneColumn.MinimumWidth = 6;
            this.PhoneColumn.Name = "PhoneColumn";
            this.PhoneColumn.Width = 125;
            // 
            // EmailColumn
            // 
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.MinimumWidth = 6;
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.Width = 125;
            // 
            // buttonDeleteFlorist
            // 
            this.buttonDeleteFlorist.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDeleteFlorist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteFlorist.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDeleteFlorist.Location = new System.Drawing.Point(635, 339);
            this.buttonDeleteFlorist.Name = "buttonDeleteFlorist";
            this.buttonDeleteFlorist.Size = new System.Drawing.Size(153, 86);
            this.buttonDeleteFlorist.TabIndex = 1;
            this.buttonDeleteFlorist.Text = "DELETE FLORIST";
            this.buttonDeleteFlorist.UseVisualStyleBackColor = false;
            this.buttonDeleteFlorist.Click += new System.EventHandler(this.buttonDeleteFlorist_Click);
            // 
            // FloristForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteFlorist);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FloristForm";
            this.Text = "FloristForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDeleteFlorist;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloristIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
    }
}