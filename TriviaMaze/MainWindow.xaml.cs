using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Diagnostics;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TriviaMaze
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ellipse_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine(e.Key);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            Log(e.Key.ToString());
            int CurRow, CurCol;
            CurRow = (int)Player.GetValue(Grid.RowProperty);
            CurCol = (int)Player.GetValue(Grid.ColumnProperty);
            try
            {
                switch (e.Key)
                {
                    case Key.Up:
                        Player.SetValue(Grid.RowProperty, (int)(Player.GetValue(Grid.RowProperty)) - 1);
                        break;

                    case Key.Down:
                        Player.SetValue(Grid.RowProperty, (int)(Player.GetValue(Grid.RowProperty)) + 1);
                        break;

                    case Key.Left:
                        Player.SetValue(Grid.ColumnProperty, (int)(Player.GetValue(Grid.ColumnProperty)) - 1);
                        break;

                    case Key.Right:
                        Player.SetValue(Grid.ColumnProperty, (int)(Player.GetValue(Grid.ColumnProperty)) + 1);
                        break;
                }
            }catch(ArgumentException ex)
            {
                Log("Cannot move out of bounds");
                //Log(ex.StackTrace);
                
            }
        }
        private void Log(String msg)
        {
            Debug.WriteLine(msg);
        }
    }
}
