using System.Diagnostics;

public class BigO
{
    private static string[] nemo = new string[]{ "nemo" };
    private static string[] everyone = new string[]{ "dory", "bruce", "marlin", "nemo", "gill", "bloat",
        "nigel", "squirt", "darla", "hank" };
    private static string[] largeArray = Enumerable.Repeat("nemo", 100000).ToArray();
    private static int[] boxes = new int[]{ 0, 1, 2, 3, 4, 5 };

    public static void BigOScalability()
    {
        //FindNemo(largeArray);
        LogFirstTwoBoxes(boxes);
    }

    public static void FindNemo(string[] array) { // Big-O => O(n) --> Linear Time
        //Stopwatch sw = Stopwatch.StartNew();
        //sw.Start();
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] == "nemo") {
                Console.WriteLine("Found NEMO!");
            }
        }
        //sw.Stop();
        //Console.WriteLine($"Call to find Nemo took: {sw.Elapsed.TotalMilliseconds} milliseconds");
    }

    public static void LogFirstBox(int[] boxes) { // Big-O => O(1) --> Constant Time
        Console.WriteLine(boxes[0]); // Just grabbing the first item
    }

    public static void LogFirstTwoBoxes(int[] boxes) { // Big-O => O(2) --> Constant Time ( O (1))
        Console.WriteLine(boxes[0]); // O(1)
        Console.WriteLine(boxes[1]); // O(1)
    }

    public static int FunChallenge(int[] input) {
        var a = 10; // O(1) - it's executed once in the function
        a = 50 + 3; // O(1) - it's executed once in the function
        for (var i = 0; i < input.Length; i++) // O(n) - n is the input
        {
            AnotherFunction(); // O(n) - The call to the function is done for every iteration
            var stranger = true; // O(n) - The assignment is done for every iteration
            a++; // O(n) - The assignment is done for every iteration
        }

        return a; // O(1) - it's executed once in the function
    }
    // 3 steps + n + n + n + n
    // BIG O(3 + 4n)

    public static void AnotherFunction()
    {
    }
}