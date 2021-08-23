using System;

namespace Exercise32
{
    class Program
    {
        static void Main(string[] args)
        {

           
            bool goOn = true;
            while (goOn == true)
            {

                int[] newArray = new int[5] { 2, 8, 0, 24, 51 };

                Console.WriteLine("Please enter a number");
                int num = Convert.ToInt32(Console.ReadLine());


                int index = FindInt(num, newArray); //Calls Method below
                if (index >= 0)
                {
                    Console.WriteLine($"The value {num} can be found at index {index}");

                }
                else if (index < 0)
                {
                    Console.WriteLine("Value not found in the array.");
                }


                //Continue
                while (true)
                {
                    Console.WriteLine("Would you like to continue? yes/no");
                    string answer = Console.ReadLine();

                    if (answer.ToLower() == "yes")
                    {
                        goOn = true;
                        break;
                    }
                    else if (answer.ToLower() == "no")
                    {
                        Console.WriteLine("Good Bye!");
                        goOn = false;

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Im sorry I didnt understand that lets try again");
                        break;
                    }
                }
            }
        }
        //Method to find number
        public static int FindInt(int user, int[] newArray)
        {


            int newInt = -1;
            for (int i = 0; i < newArray.Length; i++)
            {

                if (newArray[i] == user)
                {
                    newInt = i;
                }
                
            }
            return newInt;








        }
    }
}