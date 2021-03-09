using System;
using System.Collections.Generic;

namespace BuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var showRoomItems = new List<ShowRoomItem>
            {
                new ShowRoomItem("Bed", 12, 2.5, 10, 1.5),
                new ShowRoomItem("Painting", 15, 1.1, 1.2, 1.4),
                new ShowRoomItem("Desk", 10.2, 3.3, 2.1, 1)
            };

            var roomBuilder = new ShowRoomBuilder(showRoomItems);

            var requestFromCustomer = roomBuilder.AddName()
                .CalculateRoomDimension()
                .CalculateFinalPrice()
                .GetBuiltShowRoom();

            Console.WriteLine(requestFromCustomer.GetShowRoom());

            Console.ReadKey();
        }
    }
}
