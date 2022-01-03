using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hocbacapba.DAL;
using Hocbacapba.ModelView;

namespace Hocbacapba.BLL
{
    internal class HOCSINHBLL
    {
        public enum KETQUA
        {
            ThanhCong, TenTrung
        }

        public static List<HOCSINH> Getlist()
        {
             ModelHOCSINH model = new ModelHOCSINH();
            return model.HOCSINH.OrderByDescending(e => e.Tenhocsinh).ToList();
        }
        public static List<HocSinhVM> GetListVM()
        {
            ModelHOCSINH modlel = new ModelHOCSINH();
            var ls = modlel.HOCSINH.Select(e => new HocSinhVM
            {
                ID = e.ID,
                Tenhocsinh = e.Tenhocsinh,
                mahocsinh = e.mahocsinh,
                diemky1 = e.diemky1,
                diemky2 = e.diemky2,
                diemtong = e.diemtong,
                xeploai = e.xeploai,
            }).ToList();
            return ls;
        }
        public static KETQUA add(HocSinhVM hocSinhVM)
        {
            ModelHOCSINH model = new ModelHOCSINH();
            var hs = model.HOCSINH.Where(e => e.Tenhocsinh == hocSinhVM.Tenhocsinh).FirstOrDefault();
            if (hs != null)
            {
                return KETQUA.TenTrung;
            }
            else
            {
                hs = new HOCSINH
                {
                    Tenhocsinh = hocSinhVM.Tenhocsinh,
                    mahocsinh = hocSinhVM.mahocsinh,
                    diemky1 = hocSinhVM.diemky1,
                    diemky2 = hocSinhVM.diemky2,
                    diemtong = hocSinhVM.diemtong,
                    xeploai = hocSinhVM.xeploai
                };
                model.HOCSINH.Add(hs);
                model.SaveChanges();
                return KETQUA.ThanhCong;
            }
        }
        public static KETQUA update(HocSinhVM hocSinhVM)
        {
            ModelHOCSINH model = new ModelHOCSINH();
            var hs = model.HOCSINH.Where(e => e.ID != hocSinhVM.ID && e.Tenhocsinh == hocSinhVM.Tenhocsinh).FirstOrDefault();
            if (hs != null)
            {
                return KETQUA.TenTrung;
            }
            else
            {
                hs = model.HOCSINH.Where(e => e.ID == hocSinhVM.ID).FirstOrDefault();
                hs.Tenhocsinh = hocSinhVM.Tenhocsinh;
                hs.mahocsinh = hocSinhVM.mahocsinh;
                hs.diemky1 = hocSinhVM.diemky1;
                hs.diemky2 = hocSinhVM.diemky2;
                hs.diemtong = hocSinhVM.diemtong;
                model.SaveChanges();
                return KETQUA.ThanhCong;
            }
        }
        public static void delete(long id)
        {
            ModelHOCSINH model = new ModelHOCSINH();
            var hs = model.HOCSINH.Where(e => e.ID == id).FirstOrDefault();
            if (hs != null)
            {
                model.HOCSINH.Remove(hs);
            }
            else
            {
                throw new Exception("Học sinh  này không tồn tại!");
            }   
            model.SaveChanges();
        }


    }
}
