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
        public decimal ConvertDollarToSek(decimal amount)
        {
            return (amount*this.SEK)/this.Dollar;
        }
        public decimal ConvertEuroToSek(decimal amount)
        {
            return (amount * this.SEK) / this.Euro;
        }
        public decimal ConvertSekToDollar(decimal amount)
        {
            return (amount * this.Dollar) / this.SEK;
        }
        public decimal ConvertSekToEuro(decimal amount)
        {
            return (amount * this.Euro) / this.SEK;
        }
        public decimal ConvertDollarToEuro(decimal amount) 
        {
            return(amount*this.Euro)/this.Dollar;
        }
        public decimal ConvertEuroToDollar(decimal amount)
        {
            return (amount * this.Dollar) / this.Euro;
        }

    }
}
