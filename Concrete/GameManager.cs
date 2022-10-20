using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {

            Console.WriteLine("{0} adlı Oyun sisteme eklendi",game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} adlı Oyun silindi", game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("{0} adlı Oyun güncellendi", game.GameName);
        }
    }
}
