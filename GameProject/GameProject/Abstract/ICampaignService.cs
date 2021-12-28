using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
namespace GameProject.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
