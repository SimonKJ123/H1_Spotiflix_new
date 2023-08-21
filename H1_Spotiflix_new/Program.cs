#nullable disable
using System.Text.Json;

string path = "Database.json";

Database database = null;

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
    Console.WriteLine();
    Console.WriteLine("Press 4 to registre a Series");
    Console.WriteLine("Press 5 to look at Series Database");
    Console.WriteLine("Press 6 to Search for Keyword");
    Console.WriteLine();
    Console.WriteLine("Press 7 to registre a Song");
    Console.WriteLine("Press 8 to look at Music Database");
    Console.WriteLine("Press 9 to Search for Keyword");
    Console.WriteLine();
    Console.WriteLine("Write 10 to Search Globally");
    Console.WriteLine();
    Console.WriteLine("Press 0 to exit program");
    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            {
                InfoAboutMovie(path, database);
                break;
            }
        case "2":
            {
                MovieDatabase(database);
                break;
            }
        case "3":
            {
                PrintMovie(database);
                break;
            }
        case "4":
            {
                CreateSerieslist(path, database);
                break;
            }
        case "5":
            {
                SeriesDatabase(database);
                break;
            }
        case "6":
            {
                PrintSeries(database);
                break;
            }
        case "7":
            {
                InfoAboutSong(path, database);
                break;
            }
        case "8":
            {
                SongDatabase(database);
                break;
            }
        case "9":
            {
                PrintSong(database);
                break;
            }
        case "10":
            {
                SeriesInfo(database);

                break;
            }

        case "0":
            {
                Console.Clear();
                Console.WriteLine("Closing program");
                return;
            }
        default:
            {
                Console.WriteLine("Error");
                break;
            }
    }
}

void InfoAboutMovie(string path, Database database)
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
}

void MovieDatabase(Database database)
{
    Console.Clear();
    Console.WriteLine("List of Movies in DataBase");

    foreach (var movie in database.Movies)
    {
        movie.Print();
    }

    Console.WriteLine("Press any key to return");
    Console.ReadKey();
}

void PrintMovie(Database database)
{
    Console.Clear();
    Console.Write("Query: ");
    string query = Console.ReadLine();
    foreach (var movie in database.Movies)
    {
        if (movie.Contains(query))
        {
            movie.Print();

        }
    }
    Console.WriteLine("Press any key to return");
    Console.ReadKey();
}

void CreateSerieslist(string path, Database database)
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
}

void SeriesDatabase(Database database)
{
    Console.Clear();
    Console.WriteLine("List of Series in DataBase");

    foreach (var series in database.Seriess)
    {
        series.Print();
    }

    Console.WriteLine("Press any key to return");
    Console.ReadKey();
}

void PrintSeries(Database database)
{
    Console.Clear();
    Console.Write("Query: ");
    string query = Console.ReadLine();
    foreach (var series in database.Seriess)
    {
        if (series.Contains(query))
        {
            series.Print();
        }
    }
    Console.WriteLine("Press any key to return");
    Console.ReadKey();
}

void InfoAboutSong(string path, Database database)
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
}

void SongDatabase(Database database)
{
    Console.Clear();
    Console.WriteLine("List of Music in DataBase");

    foreach (var music in database.Musics)
    {
        music.Print();
    }

    Console.WriteLine("Press any key to return");
    Console.ReadKey();
}

void PrintSong(Database database)
{
    Console.Clear();
    Console.Write("Query: ");
    string query = Console.ReadLine();
    foreach (var music in database.Musics)
    {
        if (music.Contains(query))
        {
            music.Print();
        }
    }
    Console.WriteLine("Press any key to return");
    Console.ReadKey();
}

void SeriesInfo(Database database)
{
    Console.Clear();
    Console.Write("Query: ");
    string query = Console.ReadLine();
    foreach (var movie in database.Movies)
    {
        if (movie.Contains(query))
        {
            movie.Print();

        }
    }
    foreach (var series in database.Seriess)
    {
        if (series.Contains(query))
        {
            series.Print();
        }
    }
    foreach (var music in database.Musics)
    {
        if (music.Contains(query))
        {
            music.Print();
        }
    }
    Console.WriteLine("Press any key to return");
    Console.ReadKey();
}