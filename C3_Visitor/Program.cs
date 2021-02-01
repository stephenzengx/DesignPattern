using System;

namespace C3_Visitor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeList empList = new EmployeeList();
            IEmployee fteA = new FullTimeEmployee("梁思成", 3200.00, 45);
            IEmployee fteB = new FullTimeEmployee("徐志摩", 2000, 40);
            IEmployee fteC = new FullTimeEmployee("梁徽因", 2400, 38);
            IEmployee fteD = new PartTimeEmployee("方鸿渐", 80, 20);
            IEmployee fteE = new PartTimeEmployee("唐宛如", 60, 18);

            empList.AddEmployee(fteA);
            empList.AddEmployee(fteB);
            empList.AddEmployee(fteC);
            empList.AddEmployee(fteD);
            empList.AddEmployee(fteE);

            Department dept = new FinanceDepartment();
            if (dept != null)
            {
                empList.Accept(dept);
            }

            Console.ReadKey();
        }
    }
}
