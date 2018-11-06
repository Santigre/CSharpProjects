using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOp
{
    class Employee : Person
    {
        public int Id { get; set; }
        
        public override void SayName()
        {
            base.SayName();
        }

        public static Employee operator== (Employee employee1, Employee employee2)
        {
            employee1.Id.Equals(employee2.Id);
            return employee1;
        }

        public static Employee operator!=(Employee employee1, Employee employee2)
        {
            employee1.Id.Equals(employee2.Id);
            return employee2;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}