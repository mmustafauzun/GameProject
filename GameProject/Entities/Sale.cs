using GameProject.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    internal class Sale
    {
        public int Id { get; set; }
        public Gamer Gamer { get; set; }
        public Game Game { get; set; }
        public double Price { get { return Game.Price; } }
        public DateTime SaleDate { get; set; }
    }
}
