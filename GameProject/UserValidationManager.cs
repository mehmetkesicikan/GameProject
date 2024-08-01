using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "Mert" && gamer.LastName == "K." && gamer.IdentityNumber == 1234)
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
