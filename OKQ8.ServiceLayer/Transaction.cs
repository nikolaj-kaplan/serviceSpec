using System;

namespace OKQ8.ServiceLayer
{
    public class Transaction
    {
        // copied from dk. Let's clean this up together. TODO

        public DateTime TransactionDate { get; set; }
        public TransactionSource TransactionSource { get; set; }
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string CardHolderCompanyName { get; set; }
        public string Location { get; set; }
        public string ZipCode { get; set; }
        public string Product { get; set; }
        public string Address { get; set; }
        public string Moms { get; set; }
        public double Volume { get; set; }
        public double? UnitPrice { get; set; }
        public string Discount { get; set; }
        public string DiscountNoUnit { get; set; }
        public double TotalPrice { get; set; }
        public int? Distance { get; set; }
        public string InternalNumber { get; set; }
        public long ReceiptNumber { get; set; }
        public bool IsLiterProduct { get; set; }
        public bool? IsInvoiced { get; set; }
        public double? DiscountInPercent { get; set; }
        public int CardIndex { get; set; }
        public Guid Guid { get; set; }
        public int KmCounter { get; set; }
        public int KmCounterPrev { get; set; }
        public string Remarks { get; set; }
        public string RemarksLegend { get; set; }
        public string BKontonr { get; set; }
        public CardType CardType { get; set; }
        public double? DiscountOrePrLiter { get; set; }
        public double TotalDiscountInKr { get; set; }
        public bool HasDetails { get; set; }

    }
}