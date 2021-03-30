using System;

namespace bank
{

    class BankAccount
    {
        public BankAccount(Client client, int balance, string type)
        {
            Client = client;
            Balance = balance;
            Type = type;
        }

        public Client Client { get; }
        public int Balance { get; set; }
        public string Type { get;  }

        public int CheckBalance() 
    {
        return Balance;
    }

        public void Withdraw(int amount)
        {
            if (Balance <= amount )
            {
                Console.WriteLine("You broke.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("withdraw succesfull.");
            }    
        }

        public void Deposit(int amount)
        {
            Balance += amount;
        } 
    }

    class Client
    {
        public Client(int id, string name)
        {
            Id = id;
            Name = name;
            DateJoined = DateTime.Now;
        }

        public int Id { get;  }
        public string Name { get;  }
        public DateTime DateJoined { get;  }

    }

    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Helloooow, What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Hi \t" + name);
            Console.WriteLine("What type of bank account do you have?");
            var type = Console.ReadLine();
            Console.WriteLine("How poor or rich are you at the moment?");
            int balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to Deposit or Withdraw your moneyz, or Check if you even have money?");
            var answer = Console.ReadLine();
            var moneyman = new Client(1, name);
            var BankAccount = new BankAccount(moneyman, balance, type);


            if (answer == "check")
            {
                Console.WriteLine("Your balance now is" + BankAccount.CheckBalance());
                BankAccount.CheckBalance();
            }
            else if (answer == "deposit")
            {
                Console.WriteLine("How much do you want to deposit laddy?");
                var amount = Convert.ToInt32(Console.ReadLine());
                BankAccount.Deposit(amount);
            }
            else
            {
                Console.WriteLine("How much do you want to withdraw?");
                var amount = Convert.ToInt32(Console.ReadLine());
                BankAccount.Withdraw(amount);
            }
        }
    }
}
