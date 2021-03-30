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
            if (amount <= 0 )
            {
                Console.WriteLine("You broke.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Yo, you a rich b*tch.");
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
            string Alexandra = Console.ReadLine();
            Console.WriteLine("Hi \t" + Alexandra);
            Console.WriteLine("Would you like to Deposit or Withdraw your moneyz, or Check if you even have money?");
            int Amount = Console.ReadLine();

            var moneyman = new Client(1, Alexandra);
            var BankAccount = new BankAccount(moneyman, balance, type);
            BankAccount.CheckBalance();
            BankAccount.Withdraw(amount);
            BankAccount.Deposit(amount);
            var amount = Console.ReadLine();
            var deposit = Console.ReadLine();

           

       
        }
    }


}
