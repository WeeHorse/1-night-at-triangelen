namespace One_night_at_Triangelen;

public class Station:Location
{
    public Station(Player player):base(player)
    {
        Console.WriteLine("Yeah! You magically end up on a train to your brothers wedding in Eslöv. Or is it really your wedding...??");
    }
    
    public override void HandleResponse(string response)
    {
    }
}