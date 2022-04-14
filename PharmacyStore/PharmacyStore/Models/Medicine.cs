using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyStore.Models
{
    class Medicine
    {
        //Fields 
        private static int _id;
        public int temp;
        public int Id 
        {
            get 
            {
                return temp;
            }
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool IsDeleted = false;

        //Constructor
        public Medicine(string name, double price, int count, bool isdeleted)
        {
            Name = name;
            Price = price;
            Count = count;
            IsDeleted = isdeleted;
            _id++;
            temp = _id;
            
        }

        //Methods

        //Sell method
        public void Sell() 
        {
            if (Count > 0)
            {
                Count--;
            }
        }

        //ShowInfo method
        public override string ToString()
        {
            return $"Id : {_id}\nName : {Name}\nPrice : {Price}\nCount : {Count}\nIs Deleted : {IsDeleted}";
        }

        public void ShowInfo() 
        {
            ToString();
        }
    }
}
