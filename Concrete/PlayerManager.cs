using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GameProject.Concrete
{
    class PlayerManager : IPlayerService
    {
        public void Add(Players player)
        {
            Console.WriteLine("{0} Adlı Kişi Eklendi",player.FirstName);
        }

        public void Delete(Players player)
        {
            Console.WriteLine("{0} Adlı Kişi Silindi", player.FirstName);
        }

        public void Update(Players player)
        {
            
            Console.WriteLine("{0} Adlı Kişi Güncellendi", player.FirstName);
        }


        public void Control(Players player)
        {
            bool? durum;
            try
            {
                using (Kimlik.KPSPublicSoapClient servis = new Kimlik.KPSPublicSoapClient())
                {
                    durum = servis.TCKimlikNoDogrula(player.NationalityId, player.FirstName, player.LastName, player.DateOfBirth);
                }
            }
            catch (Exception)
            {
                durum = null;
                throw;
            }
            if ((bool)durum)
            {
                Console.WriteLine("Tc doğrulandı");
            }
            else
            {
                Console.WriteLine("Tc kimlik bilgileri yanlış");
            }
            
        }
    }
}
