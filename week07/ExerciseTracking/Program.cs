public class Program
{
    public static void Main(string[] args)
    {
        // Create a list to hold various activity objects
        List<Activity> activities = new List<Activity>();

        // Create instances of each activity type and add them to the list
        activities.Add(new Running(new DateTime(2022, 11, 03), 30, 4.8));   // Example: 4.8 km in 30 min
        activities.Add(new Cycling(new DateTime(2022, 11, 03), 45, 25.0));  // Example: 25.0 kph for 45 min
        activities.Add(new Swimming(new DateTime(2022, 11, 04), 20, 40));   // Example: 40 laps (50m each) in 20 min
        activities.Add(new Running(new DateTime(2022, 11, 05), 60, 10.0));  // Another running example
        activities.Add(new Cycling(new DateTime(2022, 11, 06), 30, 30.0));  // Another cycling example

        // Iterate through the list of activities and display their summaries
        Console.WriteLine("--- Fitness Activity Summaries ---");
        foreach (Activity activity in activities)
        {
            // Polymorphism in action: The correct GetSummary method (or the base one
            // calling the correct overridden calculation methods) is invoked
            // based on the actual type of the 'activity' object at runtime.
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine("----------------------------------");
    }
}
