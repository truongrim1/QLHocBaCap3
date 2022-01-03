using Hocbacapba.BLL;
using Hocbacapba.ModelView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hocbacapba
{
    public partial class frmHOCSINH : Form
    {
        public frmHOCSINH()
        {
            InitializeComponent();
            NapHocSinh();
        }

        void NapHocSinh()
        {
            var ls = HOCSINHBLL.GetListVM();
            hocSinhVMBindingSource.DataSource = ls;
            dataGridView1.DataSource = hocSinhVMBindingSource;
        }

        public HocSinhVM SelectHocSinh
        {
            get
            {
                return hocSinhVMBindingSource.Current as HocSinhVM;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new frmchitietHOCSINH();
            var rs = f.ShowDialog();
            if(rs == DialogResult.OK)
            {
                NapHocSinh();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(SelectHocSinh != null)
            {
                var f = new frmchitietHOCSINH(SelectHocSinh);
                var rs = f.ShowDialog();
                if(rs == DialogResult.OK)
                {
                    NapHocSinh();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(SelectHocSinh != null)
            {
                if (MessageBox.Show(
                    "Bạn có thực sự muốn xoá?",
                    "Chú ý",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    HOCSINHBLL.delete(SelectHocSinh.ID);
                    hocSinhVMBindingSource.RemoveCurrent();
                    MessageBox.Show("Đã xóa thành công!");
                }
            }
        }
    }
}
