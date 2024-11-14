using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the minimum number: ");
            int minNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the maximum number: ");
            int maxNumber = int.Parse(Console.ReadLine());

            

            int[,] frequencyArray = new int[maxNumber - minNumber + 1, 2];

            for (int i = 0; i < frequencyArray.GetLength(0); i++)
            {
                frequencyArray[i, 0] = minNumber + i;
                frequencyArray[i, 1] = 0; 
            }

            Random random = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int randomNumber = random.Next(minNumber, maxNumber + 1);
                int index = randomNumber - minNumber;

                frequencyArray[index, 1]++;
            }

            Console.WriteLine("\nNumber\tFrequency");
            for (int i = 0; i < frequencyArray.GetLength(0); i++)
            {
                Console.WriteLine(frequencyArray[i, 0] + "\t" + frequencyArray[i, 1]);
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            Console.WriteLine("Array index out of range exception occurred.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            Console.WriteLine("Please enter valid numeric values.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
