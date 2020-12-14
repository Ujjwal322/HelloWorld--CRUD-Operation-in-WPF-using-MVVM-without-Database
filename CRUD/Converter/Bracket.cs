using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Converter
{
   public class Bracket : List<string>
    {
        public Bracket()
        {
            this.Add("Program Det.");
            this.Add("Built-Up");
            this.Add("Hot Rolled");
        }
    }
}
