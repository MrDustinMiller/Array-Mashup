using System;
using System.Linq;

namespace ArrayMashup
{
    class Program
    {
        static void Main(string[] args)
        {
            //vars
            int arrayCountOne;
            int arrayCountTwo;

            //user input 
            arrayCountOne = PromptInt("How big should the first array be? ");                                           
            int[] array1 = new int[arrayCountOne];

            //user input 
            arrayCountTwo = PromptInt("How big should the second array be? ");                            
            int[] array2 = new int[arrayCountTwo];

            //passing arguements to function/calling function
            FillArray(ref array1, ref array2);                                  
            CombineArray(ref array1, ref  array2);                               
    
        }//end main

        static void FillArray(ref int[] array1, ref int[] array2)
        {            
            Console.WriteLine("\nFill the first array. ");

            //for loop to populate first array
            for (int i = 0; i < array1.Length; i++)                           
            {
                //store user input into first array
                array1[i] = PromptInt($"Array entry {i} = ");                                                  

            }//end for

            Console.WriteLine("\nFill the second array. ");

            //for loop to populate second array
            for (int i = 0; i < array2.Length; i++)                         
            {
                //store user input into second array
                array2[i] = PromptInt($"Array entry {i} = ");              

            }//end for
        }//end function

         static int CombineArray(ref int[] array1, ref int[] array2)
         {
            //create new array with size of array1 & array2                                        
            int[] NewArray = new int[array1.Length + array2.Length];

            //combine the two arrays into our new array
            NewArray = array1.Concat(array2).ToArray();

            //call function
            PrintArray(ref NewArray);                                    
            return NewArray.Length;
            
        }//end function

         static void PrintArray(ref int[] NewArray)
        {
            //create a new array that holds the combined array from prev func
            int[] CombinedArray = NewArray;                         

            Console.Write("\nThe combined array is --> [");

            //loop through/display the new combined arrays elements
            foreach (var item in CombinedArray)                    
            {
                Console.Write("{0},", item);
                
            }//end for
            Console.Write("]");
        }//end function

        static string Prompt(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }//end function

        //error checking. if anything but a num is inputted this will turn to false
        //and output instructions.
        static int PromptInt(string message)        
        {                                           
            int value = 0;

            while (int.TryParse(Prompt(message), out value) == false)
            {
                Console.WriteLine("Invalid input! Numbers only please.");
            }//end while

            return value;
        }
    }//end program
}//end namespace
