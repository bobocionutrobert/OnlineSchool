using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OnlineSchool
{
    public class ControllerPerson
    {




        private List<Person> persons;

        public ControllerPerson()
        {
            persons = new List<Person>();

            load();
        }


        public void displayPerson()
        {
            for(int i = 0; i < persons.Count; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }
        public void displayStudent()
        {
            for(int i = 0; i < persons.Count; i++)
            {
                if(persons[i].Type == "Student")
                {
                    Console.WriteLine(persons[i].ToString());
                }
            }
        }

        public int positionById(int id)
        {
            for(int i = 0; i < persons.Count; i++)
            {
                if(persons[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public Person person(int id)
        {
            foreach(Person person in persons)
            {
                if(person.Id == id)
                {
                    return person;
                }
            }
            return null;
        }

        public bool addPerson(Person person)
        {
            int poz  = positionById(person.Id);

            if(poz != -1)
            {
                return false;
            }
            else
            {
                persons.Add(person);
                return true;
            }
        }

        public bool deletePerson(int personid)
        {
            int poz = positionById(personid);

            if(poz == 1)
            {
                return false;
            }
            else
            {

                persons.RemoveAt(poz);
                return true;
            }
        }

        

        public void updateFirstName(int id, string firstname)
        {
            foreach(Person person in persons)
            {
                if(person.Id == id)
                {
                    person.FirstName = firstname;
                }
            }
        }

        public void updateLastName(int id, string lastname)
        {
            foreach(Person person in persons)
            
                {
                if(person.Id != id)
                {
                    person.LastName = lastname;
                }

                }
        }

        public void updateSalariuAdmin(int id,int salary)
        {
            foreach(Person person in persons)
            {
                if(person.Id == id)
                {
                    Admin admin = person as Admin;
                    admin.Salary = salary;
                }
            }
        }

        public void updateFinalMarkStudent(int id, int finalmark)
        {
            foreach(Person person in persons)
            
            {
                if (person.Id == id)
                {
                    Student student = person as Student;
                    student.FinalMark = finalmark;
                }

            }
        }

        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\OnlineSchool\OnlineSchool\Resources\persons.txt");


            string line = "";


            while ((line = read.ReadLine()) != null)
            {
                string[] prop = line.Split(",");

                if (prop[1].Equals("Student"))
                {
                    this.persons.Add(new Student(line));

                }
                else
                {
                    this.persons.Add(new Admin(line));
                }
            }
            read.Close();
        }

        public override string ToString()
        {
            string text = "";

            this.persons.ForEach((person) =>
            {

                text += person.ToString() + "\n";


            });

            return text;
        }

        public void Save()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\OnlineSchool\OnlineSchool\Resources\persons.txt");
            write.WriteLine(ToString());
            write.Close();  
        }
    }



}
