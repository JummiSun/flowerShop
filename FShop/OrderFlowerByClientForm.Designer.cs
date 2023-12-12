namespace FShop
{
    partial class OrderFlowerByClientForm
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
            this.titleFlowerComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colourFlowercomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ocassionFlowercomboBox = new System.Windows.Forms.ComboBox();
            this.orderFlowerButton = new System.Windows.Forms.Button();
            this.stuntNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.stuntNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ВЫБЕРИТЕ НАЗВАНИЕ ЦВЕТОВ";
            // 
            // titleFlowerComboBox
            // 
            this.titleFlowerComboBox.FormattingEnabled = true;
            this.titleFlowerComboBox.Location = new System.Drawing.Point(315, 53);
            this.titleFlowerComboBox.Name = "titleFlowerComboBox";
            this.titleFlowerComboBox.Size = new System.Drawing.Size(151, 24);
            this.titleFlowerComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ВВЕДИТЕ ШТУК ЦВЕТОВ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "ВЫБЕРИТЕ ЦВЕТ ЦВЕТОВ";
            // 
            // colourFlowercomboBox
            // 
            this.colourFlowercomboBox.FormattingEnabled = true;
            this.colourFlowercomboBox.Location = new System.Drawing.Point(315, 223);
            this.colourFlowercomboBox.Name = "colourFlowercomboBox";
            this.colourFlowercomboBox.Size = new System.Drawing.Size(121, 24);
            this.colourFlowercomboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "ВЫБЕРИТЕ СОБЫТИЕ";
            // 
            // ocassionFlowercomboBox
            // 
            this.ocassionFlowercomboBox.FormattingEnabled = true;
            this.ocassionFlowercomboBox.Location = new System.Drawing.Point(315, 307);
            this.ocassionFlowercomboBox.Name = "ocassionFlowercomboBox";
            this.ocassionFlowercomboBox.Size = new System.Drawing.Size(121, 24);
            this.ocassionFlowercomboBox.TabIndex = 9;
            // 
            // orderFlowerButton
            // 
            this.orderFlowerButton.BackColor = System.Drawing.Color.ForestGreen;
            this.orderFlowerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderFlowerButton.ForeColor = System.Drawing.SystemColors.Control;
            this.orderFlowerButton.Location = new System.Drawing.Point(144, 398);
            this.orderFlowerButton.Name = "orderFlowerButton";
            this.orderFlowerButton.Size = new System.Drawing.Size(172, 52);
            this.orderFlowerButton.TabIndex = 10;
            this.orderFlowerButton.Text = "ORDER";
            this.orderFlowerButton.UseVisualStyleBackColor = false;
            this.orderFlowerButton.Click += new System.EventHandler(this.orderFlowerButton_Click);
            // 
            // stuntNumericUpDown
            // 
            this.stuntNumericUpDown.Location = new System.Drawing.Point(315, 138);
            this.stuntNumericUpDown.Name = "stuntNumericUpDown";
            this.stuntNumericUpDown.Size = new System.Drawing.Size(58, 22);
            this.stuntNumericUpDown.TabIndex = 5;
            // 
            // OrderFlowerByClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(500, 478);
            this.Controls.Add(this.orderFlowerButton);
            this.Controls.Add(this.ocassionFlowercomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.colourFlowercomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stuntNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleFlowerComboBox);
            this.Controls.Add(this.label1);
            this.Name = "OrderFlowerByClientForm";
            this.Text = "OrderFlowerByClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.stuntNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox titleFlowerComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox colourFlowercomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ocassionFlowercomboBox;
        private System.Windows.Forms.Button orderFlowerButton;
        private System.Windows.Forms.NumericUpDown stuntNumericUpDown;
    }
}