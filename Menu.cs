namespace One_night_at_Triangelen;

public class Menu
{
    private Location _location;
    public Menu(Location location)
    {
        _location = location;
        PrintOptions();
    }

    public void PrintOptions()
    {
        Console.WriteLine(_location.Description);
        Console.WriteLine("What do you want to do?");
        AskUser();
    }

    private void AskUser()
    {
        var response = Console.ReadLine();
        if (response is not null)
        {
            _location.HandleResponse(response);
        }
    }
    
    
}