using OnlineSchool.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool.View
{
    public class ViewStudent
    {

        private Person person;
        private ControllerCourses controllercourses;
        private ControllerPerson controllerpersons;
        private ControllerEnrolment controllerenrolment;


        public ViewStudent(Person person)
        {
            this.person = person;

            controllercourses = new ControllerCourses();
            controllerpersons = new ControllerPerson();
            controllerenrolment = new ControllerEnrolment();



        }

        public void menu()
        {
            Console.WriteLine("Press 1 to see all Science courses");
            Console.WriteLine("Press 2 to see all Literature courses");
            Console.WriteLine("Press 3 to enroll for a course");
            Console.WriteLine("Press 4 to see all courses student is enrolled ");
            Console.WriteLine("Press 5 to unenroll from a course");


        }

        public void play()
        {
            bool running = true;
            while(running == true)
            {
                menu();

                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:


                        break;
                    case 1:
                        controllercourses.displayScience();
                        break;
                    case 2:
                        controllercourses.displayLiterature();
                        break;
                    case 3:
                        enrollToCourse();
                        break;
                    case 4:
                        enrolledCoursesOfStudent();
                        break;
                    case 5:
                        unenrollCourse();
                        break;

                }
            }
        }

        public void enrollToCourse()
        {

            Random random = new Random();
            int id = random.Next(1, 100);

            Console.WriteLine("Insert the name of the course you want to enroll ");

            string coursename = Console.ReadLine();

            Enrolment enrolment = new Enrolment(id, person.Id, controllercourses.returnCoruseIdByName(coursename));

            controllerenrolment.addEnrolment(enrolment);

            Console.WriteLine("Enrolment successful");

            controllerenrolment.Save();
        }

        public void unenrollCourse()
        {

            Console.WriteLine("Insert the name of the course you want to unenroll : ");

            string coursename = Console.ReadLine();

            int id = controllercourses.returnCoruseIdByName(coursename);

            controllerenrolment.deleteEnrolment(id);

            Console.WriteLine("You were unenrolled from the course");

            controllerenrolment.Save();
        }

        public void enrolledCoursesOfStudent()
        {
            List<Enrolment> list = controllerenrolment.enrolmentbyStudentId(person.Id);


            foreach(Enrolment e in list)
            {
                Console.WriteLine(controllercourses.returnCoursebyId(e.Courseid).ToString());
            }








        }


    }
}
