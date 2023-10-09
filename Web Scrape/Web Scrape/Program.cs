using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net;

class Program
{
    static void Main()
    {
        string url = "https://github.com/roy-eugene049"; // Replace with the URL of the website you want to scrape
        List<string> articleTitles = WebScrape(url);

        if (articleTitles.Count > 0)
        {
            Console.WriteLine("Article Titles:");
            foreach (string title in articleTitles)
            {
                Console.WriteLine(title);
            }
        }
        else
        {
            Console.WriteLine("No article titles were found.");
        }
    }

    static List<string> WebScrape(string url)
    {
        List<string> articleTitles = new List<string>();

        try
        {
            // Create an HtmlWeb object
            var web = new HtmlWeb();

            // Download the webpage content
            var doc = web.Load(url);

            // Use XPath to select elements with specific attributes
            var nodes = doc.DocumentNode.SelectNodes("//h2[@class='article-title']");

            if (nodes != null)
            {
                foreach (var node in nodes)
                {
                    // Extract and store the text content of selected elements
                    articleTitles.Add(WebUtility.HtmlDecode(node.InnerText.Trim()));
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }

        return articleTitles;
    }
}
