using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game_Prototype_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Text(0, 0, "Console #1: Entry: Permitted/ Aliquis Inc./ Alpha Centauri Quadrant/ ", ConsoleColor.White, false);
            Text(0, 1, "Loading text.files/ Retrieving commands.exe .....", ConsoleColor.White, false);
            Timer(50, 1, 0, 101, ConsoleColor.White, true);
            Console.Clear();

            Text(35, 10, "Combat v1.0", ConsoleColor.Blue, false);
            Text(18, 11, "Written by Brennan Sprague, 2017, Aliquis Inc.", ConsoleColor.Blue, true);
            Console.Clear();

            Text(0, 0, "What is your name?", ConsoleColor.Blue, false);
            Console.SetCursorPosition(19, 0);
            Console.ForegroundColor = ConsoleColor.White;
            string Name = Console.ReadLine();
            Text(0, 1, "It is great to meet you, ", ConsoleColor.Blue, false);
            Text(25, 1, Name + ".", ConsoleColor.White, false);
            Text(0, 2, "Welcome to the future, the year 2146, ", ConsoleColor.Blue, false);
            Text(2, 3, "where every single command is relayed by text.", ConsoleColor.Blue, false);
            Text(0, 5, "You will come across many different texts in your stay here ", ConsoleColor.Blue, false);
            Text(2, 6, "at space station", ConsoleColor.Blue, false);
            Text(19, 6, "Alpha Station #15.", ConsoleColor.DarkGreen, true);
            Console.Clear();

            Text(0, 0, "Warning! Warning! Incoming EMP Wave!", ConsoleColor.Red, false);
            Text(2, 1, "Every station personnel evacuate to EMP chambers immediatly!", ConsoleColor.Red, true);
            Console.Clear();

            Text(0, 0, "Without knowledge of any previous expeditions into the unknown", ConsoleColor.Gray, false);
            Text(2, 1, "vaccuum of space, you begin to ponder the very forces of nature.", ConsoleColor.Gray, false);
            Text(2, 2, "Suddenly, as if by coincedence, the entire space station was", ConsoleColor.Gray, false);
            Text(2, 3, "rocked by a very loud and sudden explosion.", ConsoleColor.Gray, false);

            Text(0, 5, "You:", ConsoleColor.Gray, false);
            Text(3, 6, "Continue to the chambers.", ConsoleColor.Gray, false);
            Text(3, 7, "Check for the source of the explosion.", ConsoleColor.Gray, false);
            Text(3, 8, "Don't answer and mind your own buisness.", ConsoleColor.Gray, false);
            Console.SetCursorPosition(0, 6);
            Menu(0, 6, ConsoleColor.DarkRed, "->", 6, 8, ConsoleColor.Gray, "You obey the orders, wanting to save your own life.", 6,
                "You turn around, heading in the wrong direction.", 7, "You value ignorance over the health and safety of others.", 8, 10);
            


            Console.Read();
        }

        static void Text(int XCoord, int line, string text, ConsoleColor Color, bool Pause)
        {
            int SpeechX = XCoord; int SpeechY = line;
            Console.ForegroundColor = Color;

            string[] message = text.Select(x => x.ToString()).ToArray();
            foreach (string letter in message)
            {
                Console.SetCursorPosition(SpeechX, SpeechY);
                Thread.Sleep(50);
                Console.Write(letter);
                SpeechX++;
            }

            Console.ForegroundColor = ConsoleColor.Black;
            if (Pause)
            {
                while (true)
                {
                    ConsoleKeyInfo input = Console.ReadKey();
                    if (input.Key == ConsoleKey.Spacebar || input.Key == ConsoleKey.Enter)
                    {
                        break;
                    }

                }
            }
        }

        static void Timer(int x, int y, int start, int end, ConsoleColor Color, bool On)
        {
            int BaseNum = start; int CapNum = end;
            Console.ForegroundColor = Color;

            if (On)
            {
                while (On == true)
                {
                    if (BaseNum == CapNum)
                    {
                        On = false;
                        break;
                    }
                    else if (BaseNum != CapNum)
                    {
                        Thread.Sleep(80);
                        BaseNum++;
                    }
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(BaseNum);
                }
            }
        }

        static void Menu(int x, int y, ConsoleColor Color, string Pointer, int top, int bottom, ConsoleColor Color2, string a1, int y1, string a2, int y2, string a3, int y3, int y4)
        {
            int NewY = y;
            Console.CursorVisible = false;
            ConsoleKeyInfo input;
            Console.ForegroundColor = Color;
            Console.Write(Pointer);

            while (true)
            {
                input = Console.ReadKey();
                if (input.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(x, NewY);
                    Console.Write("  ");
                    NewY--;

                    if (NewY < top)
                    {
                        Console.SetCursorPosition(x, bottom);
                        Console.Write("  ");
                        NewY = bottom;
                    }
                    Console.SetCursorPosition(x, NewY);
                    Console.Write(Pointer);
                }

                if (input.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(x, NewY);
                    Console.Write("  ");
                    NewY++;

                    if (NewY > bottom)
                    {
                        Console.SetCursorPosition(x, bottom);
                        Console.Write("  ");
                        NewY = top;
                    }
                    Console.SetCursorPosition(x, NewY);
                    Console.Write(Pointer);
                }

                if (input.Key == ConsoleKey.Enter)
                {
                    if (NewY == y1)
                    {
                        Console.SetCursorPosition(0, y4);
                        Console.ForegroundColor = Color2;
                        Console.Write(a1);
                        break;
                    }
                    else
                    if (NewY == y2)
                    {
                        Console.SetCursorPosition(0, y4);
                        Console.ForegroundColor = Color2;
                        Console.Write(a2);
                        break;
                    }
                    else
                    if (NewY == y3)
                    {
                        Console.SetCursorPosition(0, y4);
                        Console.ForegroundColor = Color2;
                        Console.Write(a3);
                        break;
                    }

                }
            }
        }
    }
}
