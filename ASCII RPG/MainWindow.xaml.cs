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

namespace ASCII_RPG
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Game game;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Map.IsReadOnly = true;
            game = new Game(this,"TestMap.txt");
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            
            switch (e.Key)
            {
                case Key.W : game.PlayerMove(0, -1);
                    break;
                case Key.S:
                    game.PlayerMove(0, 1);
                    break;
                case Key.A:
                    game.PlayerMove(-1, 0);
                    break;
                case Key.D:
                    game.PlayerMove(1, 0);
                    break;
                case Key.Up:
                    game.Attack(Direction.up);
                    break;
                case Key.Down:
                    game.Attack(Direction.down);
                    break;
                case Key.Left:
                    game.Attack(Direction.left);
                    break;
                case Key.Right:
                    game.Attack(Direction.right);
                    break;
            }
            //game.Update();
        }
    }
}
