using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingleObjectClass
    {
        private static SingleObjectClass _instance = new ();

        private SingleObjectClass()
        {
        }

        public static SingleObjectClass getInstance()
        {
            return _instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("A message from your object 'created one time and used everytime.'");
        } 
    }
}
