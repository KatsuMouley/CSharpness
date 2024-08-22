using System.Runtime.CompilerServices;

namespace ExercisesList;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new();
        int sizeOfArray = rand.Next(5, 15), temp;
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

        Array.Sort(intArray);
        // bool swapped = false;
        // // My solution
        // for (int i = 0; i < intArray.Length - 1; i++)
        // {
        //     swapped = false;
        //     //the outside loop verifys if the swap occured
        //     for (int j = 0; j < intArray.Length - i - 1; j++)//NOW I FINALLY understand this :3
        //     {
        //         //the inner loop do the swap
        //         if (intArray[j] > intArray[j + 1])
        //         {

        //             temp = intArray[j];
        //             intArray[j] = intArray[j + 1];
        //             intArray[j + 1] = temp;
        //             swapped = true;
        //         }
        //     }
        //     if (swapped == false)
        //         break;
        // }

        // Teacher solution

        // do
        // {
        //     swapped = false;
        //     //the outside loop verifys if the swap occured
        //     for (int i = 0; i < intArray.Length - 1; i++)
        //     {
        //         //the inner loop do the swap
        //         if (intArray[i] > intArray[i + 1])
        //         {

        //             temp = intArray[i];
        //             intArray[i] = intArray[i + 1];
        //             intArray[i + 1] = temp;
        //             swapped = true;
        //         }
        //     }
        // } while (swapped == true);

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
