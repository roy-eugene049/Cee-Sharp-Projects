string[] fraudData = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
string letter = "B";
foreach (string item in fraudData)
{
    if (item.StartsWith(letter))
    {
        Console.WriteLine(item);
    }
}