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

        public Map2D(string[] map,params IDisplayed[] objects)
        {
            _map = new List<StringBuilder>();
            foreach (string s in map)
            {
                _map.Add(new StringBuilder(s));
            }
            _mapObjects = objects.ToList();            
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
        public override string ToString()
        {
            StringBuilder[] TempStr = new StringBuilder[_map.Count];
            for (int i = 0; i < TempStr.Length; i++)
                TempStr[i] = new StringBuilder(_map[i].ToString());
            string Out = "";
            foreach (IDisplayed obj in _mapObjects)
            {
                TempStr[obj.Position.Y][obj.Position.X] = obj.Avatar;
            }
            foreach (StringBuilder s in TempStr)
                Out += s + "\n";
            return Out;
        }
    }
}
