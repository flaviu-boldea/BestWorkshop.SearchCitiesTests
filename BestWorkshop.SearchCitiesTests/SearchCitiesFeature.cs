using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            var sut = new CitiesFinder();
            var actual = sut.Find(searchText);
            Assert.Equal(output, actual);
        }

        [Theory(Skip = "NotImplemented")]
        [InlineData("a", new string[] {})]
        [InlineData("", new string[] {})]
        public void GivenAListOfCities_WhenSearchLessThanTwoCharacters_ThenReturnsNoResults(string searchText, string[] output)
        {

        }

        // If the search text is fewer than 2 characters, then should return no expected.
        // (It is an optimization feature of the search functionality.)
        [Theory(Skip = "NotImplemented")]
        [InlineData("VA", new[] { "Valencia", "Vancouver" })]
        [InlineData("va", new[] { "Valencia", "Vancouver" })]
        public void TheSearchFunctionalityShouldBeCaseInsensitive(string nbChars, string[] result)
        {

        }

        // The search functionality should work also when the search text is just a part of a city name.
        // For example for search text �ape�, the function should return Budapest.
        [Theory(Skip = "NotImplemented")]
        [InlineData("aso", new[] { "Brasov" })]
        public void GivenAListOfCities_WhenSearchUsingAListOfCharacters_ThenReturnsAllCitiesContainingTheInputList(string searchText, string[] expected)
        {

        }

        [Fact(Skip = "NotImplemented")]
        public void ShouldReturnAllCitiesWhenTheSearchTextIsAnAsterix()
        {
        }
    }

    public class CitiesFinder
    {
        private readonly IList<string> _cities = new List<string>()
        {
            "Valencia", "Vancouver"
        };

        public string[] Find(string searchText)
        {
            return _cities.Where(c => c.StartsWith(searchText)).ToArray();
        }
    }
}
