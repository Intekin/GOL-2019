namespace DatabaseCL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.SQLite;

    public partial class Db : DbContext
    {

        public virtual DbSet<GOL> GOL { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
    class DatabaseContext : DbContext
    {
        public DatabaseContext() :
            base(new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = @"D:\VS Projects\GOL_2019\DatabaseCL\Gol Db.db" }.ConnectionString
            }, true)
        {
        }
        public DbSet<GOL> GOL { get; set; }
    }
}
