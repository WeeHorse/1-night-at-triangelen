using Npgsql;

namespace One_night_at_Triangelen;

class Program
{
    static void Main(string[] args)
    {
        TestDb();
        var player = new Player();
        new ToiletStall(player);
    }

    static async void TestDb()
    {
        var connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=auctionista";
        await using var dataSource = NpgsqlDataSource.Create(connectionString);
        // await using (var cmd = dataSource.CreateCommand("INSERT INTO auctionista.colors (name) VALUES ($1)"))
        
        /*
        await using (var cmd = dataSource.CreateCommand("UPDATE auctionista.colors set name = $1 where name = '5'"))
        {
            cmd.Parameters.AddWithValue("Brown");
            await cmd.ExecuteNonQueryAsync();
        }
        */
        
        await using (var cmd = dataSource.CreateCommand("DELETE FROM auctionista.colors WHERE id = $1"))
        {
            cmd.Parameters.AddWithValue(3);
            await cmd.ExecuteNonQueryAsync();
        }
        
        await using (var cmd = dataSource.CreateCommand("SELECT name FROM auctionista.colors"))
        await using (var reader = await cmd.ExecuteReaderAsync())
        {
            while (await reader.ReadAsync())
            {
                Console.WriteLine(reader.GetString(0));
            }
        }
        
    }
}