using System;
using System.Collections.Generic;

namespace OKQ8.ServiceLayer
{
    public interface IInvoice
    {
        // Invoice App
        getLiterCountResponse1 GetLiterCount(string token, string[] cardNumber, DateTime fromDate, DateTime toDate);



        getTransactionsResponse1 GetCardTransactions(string token, string[] cardNumbers, TimePeriod period, invoiced invoiced);
        getTransactionDetailsResponse1 GetTransactionDetails(string token, string accountNumber, string bonNumber, DateTime transactionDate, string cardNumber);
        getLastInvoiceResponse1 GetLastInvoiceTransactions(string token, string accountNumber);
        orderCardResponse1 OrderCard(string token, string accountId, CardType cardType, string cardName, string email, string messageToQ8, string language, string ipAddress);
        changePINCodeResponse1 ChangePinCode(string token, string cardNumber, string oldPinCode, string newPinCode, string ipAddress);
        closeCardResponse1 CloseCard(string token, string cardNumber, string ipAddress);
        updateInfoLineQ8CardResponse1 UpdateInfoLineQ8Card(string token, string cardNumber, string cardInfoText);

        getDocumentResponse1 GetDocument(string token, string tsqname, string cicsid);
        List<Doc2ArchiveSearchResultRow> GetArchiveFromList(string token, IEnumerable<string> accountNumbers, TimePeriod period, ArchiveType invoice);

        getAuditResponse1 GetAudit(string token, TimePeriod period, string operation, string @object, string user, int maxcount, int samAccount);
        getSamAccountsResponse1 GetSamAccounts(string token);
        getCurrentSamAccountResponse1 GetCurrentSamAccount(string token);
        loadFromAccountSmlResponse1 LoadFromAccount(string token, string saccount);
        sendSMSResponse1 SendSms(string q8UserName, string q8Password, string to, string type, string from, string text);
        getHAccountsResponse1 GetHAccounts(string token, allowAccountTypes type);
        getUAccountsResponse1 GetUAccounts(string token);
        getAccessResponse1 GetAccess(string token);
        getCountOfCardsForSmlAccountResponse1 GetCountOfCardsForSmlAccount(string token);
        getStationDataResponse1 GetStationData(string bKontoNr);

        wsSuccess CreateCustomerServiceTask(string token, q8KCTasks q8KCTasks, string custNo, string email, string text);

    }
}