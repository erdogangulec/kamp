using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BrithYear == 2000 && gamer.FirstName == "ERDOĞAN" && gamer.LastName == "GÜLEÇ" && gamer.IdentitNumber==12345)
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
