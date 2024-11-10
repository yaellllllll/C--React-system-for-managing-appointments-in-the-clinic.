using BL.blDataObject;
using DAL.DataObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.blApi
{
    public interface BLIturn: BLIcrud<BLTurn>
    {
        List<BLTurn> turnsIn(int hourToCheck);
    }
}
