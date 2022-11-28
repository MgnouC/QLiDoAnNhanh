namespace QuanLyBanDoAnNhanh
{
    partial class fThemDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemDanhMuc));
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnADDCategory = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbCategoryName);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(32, 124);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(320, 47);
            this.panel6.TabIndex = 4;
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.Location = new System.Drawing.Point(136, 19);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.Size = new System.Drawing.Size(163, 20);
            this.txbCategoryName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên danh mục:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "THÊM DANH MỤC";
            // 
            // btnADDCategory
            // 
            this.btnADDCategory.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnADDCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnADDCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDCategory.Location = new System.Drawing.Point(141, 201);
            this.btnADDCategory.Name = "btnADDCategory";
            this.btnADDCategory.Size = new System.Drawing.Size(103, 36);
            this.btnADDCategory.TabIndex = 6;
            this.btnADDCategory.Text = "Thêm";
            this.btnADDCategory.UseVisualStyleBackColor = false;
            this.btnADDCategory.Click += new System.EventHandler(this.btnADDCategory_Click);
            // 
            // fThemDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 282);
            this.Controls.Add(this.btnADDCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fThemDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm danh mục";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnADDCategory;
    }
}