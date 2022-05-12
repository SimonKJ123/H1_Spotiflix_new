#nullable disable
using System.Text.Json;

string path = "Database.json";

Database? database = null;

void Save(Database database)
{
    string json = JsonSerializer.Serialize(database);
    File.WriteAllText(path, json);
}

if (File.Exists(path))
{
    string josn = File.ReadAllText(path);
    database = JsonSerializer.Deserialize<Database>(josn);
}
else
{
    database = new Database();

}

if (database == null)
{
    return;
}

while (true)
{

    Console.Clear();
    Console.WriteLine("Press 1 to registre a Movie");
    Console.WriteLine("Press 2 to look at Movie Database");
    Console.WriteLine("Press 3 to search for Keyword");
    Console.WriteLine(" ");
    Console.WriteLine("Press 4 to registre a Series");
    Console.WriteLine("Press 5 to look at Series Database");
    Console.WriteLine("Press 6 to Search for Keyword");
    Console.WriteLine(" ");
    Console.WriteLine("Press 7 to registre a Song");
    Console.WriteLine("Press 8 to look at Music Database");
    Console.WriteLine("Press 9 to Search for Keyword");
    Console.WriteLine(" ");
    Console.WriteLine("Press 0 to exit program");
    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            {
                Console.Clear();
                Console.WriteLine("Info about Movie");
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Length: ");
                string Length = Console.ReadLine();
                Console.Write("Gerne: ");
                string Gerne = Console.ReadLine();
                Console.Write("Release Date:");
                string ReleaseD = Console.ReadLine();
                Console.Write("Website:");
                string Web = Console.ReadLine();

                database.Movies.Add(new Movie
                {
                    Title = title,
                    Length = Length,
                    Genre = Gerne,
                    Relasedate = ReleaseD,
                    Web = Web,
                });
                Save(database);
                Console.WriteLine("Movie added to DataBase");
                Console.ReadKey();
                break;
            }
        case "2":
            {
                Console.Clear();
                Console.WriteLine("List of Movies in DataBase");

                foreach (var movie in database.Movies)
                {
                    Console.WriteLine(movie.Title);
                    Console.WriteLine(movie.Length);
                    Console.WriteLine(movie.Genre);
                    Console.WriteLine(movie.Relasedate);
                    Console.WriteLine(movie.Web);
                }

                Console.WriteLine("Press any key to return");
                Console.ReadKey();
                break;
            }
        case "3":
            {
                Console.Clear();
                Console.Write("Query: ");
                string query = Console.ReadLine();
                foreach (var movie in database.Movies)
                {
                    if (movie.Title.Contains(query) || movie.Genre.Contains(query) || movie.Relasedate.Contains(query))
                    {
                        Console.WriteLine(movie.Title);
                        Console.WriteLine(movie.Length);
                        Console.WriteLine(movie.Genre);
                        Console.WriteLine(movie.Relasedate);
                        Console.WriteLine(movie.Web);
                    }
                }
                Console.WriteLine("Press any key to return");
                Console.ReadKey();
                break;
            }
        case "4":
            {
                Console.Clear();
                Console.WriteLine("Info about Series");
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Length: ");
                string Length = Console.ReadLine();
                Console.Write("Gerne: ");
                string Gerne = Console.ReadLine();
                Console.Write("Release Date: ");
                string ReleaseD = Console.ReadLine();
                Console.Write("Episode: ");
                string ep = Console.ReadLine();
                Console.Write("Seasons: ");
                string seasons = Console.ReadLine();
                Console.Write("Episode title: ");
                string ept = Console.ReadLine();
                Console.Write("Website: ");
                string Web = Console.ReadLine();

                database.Seriess.Add(new Series
                {
                    Title = title,
                    Episode = ep,
                    TitleEpisode = ept,
                    Length = Length,
                    Season = seasons,
                    Genre = Gerne,
                    Relasedate = ReleaseD,
                    Web = Web,
                });
                Save(database);

                Console.WriteLine("Series added to DataBase");
                Console.ReadKey();
                break;
            }
        case "5":
            {
                Console.Clear();
                Console.WriteLine("List of Series in DataBase");

                foreach (var series in database.Seriess)
                {
                    Console.WriteLine(series.Title);
                    Console.WriteLine(series.TitleEpisode);
                    Console.WriteLine(series.Episode);
                    Console.WriteLine(series.Length);
                    Console.WriteLine(series.Genre);
                    Console.WriteLine(series.Season);
                    Console.WriteLine(series.Relasedate);
                    Console.WriteLine(series.Web);
                }

                Console.WriteLine("Press any key to return");
                Console.ReadKey();
                break;
            }
        case "6":
            {
                Console.Clear();
                Console.Write("Query: ");
                string query = Console.ReadLine();
                foreach (var series in database.Seriess)
                {
                    if (series.Title.Contains(query) || 
                        series.Genre.Contains(query) ||
                        series.Relasedate.Contains(query) ||
                        series.TitleEpisode.Contains(query) ||
                        series.Season.Contains(query) ||
                        series.Episode.Contains(query))
                    {
                        Console.WriteLine(series.Title);
                        Console.WriteLine(series.TitleEpisode);
                        Console.WriteLine(series.Episode);
                        Console.WriteLine(series.Length);
                        Console.WriteLine(series.Genre);
                        Console.WriteLine(series.Season);
                        Console.WriteLine(series.Relasedate);
                        Console.WriteLine(series.Web);
                    }
                }
                Console.WriteLine("Press any key to return");
                Console.ReadKey();
                break;
            }
        case "7":
            {
                Console.Clear();
                Console.WriteLine("Info about Song");
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Length: ");
                string Length = Console.ReadLine();
                Console.Write("Gerne: ");
                string Gerne = Console.ReadLine();
                Console.Write("Release Date: ");
                string ReleaseD = Console.ReadLine();
                Console.Write("Arist: ");
                string Artist = Console.ReadLine();
                Console.Write("Album: ");
                string Album = Console.ReadLine();
                Console.Write("Website: ");
                string Web = Console.ReadLine();

                database.Musics.Add(new Music
                {
                    Title = title,
                    Length = Length,
                    Genre = Gerne,
                    Relasedate = ReleaseD,
                    Artist = Artist,
                    Album = Album,
                    Web = Web,
                }); 
                Save(database);
                Console.WriteLine("Song added to DataBase");
                Console.ReadKey();
                break;
            }
        case "8":
            {
                Console.Clear();
                Console.WriteLine("List of Music in DataBase");

                foreach (var music in database.Musics)
                {
                    Console.WriteLine(music.Title);
                    Console.WriteLine(music.Length);
                    Console.WriteLine(music.Genre);
                    Console.WriteLine(music.Relasedate);
                    Console.WriteLine(music.Artist);
                    Console.WriteLine(music.Album);
                    Console.WriteLine(music.Web);
                }

                Console.WriteLine("Press any key to return");
                Console.ReadKey();
                break;
            }
        case "9":
            {
                Console.Clear();
                Console.Write("Query: ");
                string query = Console.ReadLine();
                foreach (var music in database.Musics)
                {
                    if (music.Title.Contains(query) || 
                        music.Genre.Contains(query) ||
                        music.Relasedate.Contains(query) || 
                        music.Artist.Contains(query) || 
                        music.Album.Contains(query))
                    {
                        Console.WriteLine($"Title: {music.Title}");
                        Console.WriteLine(music.Length);
                        Console.WriteLine(music.Genre);
                        Console.WriteLine(music.Relasedate);
                        Console.WriteLine(music.Artist);
                        Console.WriteLine(music.Album);
                        Console.WriteLine(music.Web);
                    }
                }
                Console.WriteLine("Press any key to return");
                Console.ReadKey();
                break;
            }

        case "0":
            {
                Console.Clear();
                Console.WriteLine("Closing program");
                break;
            }
        default:
            {
                Console.WriteLine("Error");
                break;
            }
    }
}