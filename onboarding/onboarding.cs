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
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        Hashtable openWith = new Hashtable();
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            openWith.Add(inputs[0].ToLower(), inputs[1]);
        }
        for (int i = 0; i < Q; i++)
        {
            string FNAME = Console.ReadLine(); // One file name per line. 
            if(openWith.ContainsKey(FNAME.Split('.').Last().ToLower()) && !openWith.ContainsKey(FNAME.ToLower()))
            {
                Console.WriteLine(openWith[FNAME.Split('.').Last().ToLower()]);
            } else
            {
                Console.WriteLine("UNKNOWN");
            }
        }
    }
}