using CustomIoCContainer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIoCContainer
{
    public class MasterCard : ICreditCard
    {
        public string Charge()
        {
            return "Charging MasterCard!";
        }
    }
}
