using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerLoanManager = new ConsumerLoanManager();         
            ICreditManager vehicleLoanManager = new VehicleLoanManager();         
            ICreditManager mortgageManager = new MortgageManager();

            ApplyManager applyManager = new ApplyManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() };
            applyManager.Apply(consumerLoanManager,loggers );

            List<ICreditManager> credits = new List<ICreditManager>() {mortgageManager, vehicleLoanManager };
            //applyManager.DoCreditPreİnfo(credits);
           
        }
    }
}
