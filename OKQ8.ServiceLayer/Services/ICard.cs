using OKQ8.ServiceLayer.DTO;
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
        CardSearchResponse GetCards(int skip, int take, CardFilter filter, CardSortOrder orderBy, SortDirection direction);

        //https://gg7ptb.axshare.com/6_1_2_nyt_kort.html
        void OrderCard(
            string accountNumber, 
            CardType cardType, 
            string textField2, // https://i.imgur.com/XxucaFe.png 
            string invoiceReference, //https://i.imgur.com/0HbQ9C6.png
            string invoiceAddress, //https://i.imgur.com/Ut5eEKD.png
            bool mandatoryMilageRegistration, 
            string messageToCustomerService, 
            PurchaseControlLevel purchaseControlLevel);


        void UpdateCard(
            string cardNumber,
            string invoiceReference, //https://i.imgur.com/0HbQ9C6.png
            string invoiceAddress, //https://i.imgur.com/Ut5eEKD.png
            bool mandatoryMilageRegistration,
            PurchaseControlLevel purchaseControlLevel);

        void ChangePinCode(string cardNumber, string oldPinCode, string newPinCode);

        void CloseCard(string cardNumber);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <param name="immediately">either after 14 days or immediately</param>
        void OrderReplacementCard(string cardNumber, bool immediately /*https://i.imgur.com/9oMDarG.png*/);

        IEnumerable<StationDetails> GetDetailsForStations(IEnumerable<Guid> stationIds);

        /// <summary>
        /// https://gg7ptb.axshare.com/6_0_k_bekort__korttransaktioner_.html
        /// </summary>
        /// <returns></returns>
        TransactionUpdatedInfo GetUpdateDate();

        /// TODO: 
        /// Kredit limit
    }


    public class CardSearchResponse
    {
        public SearchResponse<Card> SearchResponse;

        /// <summary>
        /// Keys are the card types and values are the count of each card type.
        /// </summary>
        public Dictionary<string, int> CardTypeCount;
    }


    public class TransactionUpdatedInfo
    {
        public DateTime LastUpdated;
        public DateTime NextUpdate;
    }
}