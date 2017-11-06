using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class6
{
    class Program
    {
        struct Song
        {
            public string author;
            public string name;
            public int length;
            public Genre genre;
        }
        enum Genre { rock, jazz, pop };
        static void Main(string[] args)
        {
            Song song1;
            song1.name = "Hello";
            song1.author = "Potap";
            song1.length = 400;
            song1.genre = Genre.pop;

            Song song2;
            song2.name = "Never Back";
            song2.author = "Fluid";
            song2.length = 550;
            song2.genre = Genre.rock;

            Song song3;
            song3.name = "Fill";
            song3.author = "Dreams";
            song3.length = 300;
            song3.genre = Genre.jazz;

            Song[] Songs = new Song[3];
            Songs[0] = song1;
            Songs[1] = song2;
            Songs[2] = song3;

            Console.WriteLine("input action number");
            int action = int.Parse(Console.ReadLine());

            switch (action)
            {
                case 1:
                    First(ref Songs);
                    break;
                case 2:
                    Second(ref Songs);
                    break;
                case 3:
                    Third(ref Songs);
                    break;
                //case 4:
                //    Forth();
                //    break;
                default:
                    break;
            }

        }

        private static void Third(ref Song[] Songs) //3
        {
            Console.WriteLine("input genre");
            string genre = Console.ReadLine();

            foreach (var sng in Songs)
            {
                if (sng.genre == Songs.genre[genre])
                {
                    Console.WriteLine("author: {0}, name: {1}, length: {2}, genre: {3}",
                    sng.author, sng.name, sng.length, sng.genre);
                }
            }
        }
        private static void Second(ref Song[] Songs) //2
        {
            Console.WriteLine("The longest Song is:");

            

            Print(Songs);
        }
        private static void First(ref Song[] Songs) //1
        {
            Console.WriteLine("input index");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("input new Song Name");
            string newSongName = Console.ReadLine();

            Songs[input].name = newSongName;

            Print(Songs);
        }

        private static void Print(Song[] Songs)
        {

            foreach (var sng in Songs)
            {
                Console.WriteLine("author: {0}, name: {1}, length: {2}, genre: {3}",
                    sng.author, sng.name, sng.length, sng.genre);
            }
        }
    }
}
