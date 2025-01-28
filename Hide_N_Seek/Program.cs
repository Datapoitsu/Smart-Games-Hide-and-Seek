using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_N_Seek
{    
    public class Game
    {
        public string name;
        public int[][] squares; //Objects on the board listed in order of appearance [tile][index]
        public string[] objectNames;
        public bool[][] tiles; //Don't change the order!
        public int[] skipIndexes;
        public int[][] presetChallenges; //All challenges from the games.
        public int maxEmptyCount = 0;
        public Game (string name, int[][] squares, string[] objectNames, bool[][] tiles, int[] skipIndexes, int[][] presetChallenges)
        {
            this.name = name;
            this.squares = squares;
            this.objectNames = objectNames;
            this.tiles = tiles;
            this.skipIndexes = skipIndexes;
            this.presetChallenges = presetChallenges;
            maxEmptyCount = countMaxEmpty(tiles);
        }

        public int countMaxEmpty(bool[][] tiles)
        {
            int[] emptyCounts = new int[tiles.Length];
            for(int i = 0; i < tiles.Length; i++)
            {
                for(int k = 0; k < tiles[i].Length; k++)
                {
                    if (tiles[i][k] == false)
                    {
                        emptyCounts[i]++;
                    }
                }
            }
            Array.Sort(emptyCounts);
            return emptyCounts[tiles.Length - 1] + emptyCounts[tiles.Length - 2] + emptyCounts[tiles.Length - 3] + emptyCounts[tiles.Length - 4];
        }
    };

    internal class Program
    {
        public static Game[] games = new Game[]
        {
            new Game(
                "Hide and Seek Safari",
                new int[][]
                {
                    new int[]{1,0,2,3,4,3,5,2,1},
                    new int[]{4,0,2,0,3,1,2,5,4},
                    new int[]{5,1,3,4,0,4,2,0,5},
                    new int[]{0,0,0,0,5,2,4,1,3},
                },
                new string[] {"Empty", "Elephant", "Lion", "Zebra", "Gazelle", "Rhino" },
                new bool[][]
                {
                    new bool[]{true,false,true,true,true,true,true,false,true}, //H-piece
                    new bool[]{true,false,true,true,false,true,true,true,true}, //U-piece
                    new bool[]{true,true,false,false,true,true,false,true,true},//b-piece
                    new bool[]{true,true,false,true,true,true,true,false,true}, //R-piece
                },
                new int[] { 8, 12 },
                new int[][]
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
                }
                ),
            new Game(
                "Hide and Seek Safari booster",
                new int[][]
                {
                    new int[]{1,0,2,3,4,3,5,2,1},
                    new int[]{4,0,2,0,3,1,2,5,4},
                    new int[]{5,1,3,4,0,4,2,0,5},
                    new int[]{0,0,0,0,5,2,4,1,3},
                },
                new string[] {"Empty", "Elephant", "Lion", "Zebra", "Gazelle", "Rhino" },
                new bool[][]
                {
                    new bool[]{true,false,true,true,true,true,true,false,true}, //H-piece
                    new bool[]{true,false,true,true,false,true,true,true,true}, //U-piece
                    new bool[]{true,true,false,false,true,true,false,true,true},//b-piece
                    new bool[]{true,true,false,true,true,true,true,false,true}, //R-piece
                    new bool[]{false,true,true,true,true,true,true,false,true}, //Mirrored R-piece
                },
                new int[] { 10, 15 },
                new int[][]
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
                    new int[]{0,1,1,2,1,4},
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
                ),
            new Game(
                "Hide and Seek Pirates",
                new int[][]
                {
                    new int[]{1,0,1,0,0,0,2,0,3},
                    new int[]{0,0,3,0,4,0,5,0,2},
                    new int[]{4,0,2,0,5,0,0,0,2},
                    new int[]{1,0,4,0,2,0,0,0,5},
                },
                new string[] {"Empty", "Rowing boat", "White sailboat", "Cave island", "Red sailboat", "Pirate island" },
                new bool[][]
                {
                    new bool[]{true,true,false,true,true,true,false, true, true}, //Top right & bottom left empty piece
                    new bool[]{true,true,true,true,true,true,false,true,false}, //Sign-piece
                    new bool[]{true,true,false,true,false,true,true,true,true}, //L-piece
                    new bool[]{true,true,false, true, true,true, true, true,true}, //Top right empty piece
                },
                new int[] { 8, 12 },
                new int[][]
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
                ),
            new Game(
                "Hide and Seek Pirates Jr.",
                new int[][]
                {
                    new int[]{0,1,2,3,0,4,5,0,0},
                    new int[]{1,6,0,0,3,4,5,7,0},
                    new int[]{1,2,7,3,4,0,7,6,8},
                    new int[]{0,0,0,6,1,8,3,7,4},
                },
                new string[] {"Empty", "Barrel", "Shipwreck", "White sailboat", "Treasure chest", "Tentacles", "Tower", "Pirate Boat", "Skull island"},
                new bool[][]
                {
                    new bool[]{true,false,true,true,true,true,true,false,true}, //H-piece
                    new bool[]{true,true,false,true,true,true,false, true, true}, //Top right & bottom left empty piece
                    new bool[]{true,false,true,true,false,true,true,true,true}, //U-piece
                    new bool[]{true,true,false,true,true,true,true,false,true}, //R-piece
                },
                new int[] { 8, 12, 9 ,13 },
                new int[][]
                {
                    new int[]{0,0,0,0,0,0,0,4,0}, //Starter 1
                    new int[]{0,0,0,0,4,0,0,0,0},
                    new int[]{0,0,0,4,0,0,0,0,0},
                    new int[]{0,4,0,0,0,0,0,0,0},
                    new int[]{0,0,1,3,0,0,0,0,0},
                    new int[]{0,0,0,3,0,1,0,0,0},
                    new int[]{0,2,2,0,0,0,1,0,0},
                    new int[]{0,0,0,3,0,0,1,0,0},
                    new int[]{0,0,0,2,0,0,0,3,0},
                    new int[]{0,0,2,2,0,0,1,0,0},
                    new int[]{0,2,1,0,0,2,0,0,0},
                    new int[]{0,1,0,0,1,2,0,1,0},
                    new int[]{0,0,0,0,2,0,0,0,1},
                    new int[]{0,3,0,0,0,0,0,0,2},
                    new int[]{0,0,1,0,0,1,1,0,1},
                    new int[]{0,0,0,0,3,0,1,0,0},
                    new int[]{0,0,0,0,1,0,0,1,0}, //Junior 17
                    new int[]{0,3,0,0,0,0,0,1,0},
                    new int[]{0,0,0,2,0,0,0,0,1},
                    new int[]{0,2,0,1,0,0,0,0,2},
                    new int[]{0,0,0,0,2,1,0,1,0},
                    new int[]{0,0,2,0,1,1,0,2,0},
                    new int[]{0,0,2,2,1,0,1,0,0},
                    new int[]{0,0,2,1,0,1,0,3,0},
                    new int[]{0,0,0,4,1,0,0,0,1},
                    new int[]{0,0,0,0,3,0,1,2,0},
                    new int[]{0,0,0,0,0,1,1,2,0},
                    new int[]{0,0,2,0,2,1,0,1,0},
                    new int[]{0,0,0,3,1,0,0,3,0},
                    new int[]{0,3,0,0,1,0,0,3,0},
                    new int[]{0,1,1,0,0,1,0,3,0},
                    new int[]{0,0,0,0,0,0,0,0,0}, //Expert 33
                    new int[]{0,1,0,0,0,0,0,2,1},
                    new int[]{0,0,1,3,0,1,0,1,0},
                    new int[]{0,0,0,0,1,1,1,1,0},
                    new int[]{0,1,0,0,0,0,2,3,0},
                    new int[]{0,1,1,1,1,1,0,0,2},
                    new int[]{0,0,2,0,1,1,0,0,0},
                    new int[]{0,0,2,0,2,1,2,0,0},
                    new int[]{0,2,0,0,0,0,0,3,1},
                    new int[]{0,2,0,0,2,0,0,0,0},
                    new int[]{0,0,0,2,0,0,0,2,1},
                    new int[]{0,0,1,0,0,1,1,1,1},
                    new int[]{0,0,1,0,3,1,2,0,0},
                    new int[]{0,0,0,0,1,1,1,2,0},
                    new int[]{0,0,0,2,0,1,2,0,0},
                    new int[]{0,1,1,0,0,0,2,0,0},
                    new int[]{0,2,1,1,0,0,2,0,0},
                    new int[]{0,0,0,2,0,0,0,2,0}, //Master 49
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
                }
                ),
            new Game(
                "Hide and Seek Monsters",
                new int[][]
                {
                    new int[]{0,1,2,3,0,4,5,0,0},
                    new int[]{1,6,0,0,3,4,5,7,0},
                    new int[]{1,2,7,3,4,0,7,6,8},
                    new int[]{0,0,0,6,1,8,3,7,4},
                },
                new string[] { "Empty", "Mushroom monster", "Green Dinosaur monster", "Blue yeti monster", "Bat montster", "Yellow fur monster", "Tentacle mosnter", "Red devil", "Green horned monster"},
                new bool[][]
                {
                    new bool[]{true,false,true,true,true,true,true,false,true}, //H-piece
                    new bool[]{true,true,false,true,true,true,false, true, true}, //Top right & bottom left empty piece
                    new bool[]{true,false,true,true,false,true,true,true,true}, //U-piece
                    new bool[]{true,true,false,true,true,true,true,false,true}, //R-piece
                },
                new int[] { 8, 12, 9 ,13 },
                new int[][]
                {
                    new int[]{0,0,0,0,0,0,0,4,0},//Starter 1
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
                    new int[]{0,0,0,2,0,0,0,0,1},
                    new int[]{0,2,0,1,0,0,0,0,2},
                    new int[]{0,0,0,0,2,1,0,1,0},
                    new int[]{0,0,0,0,2,0,0,3,0},
                    new int[]{0,0,2,0,1,1,0,2,0},
                    new int[]{0,0,2,2,1,0,1,0,0},
                    new int[]{0,0,2,1,0,1,0,3,0},
                    new int[]{0,0,0,4,1,0,0,0,1},
                    new int[]{0,0,0,0,3,0,1,2,0},
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
                    new int[]{0,0,0,2,0,0,0,2,0},//Master 49
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
                }
                ),
            new Game(
                "Hide and Seek Canada CacheCache",
                new int[][]
                {
                new int[]{1,0,1,0,0,0,2,0,3},
                new int[]{0,0,3,0,4,0,5,0,2},
                new int[]{4,0,2,0,5,0,0,0,2},
                new int[]{1,0,4,0,2,0,0,0,5},
                },
                new string[] { "Empty", "Goose", "Beaver", "Bear", "Raccoon", "Moose" },
                new bool[][]
                {
                    new bool[]{true,true,false,true,true,true,false, true, true}, //Top right & bottom left empty piece
                    new bool[]{true,true,true,true,true,true,false,true,false}, //Sign-piece
                    new bool[]{true,true,false,true,false,true,true,true,true}, //L-piece
                    new bool[]{true,true,false, true, true,true, true, true,true}, //Top right empty piece
                },
                new int[] { 8, 12 },
                new int[][] {}
                ),
            new Game(
                "Hide and Seek Rasmus Klump",
                new int[][]
                {
                    new int[]{1,0,2,0,3,0,4,0,0},
                    new int[]{0,0,5,0,0,0,1,0,3},
                    new int[]{6,0,7,0,1,0,8,0,0},
                    new int[]{9,0,0,0,3,0,10,0,11},
                },
                new string[] { "Empty", "Treasure", "Blæksprut", "Rasmus Klump", "Pelle", "Leo", "Pingo", "Skæg", "Knalle", "Basse", "Turtle", "Grete"},
                new bool[][]
                {
                    new bool[]{true,true,false,true,true,true,false, true, true}, //Top right & bottom left empty piece
                    new bool[]{true,true,true,true,true,true,false,true,false}, //Sign-piece
                    new bool[]{true,true,false,true,false,true,true,true,true}, //L-piece
                    new bool[]{true,true,false, true, true,true, true, true,true}, //Top right empty piece
                },
                new int[] { 8, 12 },
                new int[][] {}
                ),
            new Game(
                "Dora is searching for her friends",
                new int[][]
                {
                    new int[]{1,0,2,0,3,0,4,0,0},
                    new int[]{0,0,5,0,0,0,1,0,3},
                    new int[]{6,0,7,0,1,0,8,0,0},
                    new int[]{9,0,0,0,3,0,10,0,11},
                },
                new string[] { "Empty", "Explorer star", "Señor Tucán", "Dora the explorer", "Grumpy old Troll", "Butterflies", "Tico", "Isa", "Benny", "Boots", "Backpack", "Swiper" },
                new bool[][]
                {
                    new bool[]{true,true,false,true,true,true,false, true, true}, //Top right & bottom left empty piece
                    new bool[]{true,true,true,true,true,true,false,true,false}, //Sign-piece
                    new bool[]{true,true,false,true,false,true,true,true,true}, //L-piece
                    new bool[]{true,true,false, true, true,true, true, true,true}, //Top right empty piece
                },
                new int[] { 8, 12 },
                new int[][] {}
                )
        };
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            while (true)
            {
                Console.WriteLine("Choose game: ");
                Console.WriteLine("0. Exit");
                for(int i = 0; i < games.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". " + games[i].name);
                }
                bool validChoice = int.TryParse(Console.ReadLine(), out int gameChoice);
                gameChoice--;
                if(!validChoice)
                {
                    continue;
                }

                int challengeChoice = 0;
                if (games[gameChoice].presetChallenges.Length > 0) //Check if there is preset challenges
                {
                    Console.WriteLine("Choose the puzzle from 1-" + games[gameChoice].presetChallenges.Length + " or zero to input your own choice");
                    validChoice = int.TryParse(Console.ReadLine(), out challengeChoice);
                    if (!validChoice)
                    {
                        continue;
                    }
                }

                int[] desiredResult = new int[games[gameChoice].objectNames.Length]; //Zero index is max empty count
                if (challengeChoice == 0) //User inputs the amount of things to find.
                {
                    Console.WriteLine("Input the amount of objects:");
                    desiredResult[0] = games[gameChoice].maxEmptyCount;
                    for (int i = 1; i < games[gameChoice].objectNames.Length; i++)
                    {
                        Console.Write(games[gameChoice].objectNames[i] + ": ");
                        desiredResult[i] = int.Parse(Console.ReadLine());
                        desiredResult[0] -= desiredResult[i];
                    }
                    if (desiredResult[0] < 0)
                    {
                        Console.WriteLine("Too many objects. Limit is " + games[gameChoice].maxEmptyCount);
                        continue;
                    }
                }
                else if (challengeChoice > 0) //Preset values
                {
                    desiredResult = games[gameChoice].presetChallenges[challengeChoice - 1];
                    desiredResult[0] = games[gameChoice].maxEmptyCount;
                    for(int i = 1; i < desiredResult.Length; i++)
                    {
                        desiredResult[0] -= desiredResult[i];
                    }
                }

                int[] solution = new int[4]; //Brute forcing all solutions.
                while (true)
                {
                    if (checkResult(solution, games[gameChoice].squares, games[gameChoice].tiles, desiredResult))
                    {
                        showSolution(solution, games[gameChoice].tiles);
                        break;
                    }
                    if (solution[0] == games[gameChoice].tiles.Length * 4 - 1 && solution[1] == games[gameChoice].tiles.Length * 4 - 1 && solution[2] == games[gameChoice].tiles.Length * 4 - 1 && solution[3] == games[gameChoice].tiles.Length * 4 - 1)
                    {
                        Console.WriteLine("No solution! Check your input.");
                        break;
                    }
                    increase(solution, 3, games[gameChoice].skipIndexes, games[gameChoice].tiles.Length * 4);
                }
                Console.ReadLine();
            }
        }

        static public int[] increase(int[] data, int index, int[] repeatIndex, int upperLimit)
        {
            data[index] = (data[index] + 1) % upperLimit;
            for(int i = 0; i < repeatIndex.Length; i++)
            {
                if (repeatIndex.Contains(data[index]))
                {
                    return increase(data, index, repeatIndex,upperLimit);
                }
            }
            if (data[index] == 0 && index > 0)
            {
                return increase(data, index -1, repeatIndex,upperLimit);
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