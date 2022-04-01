using Xunit;

namespace BestWorkshop.SearchCitiesTests
{
    public class SearchCitiesFeature
    {
        [Theory]
        [InlineData("Va", new[] {"Valencia", "Vancouver"})]
        [InlineData("Val", new[] {"Valencia"})]
        public void GivenAListOfCities_WhenSearch_ThenReturnsCitiesStartingWithSearchText(string searchText, string[] output)
        {

        }


    }
}
