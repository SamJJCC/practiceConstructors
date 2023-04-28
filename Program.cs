namespace practiceConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car defaultCar = new car();
            car makeModelCar = new car("Toyota", "Rav4");
            car fullCar = new car("Hyundai", "Sonata", 2010, 100000);

         Console.WriteLine(defaultCar);
            Console.WriteLine(makeModelCar);
            Console.WriteLine(fullCar);

            Console.WriteLine("Bank Information");
            BankAccount account = new BankAccount("12345","Sam",20);
            Console.WriteLine(account);
            account.Deposit(500);
            Console.WriteLine(account);
            account.Deposit(-15000);
            Console.WriteLine(account);
            account.Withdraw(300);
            Console.WriteLine(account);
            account.Withdraw(-500);
            Console.WriteLine(account);
        }
    }
}