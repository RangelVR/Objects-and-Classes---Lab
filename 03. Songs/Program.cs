using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Songs
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int nSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < nSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                Song song = new Song() {
                    TypeList = data[0],
                    Name = data[1],
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
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

}
