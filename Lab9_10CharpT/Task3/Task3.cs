using System;
using System.IO;
using System.Collections;

class Program3
{
    //task3.1
    public static void Task1()
    {
        string filePath = "/Users/andriifedoryshyn/Desktop/2024/C#/csharplab9-AndriyFedoryshyn/Lab9_10CharpT/Task1/t.txt";

        try
        {
            if (File.Exists(filePath))
            {
                ArrayList linesList = new ArrayList(File.ReadAllLines(filePath));

                foreach (string line in linesList)
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

    //task3.2
    public static void Task2()
    {
        string filePath = "/Users/andriifedoryshyn/Desktop/2024/C#/csharplab9-AndriyFedoryshyn/Lab9_10CharpT/Task2/file.txt";

        try
        {
            if (File.Exists(filePath))
            {
                PrintWordsByCategory(filePath);
            }
            else
            {
                Console.WriteLine("File doesn't exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred: " + ex.Message);
        }
    }

    static void PrintWordsByCategory(string filePath)
    {
        ArrayList vowelWords = new ArrayList();
        ArrayList consonantWords = new ArrayList();

        string[] words = File.ReadAllText(filePath).Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (IsVowel(word[0]))
                vowelWords.Add(word);
            else
                consonantWords.Add(word);
        }

        Console.WriteLine("Words that start with a vowel:");
        PrintArrayList(vowelWords);

        Console.WriteLine("\nWords that start with a consonant:");
        PrintArrayList(consonantWords);
    }

    static void PrintArrayList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    static bool IsVowel(char c)
    {
        c = char.ToLower(c);
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y';
    }

    
}
