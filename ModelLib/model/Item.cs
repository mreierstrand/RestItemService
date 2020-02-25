using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace ModelLib.model
{
    public class Item
    {
        private int _id;
        private string _name;
        private string _quality;
        private double _quantity;


        public int Id
        {
            get { return _id; }
            set { Id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }

        public double Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public Item(int id, string name, string quality, double quantity)
        {
            _id = id;
            _name = name;
            _quality = quality;
            _quantity = quantity;
        }

        public void Data()
        {

        }

        public override string ToString()
        {
            return $"Id: {Id} \t Name: {Name} \t Quality: {Quality} \t Quantity: {Quantity}";
        }
    }
}