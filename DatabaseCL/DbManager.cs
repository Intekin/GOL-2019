using System.Collections.Generic;
using System.Linq;


namespace DatabaseCL
{
    public class DbManager
    {
        public static List<GOL> LoadFromDb()
        {
            DatabaseContext context = new DatabaseContext();
            var listGol = context.GOL.ToList();

            return listGol;
        }

        public static void SaveToDb(int id, string name, string generation)
        {
            DatabaseContext context = new DatabaseContext();
            var result = context.GOL.SingleOrDefault(x => x.GOL_Id == id);
            if(result != null)
            {
                result.DOA = generation;
                result.Name = name;

                context.SaveChanges();
            }
            else
            {
                GOL g = new GOL
                {
                    Name = name,
                    DOA = generation
                };
                context.GOL.Add(g);
                context.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            DatabaseContext context = new DatabaseContext();

            var idToRemove = context.GOL.Where(x => x.GOL_Id == id).FirstOrDefault();

            context.GOL.Remove(idToRemove);
            context.SaveChanges();
        }
    }
}
