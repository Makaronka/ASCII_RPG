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
        private MainWindow _gameWindow;
        private Map2D _map;
        public Player _player;
        public Game(MainWindow mainWindow, string MapFile)
        {
            _gameWindow = mainWindow;
            _player = new Player(new Position2D(2, 3));
            _map = new Map2D(File.ReadAllLines(MapFile),_player);
            Update();
        }
        public void Update()
        {
            _gameWindow.Map.Clear();
            _gameWindow.Map.Text = _map.ToString();
            //_gameWindow.Map.Text = _map.GetStr();
        }
        public void Update(string NewMap)
        {
            _gameWindow.Map.Clear();
            _gameWindow.Map.Text = NewMap;
            //_gameWindow.Map.Text = _map.GetStr();
        }

        public void PlayerMove(int x, int y)
        {
            PlayerMove(new Position2D(x, y));
        }
        public void PlayerMove(Position2D delta)
        {
            _player.Move(delta);
            Update();
        }
        public void Attack()
        {
            Update(_map.ShowAttack(new Attack(1, new Position2D(0, -1), new Position2D(0, -2)), _player.Position));
        }
        
    }
}
