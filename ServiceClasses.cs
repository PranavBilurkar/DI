using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI
{
    //Service Class
    class DataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loaddata");
        }

        public void SaveData(string name)
        {
            Console.WriteLine("Saving Data");
        }
    }

    class Logger : ILogger
    {
        public void Log(string p)
        {
            Console.WriteLine(p);
        }
    }
}
