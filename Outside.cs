namespace One_night_at_Triangelen;

public class Outside:Location
{
    public Outside(Player player):base(player)
    {
        Description = "You are outside. There is a bum there and he's wearing your jacket. There is an entrance to Triangelen and an entrance to the train station.";
        _menu = new Menu(this);
    }
    
    public override void HandleResponse(string response)
    {
        switch (response)
        {
            case("enter triangelen"):
                new FirstFloor(_player);
                break;
            case("enter station"):
                new Station(_player);
                break;
            case("steal jacket"):
                Console.WriteLine("You shouldn't have done that. He is much stronger than you, in your poor state. He puts you under for at least 24 hours.");
                break;
            
        }
    }
}