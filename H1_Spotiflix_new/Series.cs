



public class Series
{
    public string Title { get; set; } = "";
    public string TitleEpisode { get; set; } = "";
    public string Genre { get; set; } = "";
    public string Length { get; set; } = "";
    public string Relasedate { get; set; } = "";
    public string Season { get; set; } = "";
    public string Episode { get; set; } = "";
    public string Web { get; set; } = "";
    public void Print()
    {
        var series = this;
        Console.WriteLine();
        Console.WriteLine($"Title: {series.Title}");
        Console.WriteLine($"EpisodeTitle: {series.TitleEpisode}");
        Console.WriteLine($"Episode: {series.Episode}");
        Console.WriteLine($"Length: {series.Length}");
        Console.WriteLine($"Gerne: {series.Genre}");
        Console.WriteLine($"Season: {series.Season}");
        Console.WriteLine($"Relase Date: {series.Relasedate}");
        Console.WriteLine($"Website: {series.Web}");
        
    }
    public bool Contains(string query)
    {
        var series = this;
        return series.Title.Contains(query) ||
               series.Genre.Contains(query) ||
               series.Relasedate.Contains(query) ||
               series.TitleEpisode.Contains(query) ||
               series.Season.Contains(query) ||
               series.Episode.Contains(query) ||
               series.Web.Contains(query);
    }

}


