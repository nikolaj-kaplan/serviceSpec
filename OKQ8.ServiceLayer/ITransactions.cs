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

        // TODO: Service to support summaries in intervals. For graphs and summaries
        // https://gg7ptb.axshare.com/6_0_k_bekort__korttransaktioner_.html
    }
}