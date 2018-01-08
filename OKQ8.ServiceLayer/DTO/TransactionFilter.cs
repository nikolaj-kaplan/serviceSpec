using System;

namespace OKQ8.ServiceLayer.DTO
{
    public class TransactionFilter
    {
        public string ProductName;
        public bool? IsFuelPurchase;
        public string[] CardOrAccountNumbers;
        public bool? Invoiced { get; set; }
        public CardType? CardType;
        public string InternalNumber;
        public DateTime From;
        public DateTime To;
    }
}