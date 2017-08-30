using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIoCContainer.IoCContainers
{
    public class CustomContainer
    {
        private Dictionary<Type, Type> _registeredTypes = new Dictionary<Type, Type>();
        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }
        private object Resolve(Type type)
        {
            Type typeToReturn = null;
            try
            {
                typeToReturn = this._registeredTypes[type];
            }
            catch
            {
                throw new Exception($"Could not resolve {type.FullName}");
            }

            var constructor = typeToReturn.GetConstructors().FirstOrDefault();
            var parametersOfConstructor = constructor.GetParameters();

            if (parametersOfConstructor.Count() == 0)
            {
                return Activator.CreateInstance(typeToReturn);
            }

            var parameters = new List<object>();
            foreach (var parameter in parametersOfConstructor)
            {
                parameters.Add(Resolve(parameter.ParameterType));
            }
            return constructor.Invoke(parameters.ToArray());
        }
        public void Register<TFrom, TTo>()
        {
            this._registeredTypes.Add(typeof(TFrom), typeof(TTo));
        }
    }
}
