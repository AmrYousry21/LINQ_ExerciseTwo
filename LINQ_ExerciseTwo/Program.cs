namespace LINQ_ExerciseTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() 
            {
                "God Of War",
                "Call of Duty",
                "GTA",
                "Witcher"
            };

            var orderedLength = videoGames.OrderBy(x => x.Length).ToList();

            foreach(var videoGame in orderedLength) 
            {
                Console.WriteLine(videoGame);
            } 

        }
    }
}