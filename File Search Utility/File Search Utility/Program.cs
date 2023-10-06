using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the directory path to start the search: ");
        string directoryPath = Console.ReadLine();

        Console.WriteLine("Enter the file name or extension to search for: ");
        string searchTerm = Console.ReadLine();

        List<string> matchingFiles = SearchFiles(directoryPath, searchTerm);

        if (matchingFiles.Count > 0 )
        {
            Console.WriteLine("\nMatching Files: ");
            foreach (string filePath in matchingFiles)
            {
                Console.WriteLine(filePath);
            }
        } else
        {
            Console.WriteLine("\nNo files matching that search criteria were found.");
        }
    }

    static List<string> SearchFiles(string directoryPath, string searchTerm)
    {
        List<string> matchingFiles = new List<string>();

        try
        {
            foreach (string filePath in Directory.GetFiles(directoryPath, searchTerm, SearchOption.AllDirectories))
            {
                matchingFiles.Add(filePath);
            }
        } catch (UnauthorizedAccessException e)
        {
            Console.WriteLine($"Access to some directories was denied: {e.Message}");
        } catch (DirectoryNotFoundException e)
        {
            Console.WriteLine($"Directory not found: {e.Message}");
        } catch (IOException e)
        {
            Console.WriteLine($"An error occured: {e.Message}");
        }

        return matchingFiles;
    }
}
