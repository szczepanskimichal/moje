using System;
using System.Collections.Generic;

namespace FriendFace
{
    public class User
    {
        public string Name { get; }
        public int Age { get; }
        public DateOnly BirthDate { get; }
        public string Email { get; }
        public string Bio { get; }
        public List<User> Friends { get; }

        public User(string name, int age, DateOnly birthDate, string email, string bio)
        {
            Name = name;
            Age = age;
            BirthDate = birthDate;
            Email = email;
            Bio = bio;
            Friends = new List<User>();
        }

        public void AddFriend(User friend)
        {
            if (friend == null)
            {
                Console.WriteLine("Ugyldig venn.");
                return;
            }

            if (friend == this)
            {
                Console.WriteLine("Du kan ikke legge til deg selv som venn.");
                return;
            }

            if (Friends.Contains(friend))
            {
                Console.WriteLine($"{friend.Name} er allerede din venn.");
                return;
            }

            Friends.Add(friend);
            Console.WriteLine($"{friend.Name} er nå lagt til som venn.");
        }

        public void RemoveFriend(User friend)
        {
            if (Friends.Contains(friend))
            {
                Friends.Remove(friend);
                Console.WriteLine($"{friend.Name} er fjernet fra vennelisten.");
            }
            else
            {
                Console.WriteLine($"{friend.Name} er ikke på vennelisten din.");
            }
        }

        public void PrintProfile()
        {
            Console.WriteLine("\n--- Profil ---");
            Console.WriteLine($"Navn: {Name}");
            Console.WriteLine($"Alder: {Age}");
            Console.WriteLine($"Fødselsdato: {BirthDate}");
            Console.WriteLine($"E-post: {Email}");
            Console.WriteLine($"Bio: {Bio}");
            Console.WriteLine("---------------\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var mainUser = new User("Hovedbruker", 25, new DateOnly(1999, 1, 1), "main@friendface.com", "Hei! Dette er min profil.");

            var allUsers = new List<User>
            {
                mainUser,
                new User("Ola Nordmann", 30, new DateOnly(1994, 1, 15), "ola@friendface.com", "Elsker å reise og ta bilder."),
                new User("Kari Nordmann", 28, new DateOnly(1996, 5, 22), "kari@friendface.com", "Glad i musikk og bøker."),
                new User("Per Hansen", 45, new DateOnly(1979, 3, 10), "per@friendface.com", "Familiefar og sportsentusiast."),
                new User("Anne Olsen", 35, new DateOnly(1989, 7, 5), "anne@friendface.com", "Kunstner og kaffeelsker."),
                new User("Lars Johansen", 50, new DateOnly(1974, 11, 30), "lars@friendface.com", "Historieinteressert og friluftsmann.")
            };

            while (true)
            {
                Console.WriteLine("\n--- FriendFace ---");
                Console.WriteLine("1. Legg til venn");
                Console.WriteLine("2. Fjern venn");
                Console.WriteLine("3. Vis venneliste");
                Console.WriteLine("4. Vis profil til en venn");
                Console.WriteLine("5. Vis min profil");
                Console.WriteLine("6. Avslutt");
                Console.Write("Ditt valg: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Tilgjengelige brukere:");
                    for (int i = 0; i < allUsers.Count; i++)
                    {
                        var user = allUsers[i];
                        if (user != mainUser && !mainUser.Friends.Contains(user))
                        {
                            Console.WriteLine($"{i}: {user.Name}");
                        }
                    }

                    Console.Write("Skriv inn nummeret til brukeren du vil legge til: ");
                    string inputIndex = Console.ReadLine();
                    int index;
                    bool success = int.TryParse(inputIndex, out index);

                    if (success && index >= 0 && index < allUsers.Count && allUsers[index] != mainUser)
                    {
                        mainUser.AddFriend(allUsers[index]);
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig valg.");
                    }
                }
                else if (input == "2")
                {
                    if (mainUser.Friends.Count == 0)
                    {
                        Console.WriteLine("Du har ingen venner å fjerne.");
                        continue;
                    }

                    Console.WriteLine("\nDine venner:");
                    for (int i = 0; i < mainUser.Friends.Count; i++)
                    {
                        Console.WriteLine($"{i}: {mainUser.Friends[i].Name}");
                    }

                    Console.Write("Skriv inn nummeret til vennen du vil fjerne: ");
                    string inputIndex = Console.ReadLine();
                    int index;
                    bool success = int.TryParse(inputIndex, out index);

                    if (success && index >= 0 && index < mainUser.Friends.Count)
                    {
                        var friendToRemove = mainUser.Friends[index];

                        Console.Write($"Bekreft navnet på vennen ({friendToRemove.Name}): ");
                        string confirmation = Console.ReadLine();

                        if (confirmation.ToLower() == friendToRemove.Name.ToLower())
                        {
                            mainUser.RemoveFriend(friendToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Navnet stemmer ikke. Venn ikke fjernet.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig nummer.");
                    }
                }
                else if (input == "3")
                {
                    if (mainUser.Friends.Count == 0)
                    {
                        Console.WriteLine("Du har ingen venner.");
                    }
                    else
                    {
                        Console.WriteLine("\nDine venner:");
                        foreach (var friend in mainUser.Friends)
                        {
                            Console.WriteLine($"- {friend.Name}");
                        }
                    }
                }
                else if (input == "4")
                {
                    if (mainUser.Friends.Count == 0)
                    {
                        Console.WriteLine("Du har ingen venner.");
                        continue;
                    }

                    Console.WriteLine("\nDine venner:");
                    for (int i = 0; i < mainUser.Friends.Count; i++)
                    {
                        Console.WriteLine($"{i}: {mainUser.Friends[i].Name}");
                    }

                    Console.Write("Skriv inn nummeret til vennen du vil se: ");
                    string inputIndex = Console.ReadLine();
                    int index;
                    bool success = int.TryParse(inputIndex, out index);

                    if (success && index >= 0 && index < mainUser.Friends.Count)
                    {
                        mainUser.Friends[index].PrintProfile();
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig valg.");
                    }
                }
                else if (input == "5")
                {
                    mainUser.PrintProfile();
                }
                else if (input == "6")
                {
                    Console.WriteLine("Avslutter FriendFace...");
                    break;
                }
                else
                {
                    Console.WriteLine("Ugyldig valg. Prøv igjen.");
                }
            }
        }
    }
}
