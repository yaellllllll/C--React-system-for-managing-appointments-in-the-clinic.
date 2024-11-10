using System;
using System.Collections.Generic;

namespace DAL.DataObject.Models
{
    public partial class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? TherapistId { get; set; }

        public virtual Therapist? Therapist { get; set; }
    }
}
