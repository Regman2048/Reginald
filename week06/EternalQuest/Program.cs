public class Program
{
    /*
    Exceeding Requirements / Creativity Report:

    1.  Gamification Enhancements:
        -   **Leveling System:** Implemented a points-based leveling system (`_levelThresholds` and `_levelNames` dictionaries) that gives the user a sense of progression beyond just accumulating points. When enough points are earned, the user "levels up" and receives a congratulatory message.
        -   **Custom Level Names:** Instead of just "Level X", each level (up to 13) has a unique, thematic name (e.g., "Acolyte of Aspiration", "Ninja Unicorn!"). This adds a fun, personal, and whimsical touch to the user's "Eternal Quest."
        -   **Thematic Messages:** Added celebratory messages for leveling up and a farewell message consistent with the "quest" theme.

    2.  Additional Goal Types:
        -   **ProgressGoal:** This new goal type addresses the need to track progress on large, long-term goals (e.g., running a marathon, writing a book).
            -   Users define a `targetProgress` and `pointsPerUnit`.
            -   When recording, they input `units` of progress, and points are awarded proportionally.
            -   A bonus is awarded upon reaching the `targetProgress`.
            -   This goes beyond simple "complete once" or "repeatable" goals.
        -   **NegativeGoal:** This goal type allows users to track bad habits.
            -   Recording a `NegativeGoal` results in a deduction of points (a penalty).
            -   This provides a mechanism for users to be accountable for behaviors they want to reduce or eliminate, adding another layer of gamification (loss aversion).

    3.  Robust Save/Load Functionality:
        -   The save/load system is designed to handle the new goal types seamlessly due to the `GetStringRepresentation` and a factory-like parsing within `LoadGoals`.
        -   Includes basic error handling for file operations (e.g., `FileNotFoundException`, general `Exception` for corrupted files).

    4.  Improved User Experience:
        -   Enhanced input validation for numerical inputs (points, target amounts, etc.) to prevent crashes and guide the user.
        -   Clearer console output messages for recording events, saving/loading, and goal listing.
    */
    public static void Main(string[] args)
    {
        QuestManager manager = new QuestManager();
        manager.StartQuest();
    }
}
