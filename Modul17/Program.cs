class Program
{
    static void Main(string[] args)
    {
        Account regularAccount = new RegularAccount { Balance = 1500 };
        Account salaryAccount = new SalaryAccount { Balance = 2000 };

        Calculator.CalculateInterest(regularAccount);
        Calculator.CalculateInterest(salaryAccount);

        Console.WriteLine($"Процентная ставка для обычного аккаунта: {regularAccount.Interest}");
        Console.WriteLine($"Процентная ставка для зарплатного аккаунта: {salaryAccount.Interest}");
    }
}