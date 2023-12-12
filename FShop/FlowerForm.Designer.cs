namespace FShop
{
    partial class FlowerForm
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
            this.FlowerIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerStuntColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerColourColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerOccasionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteFlower = new System.Windows.Forms.Button();
            this.buttonAddFlower = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlowerIdColumn,
            this.FlowerTitleColumn,
            this.FlowerStuntColumn,
            this.FlowerPriceColumn,
            this.FlowerColourColumn,
            this.FlowerOccasionColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // FlowerIdColumn
            // 
            this.FlowerIdColumn.HeaderText = "ID";
            this.FlowerIdColumn.MinimumWidth = 6;
            this.FlowerIdColumn.Name = "FlowerIdColumn";
            this.FlowerIdColumn.Width = 125;
            // 
            // FlowerTitleColumn
            // 
            this.FlowerTitleColumn.HeaderText = "Название цветов";
            this.FlowerTitleColumn.MinimumWidth = 6;
            this.FlowerTitleColumn.Name = "FlowerTitleColumn";
            this.FlowerTitleColumn.Width = 125;
            // 
            // FlowerStuntColumn
            // 
            this.FlowerStuntColumn.HeaderText = "Штук цветов";
            this.FlowerStuntColumn.MinimumWidth = 6;
            this.FlowerStuntColumn.Name = "FlowerStuntColumn";
            this.FlowerStuntColumn.Width = 125;
            // 
            // FlowerPriceColumn
            // 
            this.FlowerPriceColumn.HeaderText = "Цена за штуку цветов.";
            this.FlowerPriceColumn.MinimumWidth = 6;
            this.FlowerPriceColumn.Name = "FlowerPriceColumn";
            this.FlowerPriceColumn.Width = 125;
            // 
            // FlowerColourColumn
            // 
            this.FlowerColourColumn.HeaderText = "Цвет цветов";
            this.FlowerColourColumn.MinimumWidth = 6;
            this.FlowerColourColumn.Name = "FlowerColourColumn";
            this.FlowerColourColumn.Width = 125;
            // 
            // FlowerOccasionColumn
            // 
            this.FlowerOccasionColumn.HeaderText = "Повод с цветами";
            this.FlowerOccasionColumn.MinimumWidth = 6;
            this.FlowerOccasionColumn.Name = "FlowerOccasionColumn";
            this.FlowerOccasionColumn.Width = 125;
            // 
            // buttonDeleteFlower
            // 
            this.buttonDeleteFlower.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDeleteFlower.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteFlower.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDeleteFlower.Location = new System.Drawing.Point(612, 348);
            this.buttonDeleteFlower.Name = "buttonDeleteFlower";
            this.buttonDeleteFlower.Size = new System.Drawing.Size(155, 60);
            this.buttonDeleteFlower.TabIndex = 1;
            this.buttonDeleteFlower.Text = "DELETE FLOWER";
            this.buttonDeleteFlower.UseVisualStyleBackColor = false;
            this.buttonDeleteFlower.Click += new System.EventHandler(this.buttonDeleteFlower_Click);
            // 
            // buttonAddFlower
            // 
            this.buttonAddFlower.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAddFlower.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddFlower.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddFlower.Location = new System.Drawing.Point(402, 348);
            this.buttonAddFlower.Name = "buttonAddFlower";
            this.buttonAddFlower.Size = new System.Drawing.Size(155, 65);
            this.buttonAddFlower.TabIndex = 2;
            this.buttonAddFlower.Text = "ADD FLOWER";
            this.buttonAddFlower.UseVisualStyleBackColor = false;
            this.buttonAddFlower.Click += new System.EventHandler(this.buttonAddFlower_Click);
            // 
            // FlowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddFlower);
            this.Controls.Add(this.buttonDeleteFlower);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FlowerForm";
            this.Text = "FlowerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerStuntColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerColourColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerOccasionColumn;
        private System.Windows.Forms.Button buttonDeleteFlower;
        private System.Windows.Forms.Button buttonAddFlower;
    }
}