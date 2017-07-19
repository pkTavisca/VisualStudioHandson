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
            Console.Write("Enter user name: ");
            string name = Console.ReadLine();
            Console.Write("Enter user's city: ");
            string city = Console.ReadLine();
            Console.Write("Enter user's street: ");
            string street = Console.ReadLine();
            Console.Write("Enter user's pin: ");
            string pin = Console.ReadLine();
            Console.Write("Enter user's house number: ");
            string houseNo = Console.ReadLine();

            Console.WriteLine(name + "\n" + houseNo + "\n" + street + "\n" + city + " - " + pin);
        }
    }
}
