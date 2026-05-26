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

        private DispatcherTimer timerCPS;
        private DispatcherTimer timerStats;

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

            timerCPS = new DispatcherTimer();

            timerCPS.Interval = TimeSpan.FromSeconds(1);

            timerCPS.Tick += TimerCPS_Tick;

            timerCPS.Start();




            timerStats = new DispatcherTimer();

            timerStats.Interval = TimeSpan.FromSeconds(0.1);

            timerStats.Tick += TimerStats_Tick;

            timerStats.Start();

        }

        private void TimerCPS_Tick(object sender, EventArgs e)
        {
            game.cookiesCount += game.cookiesPerSecond;
            
        }

        private void TimerStats_Tick(object sender, EventArgs e)
        {
          TxtCookiesCount.Text = game.cookiesCount.ToString("0.00");
          _2.Content = game.cookiesPerClick.ToString("0.00");
          _3.Content = game.cookiesPerSecond.ToString("0.00");
          _4.Content = game.totalClicks.ToString("0.00");
          _5.Content = game.upgradeCount.ToString("0.00");

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