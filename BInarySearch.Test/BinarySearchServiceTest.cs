using Xunit;

namespace BinarySearching.Test
{
    public class BinarySearchServiceTest
    {
        [Fact]
        public void When_Collection_Is_Empty_BinarySearch_Return_Negative_Index()
        {
            var emptyCollection = new int [0];

            var result = BinarySearchService.SearchItem(new int[0], 12);

            Assert.True(result<0);

        }
        [Fact]
        public void When_SortedCollection_Given_BinarySearch_Return_Index_of_TargetItem()
        {
            var collection = new int[3]{1,2,4};

            var result = BinarySearchService.SearchItem(collection, 4);

            Assert.True(result > 0);
            Assert.True(result==2);

        }
    }
}
