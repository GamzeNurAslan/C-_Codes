using BankingSystem.classes;

namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a bank
            Bank bank = new Bank();

            // Create customers
            Customer customer1 = new Customer();
            customer1.Name = "GamzeNur";
            customer1.Address = "Turkey";
            bank.Customers.Add(customer1);
        }
    }
}
