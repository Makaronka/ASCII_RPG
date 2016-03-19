using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_RPG
{
    class Attack
    {
        uint _basicDamage;
        Position2D[] _template;
        
        public Attack(uint damage, params Position2D[] tmpl)
        {
            _basicDamage = damage;
            _template = tmpl;
        }

        public Position2D[] Tamplate
        {
            get { return _template; }
        }
    }
}
