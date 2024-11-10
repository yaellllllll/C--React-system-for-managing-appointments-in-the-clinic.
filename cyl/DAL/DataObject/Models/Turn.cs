using System;
using System.Collections.Generic;

namespace DAL.DataObject.Models
{
    public partial class Turn
    {
        public int Hour { get; set; }
        public string TherapistId { get; set; } = null!;
    }
}
