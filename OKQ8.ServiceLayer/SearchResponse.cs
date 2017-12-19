using System.Collections.Generic;

namespace OKQ8.ServiceLayer
{
    public class SearchResponse<T>
    {
        public IEnumerable<T> Items;
        public int TotalCount;
    }
}