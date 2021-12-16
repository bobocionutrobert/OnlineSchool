using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OnlineSchool
{
    public class ControllerCourses
    {

        private List<Course> courseList;

        public ControllerCourses()
        {
            courseList = new List<Course>();
            load();
        }

       
        public int positionById(int id)
        {
           for(int i = 0; i < courseList.Count; i++)
            {
                if(courseList[i].Id == id)
                {
                    return i;
                }
            }
           return -1;
        }

        public Course returnCoursebyId(int id)
        {
            foreach(Course course in courseList)
            {
                if(course.Id == id)
                {
                    return course;
                }
            }
            return null;
        }

        public bool addCourse(Course course)
        {
            int poz = positionById(course.Id);

            if(poz != -1)
            {

                return false;
            }
            else
            {
                courseList.Add(course);
                return true;
                
            }
        }

        public bool deleteCourse(int id)
        {
            int poz = positionById(id);

            if(poz == 1)
            {
                return false;
            }
            else
            {
                courseList.RemoveAt(poz);
                return true;
            }
        }




        public void displayLiterature()
        {

            this.courseList.ForEach((e) =>
            {

                 if(e is Literature)
                 {   

                    Console.WriteLine(e);
                 }

            });
        }

        public void displayScience()
        {

            this.courseList.ForEach((course) =>
            {
                if(course is Science)
                {
                    Console.WriteLine(course);
                }


            });
        }





       
        public void updateName(int id,string name)
        {
            foreach(Course course in courseList)
            {
                if(course.Id == id)
                {
                    course.Name = name;
                }
            }
        }

        public void updateDepartment(int id, string department)
        {
            foreach(Course course in courseList)
            {
                if (course.Id == id)
                {
                    course.Department = department;
                }
            }
        }

        public void updateScienceNumberofCourses(int id,int numberofcourses)
        {
            foreach(Course course in courseList)
            
             {
                    if(course.Id == id)
                    {
                        Science science = course as Science;
                        science.Numberofcourses = numberofcourses;
                    }
            }
        }

        public void updateLiteratureNumberofCourses(int id,int numberofcourses)
        {
            foreach(Course course in courseList)
            {
                if (course.Id == id)
                {
                    Literature literature = course as Literature;

                    literature.Numberofcourses = numberofcourses;
                }
            }
        }



        public void load()
        {

            StreamReader read = new StreamReader(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\OnlineSchool\OnlineSchool\Resources\courses.txt");

            

            string line = "";

            while((line = read.ReadLine()) != null)
            {
                string[] prop = line.Split(",");


                Console.WriteLine(line);

                if (line.Length > 2)
                {
                    if (prop[2].Equals("Science"))
                    {

                        this.courseList.Add(new Science(line));
                    }
                    else
                    {
                        this.courseList.Add(new Literature(line));
                    }
                }
            }

            read.Close();
        }



        public override string ToString()
        {

            string text = "";

            this.courseList.ForEach((course) =>
            {

                text += course.ToString() + "\n";


            });


            return text;
        }


      
        public void Save()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\OnlineSchool\OnlineSchool\Resources\courses.txt");

            write.WriteLine(ToString());

            write.Close();
        }


    }
}
