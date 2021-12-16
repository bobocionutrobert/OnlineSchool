using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool
{
    public class Person
    {
        //id,type,firstname,lastname,email,age
        private int id;
        public string type;
        private string firstname;
        private string lastname;
        private string email;
        private int age;

        public Person(int id, string type,string firstname, string lastname, string email, int age)
        {
            this.id = id;
            this.type= type;    
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.age = age;
        }


        public Person() { }
        public Person(string props)
        {
            string[] prop = props.Split(",");

            this.id = Int32.Parse(prop[0]);
            this.Type = prop[1];
            this.firstname = prop[2];
            this.lastname=prop[3];
            this.email=prop[4];
            this.age = Int32.Parse(prop[5]);

        }

        public int Id
        {
            get { return this.id; }

            set {

                this.id = value;

            }
        }
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }  
        }
        public string FirstName
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }
        public string LastName
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public override string ToString()
        {

            return this.id + "," + this.type + "," + this.firstname + "," + this.lastname + "," + this.age;

        }


        public override bool Equals(object obj)
        {

            Person person = obj as Person;


            return this.id == person.id;
        }



    }
}
