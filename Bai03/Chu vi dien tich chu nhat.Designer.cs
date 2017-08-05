namespace WindowsFormsApplication1.Bai03
{
    partial class frm03HCN
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
            this.thDai = new System.Windows.Forms.TextBox();
            this.thRong = new System.Windows.Forms.TextBox();
            this.thChuvi = new System.Windows.Forms.TextBox();
            this.thDientich = new System.Windows.Forms.TextBox();
            this.btTinh = new System.Windows.Forms.Button();
            this.btRedo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chieu dai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chieu rong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chu vi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dien tich";
            // 
            // thDai
            // 
            this.thDai.Location = new System.Drawing.Point(93, 35);
            this.thDai.Name = "thDai";
            this.thDai.Size = new System.Drawing.Size(120, 20);
            this.thDai.TabIndex = 4;
            // 
            // thRong
            // 
            this.thRong.Location = new System.Drawing.Point(95, 64);
            this.thRong.Name = "thRong";
            this.thRong.Size = new System.Drawing.Size(117, 20);
            this.thRong.TabIndex = 5;
            // 
            // thChuvi
            // 
            this.thChuvi.Location = new System.Drawing.Point(97, 99);
            this.thChuvi.Name = "thChuvi";
            this.thChuvi.Size = new System.Drawing.Size(114, 20);
            this.thChuvi.TabIndex = 6;
            // 
            // thDientich
            // 
            this.thDientich.Location = new System.Drawing.Point(97, 135);
            this.thDientich.Name = "thDientich";
            this.thDientich.Size = new System.Drawing.Size(115, 20);
            this.thDientich.TabIndex = 7;
            // 
            // btTinh
            // 
            this.btTinh.Location = new System.Drawing.Point(32, 197);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(107, 29);
            this.btTinh.TabIndex = 8;
            this.btTinh.Text = "Calculate";
            this.btTinh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btTinh.UseVisualStyleBackColor = true;
            this.btTinh.Click += new System.EventHandler(this.btTinh_Click);
            // 
            // btRedo
            // 
            this.btRedo.Location = new System.Drawing.Point(175, 196);
            this.btRedo.Name = "btRedo";
            this.btRedo.Size = new System.Drawing.Size(92, 29);
            this.btRedo.TabIndex = 9;
            this.btRedo.Text = "Redo";
            this.btRedo.UseVisualStyleBackColor = true;
            // 
            // frm03HCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btRedo);
            this.Controls.Add(this.btTinh);
            this.Controls.Add(this.thDientich);
            this.Controls.Add(this.thChuvi);
            this.Controls.Add(this.thRong);
            this.Controls.Add(this.thDai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm03HCN";
            this.Text = "frm03HCN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox thDai;
        private System.Windows.Forms.TextBox thRong;
        private System.Windows.Forms.TextBox thChuvi;
        private System.Windows.Forms.TextBox thDientich;
        private System.Windows.Forms.Button btTinh;
        private System.Windows.Forms.Button btRedo;
    }
}
