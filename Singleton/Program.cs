using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Demo Code
            SingleObjectClass singleObject = SingleObjectClass.getInstance();
            singleObject.ShowMessage();

            #endregion
            Console.WriteLine("Done!");
        }
    }
}
