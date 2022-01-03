using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hocbacapba.ModelView
{
    public class HocSinhVM
    {
        public long ID { get; set; }

        public string Tenhocsinh { get; set; }

        public string mahocsinh { get; set; }

        public double? diemky1 { get; set; }

        public double? diemky2 { get; set; }

        public double? diemtong { get; set; }

        public string xeploai { get; set; }
    }
}
