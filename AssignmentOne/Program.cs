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

            double hourHandAngle = 0.5 * (60 * hour + minute);
            double minuteHandAngle = 6 * minute;
            double angle = Math.Abs(hourHandAngle - minuteHandAngle);

            if (angle > 180)
            {
                angle = 360 - angle;
            }

            Console.WriteLine("The lesser angle between the hour and minute hand is {0} degrees.", angle);
            Console.ReadLine();
        }
    }
}