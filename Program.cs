using System;

class Solution
{    
    static void Main(String[] args)
    {
        int numberOfTests = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfTests; i++)
        {
            int gridRows, patternRows, patternLength;
            string[] grid, pattern;
            GetInfos(out gridRows, out grid, out patternRows, out patternLength, out pattern);

            //check
            for (int c = 0; c <= gridRows - patternRows; c++)
            {
                if (grid[c].Contains(pattern[0]))
                {
                    int pos = grid[c].IndexOf(pattern[0]);
                    int test = 1;
                    for (int n = 1; n < patternRows; n++)
                    {
                        if (grid[c + n].Substring(pos, patternLength) != pattern[n]) break;
                        test++;
                    }
                    if (test == patternRows)
                    {
                        Console.WriteLine("YES");
                        break;
                    }
                }
            }
        }

    }

    private static void GetInfos(out int gridRows, out string[] grid, out int patternRows, out int patternLength, out string[] pattern)
    {
        string[] gridInfos = Console.ReadLine().Split(' ');
        gridRows = int.Parse(gridInfos[0]);
        grid = new string[gridRows];
        for (int r = 0; r < gridRows; r++)
        {
            grid[r] = Console.ReadLine();
        }
        string[] patternInfos = Console.ReadLine().Split(' ');
        patternRows = int.Parse(patternInfos[0]);
        patternLength = int.Parse(patternInfos[1]);
        pattern = new string[patternRows];
        for (int p = 0; p < patternRows; p++)
        {
            pattern[p] = Console.ReadLine();
        }
    }
}