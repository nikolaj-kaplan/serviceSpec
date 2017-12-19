using System;
using System.Collections.Generic;

namespace OKQ8.ServiceLayer
{
    public interface IInvoice
    {
        // Invoice App

        getDocumentResponse1 GetDocument(string token, string tsqname, string cicsid);
        List<Doc2ArchiveSearchResultRow> GetArchiveFromList(string token, IEnumerable<string> accountNumbers, TimePeriod period, ArchiveType invoice);
        getLastInvoiceResponse1 GetLastInvoiceTransactions(string token, string accountNumber);

        /// TODO Lasse:
        /// we need a list of invoices with an id for each invoice.
        /// This id can be used in two services that can 
        /// either get all transactions included in the invoice 
        /// or get the invoice as a pdf (byte stream)

        SearchResponse<Document> GetDocuments(int skip, int take, DocumentFilter filter, DocumentSortOrder orderBy, SortDirection direction);

        // Either send document as object or documentId
        void ReportError(Document document, DocumentErrorType errorType, string errorDescription);
    }

}