using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class GameManager : IGameService
    {

        IGamerService gamerService;

        public GameManager(IGamerService gamerService)
        {
            this.gamerService = gamerService;
        }

        public void Add(Game game)
        {
            Console.WriteLine("Oyun Kaydedildi");
        }

        public void Remove(Game game)
        {
            Console.WriteLine("Oyun Silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi");
        }
    }
}
