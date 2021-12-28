using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class GameManager : IGame
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun sisteme eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Sistemdeki oyun silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi.");
        }
    }
}
