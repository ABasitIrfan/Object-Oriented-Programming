using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction1
{
    abstract class BaseEmployee
    {
        public string name;
        public string contact;
        public string address;
        // public abstract double getmonthlysal();
        public virtual void method()
        {

        }
        public virtual void print()
        {

        }
        public virtual double getmonthlysal()
        {
            return 0.0;
        }
        public BaseEmployee()
        {
            Console.WriteLine("I am base constructor");
        }
    }
    class contractEmp : BaseEmployee
    {
        public int hourly_pay;
        public int num_of_hours;
        public override double getmonthlysal()
        {
            return num_of_hours * hourly_pay;
        }
        //public override void getmonthlysal()
        //{

        //}
        public override void method()
        {

        }
      //  public abstract void a();
    }
    class FulltimeEmp : BaseEmployee
    {
        public double annualsal;
        public override double getmonthlysal()
        {
            return annualsal/12;
        }
       
        public override void method()
        {

        }



    }
}


