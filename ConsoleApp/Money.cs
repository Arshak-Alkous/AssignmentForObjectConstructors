using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArshakAssignment
{
    public class Money
    {
        public decimal Amount {  get;  private set; }
        public Currency Currency { get; private set; }
        public Money(decimal amount, Currency currency) 
        {
            this.Amount = amount;
            this.Currency = currency;
        }
        public void ChangingCurrency(CurrencyConverter currencyConverter,Currency newcurrency) 
        {
            Currency currentCurrency=this.Currency;
            decimal currentAmount=this.Amount;
            decimal newAmount=0.0m;
            switch (currentCurrency) 
            {
                case Currency.Dollar:
                    switch (newcurrency)
                    {
                        case Currency.SEK: newAmount = currencyConverter.ConvertDollarToSek(currentAmount);
                            
                            break;
                        case Currency.Euro: newAmount = currencyConverter.ConvertDollarToEuro(currentAmount); break;
                    }
                    break;
                case Currency.Euro:
                    switch (newcurrency)
                    {
                        case Currency.SEK: newAmount = currencyConverter.ConvertEuroToSek(currentAmount); break;
                        case Currency.Dollar: newAmount = currencyConverter.ConvertEuroToDollar(currentAmount); break;
                    }
                    break;
                case Currency.SEK:
                    switch (newcurrency)
                    {
                        case Currency.Dollar: newAmount = currencyConverter.ConvertSekToDollar(currentAmount); break;
                        case Currency.Euro: newAmount = currencyConverter.ConvertSekToEuro(currentAmount); break;
                    }
                    break;
            }
            this.Amount = newAmount;
            this.Currency = newcurrency;

            Console.WriteLine("newAmount: " + newAmount + ", newcurrency: " + newcurrency);
            
           // return new Money(newAmount, newcurrency);

        }
    }
}
