using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW4
{
    public class GenericRepository<T> : IRepository<Entity>
    {
        List<Entity> list;

        public GenericRepository()
        {
            list = new List<Entity>();
        }


        public void Add(Entity item)
        {
            list.Add(item);
        }

        public IEnumerable<Entity> GetAll()
        {
            return list;
        }

        public Entity GetById(int id)
        {
            return list[id];
        }

        public void Remove(Entity item)
        {
            list.Remove(item);
        }

        public void Save()
        {
            foreach(Entity item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Saved.");
        }
    }
}
