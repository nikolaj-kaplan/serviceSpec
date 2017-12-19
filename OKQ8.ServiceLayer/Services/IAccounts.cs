using OKQ8.ServiceLayer.DTO;

namespace OKQ8.ServiceLayer.Services
{
    public interface IAccounts
    {
        /// <summary>
        /// Returns the root of the tree. OrgNumber (SE) ? / SamAccount (DK).
        /// Including all children. No lazy load. Unless it is necessary due to performance
        /// In DK portal we currently use three levels. SamAccount (the root), Main accounts (Bpa or Retail), Sub accounts
        /// </summary>
        Account GetAccountTree();
    }
}