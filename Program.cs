using System;

namespace MovingCharacter
{
    class Program
    {
        static public int StartPosX { get; set; } = 50;

        static public int StartPosY { get; set; } = 20;

        public static void PrintPlayer(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write($"{new string("■")}");    // Prints head.

            Console.SetCursorPosition(x, y + 1);
            Console.Write($"{new string("|")}");    // Prints torso.

            Console.SetCursorPosition(x - 1, y + 1);
            Console.Write($"{new string("-")}");    // Prints left arm.

            Console.SetCursorPosition(x + 1, y + 1);
            Console.Write($"{new string("-")}");    // Prints right arm.

            Console.SetCursorPosition(x - 1, y + 2);
            Console.Write($"{new string("| |")}");  // Prints legs.

            Console.SetCursorPosition(0, 0);

        }

        public static void MoveDown(int x, int y)
        {
            y++;

            try
            {
                // Delete
                Console.SetCursorPosition(x - 1, y - 1);
                Console.Write($"{new string("   ")}");

                Console.SetCursorPosition(x - 1, y);
                Console.Write($"{new string(" ")}");

                Console.SetCursorPosition(x + 1, y);
                Console.Write($"{new string(" ")}");

                // Write
                PrintPlayer(x, y);
            }
            catch (Exception)
            {
                y -= 1;
                Console.SetCursorPosition(0, 0);
            }

            StartPosY = y;
        }

        public static void MoveUp(int x, int y)
        {
            y--;

            try
            {
                // Delete
                Console.SetCursorPosition(x - 1, y + 3);
                Console.Write($"{new string("   ")}");

                // Write
                PrintPlayer(x, y);
            }
            catch (Exception)
            {
                y += 1;
                Console.SetCursorPosition(0, 0);
            }

            StartPosY = y;
        }

        public static void MoveLeft(int x, int y)
        {
            x--;

            try
            {
                // Delete
                Console.SetCursorPosition(x + 1, y);
                Console.Write($"{new string(" ")}");

                Console.SetCursorPosition(x + 2, y + 1);
                Console.Write($"{new string(" ")}");

                Console.SetCursorPosition(x + 2, y + 2);
                Console.Write($"{new string(" ")}");

                // Write
                PrintPlayer(x, y);
            }
            catch (Exception)
            {
                x += 1;
                Console.SetCursorPosition(0, 0);
            }

            StartPosX = x;
        }

        public static void MoveRight(int x, int y)
        {
            x++;


            try
            {
                // Delete
                Console.SetCursorPosition(x - 1, y);
                Console.Write($"{new string(" ")}");

                Console.SetCursorPosition(x - 2, y + 1);
                Console.Write($"{new string(" ")}");

                Console.SetCursorPosition(x - 2, y + 2);
                Console.Write($"{new string(" ")}");

                // Write
                PrintPlayer(x, y);
            }
            catch (Exception)
            {
                x -= 1;
                Console.SetCursorPosition(0, 0);
            }

            StartPosX = x;
        }

        public static char Input()
        {
            ConsoleKey result = ConsoleKey.X;
            bool loop = true;

            do
            {
                result = Console.ReadKey().Key;

                if (result == ConsoleKey.W || result == ConsoleKey.A || result == ConsoleKey.S || result == ConsoleKey.D)
                {
                    loop = false;
                }

                else
                {
                    Console.Beep(500, 90);
                    Console.Beep(350, 200);
                    Console.SetCursorPosition(0, 0);

                }

            } while (loop);

            return (char)result;
        }

        public static void Controls()
        {
            PrintPlayer(StartPosX, StartPosY);

            while (1 + 1 == 2)
            {
                switch (Input())
                {
                    case 'W':
                        MoveUp(StartPosX, StartPosY);
                        break;

                    case 'A':
                        MoveLeft(StartPosX, StartPosY);
                        break;

                    case 'S':
                        MoveDown(StartPosX, StartPosY);
                        break;

                    case 'D':
                        MoveRight(StartPosX, StartPosY);
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Tryck på 'W', 'A', 'S'  eller 'D'.");
            Console.CursorVisible = false;
            Program.Controls();
        }
    }
}
