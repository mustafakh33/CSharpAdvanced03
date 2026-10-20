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
        }
    }
}
