using OKQ8.ServiceLayer.DTO;
using System.Collections.Generic;

namespace OKQ8.ServiceLayer.Services
{
    public interface ICard
    {
        CardSearchResponse GetCards(int skip, int take, CardFilter filter, CardSortOrder orderBy, SortDirection direction);
    }

    public class CardSearchResponse
    {
        public SearchResponse<Card> SearchResponse;

        /// <summary>
        /// Keys are the card types and values are the count of each card type.
        /// </summary>
        public Dictionary<string, int> CardTypeCount;
        
        /// <summary>
        /// Keys are the various card status and values are the count of each cards matching each status. Maybe status should be an enumeration
        /// </summary>
        public Dictionary<string, int> CardStatusCount;
    }
}