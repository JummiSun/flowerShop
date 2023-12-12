namespace FShop
{
    partial class ClientForm
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
            this.ClientIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_button_clients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientIdColumn,
            this.FirstNameColumn,
            this.LastNameColumn,
            this.CityColumn,
            this.PhoneColumn,
            this.EmailColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 446);
            this.dataGridView1.TabIndex = 0;
            // 
            // ClientIdColumn
            // 
            this.ClientIdColumn.HeaderText = "ID";
            this.ClientIdColumn.MinimumWidth = 6;
            this.ClientIdColumn.Name = "ClientIdColumn";
            this.ClientIdColumn.Width = 125;
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
            // CityColumn
            // 
            this.CityColumn.HeaderText = "Город";
            this.CityColumn.MinimumWidth = 6;
            this.CityColumn.Name = "CityColumn";
            this.CityColumn.Width = 125;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.HeaderText = "Телефон";
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
            // delete_button_clients
            // 
            this.delete_button_clients.BackColor = System.Drawing.Color.ForestGreen;
            this.delete_button_clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button_clients.ForeColor = System.Drawing.SystemColors.Control;
            this.delete_button_clients.Location = new System.Drawing.Point(614, 347);
            this.delete_button_clients.Name = "delete_button_clients";
            this.delete_button_clients.Size = new System.Drawing.Size(177, 71);
            this.delete_button_clients.TabIndex = 1;
            this.delete_button_clients.Text = "DELETE CLIENT";
            this.delete_button_clients.UseVisualStyleBackColor = false;
            this.delete_button_clients.Click += new System.EventHandler(this.delete_button_clients_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(803, 446);
            this.Controls.Add(this.delete_button_clients);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete_button_clients;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
    }
}