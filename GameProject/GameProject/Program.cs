using System;
using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer _gamer1 = new Gamer();
            _gamer1.FirstName = "Tunahan";
            _gamer1.LastName = "Kaya";
            _gamer1.ID = 1;
            _gamer1.NationalID = 12345;

            Game _game1 = new Game();
            _game1.GameName = "Fight Bros";
            _game1.gameID = 1;
            _game1.Year = 2020;
            _game1.Price = 60;

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Yılbaşı Kampanyası";
            campaign1.Discount = 50;
            campaign1.ID = 1;

            GamerManager gamerManager = new GamerManager(new ValidationManager());
            gamerManager.Add(_gamer1);

            GameManager gameManager = new GameManager();
            gameManager.Add(_game1);
            gameManager.Update(_game1);

            CampaignManager campaign = new CampaignManager();
            campaign.Add(campaign1);

            SaleManager newsale = new SaleManager();
            newsale.Sale(_gamer1, _game1, campaign1);
        }
    }

    
}
