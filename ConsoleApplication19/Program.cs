using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\user\\Desktop\\1.txt";

            int[] tiles = new int[] { 1, 2, 4, 6, 7, 8, 5, 3, 0 };
            int[] NotRandomTiles = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 0 };
            Console.WriteLine("Пятнашки 0");
            game1 puzzle0 = new game1(tiles);
            Console.WriteLine(puzzle0.GetLocation(2));
            Console.WriteLine();
            print.ShowGameCondition(puzzle0);
            puzzle0.Shift(8);
            print.ShowGameCondition(puzzle0);
            puzzle0.Shift(7);
            print.ShowGameCondition(puzzle0);

          

            Console.WriteLine("Пятнашки 2");
            game3 puzzle2 = new game3(tiles);
            print.ShowGameCondition(puzzle2);
            print.ShowGameCondition(puzzle2);
            puzzle2.Shift(8);
            print.ShowGameCondition(puzzle2);
            puzzle2.Shift(7);
            print.ShowGameCondition(puzzle2);
            foreach (int element in puzzle2.history)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Отменяем действие в пятнашках 2");
            puzzle2.Undo();
            print.ShowGameCondition(puzzle2);
            foreach (int element in puzzle2.history)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Перемешиваем плитки в пятнашках 2");
            puzzle2.Randomize();
            print.ShowGameCondition(puzzle2);
            foreach (int element in puzzle2.history)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
