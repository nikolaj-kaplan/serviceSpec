using System.Collections.Generic;

namespace OKQ8.ServiceLayer
{
    /// <summary>
    /// Specifies what cards to fetch
    /// If a property is not null the service should only return cards that matches the property
    /// </summary>
    public class CardFilter
    {
        public CardType? CardType;

        /// <summary>
        /// Each of the search terms should have a partial, case-insensitive match on atleast one the following fields on the Card object:
        ///  - CardNumber
        ///  - CardType
        ///  - CardHolder
        ///  - Status
        /// </summary>
        public string[] SearchTerms;

        public bool? HasKmData;

        public IEnumerable<string> AccountNumbers;

        public bool? IsActive { get; set; }
    }
}