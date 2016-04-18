using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_RPG
{
    class Player:IDisplayed, IBeated
    {
        protected Position2D _pos;
        protected short _basicStrength;
        private short _hp, _maxHp;
        protected char _avatar;
        protected Attack _mainAttack;

        public Player(int x, int y, char avatar = '@', short maxHp = 25 ,short strength = 10)
        {
            _pos.X = x;
            _pos.Y = y;
            _avatar = avatar;
            _maxHp = maxHp;
            _hp = _maxHp;
            _basicStrength = strength;
            _mainAttack = new Attack(3, new Position2D(0, -1), new Position2D(0, -2), new Position2D(1, -2), new Position2D(-1, -2));
        }
        public Player(Position2D StartPos, char avatar = '@', short maxHp = 25, short strength = 10) : this(StartPos.X, StartPos.Y, avatar, maxHp, strength) { }
        public Position2D Position
        {
            get { return _pos; }
            set {
                _pos.X = value.X;
                _pos.Y = value.Y;
            }
        }
        public char Avatar
        {
            get { return _avatar; }
            set { _avatar = value; }
        }
        public void Move(Position2D delta)
        {
            _pos = _pos + delta;
        }
        public Attack MainAttack
        {
            get { return _mainAttack; }
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
