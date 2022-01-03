using Hocbacapba.DAL;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Hocbacapba
{
    public partial class ModelHOCSINH : DbContext
    {
        public ModelHOCSINH()
            : base("name=QLHOCBAModel")
        {
        }

        public virtual DbSet<HOCSINH> HOCSINH { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
