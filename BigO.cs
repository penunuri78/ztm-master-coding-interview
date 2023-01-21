using System.Diagnostics;

public class BigO
{
    private static string[] nemo = new string[]{ "nemo" };
    private static string[] everyone = new string[]{ "dory", "bruce", "marlin", "nemo", "gill", "bloat",
        "nigel", "squirt", "darla", "hank" };
    private static string[] largeArray = Enumerable.Repeat("nemo", 100000).ToArray();

    public static void BigOScalability()
    {
        FindNemo(largeArray);
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
}