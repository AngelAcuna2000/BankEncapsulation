namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)

        {
            var account = new BankAccount();
            Console.WriteLine("Welcome to Acuna Banking App!");
            Console.WriteLine("=============================");

            while(true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("\n1. Deposit Money");
                Console.WriteLine("\n2. Check Balance");
                Console.WriteLine("\n3. Exit\n");

                int option;
                if(!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("\nInvalid input. Please enter a valid option.\n");
                    continue;
                }

                switch(option)
                {
                    case 1:
                        Console.WriteLine("\nEnter the amount to deposit:\n");
                        double amount;
                        if(!double.TryParse(Console.ReadLine(), out amount))
                        {
                            Console.WriteLine("\nInvalid input. Please enter a valid amount.\n");
                            continue;
                        }

                        account.Deposit(amount);
                        Console.WriteLine("\nDeposit successful!\n");
                        break;

                    case 2:
                        Console.WriteLine($"\nCurrent balance is {account.GetBalance()}\n");
                        break;

                    case 3:
                        Console.WriteLine("\nThank you for using Acuna Banking App!");
                        return;

                    default: Console.WriteLine("\nInvalid option. Please enter a valid option.\n");
                        break;

                }

            }
        }
    }
}
