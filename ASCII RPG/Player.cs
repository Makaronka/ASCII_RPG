using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_RPG
{
    class Player:IDisplayed
    {
        protected Position2D _pos;//Player position
        protected uint _hp, _maxHp, _basicStrength;
        protected char _avatar;

        public Player(int x, int y, char avatar = '@', uint maxHp = 25 ,uint strength = 10)
        {
            _pos.X = x;
            _pos.Y = y;
            _avatar = avatar;
            _maxHp = maxHp;
            _hp = _maxHp;
            _basicStrength = strength;
        }
        public Player(Position2D StartPos, char avatar = '@', uint maxHp = 25, uint strength = 10) : this(StartPos.X, StartPos.Y, avatar, maxHp, strength) { }
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
    }
}
