
namespace Hocbacapba
{
    partial class frmchitietHOCSINH
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenhs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmahs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdiem1 = new System.Windows.Forms.TextBox();
            this.txtdiem2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdiemtong = new System.Windows.Forms.TextBox();
            this.txtxeploai = new System.Windows.Forms.TextBox();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên học sinh:";
            // 
            // txtTenhs
            // 
            this.txtTenhs.Location = new System.Drawing.Point(54, 67);
            this.txtTenhs.Name = "txtTenhs";
            this.txtTenhs.Size = new System.Drawing.Size(172, 20);
            this.txtTenhs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã học sinh:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtmahs
            // 
            this.txtmahs.Location = new System.Drawing.Point(54, 139);
            this.txtmahs.Name = "txtmahs";
            this.txtmahs.Size = new System.Drawing.Size(172, 20);
            this.txtmahs.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điểm kỳ 1:";
            // 
            // txtdiem1
            // 
            this.txtdiem1.Location = new System.Drawing.Point(54, 204);
            this.txtdiem1.Name = "txtdiem1";
            this.txtdiem1.Size = new System.Drawing.Size(172, 20);
            this.txtdiem1.TabIndex = 5;
            // 
            // txtdiem2
            // 
            this.txtdiem2.Location = new System.Drawing.Point(54, 267);
            this.txtdiem2.Name = "txtdiem2";
            this.txtdiem2.Size = new System.Drawing.Size(172, 20);
            this.txtdiem2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Điểm kỳ 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Xếp loại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Điểm Tổng:";
            // 
            // txtdiemtong
            // 
            this.txtdiemtong.Location = new System.Drawing.Point(54, 341);
            this.txtdiemtong.Name = "txtdiemtong";
            this.txtdiemtong.Size = new System.Drawing.Size(172, 20);
            this.txtdiemtong.TabIndex = 10;
            // 
            // txtxeploai
            // 
            this.txtxeploai.Location = new System.Drawing.Point(54, 401);
            this.txtxeploai.Name = "txtxeploai";
            this.txtxeploai.Size = new System.Drawing.Size(172, 20);
            this.txtxeploai.TabIndex = 11;
            // 
            // btnhuy
            // 
            this.btnhuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnhuy.Location = new System.Drawing.Point(406, 264);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 13;
            this.btnhuy.Text = "HUỶ";
            this.btnhuy.UseVisualStyleBackColor = true;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(406, 190);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.TabIndex = 14;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmchitietHOCSINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnhuy;
            this.ClientSize = new System.Drawing.Size(590, 515);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.txtxeploai);
            this.Controls.Add(this.txtdiemtong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdiem2);
            this.Controls.Add(this.txtdiem1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmahs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenhs);
            this.Controls.Add(this.label1);
            this.Name = "frmchitietHOCSINH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmchitietHOCSINH";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenhs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmahs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdiem1;
        private System.Windows.Forms.TextBox txtdiem2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdiemtong;
        private System.Windows.Forms.TextBox txtxeploai;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}