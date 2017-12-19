namespace OKQ8.ServiceLayer.DTO
{
    /// <summary>
    /// Maybe not needed if we go with BankId. Used in DK portal to ensure that a new user changes his password at first login
    /// </summary>
    public enum UserStatus
    {
        Invited, 
        Active,
        Deleted //maybe?
    }
}