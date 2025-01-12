using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal class EmployeeFactory
    {
        private static string[] Names = { "Eva", "Matouš", "Charlie", "Bob", "Jony", "Frajer Mc toaster", "Jirka", "Tom" };
        private static string[] Roles = { "šéf", "kontrolor", "právník", "tewn co to oddře" }; //tohle uplně nefunguje, chtěl jsem ať to nezadávam ručně, ale dávat jim pracovní pozici náhodně moc nefunguje
        private static int[] Money = { 34511, 35368, 45874, 31663, 32778,}; //náhodné platy co mohou dostávat

        private static Random Random = new Random();

        
        public static Employee CreateRandomEmployee(int moneycategory) //vytvoření náhodného zaměstnance
        {
            string name = Names[Random.Next(Names.Length)];
            string role = Roles[Random.Next(Roles.Length)];
            int basemoney = Money[Random.Next(Money.Length)];
            int money = basemoney - moneycategory;
            
            return new Employee(name, role, money);
        }
    }
}
