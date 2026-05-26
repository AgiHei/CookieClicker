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
using System.Windows.Threading;

namespace CookieClicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private GameState game;

        private DispatcherTimer timer;

        private ShopWindow shopWindow;



        public MainWindow()
        {
            InitializeComponent();

            game = new GameState();

            game.cookiesCount = 0;
            game.cookiesPerClick = 1;
            game.cookiesPerSecond = 0;
            game.totalClicks = 0;
            game.upgradeCount = 0;

            game.LepšíKurzorCena = 10;
            game.DvojitéKliknutíCena = 50;
            game.BabičkaCena = 100;
            game.PekárnaCena = 500;
            game.TovárnaCena = 2500;

            timer = new DispatcherTimer();

            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += Timer_Tick;

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            game.cookiesCount += game.cookiesPerSecond;
            TxtCookiesCount.Text = game.cookiesCount.ToString("0.00");
        }





        private void Cookie_Click(object sender, RoutedEventArgs e)
        {
            game.totalClicks += 1;
            game.cookiesCount += game.cookiesPerClick;
            TxtCookiesCount.Text = game.cookiesCount.ToString("0.00");

        }

        private void Store_Click(object sender, RoutedEventArgs e)
        {
            if (shopWindow != null)
            {
                shopWindow.Activate();
                return;
            }

            shopWindow = new ShopWindow(game);

            shopWindow.Closed += (s, args) =>
            {
                shopWindow = null;
            };

            shopWindow.Show();
        }
    }
}