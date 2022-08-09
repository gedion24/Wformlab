using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WformLab.models
{
     class item
    {
        static List<item> products = new List<item>();
        public string Studentname { get; set; }
        public string StudentID { get; set; }
        public string Coursename { get; set; }
       
   
        
        
        static public List<item> getall()
        {
            return products;
        }
    }

   
}
