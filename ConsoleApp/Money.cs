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
        public Money ChangingCurrency(CurrencyConverter currencyConverter,Currency newcurrency) 
        {

            Currency currentCurrency = this.Currency;
            decimal currentAmount=this.Amount;
            Money currentMoney = new Money(currentAmount, currentCurrency);
            decimal newAmount=0.0m;
            if (currentCurrency != newcurrency) {
                newAmount = currencyConverter.Convert(currentMoney, newcurrency);
                Console.WriteLine("changing currency successful");
                return new Money(newAmount, newcurrency);
            }
            else
            {
                Console.WriteLine("choose a suitable currency to convert current currency");
                return currentMoney;
            }
            

        }
    }
}
