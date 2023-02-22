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

namespace LuckyGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Random random = new Random();
            HidenNum = random.Next(100);
        }

        private int HidenNum;


        private void Check_Click(object sender, RoutedEventArgs e)
        {
            if (Info.Text == "Win")
            {
                Info.Text = "Угадай число!";
                Field.Text = "";
                Random random = new Random();
                HidenNum = random.Next(100);
                return;
            }

            if (int.TryParse((Field.Text).ToString(), out int Number))
            {
                if (Number == HidenNum)
                {
                    Info.Text = "Win";
                    Field.Text = "";
                }
                else if (Number < HidenNum)
                {
                    Info.Text = "Try more";
                    Field.Text = "";
                }
                else
                {
                    Info.Text = "Try less";
                    Field.Text = "";
                }
            }
            else
                Field.Text = "";
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            Info.Text = "Угадай число!";
            Field.Text = "";
            Random random = new Random();
            HidenNum = random.Next(100);
        }
    }
}
