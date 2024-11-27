// See https://aka.ms/new-console-template for more information
using ArshakAssignment;

Console.WriteLine("Hello, World!");
CreateAccount();
void CreateAccount() 
{
    Account account1 = new Account();
    account1.Id = 101;
    Money balanceOfAccount1= new Money(85.0m,Currency.Euro);
    account1.Balance = balanceOfAccount1;
    Console.WriteLine("Amount for account1 where ID is" + account1.Id + "  =  " +account1.Balance.Amount+" "+ account1.Balance.Currency);
    CurrencyConverter currencyConverter = new CurrencyConverter(0.095m, 0.085m, 1.0m);
    account1.Balance.ChangingCurrency(currencyConverter, Currency.SEK);
    Console.WriteLine("Amount for account1 where ID is" + account1.Id + "  =  " + account1.Balance.Amount + " " + account1.Balance.Currency);
    

    Account account2 = new Account();
    account2.Id = 102;
    Money balanceOfAccount2 = new Money(1000.0m, Currency.SEK);
    account2.Balance = balanceOfAccount2;
    Console.WriteLine("Amount for account2 where ID is " + account2.Id + "  =  " + account2.Balance.Amount + " " + account2.Balance.Currency);
    account2.Balance.ChangingCurrency(currencyConverter, Currency.Dollar);
    Console.WriteLine("Amount for account2 where ID is " + account2.Id + "  =  " + account2.Balance.Amount + " " + account2.Balance.Currency);
}