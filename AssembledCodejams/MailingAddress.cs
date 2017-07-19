using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembledCodejams
{
    public class MailingAddress
    {
        public static void DisplayMailingAddress()
        {
            //Input
            Console.Write("Enter user name: ");
            string name = Console.ReadLine();
            Console.Write("Enter user's house number: ");
            string houseNo = Console.ReadLine();
            Console.Write("Enter user's street: ");
            string street = Console.ReadLine();
            Console.Write("Enter user's city: ");
            string city = Console.ReadLine();
            Console.Write("Enter user's pin: ");
            long pin;
            long.TryParse(Console.ReadLine(), out pin);

            //Assigning to an object
            UserAddress address = new UserAddress(name, houseNo, street, city, pin);

            //Overridden ToString method
            Console.WriteLine(address.ToString());
        }
    }
}
