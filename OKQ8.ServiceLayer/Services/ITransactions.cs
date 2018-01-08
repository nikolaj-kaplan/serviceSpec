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

        /// <summary>
        /// Gets a summary of the data from the transactions specified by the filter.
        /// Summary is based on the intervals send to the service and is grouped by product
        /// </summary>
        /// <param name="filter">A filter specifying the transactions that should be considered</param>
        /// <param name="intervals">The intervals that the summary should be split up into</param>
        /// <returns></returns>
        TransactionSummary GetSummaries(TransactionFilter filter, IEnumerable<Interval> intervals);

        TransactionDetails GetTransactionDetails(Guid transactionId);

        // TODO: Service to support summaries in intervals. For graphs and summaries
        // https://gg7ptb.axshare.com/6_0_k_bekort__korttransaktioner_.html
    }

    public class Interval
    {
        public DateTime From;
        public DateTime To;
    }

    /// <summary>
    /// The object that is returned from the GetSummaries service
    /// </summary>
    public class TransactionSummary
    {
        /// <summary>
        /// A summary for each of the intervals
        /// </summary>
        public IEnumerable<IntervalSummary> IntervalSummaries;

        /// <summary>
        /// A list of the warnings that occur in the summarized data
        /// </summary>
        public IEnumerable<string> MilageWarnings;
    }

    /// <summary>
    /// An IntervalSummary consists of the interval that was used to calculate the summary and the list of transaction summary. A list element pr each product.
    /// </summary>
    public class IntervalSummary
    {
        public Interval Interval;
        public IEnumerable<TransactionSummaryElement> TransactionSummaries;
    }


    public class TransactionSummaryElement
    {
        public string ProductName;

        /// <summary>
        /// Will be null if this is not a liter product
        /// </summary>
        public double? Liter;

        /// <summary>
        /// The value in DKK
        /// </summary>
        public decimal Value;
    }
}