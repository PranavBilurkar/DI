using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI
{    
        interface ILogger
        {
            void Log(string p);
        }

        interface IDataAccess
        {
            void LoadData();
            void SaveData(string name);
        }

        interface IBusinessLogic
        {
            void ProcessData();
        }
   
}
