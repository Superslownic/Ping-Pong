using System;
using System.Collections.Generic;

namespace PingPong
{
    [Serializable]
    public class GameData
    {
        private Dictionary<string, object> _container;

        public GameData()
        {
            _container = new Dictionary<string, object>();
        }

        public void Add(string name, object obj)
        {
            _container.Add(name, obj);
        }

        public T Get<T>(string name)
        {
            try
            {
                return (T)_container[name];
            }
            catch
            {
                return default;
            }
        }
    }
}
