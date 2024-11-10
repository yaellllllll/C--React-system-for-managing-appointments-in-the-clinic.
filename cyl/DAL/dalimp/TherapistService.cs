using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.dalApi;
using DAL.DataObject.Models;

namespace DAL.dalimp
{
    public class TherapistService : Itherapist
    {
        dbcontext DB = new dbcontext();

        public async void Create(Therapist item)
        {
            DB.Therapists.Add(item);
            await DB.SaveChangesAsync();
        }

        public async void Delete(Therapist item)
        {
            DB.Therapists.Remove(item);
            await DB.SaveChangesAsync();
        }

        public List<Therapist> Read()
        {
            return DB.Therapists.ToList();
        }

        public async void Update(Therapist item)
        {
            DB.Therapists.Remove(item);
            await DB.SaveChangesAsync();
            DB.Therapists.Add(item);
            await DB.SaveChangesAsync();
        }
    }
}
