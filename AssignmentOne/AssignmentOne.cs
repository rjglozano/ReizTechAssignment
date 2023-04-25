namespace ClockAngleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Hour (0-12): ");
            int hour = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Minute (0-59):");
            int minute = int.Parse(Console.ReadLine());

            double angle = Math.Abs((0.5 * (60 * hour + minute)) -  (6 * minute));

            if (angle > 180)
            {
                angle = 360 - angle;
            }

            Console.WriteLine("The lesser angle between the hour and minute hand is " + angle + " degrees.");
            Console.ReadLine();
        }
    }
}