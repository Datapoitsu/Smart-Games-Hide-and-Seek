using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_N_Seek
{
    class Square
    {
        public int[] cell;
        public Square(int[] data)
        {
            cell = data;
        }
    }

    class Tile
    {
        public bool[] cell;
        public Tile(bool[] data)
        {
           cell = data;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Square[] squares = new Square[0];
                Tile[] tiles = new Tile[0];
                string[] objectNames = new string[0];

                Console.WriteLine("Choose game: ");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Hide & Seek Safari");
                Console.WriteLine("2. Hide & Seek Pirates");
                bool validChoice = int.TryParse(Console.ReadLine(), out int choice);
                if(!validChoice)
                {
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        return;
                    case 1:

                        squares = new Square[] //Matches with object names array.
                        {
                        new Square(new int[]{0,-1,1,2,4,2,3,1,0}),
                        new Square(new int[]{4,-1,1,-1,2,0,1,3,4}),
                        new Square(new int[]{3,0,2,4,-1,4,1,-1,3}),
                        new Square(new int[]{-1,-1,-1,-1,3,1,4,0,2}),
                        };

                        tiles = new Tile[]
                        {
                        new Tile(new bool[]{true,false,true,true,true,true,true,false,true}), //H-piece
                        new Tile(new bool[]{true,false,true,true,false,true,true,true,true}), //U-piece
                        new Tile(new bool[]{true,true,false,false,true,true,false,true,true}),//b-piece
                        new Tile(new bool[]{true,true,false,true,true,true,true,false,true}), //R-piece
                        };

                        objectNames = new string[] { "Elephant", "Lion", "Zebra", "Rhino", "Gazelle" };

                        break;

                    case 2:
                        squares = new Square[] //Matches with object names array.
                        {
                        new Square(new int[]{0,-1,0,-1,-1,-1,1,-1,2}),
                        new Square(new int[]{-1,-1,2,-1,3,-1,4,-1,1}),
                        new Square(new int[]{3,-1,1,-1,4,-1,-1,-1,1}),
                        new Square(new int[]{0,-1,3,-1,1,-1,-1,-1,4}),
                        };

                        tiles = new Tile[]
                        {
                        new Tile(new bool[]{true,true,true,true,true,true,false,true,false}), //Sign-piece
                        new Tile(new bool[]{true,true,false,true,false,true,true,true,true}),//L-piece
                        new Tile(new bool[]{true,true,false, true, true,true, true, true,true}),//Top right empty piece
                        new Tile(new bool[]{true,true,false,true,true,true,false, true, true}), //Top right & bottom left empty piece
                        };

                        objectNames = new string[] { "Rowing boat", "White sailboat", "Cave island", "Red sailboat", "Pirate island" };
                        break;
                    default:
                        continue;
                }

                int[] animals = new int[objectNames.Length];
                for (int i = 0; i < objectNames.Length; i++)
                {
                    Console.Write("How many " + objectNames[i] + ": ");
                    animals[i] = int.Parse(Console.ReadLine());
                }

                Console.OutputEncoding = System.Text.Encoding.Unicode;

                int[] solution = new int[4];
                while (true)
                {
                    if (checkResult(solution, squares, tiles, animals))
                    {
                        showSolution(solution, tiles);
                        break;
                    }
                    if (solution[0] == 15 && solution[1] == 15 && solution[2] == 15 && solution[3] == 15)
                    {
                        Console.WriteLine("No solution! Check your input.");
                        break;
                    }
                    increase(solution, 3);
                }
                Console.ReadLine();
            }
            
        }

        static public int[] increase(int[] data, int index)
        {
            data[index] = (data[index] + 1) % 16;
            if (data[index] == 0 && index > 0)
            {
                return increase(data, index -1);
            }
            return data;
        }

        public static bool[] rotate(bool[] data, int index)
        {
            bool[] Copy = new bool[data.Length];
            Array.Copy(data, Copy, data.Length);
            if (index <= 0)
            {
                return Copy;
            }

            int size = (int)Math.Sqrt(data.Length);
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    Copy[y * size + x] = data[((y * size + x) + (data.Length - size + (-size - 1) * x + (-size + 1) * y))];
                }
            }

            return rotate(Copy, index - 1);
        }

        static public bool sameArray(int[] a, int[] b)
        {
            if(a.Length != b.Length)
            {
                return false;
            }
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }

        static public bool noDublicates(int[] data)
        {
            for(int i = 0; i < data.Length; i++)
            {
                for(int k = 0; k < data.Length; k++)
                {
                    if(i != k && data[i] == data[k])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool checkResult(int[] data, Square[] square, Tile[] tiles, int[] desiredResult)
        {
            //Checks if inputted data is valid.
            int[] holder = (int[])data.Clone();
            for(int i = 0; i < holder.Length; i++)
            {
                holder[i] %= 4;
            }
            if (!noDublicates(holder))
            { 
                return false;
            }
            
            int[] items = new int[desiredResult.Length];
            for (int i = 0; i < data.Length; i++)
            {
                Tile T = tiles[data[i] % 4];
                int rotateAmount = (int)Math.Floor(data[i] / 4.0);
                bool[] currentTile = rotate(T.cell,rotateAmount);
                for(int k = 0; k < currentTile.Length; k++)
                {
                    if (currentTile[k] == false)
                    {
                        if(square[i].cell[k] != -1)
                        {
                            items[square[i].cell[k]]++;
                        }
                    }

                    for (int j = 0; j < desiredResult.Length; j++)
                    {
                        if (items[i] > desiredResult[i])
                        {
                            return false;
                        }
                    }
                }
            }

            return sameArray(items, desiredResult);
        }

        static public void showSolution(int[] data, Tile[] tiles)
        {
            Tile[] T = new Tile[tiles.Length];
            for (int i = 0; i < 4; i++)
            {
                T[i] = tiles[data[i] % 4];
                T[i].cell = rotate(T[i].cell, (int)Math.Floor(data[i] / 4.0));
            }
            char merkki;


            for (int i = 0; i < 9; i++)
            {
                Console.Write(" ");
            }
            Console.Write("\n");

            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write(" ");
                    for (int i = 0 + j * 3; i < 3 + j * 3; i++)
                    {
                        if (T[k].cell[i] == true)
                        {
                            merkki = '█';
                        }
                        else
                        {
                            merkki = ' ';
                        }
                        Console.Write(merkki);
                    }
                }
                Console.Write(" \n");
            }

            for (int i = 0; i < 9; i++)
            {
                Console.Write(" ");
            }
            Console.Write("\n");

            for (int j = 0; j < 3; j++)
            {
                for (int k = 2; k < 4; k++)
                {
                    Console.Write(" ");
                    for (int i = 0 + j * 3; i < 3 + j * 3; i++)
                    {
                        if (T[k].cell[i] == true)
                        {
                            merkki = '█';
                        }
                        else
                        {
                            merkki = ' ';
                        }
                        Console.Write(merkki);
                    }
                }
                Console.Write(" \n");
            }

            for (int i = 0; i < 9; i++)
            {
                Console.Write(" ");
            }
            Console.Write("\n");
        }
    }
}
