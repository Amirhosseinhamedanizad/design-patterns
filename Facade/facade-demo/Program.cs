using System;

namespace facade_demo
{
    //Third-party company
    class Program
    {
        static void Main(string[] args)
        {
            //Behind the firewall company
            //internal company services
            //AuthorService authorService = new AuthorService();
            //PublisherService publisherService = new PublisherService();
            //TitleService titleService = new TitleService();
			//this line was added by alireza
	        //This the line amir to try 


            //Open to the public 
            //Open port to the public 
            var facade = new FacadeLayer();

            facade.GetInternalCompanyData().Item1.ForEach(s => Console.WriteLine(s));

            facade.GetInternalCompanyData().Item2.ForEach(s => Console.WriteLine(s));

            facade.GetInternalCompanyData().Item3.ForEach(s => Console.WriteLine(s));

            Console.ReadLine();
        }
    }
}
