using System;

namespace HundredDoors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Application");

            // Declaring array with 100 string values and adding values to array
            string[] Doors = new string[100];
            Console.WriteLine("Creating the Doors Array");
            for (int i = 0; i < 100; i++)
            {
                Doors[i] = "#";
            }

            //Print current array values and array lenght
            Console.Write("The current lenght of the Array is: ");
            Console.WriteLine(Doors.Length);
            foreach (string item in Doors)
            {
                Console.Write(item);
            }
            Console.WriteLine("");

            //Use a While loop to go through every value and change it to an Open Door'@'
            int x = 0;
            while (x < 100)
            {
                if (String.Equals(Doors[x], "#"))
                {
                    Doors.SetValue("@", x);
                }
                else
                {
                    Console.WriteLine("One of the items was not a closed door");
                    return;
                }
                x++;
            }

            //Print current array values
            foreach (string item in Doors)
            {
                Console.Write(item);
            }
            Console.WriteLine("");


            //Use a reverse for loop to go through every 2nd value and change it to a Close Door'#'
            for (int i = Doors.Length -1; i >= 0; i-=2)
            {
                Doors.SetValue("#", i);
            }

            //Print current array values
            foreach (string item in Doors)
            {
                Console.Write(item);
            }
            Console.WriteLine("");


            //Use a For loop to go through every 3rd value and change it to an Toggle the Door to the opposite state (Closed = '#' Open = '@')
            for (int i = 2; i < 99; i+=3) 
            {
                if (String.Equals(Doors[i], "#"))
                {
                    Doors.SetValue("@", i);
                }
                else if (String.Equals(Doors[i], "@"))
                {
                    Doors.SetValue("#", i);
                }
                else
                {
                    Console.WriteLine("Something went wrong: Firstpass Loop");
                    break;
                }
            }

            //Print current array values
            foreach (string item in Doors)
            {
                Console.Write(item);
            }
            Console.WriteLine("");

            Console.WriteLine("The program is Done, check your results");
        }
    }
}
