using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puzzle
{
    class game2 : game1
    {
        public game2(int[] tiles) : base(tiles) { Randomize(); }

        public virtual void Randomize()
        {
            Random Generator = new Random();
            for (int i = gameField.Length; i >= 0; i--)
            {
                int x1 = Generator.Next(gameField.GetLength(0));
                int x2 = Generator.Next(gameField.GetLength(1));
                int y1 = Generator.Next(gameField.GetLength(0));
                int y2 = Generator.Next(gameField.GetLength(1));

                MoveTile(ref gameField[x1, y1], ref gameField[x2, y2]);
            }
        }

        public override void Shift(int value)
        {
            base.Shift(value);
        }

        public bool IsFinished()
        {
            int[] RightOrderofTiles = new int[gameField.Length];
            for (int i = 0; i < RightOrderofTiles.Length; i++)
                RightOrderofTiles[i] = i;

            int count = 0;
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    if (gameField[i, j] != RightOrderofTiles[count])
                        return false;

                    count++;
                }
            }
            return true;
        }
    }
}
