using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool
{
    public class Student : Person
    {

        private int finalmark;

        public Student(int finalamrk, int id,string type,string firstname,string lastname,string email,int age) : base(id, "Student", firstname, lastname, email, age)
        {
            this.finalmark = finalamrk;
        }

        public Student()
        {

        }

        public Student(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.finalmark = Int32.Parse(prop[6]);
        }

        public int FinalMark
        {
            get { return this.finalmark; }
            set { this.finalmark = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "," + this.finalmark;
        }

    }
}
