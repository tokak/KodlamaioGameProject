using KodlamaioGameProject.Abstract;
using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Add(Game game, Campaign campaign = null)
        {
            if (campaign==null)
            {
                Console.WriteLine($"{game.Name} {game.Price}$ game added!.");
            }
            else
            {
                Console.WriteLine($"{game.Name} {game.Price}$  {campaign.Name} Season discount %{campaign.DiscountRate} game added!");
            }
        }

        public void Delete(int id)
        {
            Console.WriteLine($"Campaign {id} deleted!!");
        }

        public void Update(Game game, Campaign campaign = null)
        {
            if (campaign == null)
            {
                Console.WriteLine($"{game.Name} {game.Price}$ game Updated!.");
            }
            else
            {
                Console.WriteLine($"{game.Name} {game.Price}$  {campaign.Name} Season discount %{campaign.DiscountRate} game Updated!");
            }
        }
    }
}
