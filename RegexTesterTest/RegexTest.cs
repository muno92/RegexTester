using Bunit;
using RegexTester.Pages;
using RegexTester.Shared;
using Xunit;

namespace RegexTesterTest
{
    public class RegexTest : TestContext
    {
        [Fact]
        public void MatchWithoutOption()
        {
            var index = RenderComponent<Index>();

            index.Find("#pattern").Change("[a-z]+");
            index.Find("#input").Change("abc123");
            index.Find("button").Click();

            var matchWords = index.FindComponents<MatchWord>();
            
            Assert.Equal(1, matchWords.Count);
        }
        
        [Fact]
        public void NotMatchWithoutOption()
        {
            var index = RenderComponent<Index>();

            index.Find("#pattern").Change("[a-z]+");
            index.Find("#input").Change("ABC123");
            index.Find("button").Click();

            var matchWords = index.FindComponents<MatchWord>();
            
            Assert.Equal(0, matchWords.Count);
        }
    }
}
