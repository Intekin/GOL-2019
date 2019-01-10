using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCL
{
    public class DbManager
    {
        public static void TestDb()
        {
            DatabaseContext context = new DatabaseContext();
            GOL g = new GOL()
            {
                Name = "Meh",
                DOA = "Fy"
            };
            context.GOL.Add(g);
            context.SaveChanges();
        }

        public static List<GOL> LoadFromDb()
        {
            DatabaseContext context = new DatabaseContext();

            var listGol = context.GOL.ToList();

            return listGol;
        }

        public static void SaveToDb(string name, string generation)
        {
            DatabaseContext context = new DatabaseContext();
            GOL g = new GOL()
            {
                Name = name,
                DOA = generation
            };
            context.GOL.Add(g);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            DatabaseContext context = new DatabaseContext();

            var idToRemove = context.GOL.Where(x => x.GOL_Id == id).FirstOrDefault();

            context.GOL.Remove(idToRemove);
        }

    }
}
