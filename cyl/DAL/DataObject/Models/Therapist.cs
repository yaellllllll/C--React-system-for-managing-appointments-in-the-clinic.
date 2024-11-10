using System;
using System.Collections.Generic;

namespace DAL.DataObject.Models
{
    public partial class Therapist
    {
        public Therapist()
        {
            Clients = new HashSet<Client>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Client> Clients { get; set; }
    }
}
