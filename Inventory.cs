namespace One_night_at_Triangelen;

public class Inventory
{
    public List<string> Items = new();

    public void Print()
    {
        Console.WriteLine("Inventory:");
        foreach(var item  in Items)
        {
            Console.WriteLine(item);
        }
    }
}