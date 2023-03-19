using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        ICampaignService _campaignService;
        IGamerService _gamerService;

        public CampaignManager(IGamerService gamerService)
        {
            _gamerService = gamerService;
        }

        public CampaignManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Kaydedildi");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
