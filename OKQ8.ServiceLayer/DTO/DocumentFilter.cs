using System;
using System.Collections.Generic;

namespace OKQ8.ServiceLayer.DTO
{
    public class DocumentFilter
    {
        public DocumentType? DocumentType;

        /// <summary>
        /// Each of the search terms should have a partial, case-insensitive match on atleast one the following fields on the Document object:
        ///  - DocumentType
        ///  - CardHolder
        ///  - Status
        /// </summary>
        public string[] SearchTerms;

        public IEnumerable<string> AccountNumbers;

        public DateTime From;

        public DateTime To;
    }
}