namespace AppDev.Week_5 {
    public class BankAccount
    {
        // private fields
        private string _accountNumber;
        private double _balance;

        //constructor
        public BankAccount(string accountNumber) {
            _accountNumber = accountNumber;
            } 

        // public properties
        public string AccountNumber { get; }

        public double Balance {
            get { return _balance; }
            private set
            {
                if (value > 0)
                    _balance = value;
                else
                {
                    Console.WriteLine("Balance must be greater than 0");
                }

            }

        }

        public double Deposit(double amount)
        {
            if (amount > 0)
                return _balance += amount;
            else
                Console.WriteLine("Cannot deposit.");
                return 0;
        
    }

        public double Withdraw(double amount)
        {
            if (amount > 0 && amount < Balance)
            return _balance -= amount;
            else
            {
                Console.WriteLine("Insufficient Fund.");
                return 0;
            }
        }


    }
}