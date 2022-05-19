using System;

namespace Ex04.Menus.Test
{
    public class Data
    {
        public static readonly string SubMenu1 = "Show Date/Time";
        public static readonly string SubMenu2 = "Version and Spaces";
        public static readonly string TimeItem = "Show Time";
        public static readonly string DateItem = "Show Date";
        public static readonly string CountSpacesItem = "Count Spaces";
        public static readonly string VersionItem = "Show Version";

        public static void ShowTime()
        {
            DateTime localTime = DateTime.Now.ToLocalTime();

            Console.WriteLine("Current Time: {0}", localTime.ToString("HH:mm:ss"));
        }

        public static void ShowDate()
        {
            DateTime localDate = DateTime.Now.ToLocalTime();

            Console.WriteLine("Current Date: {0}", localDate.Date.ToString("dd/MM/yyy"));
        }

        public static void CountSpaces()
        {
            string userInput;
            int spacesCounter = 0;

            Console.WriteLine("Please enter your sentence:");
            userInput = Console.ReadLine();

            foreach (char currentChar in userInput)
            {
                if (currentChar == ' ')
                {
                    spacesCounter++;
                }
            }

            Console.WriteLine("There are {0} Spaces in your sentence", spacesCounter);
        }

        public static void ShowVersion()
        {
            Console.WriteLine("Version: 22.2.4.8950");
        }
    }
}
