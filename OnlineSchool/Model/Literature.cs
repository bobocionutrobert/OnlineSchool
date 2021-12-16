using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool
{
    public class Literature : Course
    {
        private string literaturename;
        private int numberofcourses;

        public Literature(string literaturename,int numberofcourses, int id, string name, string department) : base(id, name, "Literature")
        {
            this.literaturename = literaturename;
            this.numberofcourses = numberofcourses;
        }

        public Literature(string props) : base(props)
        {
            string[] prop = props.Split(",");

            this.literaturename = prop[3];
            this.numberofcourses = Int32.Parse(prop[4]);

        }

        public string Literaturename
        {
            get { return literaturename; }
            set { literaturename = value; }

        }

        public int Numberofcourses
        {
            get { return numberofcourses;}
            set
            {
                numberofcourses = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "," + this.literaturename + "," + this.numberofcourses;
        }
    }
}
