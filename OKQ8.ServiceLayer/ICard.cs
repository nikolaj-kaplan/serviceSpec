using System;

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
}