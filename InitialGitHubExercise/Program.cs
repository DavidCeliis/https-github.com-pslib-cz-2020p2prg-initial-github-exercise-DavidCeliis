using System;

namespace InitialGitHubExercise
{
    class Program
    {
        private const ConsoleColor INPUT_COLOR = ConsoleColor.Yellow; // color used for user inputs
        // https://docs.microsoft.com/cs-cz/dotnet/api/system.consolecolor?view=netcore-3.1
        // https://docs.microsoft.com/cs-cz/dotnet/api/system.console.foregroundcolor?view=netcore-3.1
        // https://docs.microsoft.com/cs-cz/dotnet/api/system.console.backgroundcolor?view=netcore-3.1

        static void Main(string[] args)
        {
            Console.WriteLine(ReadString("Zadejte jméno: "));
        }

        /// <summary>
        /// This method serves as prettier user input for strings
        /// </summary>
        /// <param name="label">description of expected user input</param>
        /// <returns>string with user input</returns>
        static string ReadString(string label)
        {
            ConsoleColor storedColor = Console.ForegroundColor; // store original color
            Console.Write(label); // write label given by parameter
            Console.ForegroundColor = INPUT_COLOR; // set color to predefined constant
            string result = Console.ReadLine(); // read some string
            Console.ForegroundColor = storedColor; // restore original color
            return result; // return user input
        }

        static int ReadInt(string label)
        {
            return 0;
        }
    }
}
