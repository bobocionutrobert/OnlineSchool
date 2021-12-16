using OnlineSchool.View;
using System;
using System.Collections.Generic;

namespace OnlineSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin s = new Admin("2,Admin,Ionel,Ion,email,39,2398");

            ViewAdmin view = new ViewAdmin(s);

            view.play();

        }




           
    }
}
