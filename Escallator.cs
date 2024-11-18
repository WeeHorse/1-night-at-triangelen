namespace One_night_at_Triangelen;

public class Escallator:Location
{
    public Escallator(Player player):base(player)
    {
        Description = "You are on the escallator. There is a green button on your right. Below the escallator you can see the first floor of Triangelen. On top of the escallaror is the second floor.";
        _menu = new Menu(this);
    }

    public override void HandleResponse(string response)
    {
        switch (response)
        {
            case("walk down"):
                new FirstFloor(_player);
                break;
            case("walk up"):
                new SecondFloor(_player);
                break;
            case("press button"):
                Console.WriteLine("You shouldn't have done that. The alarm goes off, the police enters and puts you in jail for life, or at least 24 hours.");
                break;
            
        }
    }
    
}