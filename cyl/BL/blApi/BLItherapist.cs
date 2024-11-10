using BL.blDataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.blApi
{
    public interface BLItherapist:BLIcrud<BLTherapist>
    {
        List<BLTurn> TherapistTurns();
    }
}
