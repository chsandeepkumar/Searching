public class BinarySearchService
{
    public static int SearchItem(int[]inputCollection,int targetItem)
    {
        
        if(inputCollection.Length==0) return -1;
        int startIndex=0;
        int maxIndex=inputCollection.Length-1;
        while(startIndex<=maxIndex)
        {
            int guessItemIndex=ComputeGuessItemIndex(startIndex,maxIndex);        
            if(targetItem==inputCollection[guessItemIndex]) return guessItemIndex;

            if(targetItem<inputCollection[guessItemIndex])
            maxIndex=guessItemIndex-1;
            else
            startIndex=guessItemIndex+1;            
        }

        return -1;
    }

    private static int ComputeGuessItemIndex(int startIndex, int maxIndex)=> startIndex+maxIndex/2;
    
}
