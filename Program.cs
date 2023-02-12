using System;

namespace RechargeCardApp
{
    class Program
    {
        static RechargeCardManager manager = new RechargeCardManager();
        static void Main(string[] args)
        {
            manager.CreateRechargeCard();
            manager.CreateMultipleRechargeCards(3);
            foreach(var card in manager.cards) 
            {
                System.Console.WriteLine($"{card.GetCardNumber()} {card.GetCardAmount()} {card.GetCardType()} {card.GetSerialNumber()}");
            }
            
        }
    }
}
