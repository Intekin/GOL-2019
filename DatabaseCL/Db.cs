namespace DatabaseCL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.SQLite;
    using System.IO;

    public partial class Db : DbContext
    {

        public virtual DbSet<GOL> GOL { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
    class DatabaseContext : DbContext
    {
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public DatabaseContext() :
            base(new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = @"D:\VS Projects\GOL_2019\DatabaseCL\GOL db.db" }.ConnectionString
            }, true)
        {

        }
        public DbSet<GOL> GOL { get; set; }
    }
}
