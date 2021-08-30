using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining
{
    public class AwesomeSausce
    {
        public List<string> sauses { get; set; }
        public AwesomeSausce()
        {
            sauses = new List<string>();
        }

        public bool IsSauceAwesome(string sauce)
        {
            return sauses.Contains(sauce);
        }
        
    }
}
