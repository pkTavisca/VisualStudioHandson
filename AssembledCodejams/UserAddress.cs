namespace AssembledCodejams
{
    public class UserAddress
    {
        string name;
        string city;
        string street;
        long pin;
        string houseNo;

        public UserAddress(string name, string houseNo, string street, string city, long pin)
        {
            this.name = name;
            this.houseNo = houseNo;
            this.street = street;
            this.city = city;
            this.pin = pin;
        }

        override
        public string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n{3} - {4}", name, houseNo, street, city, pin);
        }
    }
}
