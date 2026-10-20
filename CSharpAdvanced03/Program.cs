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

            #region Exercise 3: Phone Book

            // 1. Create a Phone Book with 4 contacts
            Dictionary<string, string> phoneBook = new Dictionary<string, string>
                {
                   { "Ahmed", "01012345678" },
                   { "Sara", "01123456789" },
                   { "Mona", "01234567890" },
                   { "Ali", "01512345678" }
                };

            // 2. Add a new contact using [] syntax
            phoneBook["Omar"] = "01098765432";

            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.WriteLine("Phone Book:");
            Console.WriteLine("Contact added using [] syntax.");

            // 3. Try adding a duplicate using Add()
            try
            {
                phoneBook.Add("Ahmed", "01000000000");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Add Error: {ex.Message}");
            }

            // 4. Try adding a duplicate using TryAdd()
            bool added = phoneBook.TryAdd("Ahmed", "01000000000");

            Console.WriteLine($"TryAdd succeeded: {added}");

            // 5. Search for a contact that doesn't exist
            bool exists = phoneBook.ContainsKey("Youssef");

            Console.WriteLine($"Youssef exists: {exists}");

            // 6. Get a contact with a fallback of "Not Found"
            string phoneNumber = phoneBook.GetValueOrDefault(
                "Youssef",
                "Not Found"
            );

            Console.WriteLine($"Youssef's phone number: {phoneNumber}");

            // 7. Print all Keys and Values
            Console.WriteLine("\nContact Names:");
            Console.WriteLine(string.Join(", ", phoneBook.Keys));

            Console.WriteLine("\nPhone Numbers:");
            Console.WriteLine(string.Join(", ", phoneBook.Values));

            #endregion

            #region Exercise 4: Unique Email Validator

            // 1. Create a case-insensitive HashSet
            HashSet<string> emails = new HashSet<string>(
                StringComparer.OrdinalIgnoreCase
            );

            // 2. Add emails
            emails.Add("ahmed@test.com");
            emails.Add("AHMED@test.com");
            emails.Add("sara@test.com");
            emails.Add("Sara@Test.Com");

            // 3. Print Count
            Console.WriteLine("Unique Emails Count: " + emails.Count);
            Console.WriteLine("Stored Emails:");

            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

            // 4. Create Set A and Set B
            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            // Create copies for independent operations
            HashSet<int> unionSet = new HashSet<int>(setA);
            HashSet<int> intersectionSet = new HashSet<int>(setA);
            HashSet<int> differenceSet = new HashSet<int>(setA);

            // 5. UnionWith
            unionSet.UnionWith(setB);

            Console.WriteLine("\nUnionWith:");
            Console.WriteLine(string.Join(", ", unionSet.OrderBy(n => n)));

            // 6. IntersectWith
            intersectionSet.IntersectWith(setB);

            Console.WriteLine("\nIntersectWith:");
            Console.WriteLine(string.Join(", ", intersectionSet.OrderBy(n => n)));

            // 7. ExceptWith
            differenceSet.ExceptWith(setB);

            Console.WriteLine("\nExceptWith:");
            Console.WriteLine(string.Join(", ", differenceSet.OrderBy(n => n)));

            // 8. IsSubsetOf
            HashSet<int> subset = new HashSet<int> { 1, 2 };

            Console.WriteLine(
                $"\nIs {{1, 2}} a subset of Set A? {subset.IsSubsetOf(setA)}"
            );

            #endregion
        }
    }
}
