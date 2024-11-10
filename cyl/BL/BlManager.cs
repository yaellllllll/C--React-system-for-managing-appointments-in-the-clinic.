using BL.blApi;
using BL.blimp;
using DAL.dalApi;
using DAL.dalimp;
using DAL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLManager
    {
        public BLIclient client { get; }
        public BLItherapist therapist { get; }
        public BLIturn turn { get; }
        public BLManager()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddSingleton<DalManager>();

            services.AddSingleton<BLIclient, BLclientService>();

            services.AddSingleton<BLItherapist, BLtherapistService>();

         services.AddSingleton<BLIturn, BLturnService>();


            var provider = services.BuildServiceProvider();

            client = provider.GetRequiredService<BLIclient>();
            therapist = provider.GetRequiredService<BLItherapist>();
           turn = provider.GetRequiredService<BLIturn>();
        }
    }
}
