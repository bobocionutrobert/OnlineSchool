using OnlineSchool.View;
using System;
using System.Collections.Generic;

namespace OnlineSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("1,Student,Ion,Ionut,email,20,7");

            ViewStudent view = new ViewStudent(s);

            view.play();

        }




           
    }
}
