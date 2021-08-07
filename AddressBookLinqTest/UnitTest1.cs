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
             void InsertionTest()
            {
                int expected = 1;
                int actual = addressBook.InsertIntoAddressBook(new ContactDetails());
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
