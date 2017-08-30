using CustomIoCContainer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIoCContainer
{
    public class Visa : ICreditCard
    {
        public string Charge()
        {
            return "Charging Visa!";
        }
    }
}
