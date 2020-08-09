using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Serialization.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private class Customer
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
        }

        [TestMethod]
        public void TestMethod1()
        {
            var customer = new Customer() {Firstname = "Jack", Lastname = "Sparrow"};
            var expectedXml = "<Customer>" +
                           "<Firstname>Jack</Firstname>" +
                           "<Lastname>Sparrow</Lastname>" +
                           "</Customer>";
            
            var actualXml = Serializer.Serialize(customer);

            actualXml.Should().Be(expectedXml);
        }
    }
}
