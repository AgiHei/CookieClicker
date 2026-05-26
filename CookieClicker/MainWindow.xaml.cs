using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CookieClicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private GameState game;

        private void UpdateUI()
        {
            TxtCookiesCount.Text = $"Sušenky: {game.cookiesCount}";
        }

        public MainWindow()
        {
            InitializeComponent();

            game = new GameState();

            game.cookiesCount = 0;
            game.cookiesPerClick = 1;
            game.cookiesPerSecond = 0;
            game.totalClicks = 0;
            game.upgradeCount = 0;

            UpdateUI();
        }

        



        private void Cookie_Click(object sender, RoutedEventArgs e)
        {
            game.totalClicks += 1;
            game.cookiesCount += game.cookiesPerClick;
            TxtCookiesCount.Text = game.cookiesCount.ToString("0.00");

        }
    }
}