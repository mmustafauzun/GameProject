using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using GameProject.user;
using System.Diagnostics;
using System.Formats.Tar;
using System.Xml.Linq;

namespace GameProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            GameManager gameManager = new GameManager(gamerManager);
            CampaignManager campaignManager = new CampaignManager(gamerManager);
            SaleManager saleManager = new SaleManager(gamerManager);

            Game game = new Game
            {
                Id = 1,
                Name = "Example Game",
                Price = 50
            };

            Gamer gamer = new Gamer
            {
                Id = 1,
                BirthYear = 1995,
                FirstName = "ENGİN",
                LastName = "DEMİROG",
                IdentityNumber = 12345678901
            };
            Campaign campaign = new Campaign
            {
                Id = 1,
                Name = "GTA",
                DiscountRate = 5
            };

            Sale sale = new Sale
            {
                Id = 1,
                Game = game,
                Gamer = gamer
            };

            saleManager.Add(sale);



           




        }
    }
}