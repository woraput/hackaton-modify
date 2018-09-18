using System;
using Xunit;
using api;

namespace apitest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2,"This number no consecutive number")]
        [InlineData(4,"This number no consecutive number")]
        [InlineData(6,"1 2 3")]
        [InlineData(9,"4 5")]
        [InlineData(10,"1 2 3 4")]
        [InlineData(52,"3 4 5 6 7 8 9 10")]
        [InlineData(57,"28 29")]
        public void ConNumber(int totalnubmer, string expected)
        {
            var c = new Engine();
            var result = c.Calculate(totalnubmer);
            
            Assert.Equal(expected, result);         
        }
    }
}
