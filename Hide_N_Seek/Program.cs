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
                new int[]{0,0,0,0,5,0 },
                new int[]{0,0,4,0,0,0 },
                new int[]{0,0,0,4,0,3 },
                new int[]{0,0,1,0,6,0 },
                new int[]{0,0,3,0,0,3 },
                new int[]{0,3,0,0,0,4 },
                new int[]{0,0,3,1,0,0 },
                new int[]{0,3,4,0,0,0 },
                new int[]{0,0,0,0,2,3 },
                new int[]{0,0,0,1,2,0 },
                new int[]{0,0,0,4,3,0 },
                new int[]{0,1,0,0,3,0 }, //Junior 12
                new int[]{0,2,2,0,0,0 },
                new int[]{0,2,0,5,0,0 },
                new int[]{0,0,0,2,1,1 },
                new int[]{0,2,3,0,2,2 },
                new int[]{0,1,0,0,1,1 },
                new int[]{0,2,0,5,0,0 },
                new int[]{0,0,1,1,1,0 },
                new int[]{0,3,3,2,0,1 },
                new int[]{0,1,0,1,0,1 },
                new int[]{0,0,4,1,1,0 },
                new int[]{0,1,0,1,1,1 },
                new int[]{0,1,1,0,5,0 }, //Expert 25
                new int[]{0,0,4,1,0,1 },
                new int[]{0,0,0,3,1,3 },
                new int[]{0,4,3,1,0,0 },
                new int[]{0,3,2,0,0,3 },
                new int[]{0,1,3,0,0,2 },
                new int[]{0,2,0,0,1,2 },
                new int[]{0,0,3,0,1,3 },
                new int[]{0,1,0,2,1,0 },
                new int[]{0,0,2,2,0,4 },
                new int[]{0,2,3,0,0,3 },
                new int[]{0,1,0,2,0,2 },
                new int[]{0,2,1,2,1,3 }, //Master 37
                new int[]{0,4,0,1,1,0 },
                new int[]{0,3,0,0,2,2 },
                new int[]{0,0,1,0,2,3 },
                new int[]{0,4,2,0,1,0 },
                new int[]{0,1,0,4,1,0 },
                new int[]{0,4,0,1,2,0 },
                new int[]{0,0,3,3,0,1 },
                new int[]{0,2,2,2,2,0 },
                new int[]{0,1,4,1,0,1 },
                new int[]{0,2,3,2,0,0 },
                new int[]{0,3,1,1,2,1 },
            },
            new int[][] //Pirates
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
            },
            new int[][] //Monsters
            {
                new int[]{0,0,0,0,0,0,0,7,0},//Starter 1
                new int[]{0,0,0,0,4,0,0,0,0},
                new int[]{0,0,0,4,0,0,0,0,0},
                new int[]{0,4,0,0,0,0,0,0,0},
                new int[]{0,0,1,3,0,0,0,0,0},
                new int[]{0,0,0,3,0,1,0,0,0},
                new int[]{0,2,2,0,0,0,1,0,0},
                new int[]{0,0,0,3,0,0,1,0,0},
                new int[]{0,0,0,2,0,0,0,3,0},
                new int[]{0,0,2,2,0,0,1,0,0},
                new int[]{0,2,0,1,0,2,0,0,0},
                new int[]{0,1,0,0,1,2,0,1,0},
                new int[]{0,0,0,0,2,0,0,0,1},
                new int[]{0,3,0,0,0,0,0,0,2},
                new int[]{0,0,1,0,0,1,1,0,1},
                new int[]{0,0,0,0,3,0,1,0,0},
                new int[]{0,0,0,0,1,0,0,1,0},//Junior 17
                new int[]{0,3,0,0,0,0,0,1,0},
                new int[]{0,0,0,0,0,0,0,0,0},
                new int[]{0,0,0,2,0,0,0,0,1},
                new int[]{0,2,0,1,0,0,0,0,2},
                new int[]{0,0,0,0,2,1,0,1,0},
                new int[]{0,0,0,0,2,0,0,3,0},
                new int[]{0,0,2,0,1,1,0,2,0},
                new int[]{0,0,2,2,1,0,1,0,0},
                new int[]{0,0,2,1,0,1,0,3,0},
                new int[]{0,0,0,4,1,0,0,0,1},
                new int[]{0,0,0,0,3,0,1,2,0},
                new int[]{0,0,0,0,0,0,0,0,0},
                new int[]{0,0,0,0,0,1,1,2,0},
                new int[]{0,0,2,0,2,1,0,1,0},
                new int[]{0,0,0,3,1,0,0,3,0},
                new int[]{0,3,0,0,1,0,0,3,0},
                new int[]{0,1,0,1,0,1,0,3,0},
                new int[]{0,1,0,0,0,0,0,2,1}, //Expert 33
                new int[]{0,0,1,3,0,1,0,1,0},
                new int[]{0,0,0,0,1,1,1,1,0},
                new int[]{0,1,0,0,0,0,2,3,0},
                new int[]{0,1,1,1,1,1,0,0,2},
                new int[]{0,0,0,2,1,1,0,0,0},
                new int[]{0,0,0,2,2,1,2,0,0},
                new int[]{0,2,0,0,0,0,0,3,1},
                new int[]{0,2,0,0,2,0,0,0,0},
                new int[]{0,0,0,0,2,0,0,2,1},
                new int[]{0,0,1,0,0,1,1,1,1},
                new int[]{0,0,1,0,3,1,0,2,0},
                new int[]{0,0,0,0,1,1,1,2,0},
                new int[]{0,0,0,2,1,0,2,0,0},
                new int[]{0,1,1,0,0,0,2,0,0},
                new int[]{0,2,1,1,0,0,2,0,0},
                new int[]{0,0,0,0,0,0,0,0,0},//Master 49
                new int[]{0,0,0,2,0,0,0,2,0},
                new int[]{0,0,0,2,1,0,1,0,0},
                new int[]{0,2,1,0,0,1,0,1,0},
                new int[]{0,1,0,0,1,0,1,0,2},
                new int[]{0,0,0,2,0,0,1,0,1},
                new int[]{0,1,0,1,0,1,1,1,0},
                new int[]{0,2,0,0,0,1,2,2,0},
                new int[]{0,1,0,0,1,1,0,0,1},
                new int[]{0,0,0,0,2,0,2,2,0},
                new int[]{0,1,1,0,1,1,0,0,1},
                new int[]{0,1,0,0,0,1,1,2,0},
                new int[]{0,0,0,1,2,0,1,0,0},
            },
            new int[][] //Dora is searching for her friends
            {

            },
            new int[][] //Hide & Seek Canada Cache-Cahce
            {

            },
            new int[][] //Hide & Seek Safari Booster
            {
                new int[]{0,0,5,0,0,0}, //Starter 1
                new int[]{0,1,0,0,0,1},
                new int[]{0,0,1,0,0,4},
                new int[]{0,0,2,0,0,0},
                new int[]{0,0,0,0,6,0},
                new int[]{0,5,0,0,1,2},
                new int[]{0,2,0,0,6,1},
                new int[]{0,0,2,5,0,0},
                new int[]{0,5,0,0,0,1},
                new int[]{0,2,0,0,1,5},
                new int[]{0,0,2,0,6,0},
                new int[]{0,0,0,2,1,0},
                new int[]{0,4,0,0,3,0},
                new int[]{0,1,0,5,0,1},
                new int[]{0,0,1,0,0,1},
                new int[]{0,2,0,1,0,5}, //Junior 15
                new int[]{0,0,0,0,4,0},
                new int[]{0,5,0,0,0,2},
                new int[]{0,0,0,3,0,4},
                new int[]{0,4,0,1,2,1},
                new int[]{0,0,2,1,0,5},
                new int[]{0,4,0,0,3,1},
                new int[]{0,0,0,3,0,3},
                new int[]{0,4,1,0,3,1},
                new int[]{0,0,0,4,3,0},
                new int[]{0,5,3,0,0,0},
                new int[]{0,3,0,2,1,3},
                new int[]{0,0,5,0,2,1},
                new int[]{0,2,1,4,0,1},
                new int[]{0,4,1,1,2,1},
                new int[]{0,0,3,0,0,1}, //Expert 30
                new int[]{0,1,3,3,0,0},
                new int[]{0,3,2,1,3,0},
                new int[]{0,1,5,1,0,0},
                new int[]{0,3,1,0,4,0},
                new int[]{0,1,0,3,0,4},
                new int[]{0,0,4,0,4,0},
                new int[]{0,2,0,0,0,2},
                new int[]{0,3,2,1,1,2},
                new int[]{0,2,2,1,3,1},
                new int[]{0,2,4,0,0,3},
                new int[]{0,3,4,0,0,2},
                new int[]{0,0,1,3,3,2},
                new int[]{0,4,3,0,1,0},
                new int[]{0,0,4,2,0,0}, //Master 46
                new int[]{0,1,1,1,0,0},
                new int[]{0,0,4,0,0,1},
                new int[]{0,1,1,3,1,3},
                new int[]{0,1,5,1,0,1},
                new int[]{0,3,1,3,0,1},
                new int[]{0,1,1,2,2,3},
                new int[]{0,0,4,2,0,1},
                new int[]{0,3,4,1,0,0},
                new int[]{0,2,3,0,3,1},
                new int[]{0,2,1,1,4,0},
                new int[]{0,1,1,0,2,4},
                new int[]{0,0,1,1,0,1},
                new int[]{0,1,4,2,0,0},
                new int[]{0,3,2,0,1,3},
            }
        };
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int[][] squares; //Game boards.
            bool[][] tiles;
            string[] objectNames;
            int[] repeatIndex; //When there is a repeat with rotations on pieces.
            int maxEmptyCount = 0; //Amount of holes in the pieces.
            while (true)
            {
                Console.WriteLine("Choose game: ");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Hide & Seek Safari");
                Console.WriteLine("2. Hide & Seek Pirates");
                Console.WriteLine("3. Hide & Seek Monsters");
                Console.WriteLine("4. Dora is searching for her friends");
                Console.WriteLine("5. Hide & Seek Canada Cache-Cahce");
                Console.WriteLine("6. Hide & Seek Safari Booster");
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
                            new int[]{1,0,2,3,4,3,5,2,1},
                            new int[]{4,0,2,0,3,1,2,5,4},
                            new int[]{5,1,3,4,0,4,2,0,5},
                            new int[]{0,0,0,0,5,2,4,1,3},
                        };
                        tiles = new bool[][] //Don't change the order, H-piece must be firts
                        {
                            new bool[]{true,false,true,true,true,true,true,false,true}, //H-piece
                            new bool[]{true,false,true,true,false,true,true,true,true}, //U-piece
                            new bool[]{true,true,false,false,true,true,false,true,true},//b-piece
                            new bool[]{true,true,false,true,true,true,true,false,true}, //R-piece
                        };
                        maxEmptyCount = 9;
                        objectNames = new string[] {"Empty", "Elephant", "Lion", "Zebra", "Gazelle", "Rhino" };
                        repeatIndex = new int[] { 8, 12 };
                        break;
                    case 2: //Hide and Seek Pirates
                        squares = new int[][] //Matches with object names array.
                        {
                            new int[]{1,0,1,0,0,0,2,0,3},
                            new int[]{0,0,3,0,4,0,5,0,2},
                            new int[]{4,0,2,0,5,0,0,0,2},
                            new int[]{1,0,4,0,2,0,0,0,5},
                        };
                        tiles = new bool[][] //Don't change the order!
                        {
                            new bool[]{true,true,false,true,true,true,false, true, true}, //Top right & bottom left empty piece
                            new bool[]{true,true,true,true,true,true,false,true,false}, //Sign-piece
                            new bool[]{true,true,false,true,false,true,true,true,true}, //L-piece
                            new bool[]{true,true,false, true, true,true, true, true,true}, //Top right empty piece
                        };
                        maxEmptyCount = 7;
                        repeatIndex = new int[] { 8, 12 };
                        objectNames = new string[] {"Empty", "Rowing boat", "White sailboat", "Cave island", "Red sailboat", "Pirate island" };
                        break;
                    case 3: //Hide & Seek monsters
                        squares = new int[][] //Matches with object names array.
                        {
                            new int[]{0,1,2,3,0,4,5,0,0},
                            new int[]{1,6,0,0,3,4,5,7,0},
                            new int[]{1,2,7,3,4,0,7,6,8},
                            new int[]{0,0,0,6,1,8,3,7,4},
                        };
                        tiles = new bool[][] //Don't change the order, H-piece must be firts
                        {
                            new bool[]{true,false,true,true,true,true,true,false,true}, //H-piece
                            new bool[]{true,true,false,true,true,true,false, true, true}, //Top right & bottom left empty piece
                            new bool[]{true,false,true,true,false,true,true,true,true}, //U-piece
                            new bool[]{true,true,false,true,true,true,true,false,true}, //R-piece
                        };
                        maxEmptyCount = 8;
                        repeatIndex = new int[] { 8, 12, 9 ,13 };
                        objectNames = new string[] { "Empty", "Mushroom monster", "Green Dinosaur monster", "Blue yeti monster", "Bat montster", "Yellow fur monster", "Tentacle mosnter", "Red devil", "Green horned monster"};
                        break;
                    case 4: //
                        squares = new int[][] //Matches with object names array.
                        {
                            new int[]{1,0,2,0,3,0,4,0,0},
                            new int[]{0,0,5,0,0,0,1,0,3},
                            new int[]{6,0,7,0,1,0,8,0,0},
                            new int[]{9,0,0,0,3,0,10,0,11},
                        };
                        tiles = new bool[][] //Don't change the order!
                        {
                            new bool[]{true,true,false,true,true,true,false, true, true}, //Top right & bottom left empty piece
                            new bool[]{true,true,true,true,true,true,false,true,false}, //Sign-piece
                            new bool[]{true,true,false,true,false,true,true,true,true}, //L-piece
                            new bool[]{true,true,false, true, true,true, true, true,true}, //Top right empty piece
                        };
                        maxEmptyCount = 7;
                        repeatIndex = new int[] { 8, 12 };
                        objectNames = new string[] { "Empty", "Explorer star", "Señor Tucán", "Dora the explorer", "Grumpy old Troll", "Butterflies", "Tico", "Isa", "Benny", "Boots", "Backpack", "Swiper" };
                        break;
                    case 5: //Hide & Seek Canada Cache-Cache
                        squares = new int[][] //Matches with object names array.
                            {
                            new int[]{1,0,1,0,0,0,2,0,3},
                            new int[]{0,0,3,0,4,0,5,0,2},
                            new int[]{4,0,2,0,5,0,0,0,2},
                            new int[]{1,0,4,0,2,0,0,0,5},
                            };
                        tiles = new bool[][] //Don't change the order!
                        {
                            new bool[]{true,true,false,true,true,true,false, true, true}, //Top right & bottom left empty piece
                            new bool[]{true,true,true,true,true,true,false,true,false}, //Sign-piece
                            new bool[]{true,true,false,true,false,true,true,true,true}, //L-piece
                            new bool[]{true,true,false, true, true,true, true, true,true}, //Top right empty piece
                        };
                        maxEmptyCount = 7;
                        repeatIndex = new int[] { 8, 12 };
                        objectNames = new string[] { "Empty", "Goose", "Beaver", "Bear", "Raccoon", "Moose" };
                        break;
                    case 6: //Hide and Seek Safari
                        squares = new int[][] //Matches with object names array.
                        {
                            new int[]{1,0,2,3,4,3,5,2,1},
                            new int[]{4,0,2,0,3,1,2,5,4},
                            new int[]{5,1,3,4,0,4,2,0,5},
                            new int[]{0,0,0,0,5,2,4,1,3},
                        };
                        tiles = new bool[][] //Don't change the order, H-piece must be firts
                        {
                            new bool[]{true,false,true,true,true,true,true,false,true}, //H-piece
                            new bool[]{true,false,true,true,false,true,true,true,true}, //U-piece
                            new bool[]{true,true,false,false,true,true,false,true,true},//b-piece
                            new bool[]{true,true,false,true,true,true,true,false,true}, //R-piece
                            new bool[]{false,true,true,true,true,true,true,false,true}, //Mirrored R-piece
                        };
                        maxEmptyCount = 9;
                        objectNames = new string[] { "Empty", "Elephant", "Lion", "Zebra", "Gazelle", "Rhino" };
                        repeatIndex = new int[] { 10, 15 };
                        break;
                    default:
                        continue;
                }

                int problemChoice = 0;
                if (presetChallenges[gameChoice - 1].Length > 0) //Check if there is preset challenges
                {
                    Console.WriteLine("Choose the puzzle from 1-" + presetChallenges[gameChoice - 1].Length + " or zero to input your own choice");
                    validChoice = int.TryParse(Console.ReadLine(), out problemChoice);
                    if (!validChoice)
                    {
                        continue;
                    }
                }
                

                int[] desiredResult = new int[objectNames.Length]; //Zero index is max empty count
                if (problemChoice == 0) //User inputs the amount of things to find.
                {
                    Console.WriteLine("Input the amount of objects:");
                    desiredResult[0] = maxEmptyCount;
                    for (int i = 1; i < objectNames.Length; i++)
                    {
                        Console.Write(objectNames[i] + ": ");
                        desiredResult[i] = int.Parse(Console.ReadLine());
                        desiredResult[0] -= desiredResult[i];
                    }
                    if (desiredResult[0] < 0)
                    {
                        Console.WriteLine("Too many objects. Limit is " + maxEmptyCount);
                        continue;
                    }
                }
                else if (problemChoice > 0) //Preset values
                {
                    desiredResult = presetChallenges[gameChoice - 1][problemChoice - 1];
                    desiredResult[0] = maxEmptyCount;
                    for(int i = 1; i < desiredResult.Length; i++)
                    {
                        desiredResult[0] -= desiredResult[i];
                    }
                }

                int[] solution = new int[4]; //Brute forcing all solutions.
                while (true)
                {
                    if (checkResult(solution, squares, tiles, desiredResult))
                    {
                        showSolution(solution, tiles);
                        break;
                    }
                    if (solution[0] == tiles.Length * 4 - 1 && solution[1] == tiles.Length * 4 - 1 && solution[2] == tiles.Length * 4 - 1 && solution[3] == tiles.Length * 4 - 1)
                    {
                        Console.WriteLine("No solution! Check your input.");
                        break;
                    }
                    increase(solution, 3, repeatIndex);
                }
                Console.ReadLine();
            }
        }

        static public int[] increase(int[] data, int index, int[] repeatIndex)
        {
            data[index] = (data[index] + 1) % 16;
            for(int i = 0; i < repeatIndex.Length; i++)
            {
                if (repeatIndex.Contains(data[index]))
                {
                    return increase(data, index, repeatIndex);
                }
            }
            if (data[index] == 0 && index > 0)
            {
                return increase(data, index -1, repeatIndex);
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


        public static bool checkResult(int[] data, int[][] square, bool[][] tiles, int[] desiredResult)
        {
            //Checks if inputted data is valid.
            int[] holder = (int[])data.Clone();
            for(int i = 0; i < holder.Length; i++)
            {
                holder[i] %= tiles.Length;
            }
            Array.Sort(holder);
            int skipped = 0; //Takes care of situations where there is more tiles than squares.
            for(int i = 0; i < holder.Length; i++)
            {
                if (holder[i] != i + skipped)
                {
                    skipped++;
                }
                if(skipped > tiles.Length - holder.Length)
                {
                    return false;
                }
            }
            
            int[] items = new int[desiredResult.Length]; //Adds all seen objects to the list.
            for (int tileIndex = 0; tileIndex < data.Length; tileIndex++)
            {
                bool[] currentTile = rotate(tiles[data[tileIndex] % tiles.Length], (int)Math.Floor(data[tileIndex] / (double)tiles.Length));
                for(int tilePartIndex = 0; tilePartIndex < currentTile.Length; tilePartIndex++)
                {
                    if (currentTile[tilePartIndex] == false) //Increases the seen object, when there is a hole in the piece.
                    {
                        items[square[tileIndex][tilePartIndex]]++;
                    }
                }
            }

            if (items[0] > desiredResult[0])
            {
                return false;
            }
            for(int i = 1; i < desiredResult.Length; i++) //Checks that arrays are the same.
            {
                if (items[i] != desiredResult[i])
                {
                    return false;
                }
            }
            return true;
        }

        static public void showSolution(int[] data, bool[][] tiles)
        {
            bool[][] T = new bool[tiles.GetLength(0)][]; //Creates rotated versions of the tiles.
            for (int i = 0; i < data.Length; i++)
            {
                T[i] = rotate(tiles[data[i] % tiles.Length], (int)Math.Floor(data[i] / (double)tiles.Length));
            }

            Console.WriteLine();
            for(int tileVertical = 0; tileVertical < 2; tileVertical++)
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int tileHorizontal = 0 + 2 * tileVertical; tileHorizontal < 2 + 2 * tileVertical; tileHorizontal++)
                    {
                        Console.Write(" ");
                        for (int column = 0 + row * 3; column < 3 + row * 3; column++)
                        {
                            char merkki = ' ';
                            if (T[tileHorizontal][column] == true)
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