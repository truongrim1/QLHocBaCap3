
namespace Hocbacapba.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCSINH")]
    public partial class HOCSINH
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
