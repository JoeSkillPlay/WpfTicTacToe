using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfTicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string turn = string.Empty;
        

        public MainWindow()
        {
            InitializeComponent();
            InitializeGame();

        }

        private void InitializeGame()
        {
            turn = "X";
            
        
        }


        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;

            if(tb.Text != "X" && tb.Text != "O")
            {
                tb.Text = turn;

                SwitchTurn();
                CheckForWin();

            }

            
            

        }

        private void SwitchTurn()
        {
            if (turn == "X")
            {
                turn = "O";
            }

            else
            {
                turn = "X";

            }
        }


        private void CheckForWin()
        {
            var winColor = Brushes.Orange;

            if (t1.Text != "        " && t1.Text == t2.Text && t2.Text == t3.Text)
            {

                t1.Foreground = t2.Foreground = t3.Foreground = winColor;
                GameOver();

            }
            else if(t4.Text != "          " && t4.Text == t5.Text && t5.Text == t6.Text)
            {
                t4.Foreground = t5.Foreground = t6.Foreground = winColor;
                GameOver();
            }
            else if (t7.Text != "         " && t7.Text == t8.Text && t8.Text == t9.Text)
            {
                t7.Foreground = t8.Foreground = t9.Foreground = winColor;
                GameOver();
            }
            else if (t1.Text != "         " && t1.Text == t4.Text && t4.Text == t7.Text)
            {
                t1.Foreground = t4.Foreground = t7.Foreground = winColor;
                GameOver();
            }
            else if (t2.Text != "         " && t2.Text == t5.Text && t5.Text == t8.Text)
            {
                t2.Foreground = t5.Foreground = t8.Foreground = winColor;
                GameOver();
            }
            else if (t3.Text != "         " && t3.Text == t5.Text && t5.Text == t9.Text)
            {
                t3.Foreground = t5.Foreground = t9.Foreground = winColor;
                GameOver();
            }
            else if (t1.Text != "         " && t1.Text == t5.Text && t5.Text == t9.Text)
            {
                t1.Foreground = t5.Foreground = t9.Foreground = winColor;
                GameOver();
            }
            else if (t3.Text != "         " && t3.Text == t5.Text && t5.Text == t7.Text)
            {
                t3.Foreground = t5.Foreground = t7.Foreground = winColor;
                GameOver();
            }
        }

        private void GameOver()
        {
            MessageBox.Show($"Game over, {turn} wins!");
        }

    }

}
