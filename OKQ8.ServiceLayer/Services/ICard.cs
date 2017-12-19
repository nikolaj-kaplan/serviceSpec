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
        SearchResponse<Card> GetCards(int skip, int take, CardFilter filter, CardSortOrder orderBy, SortDirection direction);

        void OrderCard(string accountNumber, CardType cardType, string cardName, string email, string messageToQ8);

        void ChangePinCode(string cardNumber, string oldPinCode, string newPinCode);

        void CloseCard(string cardNumber);

        void UpdateInfoLine(string cardNumber, string cardInfoText);

        IEnumerable<StationDetails> GetDetailsForStations(IEnumerable<Guid> stationIds);

        /// <summary>
        /// https://gg7ptb.axshare.com/6_0_k_bekort__korttransaktioner_.html
        /// </summary>
        /// <returns></returns>
        TransactionUpdatedInfo GetUpdateDate();

        /// TODO: 
        /// Kredit limit
        /// Indkøbskontrol
        /// Mäterinställningsinslag
        /// Status
        /// mm.
        /// https://gg7ptb.axshare.com/6_1_kortadministration.html
        /// https://gg7ptb.axshare.com/6_3_kreditlimit.html
        /// 
    }

    public class TransactionUpdatedInfo
    {
        public DateTime LastUpdated;
        public DateTime NextUpdate;
    }
}