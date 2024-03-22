using System;
using System.IO;
using System.Collections.Generic;

class Program2
{
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
            Console.WriteLine("Error ocurred: " + ex.Message);
        }
    }

    static void PrintWordsByCategory(string filePath)
    {
        Queue<string> vowelWords = new Queue<string>(); 
        Queue<string> consonantWords = new Queue<string>(); 

        string[] words = File.ReadAllText(filePath).Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (IsVowel(word[0]))
                vowelWords.Enqueue(word);
            else
                consonantWords.Enqueue(word);
        }

        Console.WriteLine("Words that start with a vowel:");
        while (vowelWords.Count > 0)
        {
            Console.WriteLine(vowelWords.Dequeue());
        }

        Console.WriteLine("\nWords that start with a consonant:");
        while (consonantWords.Count > 0)
        {
            Console.WriteLine(consonantWords.Dequeue());
        }
    }

    static bool IsVowel(char c)
    {
        c = char.ToLower(c);
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y';
    }
}
