using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GameProject.Concrete
{
    class SalloutManager : ISelloutService
    {
        public void Sellout(Game game, Players player, Campaign campaign = null)
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
                if (campaign == null)
                {
                    Console.WriteLine("if", game.GamePrice, player.LastName);
                    Console.WriteLine("{0} isimli oyuncu {1} adlı oyunu {2} TL karşılığında satın aldı", player.FirstName, game.GameName, game.GamePrice);
                }
                else
                {

                    float calculator = game.GamePrice - ((game.GamePrice * campaign.DiscountRate)/100);
                    Console.WriteLine("{0} isimli oyuncu, {1} oyununu %{2} indirimle {3}TL fiyatına satın aldı.", player.FirstName, game.GameName, campaign.DiscountRate, calculator);

                }
            }
            else
            {
                Console.WriteLine("Oyun satın alınamadı lütfen tekrar deneyiniz.");
            }
            if ((bool)durum)
            {

            }
            
        }
    }
}


