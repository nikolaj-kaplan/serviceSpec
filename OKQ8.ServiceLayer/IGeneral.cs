namespace OKQ8.ServiceLayer
{
    public interface IGeneral
    {
        void SendSms(string from, string to, string text);
        getAuditResponse1 GetAudit(string token, TimePeriod period, string operation, string @object, string user, int maxcount, int samAccount);

    }
}