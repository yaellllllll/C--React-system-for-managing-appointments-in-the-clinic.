
using Microsoft.AspNetCore.Mvc;
using BL.blimp;
using BL.blApi;
using BL.blDataObject;
using BL;

namespace MyServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : Controller
    {
        BLIclient BLCS;
        BLIturn BLTurn;
        public ClientController(BLManager m)
        {
            BLTurn = m.turn;
            BLCS = m.client;

        }

        [HttpGet]
        [Route("GetClient")]
        public List<BLClient> getClients()
        {
            return BLCS.Read();
        }

        [HttpGet]
        [Route("GetTurns")]
        public List<BLTurn> getTurns()
        {
            return BLTurn.Read();
        }

        [HttpGet]
        [Route("GetTurnsOfHour")]
        public List<BLTurn> getTurnsOfHour(int h)
        {
            return BLTurn.turnsIn(h);
        }

        [HttpPost]
        [Route("AddClient")]
        public void addClient(BLClient client)
        {
            BLCS.Create(client);
        }
        [HttpPost]
        [Route("AddTurn")]
        public void addTurn(BLTurn turn)
        {
            BLTurn.Create(turn);
        }

    }
}

