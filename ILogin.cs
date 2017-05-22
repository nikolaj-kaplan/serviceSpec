using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace KMDSpec
{
    /// <summary>
    /// First the user logs in. The response tells the client if the user has access to more that one customer.
    /// Subsequently the user selects a customer. (Most users only has access to one customer. the this customer will be selected automatically)
    /// When a customer is selecte, we get the rights from kmd.
    /// </summary>
    public interface ILogin
    {
        LoginResponse Login(string username, string password, bool rememberMe);

        void SelectCustomer(string token, string customer);

        User GetUser(string token);
    }

    /// <summary>
    /// The user has a set of rights and an account structur for which these rights apply
    /// </summary>
    public class User
    {
        public Rights Rights { get; set; }
        public List<Account> Accounts { get; set; }
    }

    public class Account
    {
        public string AccountNumber { get; set; }
        public List<Account> ChildAccounts { get; set; }
    }

    public class LoginResponse
    {
        public string Token { get; set; }
        public List<string> Customers { get; set; }
        public bool IsSysAdmin { get; set; }
    }

    [Flags]
    public enum Rights : byte
    {
        None = 0,
        Administration = 1,
        Accounting = 2,
        CardAdministration = 4,
        OrderSubmission = 8,
    }

}
