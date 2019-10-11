using System;

namespace NumberOfIsland
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] testcase = new string[][] {
                                              new string[]    { "1", "0", "0", "0"},
                                               new string[]   { "1", "1", "0", "0"},
                                               new string[]   { "1", "0", "0", "0"},
                                               new string[]   { "1", "0", "0", "1"}
            };

            Program p = new Program();
            Console.WriteLine(p.NumIslands(testcase));
        }

        public int NumIslands(string[][] grid)
        {
            int numberOfislands = 0;

            if (grid == null || grid.Length == 0)
                return 0;


            for (int i = 0; i <= grid.Length - 1; i++)
            {
                for (int j = 0; j <= grid[i].Length - 1; j++)
                {
                    if (grid[i][j] == "1")
                    {
                        numberOfislands += dfs(grid, i, j);
                    }

                }
            }



            return numberOfislands;

        }

        public int dfs(string[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == "0")
            {
                return 0;
            }

            grid[i][j] = "0";

            dfs(grid, i+1, j);
            dfs(grid, i, j+1);
            dfs(grid, i - 1, j);
            dfs(grid, i , j-1);

            return 1;

        }

    }
}
