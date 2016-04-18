using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_RPG
{
    class Enemy: IDisplayed, IBeated
    {
        private Position2D _pos;
        private char _avatar;
        private short _hp, _maxHp;

        public Enemy(Position2D pos, char avatar,short maxHp = 10)
        {
            _pos = pos;
            _avatar = avatar;
            _maxHp = maxHp;
            _hp = _maxHp;
        }

        public Position2D Position
        {
            get { return _pos; }
            set
            {
                _pos.X = value.X;
                _pos.Y = value.Y;
            }
        }
        public char Avatar
        {
            get { return _avatar; }
            //set { _avatar = value; }
        }


        public short Hp
        {
            get { return _hp; }
        }

        public void getDamage(short damage)
        {
            _hp -= damage;
            if (_hp <= 0)
                _hp = 0;
        }
    }
}
