using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    interface IPlayerService
    {
        void Add(Players player);
        void Update(Players player);
        void Delete(Players player);
        void Control(Players player);
    }
}
