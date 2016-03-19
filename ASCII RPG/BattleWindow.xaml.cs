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
using System.Windows.Shapes;

namespace ASCII_RPG
{
    /// <summary>
    /// Логика взаимодействия для BattleWindow.xaml
    /// </summary>
    public partial class BattleWindow : Window
    {
        public BattleWindow()
        {
            InitializeComponent();
        }

        private void BattleWind_Loaded(object sender, RoutedEventArgs e)
        {
            BattlMapTxt.IsReadOnly = true;
        }
    }
}
