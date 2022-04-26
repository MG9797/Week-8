using System;
using System.Collections.Generic;
namespace Task2
{
    class Person
    {
        private string FirstName;
        private string SurName;
        public string Dob;
        public int Height;
        private int ID;

        public List<Subject> subjects = new List<Subject>();

        public Person(string pFirstName, string pSurName,string pDob,int pHeight,int pID)
        {

            FirstName=pFirstName;
            SurName=pSurName;
            Dob=pDob;
            Height=pHeight;
            ID=pID;
        }
       
        public string Fullname(){ 
            return (FirstName + " " + SurName);
        }

        public int GetHeightDifference(Person p){
          // return the difference in height.  
            return Math.Abs(this.Height - p.Height);
        } 

        public void AddSubject(Subject s) {
             subjects.Add(s);
        }

        public void ListSubjects(){
            foreach(var s in subjects){
                Console.Write(s.Name + " ");
            }
            Console.WriteLine("");
        }
    }
}