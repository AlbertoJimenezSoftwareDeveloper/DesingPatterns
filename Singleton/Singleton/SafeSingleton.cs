using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SafeSingleton
    {

        //private stactic SafeSingleton static variable 
        private static SafeSingleton _Instance;
        private static readonly object _padLock = new object();

        private SafeSingleton()
        {
            _Instance = new SafeSingleton();
        }

        public static SafeSingleton Instance {

            get
            {
                if (_Instance == null)
                {
                    lock (_padLock)
                    {
                        if (_Instance == null)
                        {
                            _Instance = new SafeSingleton();
                        }
                    }
                }
                return _Instance;

            }

        }

        public string Name;


    }
}
