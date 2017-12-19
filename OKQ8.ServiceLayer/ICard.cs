using System.Linq;
using System.Net.Sockets;

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

        getCountOfCardsForSmlAccountResponse1 GetCountOfCardsForSmlAccount(string token);
        getStationDataResponse1 GetStationData(string bKontoNr);


    }
}