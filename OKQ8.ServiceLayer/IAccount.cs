namespace OKQ8.ServiceLayer
{
    public interface IAccount
    {
        getHAccountsResponse1 GetHAccounts(string token, allowAccountTypes type);
        getUAccountsResponse1 GetUAccounts(string token);
    }
}