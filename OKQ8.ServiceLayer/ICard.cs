namespace OKQ8.ServiceLayer
{
    public interface ICard
    {


        // Homescreen
        getNumberOfCardsByStatusResponse1 GetNumberOfCardsByStatus(string token);
        getNumberOfAccountsByTypeResponse1 GetNumberOfAccountsByType(string token);

        //Card app
        getAllCardsResponse1 GetAllCards(string token);
        getNumberOfCardsByTypeResponse1 GetNumberOfCardsByType(string token);


    }
}