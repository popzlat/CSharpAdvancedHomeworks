using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Customer : IEquatable<Customer>
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int MonthlySpend { get; set; }

        public Customer() { }
        public Customer(string name, string address, string city, int monthlySpend)
        {
            this.Name = name; this.Address = address; this.City = city; this.MonthlySpend = monthlySpend;
        }
        public void PrintCustomer()
        {
            Console.WriteLine($"Customer: {Name}, {Address}, {City}, {MonthlySpend}");
        }
        public int CompareTo(Customer c)
        {
            return this.MonthlySpend.CompareTo(c.MonthlySpend);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool Equals(Customer c)
        {
            if (c == null || this.GetType().Equals(c.GetType())) {
                return false;
            }
            else {
                return true;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public static bool operator ==(Customer a, Customer b)
        {
            if (object.ReferenceEquals(a, null)) {
                if (object.ReferenceEquals(b, null)) {
                    return true;
                }
                return false;
            }
            if (object.ReferenceEquals(b, null)) {
                if (object.ReferenceEquals(a, null)) {
                    return true;
                }
                return false;
            }
            return a.Name == b.Name && a.Address == b.Address && a.City == b.City;
        }
        public static bool operator !=(Customer a, Customer b)
        {
            return a.Name == b.Name && a.Address == b.Address && a.City == b.City;
        }







    }
}


