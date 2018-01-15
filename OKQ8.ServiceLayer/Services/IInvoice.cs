using OKQ8.ServiceLayer.DTO;
using System;
using System.Collections.Generic;

namespace OKQ8.ServiceLayer
{
    public interface IInvoice
    {
        /// <summary>
        /// Returns a list of documents for populating a table
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        SearchResponse<Document> GetDocuments(int skip, int take, DocumentFilter filter, DocumentSortOrder orderBy, SortDirection direction);

        /// <summary>
        /// The service returns the pdf as a byte stream. The id comes from the document objects returned by the GetDocuments() service
        /// </summary>
        byte[] GetDocument(Guid documentId);

        void ReportError(Guid documentId, DocumentErrorType errorType, string errorDescription);
    }
}