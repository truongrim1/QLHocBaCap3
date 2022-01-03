using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hocbacapba.BLL;
using Hocbacapba.ModelView;
using static Hocbacapba.BLL.HOCSINHBLL;

namespace Hocbacapba
{
    public partial class frmchitietHOCSINH : Form
    {
        HocSinhVM HocSinhVM;
        private KETQUA HocSinhBLL;

        public frmchitietHOCSINH(HocSinhVM hocSinhVM = null)
        {
            InitializeComponent();
            this.HocSinhVM = hocSinhVM;
            if(hocSinhVM == null)
            {
                this.Text = "Thêm mới học sinh";
            }
            else
            {
                this.Text = "Sửa thông tin học sinh";
                txtmahs.Text = hocSinhVM.mahocsinh;
                txtTenhs.Text = hocSinhVM.Tenhocsinh;
                txtxeploai.Text = hocSinhVM.xeploai;
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var tenhs = txtTenhs.Text;
            var mahs = txtmahs.Text;
            long diem1 = long.Parse(txtdiem1.Text);
            long diem2 = long.Parse(txtdiem2.Text);
            long tong = long.Parse(txtdiemtong.Text);
            var xeploai = txtxeploai.Text;
            if (string.IsNullOrEmpty(tenhs))
            {
                errorProvider1.SetError(txtTenhs, "Tên Học Sinh Không Được Để Trống!");
            }
            if (string.IsNullOrEmpty(mahs))
            {
                errorProvider1.SetError(txtmahs, "Tên Mã học sinh Không Được Để Trống!");
            }
            if (string.IsNullOrEmpty(xeploai))
            {
                errorProvider1.SetError(txtxeploai, "Tên Xếp loại học sinh Không Được Để Trống!");
            }
            var rs = KETQUA.ThanhCong;
            if(HocSinhVM == null)
            {
                rs = HOCSINHBLL.add(new HocSinhVM
                {
                    Tenhocsinh = tenhs,
                    mahocsinh = mahs,
                    diemky1 = diem1,
                    diemky2 = diem2,
                    diemtong = tong,
                    xeploai = xeploai,

                });
            }
            else
            {
                HocSinhVM.Tenhocsinh = tenhs;
                HocSinhVM.mahocsinh = mahs;
                HocSinhVM.diemky1 = diem1;
                HocSinhVM.diemky2 = diem2;
                HocSinhVM.diemtong = tong;
                HocSinhVM.xeploai = xeploai;
                rs = HOCSINHBLL.update(HocSinhVM);
            }

            if(rs == KETQUA.ThanhCong)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Các thông tin không hợp lệ", "Thông báo");
            }
        }








        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
