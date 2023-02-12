using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RechargeCardApp
{
    public class RechargeCard
    {
        private string serialNumber;//{get; set;}
        private string cardType;
        private int cardNumber;
        private decimal cardAmount;
        
        

        public string GetSerialNumber()
        {
            return serialNumber;
        }
        public void SetSerialNumber()
        {
            this.serialNumber = GenerateSerialNumber();
        }
        
       
        public string GetCardType()
        {
            return cardType;
        }
        public void SetCardType(string cardType)
        {
            this.cardType = cardType;
        }
         
        public decimal GetCardAmount()
        {
            return cardAmount;
        }
        public void SetCardAmount(decimal cardAmount)
        {
            this.cardAmount = cardAmount;
        }
        
        public int GetCardNumber()
        {
            return cardNumber;
        }
        public void SetCardNumber()
        {
            this.cardNumber = GenerateCardNumber();
        }

        public string GenerateSerialNumber()
        {
            Random rand = new Random();
            int genSerialNum = rand.Next(100, 1000);
            return "S/N"+genSerialNum;
        }

        public int GenerateCardNumber()
        {
            Random rand = new Random();
            int genCardNumber = rand.Next(10000000, 1000000000);
            return genCardNumber;
        }

       

    }
}