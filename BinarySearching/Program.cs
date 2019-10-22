using System;

namespace BinarySearching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BinarySearch Engine Service Starts--------");
            int [] inputCollection = new [] {1,23,45,67,89,90,100,134,167,456};
            DisplayTheCollectionOfItems(inputCollection);
            
            Console.WriteLine("Please Enter the item to search in above collection");
            if(!int.TryParse(Console.ReadLine(),out int number))Console.WriteLine("The Input is not valid item to search in the above collection");

            var theItemPoistion=BinarySearchService.SearchItem(inputCollection,number);
            
            if(theItemPoistion>-1)
                Console.WriteLine($"The Item Found at indexpostion { theItemPoistion} ");
            else 
                Console.WriteLine($"The Item{number} not Found at indexpostion { theItemPoistion} ");
        }

        private static void DisplayTheCollectionOfItems(int[] inputCollection)
        {
            Console.Write($" The Index \t The Value\n");
           for(int index=0;index<=inputCollection.Length-1;index++)
           {
               Console.Write($" {index} \t\t {inputCollection[index]}\n");
           }
        }
    }
}
