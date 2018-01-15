using System;

namespace OKQ8.ServiceLayer.DTO
{
    public class Document
    {
        public Guid Id;

        public DateTime IssuedDate;

        public string AccountNumber;

        public string AccountName;

        public DocumentType DocumentType;

        public DocumentCategory DocumentCategory;
    }
}