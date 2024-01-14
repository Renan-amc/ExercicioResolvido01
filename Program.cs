using exProposto208C.Entities;
using exProposto208C.Services;
using System.Globalization;

namespace exProposto208C {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract Value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());


            Contract myContract = new Contract(contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine("Installments: ");
            foreach (Installments i in myContract.Installments) {
                Console.WriteLine(i);
            }
        }
    }
}
