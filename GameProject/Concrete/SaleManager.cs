using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class SaleManager : ISaleService
    {
        ICampaignService _campaignService;

        public SaleManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        IGamerService _gamerService;

        public SaleManager(IGamerService gamerService)
        {
            _gamerService = gamerService;
        }

        public void Add(Sale sale)
        {
            Console.WriteLine(sale.Gamer.FirstName + " " + sale.Gamer.LastName + " bought " + sale.Game.Name + " for " + sale.Price + " TL on " + sale.SaleDate + ".");
        }

        public void Remove(Sale sale)
        {
            Console.WriteLine("Oyun satışı silindi");
        }

        public void Update(Sale sale)
        {
            Console.WriteLine("Oyun satışı güncellendi");
        }
    }
}
