using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal class Employee
    {
        public string Name { get; }
        public string Role { get; }
        public int Money { get; }

        public Employee(string name, string role, int money)
        {
            Name = name;
            Role = role;
            Money = money;
        }

        public override string ToString()
        {
            return $"{Role}: {Name} + {Money} kč";
        }
    }
}
