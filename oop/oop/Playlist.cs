using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Playlist
    {
        private List<Song> ListOfSongs;

        public Playlist()
        {
            ListOfSongs = new List<Song>();
        }

        public void AddSong()
        {
            int seconds;

            Console.WriteLine("\nNew song");
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Artist: ");
            string artist = Console.ReadLine();
            Console.Write("Album: ");
            string album = Console.ReadLine();
            while (true)
            {
                Console.Write("Length in sec: ");
                try
                {
                    seconds = Convert.ToInt32(Console.ReadLine());
                    break;
                }

                catch (Exception ex)
                {
                    Console.WriteLine("\nInvalid choice. Please try again by choosing a number of your choice.");
                    continue;
                }

            }

            

            Song item = new Song(title, artist, album, seconds);
            ListOfSongs.Add(item);
        }

        public void ListSongs()
        {
            foreach (Song item in ListOfSongs)
            {
                item.GetSongInfo();
            }
        }

        public void RemoveSong()
        {
            int toBeRemoved;
            foreach(Song item in ListOfSongs)
            {
                Console.WriteLine(item.title + " - " + (ListOfSongs.IndexOf(item) + 1));
            }

            Console.Write("\nWhich song would you like to remove from your playlist (use the numbering system): ");
            while (true) 
            {
                try
                {
                    toBeRemoved = Convert.ToInt32(Console.ReadLine());
                    break;
                }

                catch (Exception ex)
                {
                    Console.WriteLine("\nInvalid choice. Please try again by choosing a number of your choice.");
                    continue;
                }
            }
            
            ListOfSongs.RemoveAt(toBeRemoved-1);
        }

        public void EditSong()
        {
            int editChoice;
            int toBeEdited;
            Song chosenSong;

            if(ListOfSongs.Count <= 0)
            {
                Console.WriteLine("There are no songs to edit.");
                return;
            }

            foreach (Song item in ListOfSongs)
            {
                Console.WriteLine();
                Console.WriteLine(item.title + " - " + (ListOfSongs.IndexOf(item) + 1));
            }

            Console.Write("\nWhich song from your playlist would you like to edit? (use the numbering system): ");
            while (true)
            {
                try
                {
                    toBeEdited = Convert.ToInt32(Console.ReadLine());
                    break;
                }

                catch (Exception ex)
                {
                    Console.WriteLine("\nInvalid choice. Please try again by choosing a number of your choice.");
                    continue;
                }
            }
            
            while (true)
            {
                try
                {
                    chosenSong = (ListOfSongs[(toBeEdited - 1)]);
                    break;
                }

                catch (Exception ex)
                {
                    Console.WriteLine("\nInvalid choice. Please try again by choosing a number of your choice.");
                    continue;
                }
            }
            

            Console.WriteLine("\nThis is current information about this song:");
            chosenSong.GetSongInfo();

            do
            {
                while (true)
                {
                    Console.WriteLine("\nWhich of the following would you like to change?\n1) Title\n2) Artist\n3) Album\n4) Length\n5) None\n");
                    try
                    {
                        editChoice = Convert.ToInt32(Console.ReadLine());
                        break;
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("\nInvalid choice. Please try again by choosing a number of your choice.");
                        continue;
                    }
                }

                switch (editChoice)
                {
                    case 1:
                        Console.Write("\nNew title: ");
                        chosenSong.title = Console.ReadLine();
                        break;

                    case 2:
                        Console.Write("\nNew artist: ");
                        chosenSong.artist = Console.ReadLine();
                        break;

                    case 3:
                        Console.Write("\nNew album: ");
                        chosenSong.album = Console.ReadLine();
                        break;

                    case 4:
                        Console.Write("\nNew artist: ");
                        chosenSong.seconds = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (editChoice != 5);



        }


    }
}
