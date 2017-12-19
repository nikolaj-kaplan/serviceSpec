using System.Collections.Generic;

namespace OKQ8.ServiceLayer.DTO
{
    public class SearchResponse<T>
    {
        public IEnumerable<T> Items;
        public int TotalCount;
    }
}