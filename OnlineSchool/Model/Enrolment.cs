using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool
{
    public class Enrolment
    {

        private int id;

        private int studentid;

        private int courseid;
       

        public Enrolment(int id,int studentid, int courseid)
        {
            this.id = id;  
            this.studentid = studentid;
            this.courseid = courseid;
            
        }

        public Enrolment(string props)
        {
            string[] prop = props.Split(",");

            this.id = Int32.Parse(prop[0]);
            this.studentid=Int32.Parse(prop[1]);
            this.courseid=Int32.Parse(prop[2]);
        }


        public int Id { 
            
            
            get { return id; }
            set{ this.id = value; }
         }

        public int Studentid
        {
            get { return studentid; }
            set { studentid = value; }
        }

        public int Courseid
        {
            get { return courseid; }
            set { courseid = value; }  
        }


        public override string ToString()
        {
            return this.id + "," + this.studentid + "," + this.courseid;
        }

        public override bool Equals(object obj)
        {
            Enrolment enrolment = obj as Enrolment;

            return this.id == enrolment.id;
        }



    }
}
