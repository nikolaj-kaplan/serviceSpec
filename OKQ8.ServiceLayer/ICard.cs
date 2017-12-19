using System;
using System.Collections.Generic;

namespace OKQ8.ServiceLayer
{
    public interface ICard
    {

        /// <summary>
        /// Returns the cards that matches the filter.
        /// Performance is critical
        /// </summary>
        SearchResponse<Card> GetCards(int skip, int take, CardFilter filter, CardSortOrder orderBy, SortDirection direction);

        getNumberOfCardsByStatusResponse1 GetNumberOfCardsByStatus(string token);
        getNumberOfAccountsByTypeResponse1 GetNumberOfAccountsByType(string token);


        SearchResponse<Transaction> GetCardTransactions(string[] cardNumbers, TimePeriod period, invoiced invoiced);
        getTransactionDetailsResponse1 GetTransactionDetails(string token, string accountNumber, string bonNumber, DateTime transactionDate, string cardNumber);
        orderCardResponse1 OrderCard(string token, string accountId, CardType cardType, string cardName, string email, string messageToQ8, string language, string ipAddress);
        changePINCodeResponse1 ChangePinCode(string token, string cardNumber, string oldPinCode, string newPinCode, string ipAddress);
        closeCardResponse1 CloseCard(string token, string cardNumber, string ipAddress);
        updateInfoLineQ8CardResponse1 UpdateInfoLineQ8Card(string token, string cardNumber, string cardInfoText);

        getLiterCountResponse1 GetLiterCount(string token, string[] cardNumber, DateTime fromDate, DateTime toDate);
        getCountOfCardsForSmlAccountResponse1 GetCountOfCardsForSmlAccount(string token);
        getStationDataResponse1 GetStationData(string bKontoNr);


    }

    public enum SortDirection
    {
        Ascending,
        Descending
    }

    /// <summary>
    /// Specifies what cards to fetch
    /// If a property is not null the service should only return cards that matches the property
    /// </summary>
    public class CardFilter
    {
        public CardType? CardType;

        /// <summary>
        /// Each of the search terms should have a partial, case-insensitive match on atleast one the following fields on the Card object:
        ///  - CardNumber
        ///  - CardType
        ///  - CardHolder
        ///  - Status
        /// </summary>
        public string[] SearchTerms;

        public bool? HasKmData;

        public IEnumerable<string> AccountNumbers;

        public bool? IsActive { get; set; }
    }

    public class TransactionFilter
    {
        public string ProductName;
        public bool? IsFuelPurchase;
        public RequestParameters Request;
        public OrderField OrderBy;
        public CardType? CardType;
        public string InternalNumber;
    }

    /// <summary>
    /// Specifies the sort order of cards
    /// </summary>
    public enum CardSortOrder
    {
        CreatedDate,
        CardNumber,
        Status,
        CardType,
        CardHolder,
    }

    public enum CardType
    {
        /* TODO: Danish types
        CARDTYPE_ALL,
        CARDTYPE_PRIVATE,
        CARDTYPE_CORBORATE,
        CARDTYPE_DIESEL,
        CARDTYPE_CORBORATEPLUS,
        CARDTYPE_TRANSPORT,
        LIC_CARD,
        CARDTYPE_F24_PRIVATE,
        CARDTYPE_F24_PLUS,
        IDS_CARD,
        IDS_KEY_CARD,
        IDS_CARD_LOGO,
        IDS_DALLAS_CARD,
        IDS_COMBI_CARD,
        IDS_COMBI_KEY_CARD,
        IDS_COMBI_KEY_CARD_LOGO,
        IDS_COMBI_DALLAS_CARD,
        IDS_HOMETANKCARD,
        IDS_HOMETANK_KEYCARD,
        IDS_HOMETANKCARDLOGO,
        IDS_HOMETANKDALLQSKEYCARD,
        IDS_SERVICECARD,
        IDS_SERVICEKEYCARD,
        IDS_SERVICEDALLASCARD,
        IDS_WANCARD,
        IDS_WANKEYCARD,
        IDS_WANKEYEXTRA,
        UNKNOWN,
        */
    }

    public class Card
    {
        /*TODO danish properties:

        private string stAdr2Field;
        private string stExternNrField;
        private string stForretTypeField;
        private string stGadeField;
        private string stHkontonrField;
        private string stKmstatField;
        private string stKortstatusField;
        private string stNavn1Field;
        private string stNavn2Field;
        private System.DateTime stOpretDatoField;
        private bool stOpretDatoFieldSpecified;
        private string stPostnrField;
        private string stPrLinie2Field;
        private string stPrLinie3Field;
        private string stPrLinie4Field;
        private string stSegTypeField;
        private System.DateTime stSpaerDatoField;
        private bool stSpaerDatoFieldSpecified;
        private string stSprogField;
        private System.DateTime stUdlDatoField;
        private bool stUdlDatoFieldSpecified;
        private string stUkontonrField;
        private string stKortnrField;
        private CardType stKorttypeField;
        private bool stKorttypeFieldSpecified;
*/
    }

    public class SearchResponse<T>
    {
        public IEnumerable<T> Items;
        public int TotalCount;
    }

    public class Transaction
    {
        
    }
}