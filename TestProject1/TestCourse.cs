using OnlineSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace OnlineSchoolTests
{
    public class TestCourse
    {
        private Course courses;
        private ControllerCourses control;

        private readonly ITestOutputHelper output;

        public TestCourse(ITestOutputHelper output)
        {

            courses = new Course();

            control = new ControllerCourses();
            this.output = output;
        }

        [Fact]
        //id,name,department,sciencename,noofcourses
        public void testCourse()
        {
            Course c = new Course("1,course,Science,Math,10");

            Science science = new Science("1,course,Science,Math,10");

            output.WriteLine(science.ToString());

        }
        [Fact]
        public void testSave()
        {
            control.load();

            Science s = new Science("11,sciencename,Science,name,10");

            control.addCourse(s);
            control.Save();

            output.WriteLine(s.ToString());

           
        }

        [Fact]
        public void TestLoad()
        {
            control.load();

            ControllerCourses c = new ControllerCourses();
            output.WriteLine(c.ToString());
        }
        [Fact]
        public void testDisplayLiterature()
        {
            
        }

    }
}
