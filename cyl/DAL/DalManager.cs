using DAL.dalApi;
using DAL.dalimp;
using DAL.DataObject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalManager
    {
        public Iclient client { get; }
        public Itherapist therapist { get; }
        public Iturn turn { get; }
        public DalManager()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<dbcontext>();
            services.AddSingleton<Iclient, ClientService>();
            services.AddSingleton<Itherapist, TherapistService>();
            services.AddSingleton<Iturn, TurnService>();


            var provider = services.BuildServiceProvider();

            client = provider.GetRequiredService<Iclient>();
            therapist = provider.GetRequiredService<Itherapist>();
            turn = provider.GetRequiredService<Iturn>();

        }
    }
}

