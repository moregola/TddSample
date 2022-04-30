using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DomainTests.UnityTest
{
    public class DefaultValuoObjectTest
    {

        /// <summary>
        /// A theory should be a test where you put some date on validation
        /// Validation of object construction
        /// Validation of conversions 
        /// Create all test cases to work and not work 
        /// Ensure the consistency of domain class and sample to code use
        /// </summary>
        /// <param name="numberSample"></param>
        /// <param name="sample"></param>
        [Theory(DisplayName = "value_string_sample")]
        [InlineData(1, "sample")]
        public void Test1(int numberSample, string sample)
        {
            var textNewValueSample = "teste";
            var numberNewValueSample = 1;
            Assert.Equal(sample, textNewValueSample);
            Assert.Equal(numberSample, numberNewValueSample);
        }
    }
}
