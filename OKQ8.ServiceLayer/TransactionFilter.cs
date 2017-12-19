namespace OKQ8.ServiceLayer
{
    public class TransactionFilter
    {
        public string ProductName;
        public bool? IsFuelPurchase;
        public RequestParameters Request;
        public OrderField OrderBy;
        public CardType? CardType;
        public string InternalNumber;
    }
}