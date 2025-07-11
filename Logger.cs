using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public sealed class Logger // seal class, to restrict all th inharitance
    {

        private static Logger _instance;
        private static readonly object InstanceLock = new object();

        private Logger() // Private constructor
        {
            Console.WriteLine("Logger constructor executed\n");
        }

        public static Logger Instance // Singleton instance accessor
        {
            get
            {
                lock (InstanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                    return _instance;
                }
            }
        }
        public void Log(string message) // Instance method to log messages
        {
            Console.WriteLine(message);
        }
    }

}
