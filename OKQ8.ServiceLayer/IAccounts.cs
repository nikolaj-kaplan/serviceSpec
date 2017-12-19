namespace OKQ8.ServiceLayer
{
    public interface IAccounts
    {
        /// <summary>
        /// Returns the root of the tree. OrgNumber (SE) ? / SamAccount (DK).
        /// Including all children. No lazy load. Unless it is necessary due to performance
        /// </summary>
        Account GetAccountTree();


    }
}