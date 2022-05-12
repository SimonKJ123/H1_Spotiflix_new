

public class Music
{
    public string Title { get; set; } = "";
    public string Artist { get; set; } = "";
    public string Genre { get; set; } = "";
    public string Album { get; set; } = "";
    public string Length { get; set; } = "";
    public string Relasedate { get; set; } = "";
    public string Web { get; set; } = "";

    public void Print()
    {
        var music = this;
        Console.WriteLine();
        Console.WriteLine($"Title: {music.Title}");
        Console.WriteLine($"Lenght: {music.Length}");
        Console.WriteLine($"Gerne: {music.Genre}");
        Console.WriteLine($"Relase Date: {music.Relasedate}");
        Console.WriteLine($"Artist: {music.Artist}");
        Console.WriteLine($"Album: {music.Album}");
        Console.WriteLine($"Website: {music.Web}");
        
    }

    public bool Contains(string query)
    {
        var music = this;
        return music.Title.Contains(query) ||
               music.Genre.Contains(query) ||
               music.Relasedate.Contains(query) ||
               music.Artist.Contains(query) ||
               music.Album.Contains(query) ||
               music.Web.Contains(query);
    }

}
