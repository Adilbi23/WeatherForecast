using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace урок_2
{
    class DI //Dependency Injection
    {
        private void AddToDictionary(Type key, Type value)
        {
            List<Type> types = dictionary.Keys.Where(k => k.Equals(key)).ToList();
            if (types.Count == 0)
            {
                dictionary.Add(key, value);
            }
            else
            {
                dictionary[key] = value;
            }
        }
        private Dictionary<Type, Type> dictionary = new Dictionary<Type, Type> ();

        public void Register<TKey, TValue>() where TValue : TKey  
        {
            Type key = typeof(TKey);
            Type value = typeof(TValue);
            this.AddToDictionary(key, value);
        }
        public void Register(Type key, Type value)
        {
            this.AddToDictionary(key, value);
        }


        public T GetInstance <T>()
        {
            Type instanceType = dictionary[typeof(T)];
            T instance = (T)Activator.CreateInstance(instanceType);
            return instance;
        }
        public K GetInstance1 <K>()
        {
            Type instanceType = dictionary[typeof(K)];
            K instance = (K)Activator.CreateInstance(instanceType);
            return instance;
        }

    }
    
}
