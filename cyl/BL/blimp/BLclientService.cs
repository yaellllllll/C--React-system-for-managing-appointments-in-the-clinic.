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
    public class BLclientService : BLIclient
    {
        
       
        Iclient dalClient;

        public BLclientService(DalManager a)
        {
            this.dalClient = a.client;
        }

        public void Create(BLClient item)
        {
            Client myClient= new Client();
            myClient.Name = item.Name;
            myClient.Id = item.Id;
            dalClient.Create(myClient);
        }

        public void Delete(BLClient item)
        {
            Client myClient = new Client();
            myClient.Name = item.Name;
            myClient.Id = item.Id;
            dalClient.Delete(myClient);
        }

        public List<BLClient> Read()
        {
            List<BLClient> BLclients = new();
            IEnumerable<Client> dalClients = dalClient.Read();
            foreach (Client client in dalClients)
            {
                BLClient tmpClient = new BLClient();
                tmpClient.Name = client.Name;
                tmpClient.Id = client.Id;
                BLclients.Add(tmpClient);
            }

            return BLclients;
        }

        public void Update(BLClient item)
        {
            Client myClient = new Client();
            myClient.Name = item.Name;
            myClient.Id = item.Id;
            dalClient.Update(myClient);
        }
    }
}
