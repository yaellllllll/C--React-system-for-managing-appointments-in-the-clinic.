using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.dalApi;
using DAL.DataObject.Models;

namespace DAL.dalimp
{
    public class TurnService : Iturn
    {
        dbcontext db = new dbcontext();
        public async void Create(Turn item)

        {         
            db.Turns.Add(item);
            await db.SaveChangesAsync();
        }

        public async void Delete(Turn item)
        {
            db.Turns.Remove(item);
            await db.SaveChangesAsync();
        }

        public List<Turn> Read()
        {          
            return db.Turns.ToList<Turn>();
           
        }

        public async void Update(Turn item)
        {
            db.Turns.Remove(item);
            await db.SaveChangesAsync();
            db.Turns.Add(item);
            await db.SaveChangesAsync();
        }
    }
}
