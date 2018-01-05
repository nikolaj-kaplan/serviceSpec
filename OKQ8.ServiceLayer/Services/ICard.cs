using OKQ8.ServiceLayer.DTO;

namespace OKQ8.ServiceLayer.Services
{
    public interface ICard
    {
        SearchResponse<Card> GetCards(int skip, int take, CardFilter filter, CardSortOrder orderBy, SortDirection direction);
    }
}