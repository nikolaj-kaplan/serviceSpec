using System.Collections.Generic;

namespace OKQ8.ServiceLayer
{
    /// General assumptions
    /// 
    /// If nothing else is specified, all services are called in context of a user and a company. After a user logs in, he selects the company he wants to work
    /// in context of. (if the user only has the right to one company, this selection is done automatically. See dk portal)
    /// We need some clarifications in order to specify these services. 
    public interface IAuthorize
    {

        /// <summary>
        /// Anonymous call allowed. User is created in the portal and given full rights to the company specified by the orgNumber
        /// This is the way a user can sign up to the danish portal. It has been discussed if the security is sufficient. If Mobil Bank ID will be required in sweden,
        /// it might give the extra level of security needed. Or maybe we need to rethink the enrolement entirely
        /// </summary>
        void Enrole(string account, string orgNumber, string email, string userIp, string language);

        /// <summary>
        /// Anonymous call allowed
        /// Used when user logs in with username and password
        /// the parameter sysadminEnabled is used to ensure that sysadmins only have their sysadmin right when on vpn or on company network.
        /// The wireframes and the DK portal contains the "Remember me" feature. We need to clarify if this is still wanted.
        /// </summary>
        void Authorize(string userlogin, string password, string ipAddress, bool sysAdminEnabled, bool rememberMe);

        /// <summary>
        /// Anonymous call allowed. Used to reset password. Also used in DK portal when a user is invited. It makes it possible to log in with a link and then choose a
        /// password. If we base the solution on BankId we will not use this method
        /// </summary>
        void AuthorizeWithToken(string token, string ipAddress, bool sysAdminEnabled);

        /// <summary>
        /// Service returns a special token. KV Backend uses token to generate a URL that is emailed to the user. This URL gives access to the portal.
        /// This functionality is not needed if we replace username,password with BankId.
        /// </summary>
        /// <param name="userName"></param>
        string ResetPassword(string userName);

        void ChangePassword(string oldPassword, string newPassword);

        /// <summary>
        /// Returns a list of companies the current user has rights to.
        /// This list is used to make it possible for the user to choose what company he wants to access the portal in context of.
        /// Most users will only have access to a single company. They will not be presented with a company dropdown.
        /// The "current company" will be selected by the user in will be stored in a cookie and send on all subsequent requests
        /// The user can change "current company" any time
        /// </summary>
        IEnumerable<Company> GetCompanies();

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