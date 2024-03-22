using System;
using System.IO;
using System.Collections.Generic;

class Program1
{
    public static void Task1()
    {
        string filePath = "/Users/andriifedoryshyn/Desktop/2024/C#/csharplab9-AndriyFedoryshyn/Lab9_10CharpT/Task1/t.txt";

        try
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    PrintReverse(line);
                }
            }
            else
            {
                Console.WriteLine("File doesn't exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error ocurred: " + ex.Message);
        }
    }

    static void PrintReverse(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            stack.Push(c);
        }

        while (stack.Count > 0)
        {
            Console.Write(stack.Pop());
        }
        
        Console.WriteLine(); 
    }
}
