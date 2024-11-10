using BL.blApi;
using BL.blDataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DataObject.Models;
using DAL.dalApi;

namespace BL.blimp
{
    public class BLtherapistService : BLItherapist
    {

        Itherapist dalTherapist;

        public BLtherapistService(DalManager a)
        {
            this.dalTherapist = a.therapist;
        }
        public void Create(BLTherapist item)
        {
            Therapist myTherapist = new Therapist();
            myTherapist.Name = item.Name;
            myTherapist.Id = item.Id;
            dalTherapist.Create(myTherapist);
        }

        public void Delete(BLTherapist item)
        {
            Therapist myTherapist = new Therapist();
            myTherapist.Name = item.Name;
            myTherapist.Id = item.Id;
            dalTherapist.Delete(myTherapist);
        }

        public List<BLTherapist> Read()
        {
            List<BLTherapist> BLtherapist = new();
            IEnumerable<Therapist> dalTherapists = dalTherapist.Read();
            foreach (Therapist therapist in dalTherapists)
            {
                BLTherapist tmpTherapist = new BLTherapist();
                tmpTherapist.Name = therapist.Name;
                tmpTherapist.Id = therapist.Id;
                BLtherapist.Add(tmpTherapist);
            }

            return BLtherapist;
        }

        public List<BLTurn> TherapistTurns()
        {
            throw new NotImplementedException();
        }

        public void Update(BLTherapist item)
        {
            //Therapist myTherapist = new Therapist();
            //myTherapist.Name = item.Name;
            //myTherapist.Id = item.Id;
            //dalTherapist.Update(myTherapist);

            throw new NotImplementedException();
        }
    }
}
