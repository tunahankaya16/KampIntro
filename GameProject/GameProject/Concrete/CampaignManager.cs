using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi.");
        }
    }
}
