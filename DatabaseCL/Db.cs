namespace DatabaseCL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Db : DbContext
    {
        public Db()
            : base(@"Data Source=C:\users\simon\Documents\GitHub\GOL-2019\DatabaseCL\Gol Db.db")
        {
        }

        public virtual DbSet<GOL> GOL { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
