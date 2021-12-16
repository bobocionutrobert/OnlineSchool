using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OnlineSchool.Controller
{
    public class ControllerEnrolment
    {

        private List<Enrolment> enrolments;

        public ControllerEnrolment()
        {
            enrolments = new List<Enrolment>();
            load();
        }



        public int positionbyId(int id)
        {
            for(int i = 0; i < enrolments.Count; i++)
            {
                if(enrolments[i].Id == id)
                {
                    return i;

                }

            }
            return -1;
        }

        public Enrolment enrolmentById(int idcourse)
        {
            foreach (Enrolment enrolment in enrolments)
            {
                if (enrolment.Courseid == idcourse)
                {
                    return enrolments[idcourse];
                }
            }
            return null;

        }

        public List<Enrolment> enrolmentbyStudentId(int studentid)
        {
            List<Enrolment> enro = new List<Enrolment>();
            foreach(Enrolment enrolment in enrolments)
            {
                if(enrolment.Studentid == studentid)
                {

                    enro.Add(enrolment);
                }
            }

            return enro;
        }

        

        public bool addEnrolment(Enrolment enrolment)
        {
            int poz = positionbyId(enrolment.Id);

            if(poz != -1)
            {
                return false;
            }
            else
            {
                enrolments.Add(enrolment);
                return true;
            }
        }

        public bool deleteEnrolment(int id)
        {
            int poz = positionbyId(id);
            if (poz == 1)
            {
                return false;
            }
            else
            {

                enrolments.RemoveAt(poz);
                return true;
            }
        }

        public void updateStudentId(int id, int newstudentid)
        {
            foreach(Enrolment enrolment in enrolments)
            {
                if(enrolment.Id == id)
                {
                    enrolment.Studentid = newstudentid;
                }
            }
        }

        public void updateCourseId(int id, int newcourseid)
        {
            foreach(Enrolment enrolment in enrolments)
            {
                if(enrolment.Id == id)
                {
                    enrolment.Courseid = newcourseid;
                }
            }
        }




        public void load()
        {

            StreamReader read = new StreamReader(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\OnlineSchool\OnlineSchool\Resources\enrolement.txt");

            string line = "";

            while((line = read.ReadLine()) != null)
            {
                string[] prop = line.Split(",");

                this.enrolments.Add(new Enrolment(line));
            }

            read.Close();


        }
        public override string ToString()
        {
            string text = "";

            this.enrolments.ForEach((enrolment)=>
            { 
                text += enrolment.ToString() + "\n";

            });

            return text;
        }

        public void Save()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\OnlineSchool\OnlineSchool\Resources\enrolement.txt");

            write.WriteLine(ToString());
            write.Close();

        }
    }
}
