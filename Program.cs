using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {                                                                                                                            //UrNationalityId
            Players player1 = new Players { Id = 1, FirstName = "ÜMİT FARUK", LastName = "ATMACA", DateOfBirth = 2001, NationalityId = 12345678910 };
            Players player2 = new Players { Id = 2, FirstName = "Esma" , LastName = "Balcı",  DateOfBirth = 1990, NationalityId = 27156424784 };
            Game game1 = new Game { GameId=1, GameName = "Metro" , GamePrice = 30};
            Campaign Newcampaign = new Campaign { CampaignId=1 , CampaignName="Bahar İndirimi" , DiscountRate=50};

            ICampaignService campaignService = new CampaignManager();
            IGameService gameService = new GameManager();
            IPlayerService playerService = new PlayerManager();
            ISelloutService selloutService = new SalloutManager();

            //gameService.Add(game1);
            //playerService.Add(player1);
            //playerService.Control(player1);

            selloutService.Sellout(game1,player1,Newcampaign);
            
            Console.ReadLine();
        }
    }
}
