namespace WindowsFormsApplication1.Bai03
{
    partial class frm03Triangle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tha = new System.Windows.Forms.TextBox();
            this.thb = new System.Windows.Forms.TextBox();
            this.thc = new System.Windows.Forms.TextBox();
            this.thchuvi = new System.Windows.Forms.TextBox();
            this.thdientich = new System.Windows.Forms.TextBox();
            this.btTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Canh a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Canh b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Canh c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chu vi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dien tich";
            // 
            // tha
            // 
            this.tha.Location = new System.Drawing.Point(78, 37);
            this.tha.Name = "tha";
            this.tha.Size = new System.Drawing.Size(152, 20);
            this.tha.TabIndex = 5;
            // 
            // thb
            // 
            this.thb.Location = new System.Drawing.Point(78, 67);
            this.thb.Name = "thb";
            this.thb.Size = new System.Drawing.Size(152, 20);
            this.thb.TabIndex = 6;
            // 
            // thc
            // 
            this.thc.Location = new System.Drawing.Point(78, 100);
            this.thc.Name = "thc";
            this.thc.Size = new System.Drawing.Size(152, 20);
            this.thc.TabIndex = 7;
            // 
            // thchuvi
            // 
            this.thchuvi.Location = new System.Drawing.Point(79, 131);
            this.thchuvi.Name = "thchuvi";
            this.thchuvi.Size = new System.Drawing.Size(150, 20);
            this.thchuvi.TabIndex = 8;
            // 
            // thdientich
            // 
            this.thdientich.Location = new System.Drawing.Point(81, 166);
            this.thdientich.Name = "thdientich";
            this.thdientich.Size = new System.Drawing.Size(147, 20);
            this.thdientich.TabIndex = 9;
            // 
            // btTinh
            // 
            this.btTinh.Location = new System.Drawing.Point(34, 216);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(113, 31);
            this.btTinh.TabIndex = 10;
            this.btTinh.Text = "Tinh";
            this.btTinh.UseVisualStyleBackColor = true;
            this.btTinh.Click += new System.EventHandler(this.btTinh_Click);
            // 
            // frm03Triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btTinh);
            this.Controls.Add(this.thdientich);
            this.Controls.Add(this.thchuvi);
            this.Controls.Add(this.thc);
            this.Controls.Add(this.thb);
            this.Controls.Add(this.tha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm03Triangle";
            this.Text = "frm03Triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tha;
        private System.Windows.Forms.TextBox thb;
        private System.Windows.Forms.TextBox thc;
        private System.Windows.Forms.TextBox thchuvi;
        private System.Windows.Forms.TextBox thdientich;
        private System.Windows.Forms.Button btTinh;
    }
}
