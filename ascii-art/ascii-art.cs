using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine().ToUpper();
        string[] ROW = new string[H];
        string[] answer = new string[H];
        string[,] letter = new string[H,T.Count()];
        int letterCount = 0;
        for (int i = 0; i < H; i++)
        {
            ROW[i] = Console.ReadLine();
        }
        foreach(char ltr in T)
        {
            int pos1 = (Convert.ToInt32(ltr) - 65) * L;
            if (pos1 < 0 || pos1 > L * 26)
            {
                pos1 = 104;
            }
            for (int i = 0; i < H; i++)
            {
                letter[i,letterCount] += ROW[i].Substring(pos1, L);
                answer[i] += letter[i,letterCount];
            }
            letterCount++;
        }
        

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        for (int i = 0; i < H; i++)
        {
            Console.WriteLine(answer[i]);
        }
    }
}