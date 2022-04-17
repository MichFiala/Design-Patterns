using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton.Singleton
{
    public class ThreadSafeSingleton
    {
        // We now have a lock object that will be used to synchronize threads
        // during first access to the Singleton.
        private static readonly object _lock = new object();

		private static ThreadSafeSingleton? _instance;

		public static ThreadSafeSingleton Instance 
        {
            get 
            {
                if(_instance is null)
                {
                    lock(_lock)
                    {
                        if(_instance == null)
                        {
							_instance = new ThreadSafeSingleton();
						}
                    }
                }
				return _instance;
			}
        }
        private ThreadSafeSingleton() { }
	}
}