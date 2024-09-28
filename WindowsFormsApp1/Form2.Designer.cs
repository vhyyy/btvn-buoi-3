namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnDongY = new System.Windows.Forms.Button();
            this.msnv = new System.Windows.Forms.Label();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(118, 166);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.TabIndex = 0;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // msnv
            // 
            this.msnv.AutoSize = true;
            this.msnv.Location = new System.Drawing.Point(86, 37);
            this.msnv.Name = "msnv";
            this.msnv.Size = new System.Drawing.Size(38, 13);
            this.msnv.TabIndex = 1;
            this.msnv.Text = "MSNV";
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(220, 30);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(172, 20);
            this.txtMSNV.TabIndex = 2;
            this.txtMSNV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMSNV_KeyDown);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(220, 76);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(199, 20);
            this.txtTenNV.TabIndex = 2;
            this.txtTenNV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenNV_KeyDown);
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(220, 118);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(172, 20);
            this.txtLuongCB.TabIndex = 2;
            this.txtLuongCB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLuongCB_KeyDown);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(266, 166);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 0;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lương CB";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 227);
            this.Controls.Add(this.txtLuongCB);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMSNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msnv);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnDongY);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Label msnv;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}