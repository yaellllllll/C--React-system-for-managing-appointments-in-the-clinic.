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
using DAL.dalimp;
using BL;
namespace BL.blimp
{
    public class BLturnService : BLIturn
    {
        public Iturn dalTurn;
      
        public BLturnService(DalManager a)
        {
            this.dalTurn = a.turn;
            
        }

        public void Create(BLTurn item)

        {
            Turn myDalTurn= new Turn();
            myDalTurn.Hour = item.Hour;
            myDalTurn.TherapistId = item.TherapistId;
            dalTurn.Create(myDalTurn);
        }

        public void Delete(BLTurn item)
        {
            Turn myDalTurn = new Turn();
            myDalTurn.Hour = item.Hour;
            myDalTurn.TherapistId = item.TherapistId;
            dalTurn.Delete(myDalTurn);
        }

        public List<BLTurn> Read()
        {

            List<BLTurn> BLturns = new();
            IEnumerable<Turn> dalTurns = dalTurn.Read();
            foreach (Turn turn in dalTurns)
            {
                BLTurn tempTurn = new();
                tempTurn.Hour = turn.Hour;
                tempTurn.TherapistId = turn.TherapistId;
                BLturns.Add(tempTurn);
            }

            return BLturns;
        }

        public void Update(BLTurn item)
        {
            Turn myDalTurn = new Turn();
            myDalTurn.Hour = item.Hour;
            myDalTurn.TherapistId = item.TherapistId;
            dalTurn.Update(myDalTurn);
        }

       public List<BLTurn> turnsIn(int hourToCheck)
       {
           // BLturnService t=new BLturnService();
            List<BLTurn> fList =this.Read();
            List<BLTurn> newList= new List<BLTurn>();
            foreach (BLTurn f in fList)
            {
                if(f.Hour == hourToCheck)
                    newList.Add(f); 
            }
            return newList;
       }

    }
}
