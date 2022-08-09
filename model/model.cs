using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WformLab.model
{
    class Item
    {
        static List<Item> product = new List<Item>();
        public string number { get; set; }
        public string date { get; set; }
        public string inventorynumber { get; set; }
        public string objectname { get; set; }
        public int count { get; set; }
        public string price { get; set; }

        public bool chbox { get; set; }
/*
        public static Item findone (string name)
        {
            return product.Find(p => p.name == name);
        }*/

        static public List<Item> getall()
        {
            return product;
 

        }
          
      
        public void save()
        {
           // Item.add(this);
        }

    }
}
