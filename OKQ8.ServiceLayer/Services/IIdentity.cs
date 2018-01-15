using System.Collections.Generic;
using OKQ8.ServiceLayer.DTO;

namespace OKQ8.ServiceLayer.Services
{
    /// If nothing else is specified, all services are called in context of a user and a company. After a user logs in, he selects the company he wants to work
    /// in context of. (if the user only has the right to one company, this selection is done automatically. See dk portal)
    /// We need some clarifications in order to specify these services. 
    public interface IIdentity
    {

        /// <summary>
        /// Called by the client when a user wants to log in. The service returns the authentication url to the idp
        /// </summary>
        /// <returns></returns>
        string GetAuthenticateUrl();

        /// <summary>
        /// This service is used to get a session token after logging in at idp.
        /// The token comes from the idp and is used by okq8 backend to get the id of the user from the idp (Resolve authentication)
        /// The service returns a new token that should be used in all subsequent service calls as long as the session is alive
        /// </summary>
        string Authenticate(string token);

        /// <summary>
        /// User is created in the portal and given full rights to the company specified by the orgNumber
        /// This is the way a user can sign up to the danish portal. It has been discussed if the security is sufficient. If Mobil Bank ID will be required in sweden,
        /// it might give the extra level of security needed. Or maybe we need to rethink the enrolement entirely
        /// This service is called after the user has logged in with bank-id
        /// </summary>
        void Enrole(string account, string orgNumber, string email, string userIp, string language);

        /// <summary>
        /// Returns a list of companies the current user has rights to.
        /// This list is used to make it possible for the user to choose what company he wants to access the portal in context of.
        /// Most users will only have access to a single company. They will not be presented with a company dropdown.
        /// The "current company" will be selected by the user in will be stored in a cookie and send on all subsequent requests
        /// The user can change "current company" any time
        /// </summary>
        IEnumerable<Company> GetCompanies();

        /// <summary>
        /// Returns all companies that matches the search text. A partial match on organization number, company name, phone number, etc...
        /// Used by sysadmin 
        /// </summary>
        /// <param name="searchText"></param>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <returns></returns>
        SearchResponse<Company> GetCompanies(string searchText, int skip, int take);

        /// <summary>
        /// Returns true if the current user has sysadmin rights
        /// Can be called without having a context company
        /// If the user is sysAdmin, they will be able to choose to access the portal in context of any company. 
        /// In the UI they will get a textbox where they can search for companies instead of a dropdown
        /// </summary>
        /// <returns></returns>
        bool IsSysAdmin();
    }
}