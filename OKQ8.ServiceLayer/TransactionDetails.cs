using System;
using System.Collections.Generic;

namespace OKQ8.ServiceLayer
{
    public class TransactionDetails
    {
        public DateTime Date { get; set; }
        public Address Address { get; set; }
        public string TotalIncludingVat { get; set; }
        public string Vat { get; set; }
        public IEnumerable<OrderLine> OrderLines{ get; set; }
    }

    public class OrderLine
    {
        public string Product { get; set; }
        public string Details { get; set; }
        public string Price { get; set; }
    }
}