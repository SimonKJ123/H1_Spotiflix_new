


public class Movie
{
    public string Title { get; set; } = "";
    public string Length { get; set; } = "";
    public string Genre { get; set; } = "";
    public string Relasedate { get; set; } = "";
    public string Web { get; set; } = "";
    public void Print()
    {
        var movie = this;
        Console.WriteLine();
        Console.WriteLine($"Title: {movie.Title}");
        Console.WriteLine($"Length: {movie.Length}");
        Console.WriteLine($"Gerne: {movie.Genre}");
        Console.WriteLine($"Relasedate: {movie.Relasedate}");
        Console.WriteLine($"Website: {movie.Web}");
    }

    public bool Contains(string query)
    {
        var movie = this;
        return movie.Title.Contains(query) ||
               movie.Genre.Contains(query) ||
               movie.Relasedate.Contains(query) ||
               movie.Web.Contains(query);
    }
}





