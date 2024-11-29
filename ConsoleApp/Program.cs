// See https://aka.ms/new-console-template for more information
using ArshakAssignment;

Console.WriteLine("Hello, World!");
CreateAccount();
void CreateAccount() 
{
    Currency dollar= Currency.Dollar;
    Currency euro= Currency.Euro;
    Currency sek = Currency.SEK;
    Account account1 = new Account();
    account1.Id = 101;
    Money balanceOfAccount1= new Money(85.0m,euro );
    account1.Balance = balanceOfAccount1;
    Console.WriteLine("Amount for account1 where ID is "+account1.Id + "  =  " +account1.Balance.Amount+" "+ account1.Balance.Currency);
    CurrencyConverter currencyConverter = new CurrencyConverter(0.095m, 0.085m, 1.0m);
  //account1.Balance.ChangingCurrency(currencyConverter, sek);
  //Console.WriteLine("new Amount for account1 where ID is " + account1.Id + "  =  " + account1.Balance.Amount + " " + account1.Balance.Currency);
    //here we need to creat new Money where previous statment work without error but it could not change current balance
    Money changeMoneyofAccount1 = balanceOfAccount1.ChangingCurrency(currencyConverter, sek);
    account1.Balance= changeMoneyofAccount1;
    Console.WriteLine("new Amount for account1 where ID is " + account1.Id + "  =  " + account1.Balance.Amount + " " + account1.Balance.Currency);

    Account account2 = new Account();
    account2.Id = 102;
    Money balanceOfAccount2 = new Money(1000.0m, sek);
    account2.Balance = balanceOfAccount2;
    Console.WriteLine("Amount for account2 where ID is " + account2.Id + "  =  " + account2.Balance.Amount + " " + account2.Balance.Currency);
 // account2.Balance.ChangingCurrency(currencyConverter, dollar);
  //onsole.WriteLine("new Amount for account2 where ID is " + account2.Id + "  =  " + account2.Balance.Amount + " " + account2.Balance.Currency);
    Money changeMoneyofAccount2 = balanceOfAccount2.ChangingCurrency(currencyConverter,sek);
    account2.Balance = changeMoneyofAccount2;
    Console.WriteLine("new Amount for account2 where ID is " + account2.Id + "  =  " + account2.Balance.Amount + " " + account2.Balance.Currency);

    Money changeMoney = balanceOfAccount2.ChangingCurrency(currencyConverter,dollar);
    account2.Balance = changeMoney;
    Console.WriteLine("new Amount for account2 where ID is " + account2.Id + "  =  " + account2.Balance.Amount + " " + account2.Balance.Currency);
}