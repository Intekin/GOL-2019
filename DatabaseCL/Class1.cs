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
            using (var DbContext = new Db())
            {
                GOL g = new GOL();
                g.GOL_Id = 1;
                g.Name = "Game1";
                g.DOA = "";

                DbContext.SaveChanges();
            }
        }

        public void LoadFromDb()
        {

        }

        public void SaveToDb()
        {

        }
    }
}
