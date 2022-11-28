namespace QuanLyBanDoAnNhanh
{
    partial class fThemBanAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemBanAn));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbTableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnAddTable);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(2, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 298);
            this.panel4.TabIndex = 11;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbTableName);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(22, 85);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(320, 47);
            this.panel6.TabIndex = 3;
            // 
            // txbTableName
            // 
            this.txbTableName.Location = new System.Drawing.Point(135, 19);
            this.txbTableName.Name = "txbTableName";
            this.txbTableName.Size = new System.Drawing.Size(163, 20);
            this.txbTableName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bàn:";
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddTable.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTable.Location = new System.Drawing.Point(127, 173);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(114, 33);
            this.btnAddTable.TabIndex = 5;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "THÊM BÀN ĂN";
            // 
            // fThemBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 307);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fThemBanAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm bàn ăn";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbTableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Label label4;
    }
}