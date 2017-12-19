using System.Collections.Generic;

namespace OKQ8.ServiceLayer
{
    public class Group
    {
        public string Name;

        /// <summary>
        /// We assume that accounts is a tree structure with a single root representing the company. In denmark this root is called SamAccount (Sam = samle)
        /// If a user has the right to a node in the tree he will implicitly have access to all current and future subnodes of the tree.
        /// We suggest that Denmark and Sweden could be represented as two special account numbers. This way it would be possible to create a danish or swedish superadmin.
        /// </summary>
        public IEnumerable<string> Accounts; 
        public IEnumerable<Right> Rights;
    }
}