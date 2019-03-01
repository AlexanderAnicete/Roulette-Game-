using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            Console.WriteLine("Welcome! Lets play some roulette! Do you want to play?");
            string choice = Console.ReadLine();
            Console.WriteLine("How many times do you want to play?");
            int temp = int.Parse(Console.ReadLine());
            Console.Clear();
            if (choice == "yes")
            {
                for (int i = 0; i < temp; i++)
                {
                    Console.WriteLine("Choose a number to choose the type of bet \n" +
                        "1. Numbers: the number of the bin \n" +
                            "2.Evens / Odds: even or odd numbers \n" +
                            "3.Reds / Blacks: red or black colored numbers \n" +
                            "4.Lows / Highs: low(1 - 18) or high(19 - 38) numbers. \n" +
                            "5.Dozens: row thirds, 1 - 12, 13 - 24, 25 - 36 \n" +
                            "6.Columns: first, second, or third columns \n" +
                            "7.Street: rows, e.g., 1 / 2 / 3 or 22 / 23 / 24 \n" +
                            "8. 6 Numbers: double rows, e.g., 1 / 2 / 3 / 4 / 5 / 6 or 22 / 23 / 24 / 25 / 26 / 26 \n" +
                            "9.Split: at the edge of any two contiguous numbers, e.g., 1 / 2, 11 / 14, and 35 / 36 \n" +
                            "10.Corner: at the intersection of any four contiguous numbers, e.g., 1 / 2 / 4 / 5, or 23 / 24 / 26 / 27 ");

                    int user = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Bet(user);
                }   
            }
            else
            {
                Console.WriteLine("Thanks for stopping by!");
            }
            Console.WriteLine("Thanks for playing!");
        }
        public static void Bet(int input)
        {
            char[] colors = {'g', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'g', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b'};
            int[] numbersWheel = { 0, 2, 14, 35, 23, 4, 16, 33, 21, 6, 18, 31, 19, 8, 12, 29, 25, 10, 27, 00, 1, 13, 36, 24, 3, 15, 34, 22, 5, 17, 32, 20, 7, 11, 30, 26, 9, 28 };
            Random NumWheel = new Random();            
            int num = NumWheel.Next(0, 37);
            int result = numbersWheel[num];
            char result2 = colors[num];
            bool play = true;
            Console.WriteLine("How much money do you want to bet");
            int bet = int.Parse(Console.ReadLine());

            switch (input)
            {
                                     
                case 1:   
                    
                        Console.WriteLine("enter a number on the wheel");
                        int wheelNum = int.Parse(Console.ReadLine());
                    
                        if (result == wheelNum)
                        {
                            Console.WriteLine("You won! Your prize is " + bet);
                            
                        }
                        else
                        {
                            Console.WriteLine("you lost");
                        }
                    break;
                case 2:
                    Console.WriteLine("Choose Odds or Evens");
                    string selection = Console.ReadLine();
                    Console.WriteLine(result);
                        
                        if (selection == "odds")
                        {  
                            if (result % 2 == 1)
                            {
                            Console.WriteLine("You won! Your prize is " + bet);
                        }
                            else 
                            {
                                Console.WriteLine("You Lost");
                            }
                        }
                        else if (selection == "even")
                        {
                            if (result % 2 == 0)
                            {
                            Console.WriteLine("You won! Your prize is $" + bet);
                        }
                            else
                            {
                                Console.WriteLine("you lost");                                
                            }
                        } 
                    break;
                case 3:
                    Console.WriteLine("Choose a color red as 'r', black as 'b'");
                    char selection2 = char.Parse(Console.ReadLine());

                    if (result2 == selection2)
                    {
                        Console.WriteLine("You chose " + selection2 + " , you won! Your prize is $" + bet);
                    }
                    else
                    {
                        Console.WriteLine("You chose " + selection2 + ", it landed on " + result2 + " you lost");
                    }
                    break;
                case 4:
                    Console.WriteLine("Choose highs or lows");
                    string selection3 = Console.ReadLine();
                    if (selection3 == "highs")
                    {
                        if (result >= 19)
                        {
                            Console.WriteLine("It landed on " + result + ". You won $" + bet + "!");
                        }
                        else
                        {
                            Console.WriteLine("You lost");
                        }
                    }
                    else if (selection3 == "lows")
                    {
                        if (result <= 18)
                        {
                            Console.WriteLine("It landed on " + result + ". You won $" + bet + "!");
                        }
                        else
                        {
                            Console.WriteLine("You lost");
                        }
                    }
                    break;
                case 5:
                    Console.WriteLine("Choose dozens 1,2, or 3: 1-12 is row 1, 13-24 is row 2, 25-36 is row 3");
                    int result3 = int.Parse(Console.ReadLine());
                    if (result3 == 1)
                    {
                        if (result <= 12)
                        {
                            Console.WriteLine("It landed on " + result + ". You won $" + (bet * 2) + "!");
                        }
                        else
                        {
                            Console.WriteLine("You lost");
                        }
                    }
                    else if (result3 == 2)
                    {
                        if (result >= 13 && result <=24)
                        {
                            Console.WriteLine("It landed on " + result + ". You won $" + (bet * 2) + "!");
                        }
                        else
                        {
                            Console.WriteLine("You lost");
                        }
                    }
                    else if (result3 == 3)
                    {
                        if (result < 24)
                        {
                            Console.WriteLine("It landed on " + result + ". You won $" + (bet *2) + "!");
                        }
                        else
                        {
                            Console.WriteLine("You lost");
                        }
                    }
                    break;
                case 6:
                    Console.WriteLine("Choose column 1, 2, or 3");
                    int input2 = int.Parse(Console.ReadLine());
                    if (input2 == 1)
                    {
                        Console.WriteLine($" The ball landed on {result}");
                        if (result % 3 == 1) 
                        {
                            Console.WriteLine($"You won {bet * 2}");
                        }
                        else
                        {
                            Console.WriteLine("you lost");
                        }
                    }
                    else if (input2 == 2)
                    {
                        Console.WriteLine(result);
                        if (result % 3 == 2)
                        {
                            Console.WriteLine($"You won {bet * 2}");
                        }
                        else
                        {
                            Console.WriteLine("you lost");
                        }
                    }
                    else if (input2 == 3)
                    {
                        Console.WriteLine(result);
                        if (result % 3 == 0)
                        {
                            Console.WriteLine($"You won {bet * 2}");
                        }
                        else if(result == 0)
                        {
                            Console.WriteLine("you lost");
                        }
                        else
                        {
                            Console.WriteLine("you lost");
                        }
                    }
                    break;
                case 7:
                    Console.WriteLine("Choose row 1,4,7,10,13,16,19,22,25,28,31, or 34 to bet on.");
                    int rowNum = int.Parse(Console.ReadLine());
                    int wholeRow = rowNum + 2;
                    if(result >= rowNum && result <= wholeRow)
                    {
                        Console.WriteLine($"The ball landed on {result}, you win {bet * 11}! ");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry,  the ball landed on {result} and you bet on row {rowNum} ");
                    }
                    break;
                case 8:
                    Console.WriteLine("Choose row 1,4,7,10,13,16,19,22,25,28, or 31 for a six row bet.");
                    int rowNum1 = int.Parse(Console.ReadLine());
                    int wholeRow1 = rowNum1 + 5;
                    if (result >= rowNum1 && result <= wholeRow1)
                    {
                        Console.WriteLine($"The ball landed on {result}, you win {bet * 5}! ");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry,  the ball landed on {result} and you bet on row {rowNum1} ");
                    }
                    break;
                case 9:
                    Console.WriteLine("Choose 2 numbers followed by enter for a split bet");
                    int splitNum1 = int.Parse(Console.ReadLine());
                    int splitNum2 = int.Parse(Console.ReadLine());
                    if (splitNum1 == result || splitNum2 == result)
                    {
                        Console.WriteLine($"The ball landed on {result}, you chose {splitNum1}/{splitNum2}, you win!");
                    }
                    else
                    {
                        Console.WriteLine($"The ball landed on {result}, you bet on {splitNum1}/{splitNum2}, you lose.");
                    }
                    break;
                case 10:
                    Console.WriteLine("Choose 4 numbers followed by enter for a corner bet");
                    int cornerNum1 = int.Parse(Console.ReadLine());
                    int cornerNum2 = int.Parse(Console.ReadLine());
                    int cornerNum3 = int.Parse(Console.ReadLine());
                    int cornerNum4 = int.Parse(Console.ReadLine());
                    if (cornerNum1 == result || cornerNum2 == result || cornerNum3 == result || cornerNum4 == result)
                    {
                        Console.WriteLine($"The ball landed on {result}, you chose corner {cornerNum1}/{cornerNum2}/{cornerNum3}/{cornerNum4}, winner! You won {bet * 8}!");
                    }
                    else
                    {
                        Console.WriteLine($"The ball landed on {result}, you chose corner {cornerNum1}/{cornerNum2}/{cornerNum3}/{cornerNum4}, you lose.");
                    }
                    break;
            }   
            


        }

    }

}
