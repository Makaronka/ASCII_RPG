using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_RPG
{
    interface IDisplayed
    {
        Position2D Position
        {
            get;
            set;
        }
        char Avatar
        {
            get;
            set;
        }
    }
}
