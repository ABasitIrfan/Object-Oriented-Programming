using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Human
    {
        private string name;
        private string contact;
        private string address;
        public Human()
        {
            //base.work();
            Console.WriteLine("I am Human Contructor");
        }
        public Human(string n,string c,string ad,string ec)
        {
            name = n;
            contact = c;
            address = ad;
         
            

    }
        public void display()
        {
            Console.WriteLine("\n\nName:{0},Contact:{1},Address:{2}",name,contact,address);
        }
        public void work()
        {
           
            Console.WriteLine("Human Works");
        }
    }
    class student:Human
    {
        public string rollnum;
        public student()
        {
            Console.WriteLine("I am Student Contructor");
        }
    }
    class Employee:Human
    {
        public string emp_code;
        public Employee()
        {
            Console.WriteLine("I am Employee Contructor");
        }
        protected void work()
        {
            base.work();
    Console.WriteLine("Employee Works");
    }
        public Employee(string n,string c,string ad,string ec):base(n,c,ad,ec)
        {
            emp_code = ec;

            
        }
    }
    class faculty:Employee
    {
        public string facultyId;
        public faculty()
        {
            Console.WriteLine("I am Faculty Contructor");
        }
        protected void work()
{
    base.work();
    Console.WriteLine("Faculty Works");
}
    }
    class staff:Employee
    {
        public string staffId;
        public staff()
        {
            Console.WriteLine("I am Staff Contructor");
        }
    }
    class security:Employee
    {
        public string securityId;
        public security()
        {
            Console.WriteLine("I am Security Contructor");
        }
    }
   


}
