
int n = int.Parse(Console.ReadLine());

List<Song> songs = new List<Song>();

while (n > 0)
{
    string[] currSong = Console.ReadLine().Split("_").ToArray(); 

    string type = currSong[0];
    string name = currSong[1];

    Song newSong = new Song
    {
        TypeList = type,
        Name = name
    };

    songs.Add(newSong);
    n--;
}

string typeList = Console.ReadLine();

if (typeList == "all")
{
    foreach (Song song in songs)
    {
        Console.WriteLine(song.Name);
    }
}
else
{
    foreach (Song song in songs)
    {
        if (song.TypeList == typeList)
        {
            Console.WriteLine(song.Name);
        }
    }
}

class Song
{
    public string TypeList { get; set; }

    public string Name { get; set; }
}
