using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_N_Seek
{    
    internal class Program
    {
        static int[][][] presetChallenges = new int[][][] //[Game][problem][objectcount]
        {
            new int[][] //Safari
            {
                new int[]{0,5,0,0,0,0 }, //Starter 1
                new int[]{0,0,0,0,0,5 },
                new int[]{0,0,4,0,0,0 },
                new int[]{0,0,0,4,3,0 },
                new int[]{0,0,1,0,0,6 },
                new int[]{0,0,3,0,3,0 },
                new int[]{0,3,0,0,4,0 },
                new int[]{0,0,3,1,0,0 },
                new int[]{0,3,4,0,0,0 },
                new int[]{0,0,0,0,3,2 },
                new int[]{0,0,0,1,0,2 },
                new int[]{0,0,0,4,0,3 },
                new int[]{0,1,0,0,0,3 }, //Junior 12
                new int[]{0,2,2,0,0,0 },
                new int[]{0,2,0,5,0,0 },
                new int[]{0,0,0,2,1,1 },
                new int[]{0,2,3,0,2,2 },
                new int[]{0,1,0,0,1,1 },
                new int[]{0,2,0,5,0,0 },
                new int[]{0,0,1,1,0,1 },
                new int[]{0,3,3,2,1,0 },
                new int[]{0,1,0,1,1,0 },
                new int[]{0,0,4,1,0,1 },
                new int[]{0,1,0,1,1,1 },
                new int[]{0,1,1,0,0,5 }, //Expert 25
                new int[]{0,0,4,1,1,0 },
                new int[]{0,0,0,3,3,1 },
                new int[]{0,4,3,1,0,0 },
                new int[]{0,3,2,0,3,0 },
                new int[]{0,1,3,0,2,0 },
                new int[]{0,2,0,0,2,1 },
                new int[]{0,0,3,0,3,1 },
                new int[]{0,1,0,2,0,1 },
                new int[]{0,0,2,2,4,0 },
                new int[]{0,2,3,0,3,0 },
                new int[]{0,1,0,2,2,0 },
                new int[]{0,2,1,2,3,1 }, //Master 37
                new int[]{0,4,0,1,0,1 },
                new int[]{0,3,0,0,2,2 },
                new int[]{0,0,1,0,3,2 },
                new int[]{0,4,2,0,0,1 },
                new int[]{0,1,0,4,0,1 },
                new int[]{0,4,0,1,0,2 },
                new int[]{0,0,3,3,1,0 },
                new int[]{0,2,2,2,0,2 },
                new int[]{0,1,4,1,1,0 },
                new int[]{0,2,3,2,0,0 },
                new int[]{0,3,1,1,1,2 },
            },
            new int[][] //Pirates  //{"Empty", "Rowing boat", "White sailboat", "Cave island", "Red sailboat", "Pirate island" };
            {
                new int[]{0,0,5,0,0,0 }, //Starter 1
                new int[]{0,0,0,2,3,0 },
                new int[]{0,3,0,0,0,2 },
                new int[]{0,0,0,2,0,2 },
                new int[]{0,0,0,1,3,0 },
                new int[]{0,2,0,2,3,0 },
                new int[]{0,0,1,2,0,0 },
                new int[]{0,2,5,0,0,0 },
                new int[]{0,0,1,0,3,0 },
                new int[]{0,0,0,2,0,3 },
                new int[]{0,2,0,0,3,0 },
                new int[]{0,0,0,2,1,0 },
                new int[]{0,0,5,0,1,0 }, //Junior 13
                new int[]{0,0,2,2,3,0 },
                new int[]{0,0,0,2,2,3 },
                new int[]{0,0,3,0,3,0 },
                new int[]{0,0,3,0,0,0 },
                new int[]{0,2,0,0,3,1 },
                new int[]{0,1,0,2,1,3 },
                new int[]{0,1,5,0,0,1 },
                new int[]{0,0,1,1,3,2 },
                new int[]{0,0,1,1,2,3 },
                new int[]{0,0,1,0,1,1 },
                new int[]{0,0,1,2,3,1 },
                new int[]{0,0,3,0,3,1 }, //Expert 25
                new int[]{0,0,1,0,1,2 },
                new int[]{0,0,1,0,2,0 },
                new int[]{0,0,0,1,2,2 },
                new int[]{0,0,4,0,0,2 },
                new int[]{0,0,4,0,2,1 },
                new int[]{0,0,1,2,2,2 },
                new int[]{0,0,0,1,1,1 },
                new int[]{0,1,0,2,0,3 },
                new int[]{0,1,0,1,3,2 },
                new int[]{0,0,0,1,3,1 },
                new int[]{0,0,0,1,2,0 },
                new int[]{0,3,1,1,1,0 }, //Master 37
                new int[]{0,2,0,1,1,0 },
                new int[]{0,0,4,1,0,2 },
                new int[]{0,2,1,2,0,0 },
                new int[]{0,2,0,1,3,1 },
                new int[]{0,0,0,2,2,2 },
                new int[]{0,2,0,2,1,0 },
                new int[]{0,0,2,1,2,2 },
                new int[]{0,0,1,0,2,2 },
                new int[]{0,0,4,0,1,2 },
                new int[]{0,1,1,0,2,3 },
                new int[]{0,0,0,1,1,2 },
            }
        };
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int[][] squares;
            bool[][] tiles;
            string[] objectNames;
            int emptyCount = 0; //Amount of holes in the pieces.

            while (true)
            {
                Console.WriteLine("Choose game: ");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Hide & Seek Safari");
                Console.WriteLine("2. Hide & Seek Pirates");
                bool validChoice = int.TryParse(Console.ReadLine(), out int gameChoice);
                if(!validChoice)
                {
                    continue;
                }

                switch (gameChoice)
                {
                    case 0:
                        return;
                    case 1: //Hide and Seek Safari

                        squares = new int[][] //Matches with object names array.
                        {
                            new int[]{1,0,2,3,5,3,4,2,1},
                            new int[]{5,0,2,0,3,1,2,4,5},
                            new int[]{4,1,3,5,0,5,2,0,4},
                            new int[]{0,0,0,0,4,2,5,1,3},
                        };

                        tiles = new bool[][]
                        {
                            new bool[]{true,false,true,true,true,true,true,false,true}, //H-piece
                            new bool[]{true,false,true,true,false,true,true,true,true}, //U-piece
                            new bool[]{true,true,false,false,true,true,false,true,true},//b-piece
                            new bool[]{true,true,false,true,true,true,true,false,true}, //R-piece
                        };
                        emptyCount = 9;
                        objectNames = new string[] {"Empty", "Elephant", "Lion", "Zebra", "Rhino", "Gazelle"};

                        break;

                    case 2: //Hide and Seek Pirates
                        squares = new int[][] //Matches with object names array.
                        {
                            new int[]{1,0,1,0,0,0,2,0,3},
                            new int[]{0,0,3,0,4,0,5,0,2},
                            new int[]{4,0,2,0,5,0,0,0,2},
                            new int[]{1,0,4,0,2,0,0,0,5},
                        };

                        tiles = new bool[][]
                        {
                            new bool[]{true,true,true,true,true,true,false,true,false}, //Sign-piece
                            new bool[]{true,true,false,true,false,true,true,true,true},//L-piece
                            new bool[]{true,true,false, true, true,true, true, true,true},//Top right empty piece
                            new bool[]{true,true,false,true,true,true,false, true, true}, //Top right & bottom left empty piece
                        };
                        emptyCount = 7;
                        objectNames = new string[] {"Empty", "Rowing boat", "White sailboat", "Cave island", "Red sailboat", "Pirate island" };
                        break;
                    default:
                        continue;
                }

                Console.WriteLine("Choose the puzzle from 1-" + presetChallenges[gameChoice - 1].Length + " or zero to input your own choice");
                validChoice = int.TryParse(Console.ReadLine(), out int problemChoice);
                if (!validChoice)
                {
                    continue;
                }

                int[] desiredResult = new int[objectNames.Length];
                desiredResult[0] = emptyCount;
                if (problemChoice == 0)
                {
                    //User inputs the amount of things to find.
                    desiredResult[0] = emptyCount;
                    for (int i = 1; i < objectNames.Length; i++)
                    {
                        Console.Write("How many " + objectNames[i] + ": ");
                        desiredResult[i] = int.Parse(Console.ReadLine());
                        desiredResult[0] -= desiredResult[i];
                    }
                }
                else if (problemChoice > 0) //Preset values
                {
                    desiredResult = presetChallenges[gameChoice - 1][problemChoice - 1];
                    desiredResult[0] = emptyCount - (desiredResult[1] + desiredResult[2] + desiredResult[3] + desiredResult[4] + desiredResult[5]);
                }

                int[] solution = new int[4];
                while (true)
                {
                    if (checkResult(solution, squares, tiles, desiredResult))
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

        public static bool checkResult(int[] data, int[][] square, bool[][] tiles, int[] desiredResult)
        {
            if (data[0] == 6 && data[1] == 4 && data[2] == 1 && data[3] == 3)
            {
                //Console.WriteLine("haluttu tulos: " + desiredResult[0] + ", " + desiredResult[1] + ", " + desiredResult[2] + ", " + desiredResult[3] + ", " + desiredResult[4] + ", " + desiredResult[5]);
            }
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
            for (int i = 0; i < data.Length; i++) //Jokainen laatta.
            {
                bool[] T = tiles[data[i] % 4];
                int rotateAmount = (int)Math.Floor(data[i] / 4.0);
                bool[] currentTile = rotate(T,rotateAmount);
                for(int k = 0; k < currentTile.Length; k++) //Laatan ruudut.
                {
                    if (currentTile[k] == false)
                    {
                        items[square[i][k]]++;
                    }

                    for (int j = 0; j < desiredResult.Length; j++)
                    {
                        if (items[i] > desiredResult[i])
                        {
                            if (data[0] == 6 && data[1] == 4 && data[2] == 1 && data[3] == 3)
                            {
                                //Console.WriteLine("liian monta " + i + "");
                                //Console.WriteLine("Nyt on " + items[i] + ", pitäisi olla " + desiredResult[i]);
                            }
                            return false;
                        }
                    }
                }
            }
            //if (data[0] == 6 && data[1] == 4 && data[2] == 1 && data[3] == 3)
                //Console.WriteLine("Items: " + items[0] + ", " + items[1] + ", " + items[2] + ", " + items[3] + ", " + items[4] + ", " + items[5]);
            return sameArray(items, desiredResult);
        }

        static public void showSolution(int[] data, bool[][] tiles)
        {
            //Console.WriteLine("Tulos: " + data[0] + ", " + data[1] + ", " + data[2] + ", " + data[3]);
            bool[][] T = new bool[tiles.GetLength(0)][];
            for (int i = 0; i < 4; i++)
            {
                T[i] = rotate(tiles[data[i] % 4], (int)Math.Floor(data[i] / 4.0));
            }

            for (int i = 0; i < 9; i++)
            {
                Console.Write(" ");
            }
            Console.Write("\n");

            for(int l = 0; l < 2; l++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0 + 2 * l; k < 2 + 2 * l; k++)
                    {
                        Console.Write(" ");
                        for (int i = 0 + j * 3; i < 3 + j * 3; i++)
                        {
                            char merkki = ' ';
                            if (T[k][i] == true)
                            {
                                merkki = '█';
                            }
                            Console.Write(merkki);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            

        }
    }
}