using CustomIoCContainer.Contracts;
using System;

namespace CustomIoCContainer
{
    public class Shopper
    {
        private ICreditCard _creditCard;
        public Shopper(ICreditCard creditCard)
        {
            this._creditCard = creditCard;
        }

        public void Charge()
        {
            Console.WriteLine(this._creditCard.Charge());
        }
    }
}