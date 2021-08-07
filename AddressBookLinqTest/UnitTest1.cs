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
            [TestMethod]
             void DeleteCOntactTest()
            {
                int expected = 1;
                addressBook.AddAddresss();
                int actual = addressBook.DeleteContact(3);
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
             void RetrivalBaseonCityOrStateTest()
            {
                string expected = "ruby james";
                addressBook.AddAddresss();
                string actual = addressBook.RetriveOnCityOrState("trichy", "TamilNadu");
                Assert.AreEqual(expected, actual);
            }
        
            [TestMethod]
            void CountBaseonCityOrStateTest()
            {
                string expected = "ymg 1 madurai 2 abc 1 salem 1 trichy 1 ";
                addressBook.AddAddresss();
                string actual = addressBook.CountOfList();
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
