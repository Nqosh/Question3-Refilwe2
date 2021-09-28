using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTION_3_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Employee Id");
            int Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Physical Address");
            string physicalAddress = Console.ReadLine();

            Console.WriteLine("Enter Employee Allowance Total");
            int allowanceTotal = Convert.ToInt32(Console.ReadLine());

            Employee employee = new Employee();
            employee.emp_name = name;
            employee.emp_lastname = lastName;
            employee.emp_physicaladdress = physicalAddress;
            employee.emp_id = Id;
            employee.AllowanceTotal = employee.Allowance(allowanceTotal);

            Console.WriteLine("Receptionist Details:");

            Console.WriteLine("Enter Receptionist Name");
            name = Console.ReadLine();

            Console.WriteLine("Enter Receptionist Last Name");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter Receptionist Id");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Receptionist Physical Address");
            physicalAddress = Console.ReadLine();

            Console.WriteLine("Enter Receptionist Allowance Total");
            allowanceTotal = Convert.ToInt32(Console.ReadLine());

            Receptionist receptionist = new Receptionist();
            receptionist.emp_name = name;
            receptionist.emp_lastname = lastName;
            receptionist.emp_physicaladdress = physicalAddress;
            receptionist.emp_id = Id;
            receptionist.rec_salary = 20000;
            receptionist.rec_workinghours = 8;
            receptionist.AllowanceTotal = receptionist.Allowance(allowanceTotal);

            Console.WriteLine("Employee :", Environment.NewLine);
            Console.WriteLine("emp_name :" + " "+ employee.emp_name);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("emp last name :" + " " + employee.emp_lastname);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("emp Id :" + " "+ employee.emp_id);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("emp Physical adresss :" + " " + employee.emp_physicaladdress);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("emp Allowance :" + " " + employee.AllowanceTotal);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Receptionist:");
            Console.WriteLine("emp_name :" + " " + receptionist.emp_name);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("emp last name :" + " " + receptionist.emp_lastname);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("emp Id :" + " " + receptionist.emp_id);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("emp Physical adresss :" + " " + receptionist.emp_physicaladdress);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("emp Allowance :" + " " + receptionist.AllowanceTotal);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("rec work Hours :" + " " + receptionist.rec_workinghours);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("rec Salary :" + " " + receptionist.rec_salary);
        }
    }

    public class Employee
    {
        public string emp_name { get; set; }
        public string emp_lastname { get; set; }
        public int emp_id { get; set; }
        public string emp_physicaladdress { get; set; }

        public int temp;

        public int HouseAllowance
        {
            get { return temp; }
            set { temp = 2500; }
        }
        public int CarAllowance
        {
            get { return temp; }
            set { temp = 1000; }
        }

        public int AllowanceTotal { get; set; }
        public virtual int Allowance(int total)
        {
            AllowanceTotal = total;
            return AllowanceTotal;
        }
    }

    public class Receptionist : Employee
    {

        public int rec_workinghours { get; set; }
        public int rec_salary { get; set; }

        public const int clothingAllowance = 500;

        public override int Allowance(int total)
        {
            AllowanceTotal = total;
            return AllowanceTotal;
        }
    }
}
