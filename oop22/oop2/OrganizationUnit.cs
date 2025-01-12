using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal class OrganizationUnit
    { 
        public string Name { get; }
        private List<Employee> Employees { get; } = new List<Employee>();
        public List<OrganizationUnit> SubUnits { get; } = new List<OrganizationUnit>();

        public OrganizationUnit(string name)
        {
            Name = name;
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void AddSubUnit(OrganizationUnit unit)
        {
            SubUnits.Add(unit);
        }

        public void DisplayHierarchy(string indent = "")
        {
            Console.WriteLine($"{indent} oddělení: {Name}");
            Console.WriteLine($"{indent} zaměstnanci:");
            foreach (var employee in Employees)
            {
                Console.WriteLine($"{indent}  - {employee}");
            }
            foreach (var subUnit in SubUnits)
            {
                subUnit.DisplayHierarchy(indent + "  ");
            }
        }

        public int GetTotalEmployees()
        {
            int count = Employees.Count;
            foreach (var subUnit in SubUnits)
            {
                count += subUnit.GetTotalEmployees();
            }
            return count;
        }
        public int GetTotalmoney()
        {
            int totalMoney = Employees.Sum(e => e.Money); //suma všech hodnot money u zamestnancu
            foreach (var subUnit in SubUnits)
            {
                totalMoney += subUnit.GetTotalmoney(); 
            }
            return totalMoney;
        }
    }

}
