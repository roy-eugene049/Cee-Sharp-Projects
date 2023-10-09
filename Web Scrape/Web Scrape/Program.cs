using HtmlAgilityPack;
using System;
using System.IO;
using System.Net;

class Program
{
    static void Main()
    {
        string url = "https://github.com/roy-eugene049"; // Replace with the URL of the website you want to scrape
        string pageText;
        string profileImageFileName;

        if (WebScrape(url, out pageText, out profileImageFileName))
        {
            Console.WriteLine("Formatted Page Text:");
            Console.WriteLine(pageText);

            if (!string.IsNullOrEmpty(profileImageFileName))
            {
                Console.WriteLine("Profile Image:");
                Console.WriteLine(profileImageFileName);
            }
        }
        else
        {
            Console.WriteLine("No data was found on the page.");
        }
    }

    static bool WebScrape(string url, out string pageText, out string profileImageFileName)
    {
        pageText = string.Empty;
        profileImageFileName = string.Empty;

        try
        {
            // Create an HtmlWeb object
            var web = new HtmlWeb();

            // Download the webpage content
            var doc = web.Load(url);

            // Extract all text content from the page
            pageText = WebUtility.HtmlDecode(doc.DocumentNode.InnerText.Trim());

            // Extract and store profile image, if available
            var imgNode = doc.DocumentNode.SelectSingleNode("//img[@class='profile-image']");
            if (imgNode != null)
            {
                string imgUrl = imgNode.GetAttributeValue("src", string.Empty);
                if (!string.IsNullOrEmpty(imgUrl))
                {
                    // Download and save the profile image
                    using (var client = new WebClient())
                    {
                        profileImageFileName = "profile_image.jpg"; // You can specify a different file name
                        client.DownloadFile(imgUrl, profileImageFileName);
                    }
                }
            }

            // Format the extracted text content as needed here

            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
            return false;
        }
    }
}
