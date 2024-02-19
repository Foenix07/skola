using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Playlist playlist = new Playlist();

            int choice;
            do
            {
                while (true)
                {
                    Console.WriteLine("\nThis is your playlist. What would you like to do with it?\n1) Add a song\n2) Remove a song\n3) Edit a song\n4) List all songs\n5) Exit\nPlease choose by entering a number equivalent to your choice.\n");
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("\nInvalid choice. Please try again by choosing a number of your choice.");
                        continue;
                    }
                }

                switch (choice)
                {
                    case 1:
                        playlist.AddSong();
                        break;

                    case 2:
                        playlist.RemoveSong();
                        break;

                    case 3:
                        playlist.EditSong();
                        break;

                    case 4:
                        playlist.ListSongs();
                        break;
                }
            }
            while (choice != 5);

            Console.ReadKey();


        }

        
    }
}
