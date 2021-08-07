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
        List<ContactDetails> AddAddresss()
        {


            address.Add(new ContactDetails { PersonId = 1, Addbookname = "TVS", FirstName = "xxx", LastName = "yyy", Address = "crosss street", State = "kerala", City = "ymg", ZipCode = 589643, PhoneNumber = 8667361462, Email = "xxx@gmail.com" });
            address.Add(new ContactDetails { PersonId = 2, Addbookname = "Zoho", FirstName = "abc", LastName = "def", Address = "aaaa coloney", State = "TamilNadu", City = "madurai", ZipCode = 546214, PhoneNumber = 8756432109, Email = "abc@gmail.com" });
            address.Add(new ContactDetails { PersonId = 3, Addbookname = "CTS", FirstName = "vvv", LastName = "ssss", Address = "srs road", State = "Kerala", City = "zzz", ZipCode = 456123, PhoneNumber = 9874563210, Email = "vvv@gmail.com" });
            address.Add(new ContactDetails { PersonId = 6, Addbookname = "TCS", FirstName = "siva", LastName = "hari", Address = "KK nagar", State = "TamilNadu", City = "madurai", ZipCode = 123654, PhoneNumber = 6541230987, Email = "siva@gmail.com" });
            address.Add(new ContactDetails { PersonId = 4, Addbookname = "INFO", FirstName = "bala", LastName = "vikram", Address = "market road", State = "TamilNadu", City = "salem", ZipCode = 456987, PhoneNumber = 9871236540, Email = "bala@gmail.com" });
            address.Add(new ContactDetails { PersonId = 5, Addbookname = "CTS", FirstName = "ruby", LastName = "james", Address = "mr nagar", State = "kerala", City = "trichy", ZipCode = 8546321, PhoneNumber = 6547893210, Email = "ruby@gmail.com" });

            return address;
        }
    }
}
