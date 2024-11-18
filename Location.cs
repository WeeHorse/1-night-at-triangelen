namespace One_night_at_Triangelen;

public abstract class Location
{
    protected Player _player;
    public Location(Player player)
    {
        _player = player;
    }
    
    public string Description;

    protected Menu _menu; 

    public abstract void HandleResponse(string response);
}