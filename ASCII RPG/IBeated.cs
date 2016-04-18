using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_RPG
{
    interface IBeated
    {
        short Hp
        {
            get;
        }
        void getDamage(short damage);
    }
}
