using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        string usersInput = "aabccdeff";
        var charCount = Iterator(usersInput);

        // Find the first character in the original string with a count of 1
        char? firstNonRepeated = null;
        foreach (var ch in usersInput)
        {
            if (charCount.TryGetValue(ch, out var c) && c == 1)
            {
                firstNonRepeated = ch;
                break;
            }
        }

        if (firstNonRepeated.HasValue)
            Console.WriteLine($"{firstNonRepeated}");
        else
            Console.WriteLine("null");

        static Dictionary<char, int> Iterator(string userInput)
        {
            var counts = new Dictionary<char, int>();
            foreach (var character in userInput)
            {
                if (counts.ContainsKey(character)) counts[character]++;
                else counts[character] = 1;
            }
            return counts;
        }

        Console.WriteLine("Hello Sandbox World!");
    }
}