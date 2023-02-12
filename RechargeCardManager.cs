using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RechargeCardApp
{
    public class RechargeCardManager
    {
       //public RechargeCard[] cards = new RechargeCard[10];

       public List<RechargeCard> cards = new List<RechargeCard>();
       
        public void AddRechargeCardToList(RechargeCard rechargeCard) //means a class can also become a data type
        {
            //cards[0] = rechargeCard;
            cards.Add(rechargeCard);
        }


        
        public void CreateRechargeCard()
        {
            RechargeCard rechargeCard = new RechargeCard();
            rechargeCard.SetSerialNumber();
            rechargeCard.SetCardType("MTN");
            rechargeCard.SetCardAmount(100m);
            rechargeCard.SetCardNumber();

            AddRechargeCardToList(rechargeCard); //it's like nothing added to an empty bucket
        }
        public void CreateMultipleRechargeCards(int numberOfCards)
        {
           for(int i = 0; i < numberOfCards; i++)
           {
                RechargeCard rechargeCard = new RechargeCard();
                rechargeCard.SetSerialNumber();
                rechargeCard.SetCardType("Glo");
                rechargeCard.SetCardAmount(200);
                rechargeCard.SetCardNumber();

                AddRechargeCardToList(rechargeCard); //it's like nothing added to an empty bucket
           }
        }



    }
}