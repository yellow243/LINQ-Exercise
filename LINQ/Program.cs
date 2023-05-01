namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGameTitles = new List<string>() { "Fortnite", "Apex Legends", "Minecraft", "Hogwarts Legacy", "Star Wars: Jedi Fallen Order", "High on Life", "Fallout 4", "Grand Theft Auto 5", "Tiny Tina's Wonderlands" };

            videoGameTitles.Add("League of Legends");
            videoGameTitles.Add("Assassins Creed Odyssey");
            videoGameTitles.Add("My Hero One's Justice");
            videoGameTitles.Add("Naruto Shippuden: Ultimate Ninja Storm 4");
            videoGameTitles.Add("Minecraft Dungeons");
            videoGameTitles.Add("South Park: The Stick of Truth");
            videoGameTitles.Add("The Last of Us");
            videoGameTitles.Add("Totally Accurate Battle Simulator");
            videoGameTitles.Add("Dragon Ball Xenoverse 2");
            videoGameTitles.Add("Dragon Quest XI: Echoes of an Elusive Age");



           var orderedTitles = videoGameTitles.OrderByDescending(name  => name.Length);

            foreach (var title in orderedTitles) 
            {
                Console.WriteLine(title);
            }
        }
    }
}
