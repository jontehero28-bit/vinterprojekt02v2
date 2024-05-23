using System.Runtime.CompilerServices;

public class Market
{
    Utility utility = new();
    public List<MarketItem> MarketItems = new() { };   //Lista för items på Market.

    public void ListItemsInMarket(Market market)
    {
        Console.WriteLine("Välkommen till Market");
        Console.WriteLine("Du kan försöka sno dessa föremål");

        foreach (MarketItem i in market.MarketItems)
        {

        }
    }

}