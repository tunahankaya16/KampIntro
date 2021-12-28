using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    interface ISaleService
    {
        void Sale(Gamer gamer, Game Game,Campaign campaign);
    }
}
