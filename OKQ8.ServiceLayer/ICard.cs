namespace OKQ8.ServiceLayer
{
    public interface ICard
    {


        // Homescreen
        getNumberOfCardsByStatusResponse1 GetNumberOfCardsByStatus(string token);
        getNumberOfAccountsByTypeResponse1 GetNumberOfAccountsByType(string token);

        //Card app
        getAllCardsResponse1 GetAllCards(string token);
        getNumberOfCardsByTypeResponse1 GetNumberOfCardsByType(string token);


        getTransactionsResponse1 GetCardTransactions(string token, string[] cardNumbers, TimePeriod period, invoiced invoiced);
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