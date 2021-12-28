using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer, Game Game, Campaign campaign)
        {
            Console.WriteLine("--------SALE DETAILS--------\nGamer: " + gamer.FirstName + " " + gamer.LastName + " Name of game: "
                + Game.GameName + " by " + campaign.CampaignName + "Game cost: "+ Game.Price*campaign.Discount/100);
        }
    }
}
