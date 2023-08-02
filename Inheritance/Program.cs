using System;
namespace Inheritance
{
    class program
    {
        static void Main(string[] args)
        {
            //instance of an adult
            Adult adult1 = new Adult();

           /*
            * Console.WriteLine(adult1.pName);
            Console.WriteLine(adult1.pSurname);
            Console.WriteLine(adult1.pAddress);
           */

            adult1.pName = "Musa";
            adult1.pSurname = "Mavasa";
            adult1.pAddress = "Ivory Park Ext 3";
            Console.WriteLine();
            Console.WriteLine(adult1.pName);
            Console.WriteLine(adult1.pSurname);
            Console.WriteLine(adult1.pAddress);

            adult1.Examine();
            adult1.Payment();
            adult1.Insurance();



            //instance of a child 
            Child child1 = new Child();
            child1.Innoculated();


        }
    }
    public class Patient
    {
        public string pName;//"Musa";
        public string pSurname;//"Mavasa";
        public string pAddress;//"Ivory Park Ext 3"
        public void Examine()
        {
            Console.WriteLine("Patient has been examined");
        }
    }

    //adult inheritance from patient
        public class Adult: Patient
        {
            public void Payment()
            {
                Console.WriteLine("Payment Done!!");
            }
            public void Insurance()
            {
                Console.WriteLine("They have medical aid");
            }

        }
    public class Child
    {
        public void Innoculated()
        {
            Console.WriteLine("Child has been vaccinated");
        }
    }
}