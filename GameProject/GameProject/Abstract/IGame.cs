using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    interface IGame
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
