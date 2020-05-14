using System;
public class ArrayUtils
{
    public static void PrintSubArray(int[] inputArray)
    {
        if(inputArray.Length==0) Console.WriteLine(" there are no array elements");
        
        for(int startIndex=0;startIndex<inputArray.Length;startIndex++)
        {
            for(int subArrayStartIndex=startIndex;subArrayStartIndex<=inputArray.Length;subArrayStartIndex++)
            {
                for(int arrayIndex=startIndex;arrayIndex<subArrayStartIndex;arrayIndex++){
                    
                    Console.Write(inputArray[arrayIndex]);
                }
                Console.WriteLine();
            }
        }
    }
}