using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_RPG
{
    class Item
    {
        protected string Title;
        protected string Description;
        public override string ToString()
        {
            return Title + ":\n" + Description;
        }
    }
}
