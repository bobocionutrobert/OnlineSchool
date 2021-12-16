using OnlineSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace TestProject1
{
    public class TestStudent
    {

        private Person person;
        private Student student;
        private Admin admin;

        private readonly ITestOutputHelper output;

        public TestStudent(ITestOutputHelper output)
        {
            person = new Person();
            student = new Student();
            admin = new Admin();
            this.output = output;
        }
        [Fact]
        //id,type,firstname,lastname,email,age,mark
        public void testStudent()
        {
            Student s = new Student("1,Student,Ionut,Ionel,email,29,8");

            output.WriteLine(((Person)s).ToString());
        }



    }
}
