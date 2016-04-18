using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace ASCII_RPG
{
    class Game
    {
        private TextBox _gameWindow;
        private Map2D _map;
        public Player _player;
        public Game(TextBox Map, string MapFile)
        {
            _gameWindow = Map;
            _player = new Player(new Position2D(2, 3));
            _map = new Map2D(File.ReadAllLines(MapFile), _player);
            Update();
        }
        public void Update()
        {
            _gameWindow.Clear();
            _gameWindow.Text = _map.ToString();
            //_gameWindow.Map.Text = _map.GetStr();
        }
        public void Update(string NewMap)
        {
            _gameWindow.Clear();
            _gameWindow.Text = NewMap;
            //_gameWindow.Map.Text = _map.GetStr();
        }

        public void PlayerMove(int x, int y)
        {
            PlayerMove(new Position2D(x, y));
        }
        public void PlayerMove(Position2D delta)
        {
            if (_map.GetChar(_player.Position + delta) == '$')
            {
                BattleWindow bttl = new BattleWindow();
                bttl.ShowDialog();
            }
            if (_map.GetChar(_player.Position + delta) != '#' && _map.GetChar(_player.Position + delta) != 'e')
                _player.Move(delta);
            Update();
        }
        public void Attack(Direction dir = Direction.up)
        {
            Attack atk = _player.MainAttack.Turn(dir);
            foreach (Position2D pos in atk.Tamplate)
                foreach (IDisplayed obj in _map.GetEnemis())
                    if (obj.Position == pos + _player.Position)
                        if (obj is IBeated)
                        {
                            (obj as IBeated).getDamage(atk.Damage);
                            if ((obj as IBeated).Hp == 0)
                                _map.DelObj(obj);
                        }

            Update(_map.ShowAttack(atk, _player.Position));
            //Update();
        }

        public void AddObj(IDisplayed obj)
        {
            _map.AddObj(obj);
        }
        public void DelObj(IDisplayed obj)
        {
            _map.DelObj(obj);
        }

    }
}
