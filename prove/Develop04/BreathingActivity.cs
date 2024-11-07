// Breathing Activity Class Code.
class BreathingActivity : Activity
{
    //BreathingActivity Class inherits from the base Activity class and gives a name and description for the activity. Constructor.
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through deep breathing.")
    {

    }

    //Method that performs the breathing activity. Asks for user duration of activity and gives them intervals to breathe in and out.
    public override void PerformActivity()
    {
        StartActivity();
        int remainingTime = _duration;
        while (remainingTime > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            ShowPauseAnimation(3);
            Console.WriteLine("Breathe out...");
            ShowPauseAnimation(6);
            remainingTime -= 9; //Remaining time should be -= # that is the sum of the pause animation durations.
        }
        EndActivity();
    }
}