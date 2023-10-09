using System;
using HtmlAgilityPack;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string url = "https://dictionary.cambridge.org/dictionary/english/article"; //Replace with actual url
        List<string> articleTitles = WebScrape(url);

        if (articleTitles.Count > 0 )
        {
            Console.WriteLine("Article Titles: ");
            foreach ( string title in articleTitles )
            {
                Console.WriteLine(title);
            }
        } else
        {
            Console.WriteLine("No article titles were found.");
        }
    }

    static List<string> WebScrape(string url)
    {
        List<string> articleTitles = new List<string>();

        try
        {
            //Initialize Html Web and HtmlDocument objects 
            var web = new HtmlWeb();
            var doc = web.Load(url);

            //Use Xpath to select elements with specific attributes
            var nodes = doc.DocumentNode.SelectNodes("//a[class='article-title']");

            if (nodes != null)
            {
                foreach ( var node in nodes )
                {
                    //Extract and store the text content of selected elements
                    articleTitles.Add(node.InnerText.Trim());
                }
            }
        }

        catch (Exception e)
        {
            Console.WriteLine($"An error occured: {e.Message}");
        }

        return articleTitles;
    }
}