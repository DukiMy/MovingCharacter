using System;

namespace MovingCharacter
{
    class Program
    {
        static public int StartPosX { get; set; } = 50;

        static public int StartPosY { get; set; } = 20;

        public static void TestMoveDown(int x, int y)
        {
            do
            {
                y++;

                // Delete
                Console.SetCursorPosition(x - 1, y - 1);
                Console.WriteLine($"{new string("   ")}");

                Console.SetCursorPosition(x - 1, y);
                Console.WriteLine($"{new string(" ")}");

                Console.SetCursorPosition(x + 1, y);
                Console.WriteLine($"{new string(" ")}");

                // Write
                Console.SetCursorPosition(x, y);
                Console.WriteLine($"{new string("■")}");

                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine($"{new string("|")}");

                Console.SetCursorPosition(x - 1, y + 1);
                Console.WriteLine($"{new string("-")}");

                Console.SetCursorPosition(x + 1, y + 1);
                Console.WriteLine($"{new string("-")}");

                Console.SetCursorPosition(x - 1, y + 2);
                Console.WriteLine($"{new string("| |")}");

                StartPosY = y;

            } while (1 + 1 == 0);
        }

        public static void TestMoveUp(int x, int y)
        {
            do
            {
                y--;

                // Delete
                Console.SetCursorPosition(x - 1, y + 3);
                Console.WriteLine($"{new string("   ")}");

                // Write
                Console.SetCursorPosition(x, y);
                Console.WriteLine($"{new string("■")}");

                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine($"{new string("|")}");

                Console.SetCursorPosition(x - 1, y + 1);
                Console.WriteLine($"{new string("-")}");

                Console.SetCursorPosition(x + 1, y + 1);
                Console.WriteLine($"{new string("-")}");

                Console.SetCursorPosition(x - 1, y + 2);
                Console.WriteLine($"{new string("| |")}");

                StartPosY = y;

            } while (1 + 1 == 0);
        }

        public static void TestMoveLeft(int x, int y)
        {
            do
            {
                x--;

                // Delete
                Console.SetCursorPosition(x + 1, y);
                Console.WriteLine($"{new string(" ")}");

                Console.SetCursorPosition(x + 2, y + 1);
                Console.WriteLine($"{new string(" ")}");

                Console.SetCursorPosition(x + 2, y + 2);
                Console.WriteLine($"{new string(" ")}");

                // Write
                Console.SetCursorPosition(x, y);
                Console.WriteLine($"{new string("■")}");

                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine($"{new string("|")}");

                Console.SetCursorPosition(x - 1, y + 1);
                Console.WriteLine($"{new string("-")}");

                Console.SetCursorPosition(x + 1, y + 1);
                Console.WriteLine($"{new string("-")}");

                Console.SetCursorPosition(x - 1, y + 2);
                Console.WriteLine($"{new string("| |")}");

                StartPosX = x;

            } while (1 + 1 == 0);
        }

        public static void TestMoveRight(int x, int y)
        {
            do
            {
                x++;
                // Delete
                Console.SetCursorPosition(x - 1, y);
                Console.WriteLine($"{new string(" ")}");

                Console.SetCursorPosition(x - 2, y + 1);
                Console.WriteLine($"{new string(" ")}");

                Console.SetCursorPosition(x - 2, y + 2);
                Console.WriteLine($"{new string(" ")}");

                // Write
                Console.SetCursorPosition(x, y);
                Console.WriteLine($"{new string("■")}");

                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine($"{new string("|")}");

                Console.SetCursorPosition(x - 1, y + 1);
                Console.WriteLine($"{new string("-")}");

                Console.SetCursorPosition(x + 1, y + 1);
                Console.WriteLine($"{new string("-")}");

                Console.SetCursorPosition(x - 1, y + 2);
                Console.WriteLine($"{new string("| |")}");

                StartPosX = x;

            } while (1 + 1 == 0);
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
                }

            } while (loop);

            return (char)result;
        }

        public static void Controls()
        {
            while (1 + 1 == 2)
            {
                switch (Input())
                {
                    case 'W':
                        TestMoveUp(StartPosX, StartPosY);
                        break;

                    case 'A':
                        TestMoveLeft(StartPosX, StartPosY);
                        break;

                    case 'S':
                        TestMoveDown(StartPosX, StartPosY);
                        break;

                    case 'D':
                        TestMoveRight(StartPosX, StartPosY);
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Tryck på 'W', 'A', 'S'  eller 'D'.");

            Program.Controls();
        }
    }
}
