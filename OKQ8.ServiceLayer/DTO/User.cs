using System;
using System.Collections.Generic;

namespace OKQ8.ServiceLayer.DTO
{
    public class User
    {
        public Guid Id;

        /// <summary>
        /// The list of groups that the user is a member of
        /// </summary>
        public IEnumerable<Guid> Groups;

        public UserStatus Status;
    }
}
