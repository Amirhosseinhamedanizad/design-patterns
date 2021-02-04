using System;

namespace MementoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem
            //Student student = new Student();
            //student.Email = "test@test.com";
            //student.Name = "test";
            ////do other things

            //student.Email = "test2@test.com";
            //student.Name = "test2";
            //Console.ReadKey();

            //Solution 
            //--------------------------------------------------

            Banking atm = new Banking();
            var i = 0;
            do {

                Console.WriteLine("Please enter your name?");
                atm.Name = Console.ReadLine();
                Console.WriteLine("please enter your amount?");
                atm.Amount = Console.ReadLine();
                atm.SaveMemento();
                i++;
            } while (i < 3);

            do
            {
                Console.WriteLine("Did you make a mistake");
                var probelmExist = Console.ReadLine() == "y" ? true : false;

                if (probelmExist)
                {
                    atm.ResotreMemnto();
                    Console.WriteLine($"your previous state was {atm.Name} {atm.Amount}");
                }
                i--;
            } while (i > 0);

            Console.ReadLine();


        }
    }

    //class Student
    //{
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //}
}
