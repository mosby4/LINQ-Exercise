namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            { "Super Mario", "Halo", "F1 23", "FortNite", "Dungens and Dragons", };

            IEnumerable<string> nameLength = videoGames.OrderBy(str => str.Length);

            foreach (var name in nameLength)
            {
                Console.WriteLine(name);
            }

        }
    }
}
/*(Using Method Syntax)
Create a list of video game names..
Order the list of games by length of the game name.
Use the lambda expression in this exercise as well.
Where() - Filters a sequence of values based on a predicate.
Select()
OrderBy() - Sorts the elements of a sequence in ascending order.
Sum()
Average()
Count() - Returns the number of elements in a sequence.
Min()
Max()
Take() - Returns a specified number of contiguous elements from the start of a sequence.
Append() - Appends a value to the end of the sequence.
ThenBy() - Performs a subsequent ordering of the elements in a sequence in ascending order.
*/