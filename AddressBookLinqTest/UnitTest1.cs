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

            [TestMethod]
             void EditCOntactTest()
            {
                int expected = 1;
                addressBook.AddAddresss();
                int actual = addressBook.EditContact(4, "Siva", 8976541230);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
