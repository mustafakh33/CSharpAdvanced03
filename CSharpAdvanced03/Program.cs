namespace CSharpAdvanced03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            List<int> grades = new List<int>{ 85, 92, 78, 95, 88, 70, 100, 65};

            // 1. Print the collection, Count, first and last grade
            Console.WriteLine("Original Grades:");
            Console.WriteLine(string.Join(", ", grades));

            Console.WriteLine($"Count: {grades.Count}");
            Console.WriteLine($"First Grade: {grades.First()}");
            Console.WriteLine($"Last Grade: {grades.Last()}");

            // 2. Sort grades ascending
            grades.Sort();

            Console.WriteLine("\nSorted Grades:");
            Console.WriteLine(string.Join(", ", grades));

            // 3. Get the first grade above 90
            int firstAbove90 = grades.Find(g => g > 90);

            Console.WriteLine($"\nFirst Grade Above 90: {firstAbove90}");

            // 4. Get all grades below 75
            List<int> failingGrades = grades
                .Where(g => g < 75)
                .ToList();

            Console.WriteLine("\nFailing Grades:");
            Console.WriteLine(string.Join(", ", failingGrades));

            // 5. Remove all failing grades
            grades.RemoveAll(g => g < 75);

            Console.WriteLine("\nGrades After Removing Failures:");
            Console.WriteLine(string.Join(", ", grades));

            // 6. Check if any grade equals 100
            Console.WriteLine($"\nHas Grade 100: {grades.Contains(100)}");

            // 7. Convert grades into strings
            List<string> gradeDescriptions = grades
                .Select(g => $"Grade: {g}")
                .ToList();

            Console.WriteLine("\nGrade Descriptions:");
            Console.WriteLine(string.Join(", ", gradeDescriptions));
            #endregion

            #region Exercise 2: Leaderboard
            SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();

            // 1. Add players
            leaderboard.Add(500, "Ahmed");
            leaderboard.Add(200, "Sara");
            leaderboard.Add(800, "Ali");
            leaderboard.Add(350, "Mona");

            // 2. Print all entries
            Console.WriteLine("Leaderboard:");

            foreach (KeyValuePair<int, string> player in leaderboard)
            {
                Console.WriteLine($"Score: {player.Key}, Player: {player.Value}");
            }

            // 3. Access the first key and first value
            Console.WriteLine($"\nFirst Key: {leaderboard.First().Key}");
            Console.WriteLine($"First Value: {leaderboard.First().Value}");

            // 4. Check if score 500 exists
            Console.WriteLine($"\nScore 500 Exists: {leaderboard.ContainsKey(500)}");

            // 5. Safely get the player with score 999
            if (leaderboard.TryGetValue(999, out string? playerName))
            {
                Console.WriteLine($"Player with score 999: {playerName}");
            }
            else
            {
                Console.WriteLine("No player found with score 999.");
            }

            // 6. Remove the player with score 200
            leaderboard.Remove(200);

            Console.WriteLine("\nUpdated Leaderboard:");

            foreach (KeyValuePair<int, string> player in leaderboard)
            {
                Console.WriteLine($"Score: {player.Key}, Player: {player.Value}");
            }
            #endregion
        }
    }
}
