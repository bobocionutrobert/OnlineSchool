using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool
{
    public class Course
    {

        private int id;
        private string name;
        private string department;

        public Course(int id,string name,string department)
        {
            this.id = id;
            this.name = name;
            this.department = department;
        }

        public Course()
        {

        }
        
        public Course(string props)
        {
            string[] prop = props.Split(",");

            this.id=Int32.Parse(prop[0]);
            this.name=prop[1];
            this.department=prop[2];
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Department
        {
            get { return department; }  
            set { department = value; }
        }

        public override string ToString()
        {


            return this.id + "," + this.name + "," + this.department;
        }

        public override bool Equals(object obj)
        {
            Course course = obj as Course;

           return this.id == course.id;
        }

    }
}
