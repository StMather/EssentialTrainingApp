using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining
{
    public class SimpleArray
    {
        public string[] groceryList;

        public SimpleArray()
        {
            groceryList = new string[4] { "Bread", "milk", "eggs", "cheese" };
        }
        public override string ToString()
        {
            return "There are " + groceryList.Length + " and they are: " + groceryList.ToString();
        }
    }
}
