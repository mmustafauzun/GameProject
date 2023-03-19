using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.user;

namespace GameProject.Entities
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1995 && gamer.FirstName == "ENGİN" && gamer.IdentityNumber == 12345678901)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
