using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6
{
    internal class Employee
    {
        public int id; 
        public string name;
        public decimal salary;
        public Employee(int id , string name , decimal salray )
        {
            this.id = id;   
            this.name = name;   
            this.salary = salray;
        }
        public override string ToString()
        {
            return $"Id :{id} \n Name : {name} \n salary : {salary}";
        }
        //
    }
}
