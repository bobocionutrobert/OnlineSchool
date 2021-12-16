using OnlineSchool;
using OnlineSchool.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace OnlineSchoolTests
{
    public class TestEnrolment
    {
        private ControllerEnrolment control;

        private readonly ITestOutputHelper output;

        public TestEnrolment(ITestOutputHelper output)
        {
            this.output = output;
            control = new ControllerEnrolment();

        }

        [Fact]

        public void testEnrolmentByStudentId()
        {
            control.load();


           



            
        }
    }
}
