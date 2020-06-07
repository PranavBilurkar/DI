using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI
{
    //Client Class
    class Client_BusinessLogic : IBusinessLogic
    {
        ILogger _log;
        IDataAccess _dataAccess;

        public Client_BusinessLogic(ILogger log, IDataAccess dataAccess)
        {
            _log = log;
            _dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            _log.Log("Start");
            Console.WriteLine("process");
            _dataAccess.LoadData();
            _dataAccess.SaveData("processInfo");
            _log.Log("Finish");
        }
    }
}

