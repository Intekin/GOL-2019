using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCL
{
    public class Class1
    {
        public void TestDb()
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

        public void LoadFromDb()
        {

        }

        public void SaveToDb(string name, string generation)
        {
            using (var DbContext = new Db())
            {
                GOL gol = new GOL();
                gol.Name = name;
                gol.DOA = generation;

                DbContext.GOL.Add(gol);
                DbContext.SaveChanges();
            }
        }
    }
}
