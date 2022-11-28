namespace QuanLyBanDoAnNhanh
{
    partial class fThemThucAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemThucAn));
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(123, 350);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(103, 63);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbFoodID);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(320, 47);
            this.panel5.TabIndex = 2;
            // 
            // txbFoodID
            // 
            this.txbFoodID.Location = new System.Drawing.Point(111, 19);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.ReadOnly = true;
            this.txbFoodID.Size = new System.Drawing.Size(188, 20);
            this.txbFoodID.TabIndex = 1;
            this.txbFoodID.TextChanged += new System.EventHandler(this.btnAddFood_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbFoodName);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(3, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(320, 47);
            this.panel6.TabIndex = 3;
            // 
            // txbFoodName
            // 
            this.txbFoodName.Location = new System.Drawing.Point(111, 19);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(188, 20);
            this.txbFoodName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món: ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbFoodCategory);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(3, 125);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(320, 47);
            this.panel7.TabIndex = 4;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(111, 17);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(188, 21);
            this.cbFoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.nmFoodPrice);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(3, 178);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(320, 47);
            this.panel8.TabIndex = 5;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(111, 22);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(188, 20);
            this.nmFoodPrice.TabIndex = 1;
            this.nmFoodPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(12, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(322, 249);
            this.panel4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "THÊM MÓN";
            // 
            // fThemThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fThemThucAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm thức ăn";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbFoodID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
    }
}