using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_RPG
{
    enum Direction { up, down, left, right }

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
        public Attack Turn(Direction dir)
        {
            Position2D[] newTmpl = new Position2D[_template.Length];
            for (int i = 0; i < _template.Length; i++)
                newTmpl[i] = new Position2D(_template[i].X, _template[i].Y);
            for (int i = 0; i < newTmpl.Length; i++)
                newTmpl[i].Turn(dir);
            return new Attack(_basicDamage, newTmpl);
        }
    }
}
