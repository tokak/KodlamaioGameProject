using KodlamaioGameProject.Abstract;
using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Concrete
{
    public class GamerManager : IGamerService

    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public  void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                Console.WriteLine($"{gamer.FirstName} Gamer Added!");
            }
            else
            {
                throw new Exception($"{gamer.FirstName} the gamer is not verified");
            }
           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine($"{gamer.Id} gamer deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine($"{gamer.Id} gamer update.");
        }
    }
}
