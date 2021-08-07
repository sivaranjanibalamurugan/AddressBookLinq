using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBookLinq;

namespace AddressBookLinqTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AddressBookManager addressBook;
            [TestInitialize]
             void TestSetUp()
            {
                addressBook = new AddressBookManager();
            }
            [TestMethod]
             void TestMethod1()
            {
            }
        }
    }
}
