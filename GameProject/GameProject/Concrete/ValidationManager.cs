using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    class ValidationManager : IValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.FirstName=="Tunahan"&&gamer.LastName=="Kaya"&&gamer.NationalID==12345)
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
