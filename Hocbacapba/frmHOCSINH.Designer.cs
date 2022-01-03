
namespace Hocbacapba
{
    partial class frmHOCSINH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHOCSINH));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhocsinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahocsinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemky1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemky2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemtongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeploaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocSinhVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnXoa,
            this.btnSua,
            this.btnThem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(766, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(109, 22);
            this.toolStripLabel1.Text = "danh sách học sinh";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tenhocsinhDataGridViewTextBoxColumn,
            this.mahocsinhDataGridViewTextBoxColumn,
            this.diemky1DataGridViewTextBoxColumn,
            this.diemky2DataGridViewTextBoxColumn,
            this.diemtongDataGridViewTextBoxColumn,
            this.xeploaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hocSinhVMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 289);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(57, 22);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(46, 22);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 22);
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // tenhocsinhDataGridViewTextBoxColumn
            // 
            this.tenhocsinhDataGridViewTextBoxColumn.DataPropertyName = "Tenhocsinh";
            this.tenhocsinhDataGridViewTextBoxColumn.HeaderText = "Tenhocsinh";
            this.tenhocsinhDataGridViewTextBoxColumn.Name = "tenhocsinhDataGridViewTextBoxColumn";
            // 
            // mahocsinhDataGridViewTextBoxColumn
            // 
            this.mahocsinhDataGridViewTextBoxColumn.DataPropertyName = "mahocsinh";
            this.mahocsinhDataGridViewTextBoxColumn.HeaderText = "mahocsinh";
            this.mahocsinhDataGridViewTextBoxColumn.Name = "mahocsinhDataGridViewTextBoxColumn";
            // 
            // diemky1DataGridViewTextBoxColumn
            // 
            this.diemky1DataGridViewTextBoxColumn.DataPropertyName = "diemky1";
            this.diemky1DataGridViewTextBoxColumn.HeaderText = "diemky1";
            this.diemky1DataGridViewTextBoxColumn.Name = "diemky1DataGridViewTextBoxColumn";
            // 
            // diemky2DataGridViewTextBoxColumn
            // 
            this.diemky2DataGridViewTextBoxColumn.DataPropertyName = "diemky2";
            this.diemky2DataGridViewTextBoxColumn.HeaderText = "diemky2";
            this.diemky2DataGridViewTextBoxColumn.Name = "diemky2DataGridViewTextBoxColumn";
            // 
            // diemtongDataGridViewTextBoxColumn
            // 
            this.diemtongDataGridViewTextBoxColumn.DataPropertyName = "diemtong";
            this.diemtongDataGridViewTextBoxColumn.HeaderText = "diemtong";
            this.diemtongDataGridViewTextBoxColumn.Name = "diemtongDataGridViewTextBoxColumn";
            // 
            // xeploaiDataGridViewTextBoxColumn
            // 
            this.xeploaiDataGridViewTextBoxColumn.DataPropertyName = "xeploai";
            this.xeploaiDataGridViewTextBoxColumn.HeaderText = "xeploai";
            this.xeploaiDataGridViewTextBoxColumn.Name = "xeploaiDataGridViewTextBoxColumn";
            // 
            // hocSinhVMBindingSource
            // 
            this.hocSinhVMBindingSource.DataSource = typeof(Hocbacapba.ModelView.HocSinhVM);
            // 
            // frmHOCSINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 353);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmHOCSINH";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhVMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhocsinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahocsinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemky1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemky2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemtongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xeploaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hocSinhVMBindingSource;
    }
}

