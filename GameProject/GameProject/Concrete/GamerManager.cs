using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        private ValidationManager validationService;

        public GamerManager(ValidationManager validationService)
        {
            this.validationService = validationService;
        }
        
        public void Add(Gamer gamer)
        {
            if (validationService.Validation(gamer)==true)
            {
            Console.WriteLine("Oyuncu Eklendi.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi.");
        }
    }
}
