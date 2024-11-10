using DAL;
using DAL.dalApi;
using DAL.DataObject.Models;
using System;

public class ClientService : Iclient
{
    dbcontext DB = new dbcontext();

    public ClientService()
    {
       
    }
    public async void Create(Client item)
    {
        DB.Clients.Add(item);
        await DB.SaveChangesAsync();

    }

    public async void Delete(Client item)
    {
        DB.Clients.Remove(item);
        await DB.SaveChangesAsync();
    }

    public List<Client> Read()
    {
        List<Client> list = new List<Client>();
        list= DB.Clients.ToList();
        return list;
    }

    public async void Update(Client item)
    {
        DB.Clients.Remove(item);
        await DB.SaveChangesAsync();
        DB.Clients.Add(item);
        await DB.SaveChangesAsync();
    }
}
