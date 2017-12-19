using System;
using System.Collections.Generic;
using OKQ8.ServiceLayer.DTO;

namespace OKQ8.ServiceLayer.Services
{
    public interface IGeneral
    {
        /// <summary>
        /// Sends an sms. Used by alarm app and possibly other apps
        /// </summary>
        void SendSms(string from, string to, string text);

        /// <summary>
        /// Audit log is part of the danish solution. Any requirements for this for the swedish solution. KV is uncertain exactly what is logged. KMD can specify or we can see examples.
        /// TODO: should it be possible for sysadmin to see audit-log across companies. Other ways of filtering the log?
        /// </summary>
        SearchResponse<AuditEntry> GetAuditLog(int skip, int take, DateTime from, DateTime to, string accountNumber);
    }

    public class AuditEntry
    {
        public AuditEntryType Type;
        public string Message;
        public string User;
        public DateTime TimeStamp;
    }

    public enum AuditEntryType
    {
        //TODO: Who has requirements for this. Should we copy DK portal?
        LogIn,
        CreateUser,
        ChangeUserRights,
    }
}