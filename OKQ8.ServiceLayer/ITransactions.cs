using System;
using System.Collections.Generic;

namespace OKQ8.ServiceLayer
{
    public interface ITransactions
    {
        /// <summary>
        /// Summary of the liter volume of all transactions matching the filter. The list of LiterCount object makes it possible for KV backend
        /// to group by fuel type and/or card number
        /// </summary>
        IEnumerable<LiterCount> GetLiterCount(TransactionFilter filter);

        SearchResponse<Transaction> GetCardTransactions(TransactionFilter filter, TransactionSortOrder orderBy, SortDirection sortDirection);

        TransactionDetails GetTransactionDetails(Guid transactionId);
    }
}