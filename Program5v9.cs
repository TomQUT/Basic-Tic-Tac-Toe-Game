namespace ConsoleApp6
{
    internal class Program
    {
        static void Main()
        {
            string[] grid = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };
            bool xturn = true;
            int turns = 0;
            Console.WriteLine("Noughts and crosses!");
            Console.WriteLine("  a   b   c" + "");
            Console.WriteLine($"1 {grid[0]} | {grid[1]} | {grid[2]} ");
            Console.WriteLine(" ---+---+---");
            Console.WriteLine($"2 {grid[3]} | {grid[4]} | {grid[5]} ");
            Console.WriteLine(" ---+---+---");
            Console.WriteLine($"3 {grid[6]} | {grid[7]} | {grid[8]} ");
            while (true)
            {
                if (xturn)
                {
                    Console.WriteLine("X's turn to play:");
                }
                else
                {
                    Console.WriteLine("O's turn to play:");
                }
                string move = Console.ReadLine();
                int index = -1;
                switch (move)
                {
                    case "a1": index = 0; break;
                    case "b1": index = 1; break;
                    case "c1": index = 2; break;
                    case "a2": index = 3; break;
                    case "b2": index = 4; break;
                    case "c2": index = 5; break;
                    case "a3": index = 6; break;
                    case "b3": index = 7; break;
                    case "c3": index = 8; break;
                    default:
                        Console.WriteLine("Invalid position. Position must be of the format a1 and be on the board.");
                        Console.WriteLine();
                        continue;
                }
                if (grid[index] != " ")
                {
                    Console.WriteLine("Invalid position. Position must be unoccupied.");
                    continue;
                }
                if (xturn)
                {
                    grid[index] = "X";
                }
                else
                {
                    grid[index] = "O";
                }
                Console.WriteLine("  a   b   c" + "");
                Console.WriteLine($"1 {grid[0]} | {grid[1]} | {grid[2]} ");
                Console.WriteLine(" ---+---+---");
                Console.WriteLine($"2 {grid[3]} | {grid[4]} | {grid[5]} ");
                Console.WriteLine(" ---+---+---");
                Console.WriteLine($"3 {grid[6]} | {grid[7]} | {grid[8]} ");
                turns++;
                if (bragging_rights(grid))
                {
                    if (xturn)
                    {
                        Console.WriteLine("X wins!");
                    }
                    else
                    {
                        Console.WriteLine("O wins!");
                    }
                    break;
                }
                if (turns == 9)
                {
                    Console.WriteLine("It's a tie!");
                    break;
                }
                xturn = !xturn;
            }
        }
        static bool bragging_rights(string[] grid)
        {
            if (grid[0] == grid[1] && grid[1] == grid[2] && grid[0] != " ") return true;
            if (grid[3] == grid[4] && grid[4] == grid[5] && grid[3] != " ") return true;
            if (grid[6] == grid[7] && grid[7] == grid[8] && grid[6] != " ") return true;
            if (grid[0] == grid[3] && grid[3] == grid[6] && grid[0] != " ") return true;
            if (grid[1] == grid[4] && grid[4] == grid[7] && grid[1] != " ") return true;
            if (grid[2] == grid[5] && grid[5] == grid[8] && grid[2] != " ") return true;
            if (grid[0] == grid[4] && grid[4] == grid[8] && grid[0] != " ") return true;
            if (grid[2] == grid[4] && grid[4] == grid[6] && grid[2] != " ") return true;
            return false;
        }
    }
}

