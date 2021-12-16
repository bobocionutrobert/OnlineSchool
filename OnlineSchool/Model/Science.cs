using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool
{
    public class Science : Course
    {
        private string sciencename;
        private int numberofcourses;

        public Science(string sciencename, int numberofcourses, int id, string name, string department) : base(id, name,"Science")
        {
            this.sciencename = sciencename;
            this.numberofcourses = numberofcourses;
        }

        public Science(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.sciencename = prop[3];
            this.numberofcourses = Int32.Parse(prop[4]);
        }

        
        public string Sciencename
        {
            get
            {
                return sciencename;
            }
            set
            {
               this.sciencename = value;
            }
        }

        public int Numberofcourses
        {
            get { return numberofcourses; }
            set { this.numberofcourses = value; }   
        }

        public override string ToString()
        {
            
            
            return base.ToString() + "," + this.sciencename + "," + this.numberofcourses;

            
        }

    }
}
