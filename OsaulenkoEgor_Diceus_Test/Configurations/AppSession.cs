using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsaulenkoEgor_Diceus_Test.Configurations
{
    public class AppSession
    {
        private Dictionary<string, object> _values = new Dictionary<string, object>();

        private static AppSession _instance;

        public static AppSession Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AppSession();
                }

                return _instance;
            }
        }

        public void SetValue(string key, object value)
        {
            if (_values.ContainsKey(key))
            {
                _values.Remove(key);
            }
            _values.Add(key, value);
        }

        public T GetValue<T>(string key)
        {
            if (_values.ContainsKey(key))
            {
                return (T)_values[key];
            }
            else
            {
                return default(T);
            }
        }

        public void RemoveValue(string key)
        {
            _values.Remove(key);
        }

        internal bool ValueExists(string key)
        {
            return _values.ContainsKey(key);
        }
    }
}
