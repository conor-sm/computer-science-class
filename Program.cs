using System;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
//Hello World
namespace Program{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Choose program to do::\n1:: Password strength tester\n2:: Game/Search demonstration\n3:: Password Generator\n4:: Patterns");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: Password(); break;

                case 2: Game(); break;

                case 3: PasswordGenerator(); break;

                case 4: Patterns(); break;

            }
        }

        static void Patterns()
        {
            Console.Clear();
            Console.WriteLine("Stair Case Pattern:");

            for (int i = 1; i<=5; i++)
            {   
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Reversed Stair Case Pattern:");

            for (int i = 1; i<=5; i++)
            {   
                for (int j = i; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Pyramid Pattern");

        }

        static void Password()
        {
            Console.Clear();
            char whitespace = ' ';
            int special_count = 0;
            int upper_count = 0;
            bool whitespace_bool = false;

            Console.WriteLine("Enter your password::");
            string password = Convert.ToString(Console.ReadLine());

            foreach (char item in password)
            {
                if (item == whitespace)
                {
                    Console.WriteLine("Sorry, the character can not include any whitespace.");
                    whitespace_bool = true;
                }

                else if (((int)(item) >= 33) && ((int)(item) <= 47))
                {
                    special_count = special_count +=1;
                }

                else if (((int)(item) >= 33) && ((int)(item) <= 47))
                {
                    special_count = special_count +=1;
                }

                else if (((int)(item) >= 58) && ((int)(item) <= 65))
                {
                    special_count = special_count +=1;
                }

                else if (((int)(item) >= 91) && ((int)(item) <= 96)) 
                {
                    special_count = special_count +=1;
                }

                else if (((int)(item) >= 123) && ((int)(item) <= 126))
                {
                    special_count = special_count +=1;
                }

                else if (Char.IsUpper(item))
                {
                    upper_count = upper_count +=1;
                }

            }


            if (special_count >= 2 && upper_count >= 1 && whitespace_bool == false)
            {
                Console.WriteLine("Your password is strong enough");
            }

            else
            {
                Console.WriteLine("Your password is not strong enough.");
            }

            Menu();
        }

        static void Game()
        {   
            Console.Clear();
            int guesses = 0;
            bool tf = false;

            Console.WriteLine("What range of numbers would you like to do?\nLower boundary::");
            int ifrom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nUpper boundary::");
            int ito = Convert.ToInt32(Console.ReadLine());

            int random_number = RandomNumber(ifrom, ito);

            while (tf != true)
            {
                Console.WriteLine("Enter your guess::");
                int guess = Convert.ToInt32(Console.ReadLine());
                guesses += 1;
                
                if (guess == random_number)
                {
                    Console.WriteLine($"Correct. You found it in {guesses} guesses.");
                    tf = true;
                }

                else if (guess >= random_number)
                {
                    Console.WriteLine("Think of a lower number.");
                }

                else if (guess <= random_number)
                {
                    Console.WriteLine("Think of a higher number.");
                }
                
            }

            Menu();
        }
        
        //for Game - makes random number

        static int RandomNumber(int ifrom, int ito)
        {
            Console.Clear();
            Random random = new Random();
            return random.Next(ifrom, ito);
        }

        static void PasswordGenerator()
        {
            //Requirements for password: Atleast 12 characters, 4 numbers, 4 special characters, 2 upper case, 2 lower case.
            //Formats password in UpperCase/Numbers/LowerCase/SpecialCharacters
            Console.Clear();
            string password;
            string special_characters = "!£$%^&*()_+-=[]{};:@#~,./<>?|\"";
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lower_case = upper_case.ToLower();
            string special_character_1 = "";
            string special_character_2 = "";
            string special_character_3 = "";
            string special_character_4 = "";
            string alphabet_number_1 = "";
            string alphabet_number_2 = "";
            string alphabet_number_3 = "";
            string alphabet_number_4 = "";

            int number_1 = Convert.ToInt32(RandomNumberRange(0, 9));
            int number_2 = Convert.ToInt32(RandomNumberRange(0, 9));

            int special_number = Convert.ToInt32(RandomNumberSpecialCharacters(0, 30));

            foreach (char item in special_characters)
            {
                int item_index = special_characters.IndexOf(item);

                if (item_index == special_number)
                {
                    special_character_1 = Convert.ToString(item);
                    break;
                }
            }

            special_number = Convert.ToInt32(RandomNumberSpecialCharacters(0, 30));

            foreach (char item in special_characters)
            {
                int item_index = special_characters.IndexOf(item);

                if (item_index == special_number)
                {
                    special_character_2 = Convert.ToString(item);
                    break;
                }
            }

            special_number = Convert.ToInt32(RandomNumberSpecialCharacters(0, 30));

            foreach (char item in special_characters)
            {
                int item_index = special_characters.IndexOf(item);

                if (item_index == special_number)
                {
                    special_character_3 = Convert.ToString(item);
                    break;
                }
            }

            special_number = Convert.ToInt32(RandomNumberSpecialCharacters(0, 30));

            foreach (char item in special_characters)
            {
                int item_index = special_characters.IndexOf(item);

                if (item_index == special_number)
                {
                    special_character_4 = Convert.ToString(item);
                    break;
                }
            }

            int alphabet_number = Convert.ToInt32(RandomAlphabet(0,25));

            foreach (char item_1 in upper_case)
            {
                int item_index_1 = upper_case.IndexOf(item_1);

                if (item_index_1 == alphabet_number)
                {
                    alphabet_number_1 = Convert.ToString(item_1);
                    break;
                }
            }

            alphabet_number = Convert.ToInt32(RandomAlphabet(0,25));

            foreach (char item_1 in upper_case)
            {
                int item_index_1 = upper_case.IndexOf(item_1);

                if (item_index_1 == alphabet_number)
                {
                    alphabet_number_2 = Convert.ToString(item_1);
                    break;
                }
            }
            
            alphabet_number = Convert.ToInt32(RandomAlphabet(0, 25));

            foreach (char item_2 in lower_case)
            {
                int item_index_2 = lower_case.IndexOf(item_2);

                if (item_index_2 == alphabet_number)
                {
                    alphabet_number_3 = Convert.ToString(item_2);
                    break;
                }
            }

            alphabet_number = Convert.ToInt32(RandomAlphabet(0, 25));

            foreach (char item_2 in lower_case)
            {
                int item_index_2 = lower_case.IndexOf(item_2);

                if (item_index_2 == alphabet_number)
                {
                    alphabet_number_4 = Convert.ToString(item_2);
                    break;
                }
            }
            
            password = $"{alphabet_number_1}{alphabet_number_2}{number_1}{number_2}{alphabet_number_3}{alphabet_number_4}{special_character_1}{special_character_2}{special_character_3}{special_character_4}";

            Console.WriteLine($"Your password is {password}");
        }

        static int RandomNumberRange(int number_min, int number_max)
        {
            Random random = new Random();
            return random.Next(number_min, number_max);
        }

        static int RandomNumberSpecialCharacters(int number_special_min, int number_special_max)
        {
            Random random = new Random();
            return random.Next(number_special_min, number_special_max);   
        }

        static int RandomAlphabet(int number_alphabet_min, int number_alphabet_max)
        {
            Random random = new Random();
            return random.Next(number_alphabet_min, number_alphabet_max);
        }

    }
}