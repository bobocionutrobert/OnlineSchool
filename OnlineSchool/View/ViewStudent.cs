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
            Console.WriteLine("Press 4 to ");


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
                }
            }
        }

        public void enrollToCourse()
        {
            Console.WriteLine("Insert the id of the course you want to enroll");

            int choice = Int32.Parse(Console.ReadLine());

            Enrolment enrolment = controllerenrolment.enrolmentById(choice);

            Console.WriteLine("Enrolment successful");

            controllerenrolment.Save();
        }


    }
}
