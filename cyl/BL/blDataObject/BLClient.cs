using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.blDataObject
{
    public class BLClient
    {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        //public string LastTreat { get; set; } = null!;
        //public DateTime DateStart { get; set; }
        //public List<BLTurn> listTurns { get; set; } = new List<BLTurn>();
        public BLClient()
        {
        }

    }
}

