namespace One_night_at_Triangelen;

public class SecondFloor:Location
{
    public SecondFloor(Player player):base(player)
    {
        Description =
            "You are on the second floor in what you recognize as Triangelen. There is an escallator and an entrance to the Ladies room.";
        _menu = new Menu(this);
    }
    
    public override void HandleResponse(string response)
    {
        switch (response)
        {
            case("enter escallator"):
                new Escallator(_player);
                break;
            case("enter ladies room"):
                new LadiesRoom(_player);
                break;
            
        }
    }
}