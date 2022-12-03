using System;
using System.Collections.Generic;

namespace Randomize_Words
{


    class Program
    {
        class Song
        {

            public string TypeList { get; set; }

            public string Name { get; set; }

            public string Time { get; set; }

        }
        static void Main(string[] args)
        {
            int numOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 1; i <= numOfSongs; i++)
            {
                string[] dataofSong = Console.ReadLine()
                    .Split("_", StringSplitOptions.RemoveEmptyEntries);

                Song song = new Song() 
                {
                    TypeList = dataofSong[0],
                    Name = dataofSong[1],
                    Time = dataofSong[2],
                };
           
                songs.Add(song);

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
                    if (typeList == song.TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
