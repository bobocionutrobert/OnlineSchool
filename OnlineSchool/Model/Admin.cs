using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool
{
    public class Admin : Person
    {
        private int salary;

        public Admin(int salary, int id, string type, string firstname, string lastname, string email, int age) : base(id, "Admin", firstname, lastname, email, age)
        {
            this.salary= salary;    
        }
        public Admin()
        {

        }
        public Admin(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.salary = Int32.Parse(prop[6]);
        }

        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "," + this.salary;
        }

    }
}
