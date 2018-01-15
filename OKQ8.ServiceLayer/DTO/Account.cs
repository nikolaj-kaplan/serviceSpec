using System.Collections.Generic;

namespace OKQ8.ServiceLayer.DTO
{
    public class Account
    {
        public AccountType AccountType;
        public IEnumerable<Account> Children;
        public string AccountNumber;
        
        /// <summary>
        /// Maybe we need a lightweight account object and a service for returning account details such as the address
        /// </summary>
        public Address Address;
    }
}