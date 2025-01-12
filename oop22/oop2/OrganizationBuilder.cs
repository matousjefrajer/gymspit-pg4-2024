using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal class OrganizationBuilder
    {
        private OrganizationUnit RootUnit = new OrganizationUnit("Trenyrkarna.cz"); //založim tu společnost
                
        public OrganizationBuilder AddDepartment(string departmentName, int numEmployees, int moneycategory) 
        {
            var department = new OrganizationUnit(departmentName);
            for (int i = 0; i < numEmployees; i++)
            {
                department.AddEmployee(EmployeeFactory.CreateRandomEmployee(moneycategory));
            }
            RootUnit.AddSubUnit(department);
            return this; 
        }

        public OrganizationBuilder AddSubDepartment(string parentDepartmentName, string subDepartmentName, int numEmployees, int moneycategory)
        {
            var parent = FindUnitByName(RootUnit, parentDepartmentName);
            if (parent != null)
            {
                var subDepartment = new OrganizationUnit(subDepartmentName);
                for (int i = 0; i < numEmployees; i++)
                {
                    subDepartment.AddEmployee(EmployeeFactory.CreateRandomEmployee(moneycategory));
                }
                parent.AddSubUnit(subDepartment);
            }
            return this;
        }

        private OrganizationUnit FindUnitByName(OrganizationUnit unit, string name)
        {
            if (unit.Name == name) return unit;
            foreach (var subUnit in unit.SubUnits)
            {
                var result = FindUnitByName(subUnit, name);
                if (result != null) return result;
            }
            return null;
        }

        public OrganizationUnit Build()
        {
            return RootUnit;
        }
    }
}
