using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Random rnd = new Random();
            Person a =new Person("Bob","Boby","20/10/1990",180,rnd.Next(1000,9999));
            Person b =new Person("Jake","Rusll","15/05/1992",190,rnd.Next(1000,9999));
            
            */

            Person p1 = new Person("Bob", "Jane", "12/6/1950", 187, 1);
            Person p2 =new Person("Sam","Sami","02/01/1995",170,2);

            Console.WriteLine( "Height Difference: " + p1.GetHeightDifference(p2));
            Console.WriteLine( p1.Fullname());

            p1.AddSubject(new Subject("Maths", "2019"));
            p1.AddSubject(new Subject("English", "2018"));
            p1.AddSubject(new Subject("The History of Ancient Chinese Study of the disection of Bettles for the psuedo scientific validation od religious ideas on massage based accupunture", "1910"));

            p1.ListSubjects();

        }
    }
}
