class Program
    {
        static void Main(string[] args)
        {
            // Report on what has been done to exceed requirements:
            // 1. Activity Log: The program now keeps track of how many times each
            //    activity has been completed. This log can be viewed from the main
            //    menu (option 4). The `_activitiesLog` dictionary in the `App` class
            //    stores and manages this data.
            // 2. Unique Reflection Questions: In the Reflection Activity, a `_unusedQuestions`
            //    list is used to ensure that all available reflection questions are
            //    presented to the user at least once before any question is repeated
            //    within a single activity session. This provides a more varied and
            //    comprehensive reflection experience.
            // 3. Enhanced Breathing Animation: The Breathing Activity now includes
            //    a more meaningful text animation where the "Breathe in..." and
            //    "Breathe out..." messages visually "grow" and "shrink" by adding
            //    or removing dots, providing a subtle visual cue for the breathing pace.
            App app = new App();
            app.Run();
        }
    }
}
