using HtmlAgilityPack;
using System;
using System.Net;

class Program
{
    static void Main()
    {
        string url = "https://github.com/roy-eugene049"; // Replace with the URL of the website you want to scrape
        string pageText = WebScrape(url);

        if (!string.IsNullOrEmpty(pageText))
        {
            Console.WriteLine("Page Text:");
            Console.WriteLine(pageText);
        }
        else
        {
            Console.WriteLine("No text was found on the page.");
        }
    }

    static string WebScrape(string url)
    {
        try
        {
            // Create an HtmlWeb object
            var web = new HtmlWeb();

            // Download the webpage content
            var doc = web.Load(url);

            // Extract all text content from the page
            string pageText = WebUtility.HtmlDecode(doc.DocumentNode.InnerText.Trim());

            return pageText;
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
            return null;
        }
    }
}
