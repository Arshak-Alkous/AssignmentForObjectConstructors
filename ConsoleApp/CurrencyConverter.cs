using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArshakAssignment
{
    public class CurrencyConverter
    {
        public decimal Dollar { get; private set; }
        public decimal Euro { get; private set; }
        public decimal SEK { get; private set; }
        public CurrencyConverter(decimal dollar,decimal euro,decimal sek) 
        {
            this.Dollar = dollar;
            this.Euro = euro;
            this.SEK = sek;
        }

        private decimal ConvertAmount(decimal amount,decimal from,decimal to)
        {
            return(amount* to)/ from;
        }
        public decimal Convert(Money currentMoney, Currency newcurrency)
        {
            Currency currentCurrency = currentMoney.Currency;
            decimal currentAmount = currentMoney.Amount;
            decimal newAmount = currentMoney.Amount;
            switch (currentCurrency)
            {
                case Currency.Dollar:
                    switch (newcurrency)
                    {
                        case Currency.Euro:newAmount=ConvertAmount(currentAmount,this.Dollar,this.Euro); break;
                        case Currency.SEK: newAmount=ConvertAmount(currentAmount,this.Dollar,this.SEK); break;
                      //default: Console.WriteLine("choose a suitable currency to convert current currency");break;
                    }break;
                case Currency.Euro:
                    switch (newcurrency)
                    {
                        case Currency.Dollar: newAmount = ConvertAmount(currentAmount, this.Euro,this.Dollar); break;
                        case Currency.SEK: newAmount = ConvertAmount(currentAmount, this.Euro, this.SEK); break;
                      //default: Console.WriteLine("choose a suitable currency to convert current currency"); break;
                    }
                    break;
                case Currency.SEK:
                    switch (newcurrency)
                    {
                        case Currency.Dollar: newAmount = ConvertAmount(currentAmount, this.SEK, this.Dollar); break;
                        case Currency.Euro: newAmount = ConvertAmount(currentAmount, this.SEK, this.Euro); break;
                     // default: Console.WriteLine("choose a suitable currency to convert current currency"); break;
                    }
                    break;
            }
            return newAmount;
        }

    }
}
