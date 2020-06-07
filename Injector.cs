using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI
{
    //Injector Class
    class Injector
    {
        static void Main(string[] args)
        {
            ILogger _log = new Logger();
            IDataAccess _da = new DataAccess();

            Client_BusinessLogic bs = new Client_BusinessLogic(_log,_da);
            bs.ProcessData();
            Console.ReadLine();
        }
    }
}
