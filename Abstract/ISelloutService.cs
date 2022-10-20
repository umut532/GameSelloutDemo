using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    interface ISelloutService
    {
        void Sellout(Game game,Players player,Campaign campaign = null);
    }
}
