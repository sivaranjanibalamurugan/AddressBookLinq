using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
   public class AddressBookManager
   {
        List<ContactDetails> address;
        //adding item to the address book
       public List<ContactDetails> AddAddresss()
        {


            address.Add(new ContactDetails { PersonId = 1,  FirstName = "xxx", LastName = "yyy", Address = "crosss street", State = "kerala", City = "ymg", ZipCode = 589643, PhoneNumber = 8667361462, Email = "xxx@gmail.com" });
            address.Add(new ContactDetails { PersonId = 2,  FirstName = "abc", LastName = "def", Address = "aaaa coloney", State = "TamilNadu", City = "madurai", ZipCode = 546214, PhoneNumber = 8756432109, Email = "abc@gmail.com" });
            address.Add(new ContactDetails { PersonId = 3,  FirstName = "vvv", LastName = "ssss", Address = "srs road", State = "Kerala", City = "zzz", ZipCode = 456123, PhoneNumber = 9874563210, Email = "vvv@gmail.com" });
            address.Add(new ContactDetails { PersonId = 6,  FirstName = "siva", LastName = "hari", Address = "KK nagar", State = "TamilNadu", City = "madurai", ZipCode = 123654, PhoneNumber = 6541230987, Email = "siva@gmail.com" });
            address.Add(new ContactDetails { PersonId = 4,  FirstName = "bala", LastName = "vikram", Address = "market road", State = "TamilNadu", City = "salem", ZipCode = 456987, PhoneNumber = 9871236540, Email = "bala@gmail.com" });
            address.Add(new ContactDetails { PersonId = 5,  FirstName = "ruby", LastName = "james", Address = "mr nagar", State = "kerala", City = "trichy", ZipCode = 8546321, PhoneNumber = 6547893210, Email = "ruby@gmail.com" });

            return address;
        }
        //UC2-Insert Into AddressBook
      public int InsertIntoAddressBook(ContactDetails contact)
      {
            contact.PersonId = 7;
            contact.FirstName = "suba";
            contact.LastName = "sri";
            contact.Address = "PS nagar";
            contact.City = "Madurai";
            contact.State = "Tamil nadu";
            contact.ZipCode = 865432;
            contact.PhoneNumber = 7856423695;
            contact.Email = "sri@gmail.com";
            AddAddresss();
            address.Add(contact);
            return 1;
      }
        //UC3-Edit contact
        public int EditContact(int personid, string firstName, long phoneNumber)
        {
            ContactDetails contact = (from add in address where add.PersonId == personid && add.FirstName.Equals(firstName) select add).First();
            if (contact == null)
            {
                return 0;
            }
            else
            {
                contact.PhoneNumber = phoneNumber;
                return 1;
            }
        }
        //UC5-Deteling the contact from list
        public int DeleteContact(int personid)
        {
            ContactDetails contact = (from add in address where add.PersonId == personid select add).First();
            if (contact == null)
            {
                return 0;
            }
            else
            {
                address.Remove(contact);
                return 1;
            }
        }
        //UC6- Retreive the data 
        public string RetriveOnCityOrState(string city, string state)
        {
            string result = "";
            var res = (from add in address where (add.City == city || add.State == state) select add).ToList();
            foreach (var r in res)
            {
                result += "" + r.FirstName + " ";
            }
            return result;
        }
        //UC7-Count the contact from list
        public string CountOfList()
        {
            string result = "";
            var res = address.GroupBy(x => x.City).Select(x => new { PersonId = x.Key, count = x.Count() });
            foreach (var r in res)
            {
                result += "" + r.PersonId + " " + r.count + " ";
            }
            return result;
        }
       

    }
}

