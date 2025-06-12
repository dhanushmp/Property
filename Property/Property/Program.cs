namespace Property
{
    class Customer
    {
        int _Custid;
        bool _Status;
        string _Cname, _State;
        double _Balance;
        Cities _City;

        public Customer(int Custid, bool Status, string Cname, double Balance, Cities city,string state)
        {
            _Custid = Custid;
            _Status = Status;
            _Cname = Cname;
            _Balance = Balance;
            _City = city;
            _State = state;

        }

        public int Custid
        {
            get
            {
                return _Custid;
            }

        }
        public bool Status
        {
            get
            {
                return _Status;
            }
            set
            {
                if (_Status == true)
                {
                    _Status = value;
                }

            }
        }
        public string Cname
        {
            get
            {
                return _Cname;
            }
            set
            {
                if (_Status == true)
                {
                    _Cname = value;
                }
            }
        }
        public double Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                _Balance = value;
            }
        }
        public Cities City
        {
            get
            {
                return _City;
            }
            set
            {
                if (_Status == true)
                {
                    _City = value;
                }
            }
        }
        public string State
        {
            get
            {
                return _State;
            }
            protected set
            {
                if (_Status == true)
                {
                    _State = value;
                }
            }
        }

        public string Country { get; } = "India";

    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Customer cus = new Customer(101, false, "John Doe", 5000.00, Cities.Chicago,"Telangana");
            Console.WriteLine("Customer ID: " + cus.Custid);
            Console.WriteLine("Customer Name: " + cus.Cname);
            Console.WriteLine("Customer Status: " + cus.Status);
            Console.WriteLine("Customer Balance: " + cus.Balance);
            Console.WriteLine("Customer City:"+ cus.City);

            Console.WriteLine();

            Console.WriteLine("Modified value");
            cus.Cname = "Dhanush";

            Console.WriteLine("Customer Name: " + cus.Cname);
            cus.City = Cities.Houston;
           // cus.State = "Telangana"; // This will not change as State is protected set
            Console.WriteLine("Modified City: " + cus.City);

            Console.WriteLine("Customer Country:"+cus.Country);

        }
        }
    
}
