using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDemo
{
    public class ShowRoomItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public ShowRoomItem(string name, double price, double weight, double width, double height)
        {
            Name = name;
            Price = price;
            Weight = weight;
            Width = width;
            Height = height;
        }
    }

    //director
    public class ShowRoomToCustomer
    {
        public string Title;
        public string RoomDimension;
        public double FinalPrice;


        public string GetShowRoom()
        {
            return new StringBuilder()
                .AppendLine(Title)
                .AppendLine(RoomDimension)
                .AppendLine(FinalPrice.ToString())
                .ToString();
        }
    }

    //builder interface
    public interface IShowRoomBuilder
    {
        IShowRoomBuilder AddName();
        IShowRoomBuilder CalculateRoomDimension();
        IShowRoomBuilder CalculateFinalPrice();
        ShowRoomToCustomer GetBuiltShowRoom();
    }


    //builder concerete class
    public class ShowRoomBuilder : IShowRoomBuilder
    {
        IEnumerable<ShowRoomItem> _items;
        ShowRoomToCustomer _requestedShowRoom;

        public ShowRoomBuilder(IEnumerable<ShowRoomItem> items)
        {
            //call Director
            InitializeShowRoom();
            _items = items;
        }

        public IShowRoomBuilder CalculateRoomDimension()
        {
            _requestedShowRoom.RoomDimension = string.Join(Environment.NewLine, _items.Select(item =>         
                $"Dimension {item.Name} => {item.Width} * {item.Height}"
            ));

            return this;
        }

        public IShowRoomBuilder AddName()
        {
            _requestedShowRoom.Title = "Ikea Show Room No#10";
            return this;
        }

        public IShowRoomBuilder CalculateFinalPrice()
        {
            _requestedShowRoom.FinalPrice = _items.Sum(item =>
                 _requestedShowRoom.FinalPrice + item.Price
            );
            return this;
        }

        public ShowRoomToCustomer GetBuiltShowRoom()
        {
            ShowRoomToCustomer showRoom = _requestedShowRoom;
            return showRoom;
        }

        public void InitializeShowRoom()
        {
            _requestedShowRoom = new ShowRoomToCustomer();
        }
    }
}
