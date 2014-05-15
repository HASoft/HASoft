using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record.Core.Model
{
    public class Transaction
    {
        #region Constructor
        public Transaction()
        { 
            DateTime = DateTime.MinValue;
            Address = "";
            Currency = Currency.CAD;
            CardType = CardType.Debit;
            CardNumber = "0000";
            Discription = "";
            Category = Category.BabyAmy;
            DebitValue = 0;
            CreditValue = 0;
            Comment = "";
        }
        #endregion

        #region Properties
        public DateTime     DateTime{get;set;}

        public string       Address{get;set;}

        public Currency     Currency { get; set; }

        public CardType     CardType { get; set; }

        public string       CardNumber { get; set; }

        public string       Discription { get; set; }

        public Category     Category { get; set; }

        public Decimal      DebitValue { get; set; }

        public Decimal      CreditValue { get; set; }

        public string       Comment { get; set; }

        #endregion

    }
}
