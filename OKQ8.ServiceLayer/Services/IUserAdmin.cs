using System;
using System.Collections.Generic;

namespace OKQ8.ServiceLayer
{
    /// <summary>
    /// A user should have the right Right.UserAdmin in order to call any of these methods.
    /// A user cannot change his own rights (neither by changing the rights of his own group or by moving him self to a new group)
    /// A user cannot assign rights to others that he does not have himself
    /// A user can change the name of his own group and add new persons to his own group
    /// </summary>
    public interface IUserAdmin
    { 
        /// <summary>
        /// Returns all users in
        /// No paging necessary
        /// </summary>
        IEnumerable<User> GetUsers();

        // Useradmin
        /// <summary>
        /// Returns all groups
        /// No paging necessary
        /// </summary>
        IEnumerable<Group> GetGroups();

        Guid CreateGroup(string name, IEnumerable<string> accounts, IEnumerable<Right> rights);
        void RenameGroup(Guid grouId, string newName);
        void UpdateGroupRights(Guid groupId, IEnumerable<string> accounts, IEnumerable<Right> rights);
        void DeleteGroup(string name, IEnumerable<string> accounts, IEnumerable<Right> rights);

        /// <summary>
        /// In dk portal a user can only be a member of one group below each company. This means that when a user is added to a group, they are 
        /// automatically removed the group they were previously in.
        /// </summary>
        /// <param name="userIds"></param>
        /// <param name="groupId"></param>
        void AddUsersToGroup(IEnumerable<Guid> userIds, Guid groupId);

        /// <summary>
        /// A user will be removed from the rights group of the company in context
        /// It will probably make sense to keep the user in the db. The user might have relations that we do not want to break, and the user might still have 
        /// rights in context of other companies
        /// </summary>
        void DeleteUser();

        /// <summary>
        /// This service will be called when a user invites a colleague.
        /// When inviting a colleague a rights group must be chosen.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="groupId"></param>
        void InviteUser(string email, string name, Guid groupId);
    }
}