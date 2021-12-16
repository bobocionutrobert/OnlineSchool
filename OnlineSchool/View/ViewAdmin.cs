using OnlineSchool.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool.View
{
    public class ViewAdmin
    {
        private Person person;
        private ControllerCourses controllercourses;
        private ControllerPerson controllerpersons;
        private ControllerEnrolment controllerenrolment;

        public ViewAdmin(Person person)
        {
            this.person = person;

            controllercourses = new ControllerCourses();
            controllerpersons = new ControllerPerson();
            controllerenrolment = new ControllerEnrolment();
        }

        public void menu()
        {
            Console.WriteLine("Press 1 to see all students");
            Console.WriteLine("Press 2 to see all Science courses");
            Console.WriteLine("Press 3 to see all Literature courses");
            Console.WriteLine("Press 4 to add a new course ");
            Console.WriteLine("Press 5 to add a new student");
            Console.WriteLine("Press 6 to delete a course");
            Console.WriteLine("Press 7 to delete a student");


        }

        public void play()
        {
            bool running = true;
            while (running == true)
            {
                menu();

                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:


                        break;
                    case 1:
                        controllerpersons.displayStudent();
                        break;
                    case 2:
                        controllercourses.displayScience();
                        break;
                    case 3:

                        controllercourses.displayLiterature();
                        break;
                    case 4:
                        addNewCourse();
                        break;
                    case 5:
                        addNewStudent();
                        break;
                    case 6:
                        deleteCourse();
                        break;
                    case 7:
                        deleteStudent();
                        break;
                }
            }
        }

        public void addNewCourse()
        {
            Random id = new Random();

            Console.WriteLine("Insert course name : ");

            string coursename = Console.ReadLine();

            Console.WriteLine("Insert course department : ");

            string coursedepartemnt = Console.ReadLine();

            int courseid = id.Next(1, 100);
            Course c = new Course(courseid, coursename, coursedepartemnt);


        }
        //id,type,firstname,lastname,email,age
        public void addNewStudent()
        {
            string type = "Student";
            Random random = new Random();
            int id = random.Next(1, 100);
            Console.WriteLine("Insert student first name : ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Insert student last name : ");
            string lastname = Console.ReadLine();
            Console.WriteLine("insert student email : ");
            string email = Console.ReadLine();
            Console.WriteLine("insert student age : ");
            int age = Int32.Parse(Console.ReadLine());

            Person student = new Person(id, type, firstname, lastname, email, age);
        }

        public void deleteCourse()
        {
            Console.WriteLine("Insert course id you want to delete from database : ");

            int id = Int32.Parse(Console.ReadLine());

            controllercourses.deleteCourse(id);
        }

        public void deleteStudent()
        {
            Console.WriteLine("Insert student id you want to delete from database : ");
            int id = Int32.Parse(Console.ReadLine());
            controllerpersons.deletePerson(id);
        }

    }
}
