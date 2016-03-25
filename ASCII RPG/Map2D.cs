using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_RPG
{

    class Map2D
    {
        private readonly List<StringBuilder> _map;
        private List<IDisplayed> _mapObjects;

        public Map2D(string[] map, params IDisplayed[] objects)
        {
            _map = new List<StringBuilder>();
            foreach (string s in map)
            {
                _map.Add(new StringBuilder(s));
            }
            _mapObjects = objects.ToList();
        }

        public char GetChar(Position2D pos)
        {
            return _map[pos.Y][pos.X];
        }

        public void AddObj(IDisplayed obj)
        {
            _mapObjects.Add(obj);
        }
        public void DelObj(IDisplayed obj)
        {
            _mapObjects.Remove(obj);
        }
        public string ShowObj(IDisplayed obj)
        {
            AddObj(obj);
            string Out = ToString();
            DelObj(obj);
            return Out;
        }
        public string ShowAttack(Attack atk, Position2D pos)
        {
            foreach (Position2D p in atk.Tamplate)
                AddObj(new MapObject(p + pos, '*'));
            string Out = ToString();
            for (int i = 0; i < atk.Tamplate.Count(); i++)
                _mapObjects.Remove(_mapObjects.Last());
            return Out;
        }
        public override string ToString()
        {
            StringBuilder[] TempStr = new StringBuilder[_map.Count];
            for (int i = 0; i < TempStr.Length; i++)
                TempStr[i] = new StringBuilder(_map[i].ToString());
            string Out = "";
            foreach (IDisplayed obj in _mapObjects)
            {
                if (obj.Position.X >= 0 && obj.Position.Y >= 0 && obj.Position.X < _map[0].Length && obj.Position.Y < _map.Count)
                    TempStr[obj.Position.Y][obj.Position.X] = obj.Avatar;
            }
            foreach (StringBuilder s in TempStr)
                Out += s + "\n";
            return Out;
        }
    }

    class MapObject : IDisplayed
    {
        private char _avatar;
        private Position2D _pos;

        public MapObject(Position2D pos, char avatar)
        {
            _pos = pos;
            _avatar = avatar;
        }
        public char Avatar
        {
            get
            {
                return _avatar;
            }
        }

        public Position2D Position
        {
            get
            {
                return _pos;
            }

            set
            {
                _pos = value;
            }
        }
    }

}
