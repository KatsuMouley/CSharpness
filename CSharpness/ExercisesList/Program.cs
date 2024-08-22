using System.Runtime.CompilerServices;

namespace ExercisesList;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new();
        int sizeOfArray = rand.Next(5, 10), temp;
        int[] intArray = new int[sizeOfArray];

        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = rand.Next(1, 64);
        }

        Console.WriteLine("Unsorted value of the array");

        for (int i = 0; i < intArray.Length; i++)
        {
            if (i != (intArray.Length - 1))
            {
                Console.Write(intArray[i] + ", ");
            }
            else
            {
                Console.Write(intArray[i] + ".\n");
            }
        }
        bool swapped = false;

        for (int i = 0; i < intArray.Length - 1; i++)
        {
            swapped = false;
            //the outside loop verifys if the swap occured
            for (int j = 0; j < intArray.Length - i/*with this we verify the value before*/ - 1; j++)//NOW I FINALLY understand this :3
            {
                //the inner loop do the swap
                if (intArray[j] > intArray[j + 1])
                {

                    temp = intArray[j];
                    intArray[j] = intArray[j + 1];
                    intArray[j + 1] = temp;
                    swapped = true;
                }
            }
            if (swapped == false)
                break;
        }

        Console.WriteLine("Sorted value of the array");

        for (int i = 0; i < intArray.Length; i++)
        {
            if (i != (intArray.Length - 1))
            {
                Console.Write(intArray[i] + ", ");
            }
            else
            {
                Console.Write(intArray[i] + ".\n");
            }
        }

    }
}
