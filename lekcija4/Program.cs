using System;

namespace lekcija4
{
    class Program
    {
        static void Main(string[] args)
        {
            //TaskIn1To10();
            TaskAlarmClock();
        }

        public static void TaskAlarmClock()
        {
            Console.WriteLine("Enter 1 if you are on vacation:");
            var vacationValue = Console.ReadLine();
            Console.WriteLine("...:");

            for (int i = 0; i <= 6; i++)
            {
                string alarm = i == 0 || i == 6 ? "10:00" : "7:00";
                if (vacationValue == "1") alarm = i == 0 || i == 6 ? "off" : "10:00";
                Console.WriteLine($"{i} {alarm}");
            }
            Console.WriteLine("Again? Enter 1 if YES:");
            var cont = Console.ReadLine();
            Console.WriteLine("----------");
            if (cont == "1")
            {
                TaskAlarmClock();
            }
        }

        public static void TaskIn1To10()
        {
            Console.WriteLine("Enter 1 if use OutsideMode");
            var outsideModeValue = Console.ReadLine();
            var outsideMode = outsideModeValue == "1";

            Console.WriteLine($"Thank you! Use OutsideMode: {outsideMode}");
            Console.WriteLine("Enter number N:");
            var numberValue = Console.ReadLine();
            var number = Int32.Parse(numberValue);


            if (outsideMode)
            {
                if (number <= 1 || number >= 10)
                {
                    Console.WriteLine("TRUE");
                }
                else
                {
                    Console.WriteLine("FALSE");
                }
            }
            else
            {
                if (number <= 1 || number >= 10)
                {
                    Console.WriteLine("FALSE");
                }
                else
                {
                    Console.WriteLine("TRUE");
                }
            }
            Console.WriteLine("Continue? Enter 1 if YES:");
            var cont = Console.ReadLine();
            Console.WriteLine("----------");
            if (cont == "1")
            {
                TaskIn1To10();
            }
        }
    }
}
