using CustomIoCContainer.Contracts;
using CustomIoCContainer.IoCContainers;
using Microsoft.Practices.Unity;

namespace CustomIoCContainer
{
    class Startup
    {
        static void Main(string[] args)
        {
            //using Unity IoC container
            var container = new UnityContainer();
            container.RegisterType<ICreditCard, Visa>();
            var shopper = container.Resolve<Shopper>();
            shopper.Charge();

            //using custom IoC container
            var customContainer = new CustomContainer();
            customContainer.Register<Shopper, Shopper>();
            customContainer.Register<ICreditCard, MasterCard>();
            var shopper2 = customContainer.Resolve<Shopper>();
            shopper2.Charge();
        }
    }
}
