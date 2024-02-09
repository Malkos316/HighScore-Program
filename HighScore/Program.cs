namespace HighScore
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Path to the file that you wish to read highscores from.
            string filePath = @"C:\Users\marku\Desktop\Personal projects\HighScore\HighScore.txt.txt";

            //Read the files lines from filePath.
            string[] lines = File.ReadAllLines(filePath);

            //Create a new list called scores for the objects to be palced into.
            List<Scores> scores = new List<Scores>();

            //Parse those lines into Score objects.
            foreach (var line in lines)
            {
                //Splits the line at every space.
                var parts = line.Split(' ');
                //For each of the Score objects, takes the name from index 0, and the score from index 1.
                scores.Add(new Scores { Name = parts[0], Score = int.Parse(parts[1]) });
            }

            //Sort the list in descending order using LINQ's OrderByDescending, then save that list as highScore.
            var highScore = scores.OrderByDescending(s => s.Score).ToList();

            //Print that list to console.
            foreach (var score in highScore)
            {
                Console.WriteLine($"{score.Name} {score.Score}");
            }
        }
    }
}