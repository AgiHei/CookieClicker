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

        public MainWindow()
        {
            InitializeComponent();
        }

        float CookiesCount = 0;
        float CookiesPerClick = 1;
        float CookiesPerSecond = 0;
        int totalClicks = 0;
        int upgradeCount = 0;
        


        private void Cookie_Click(object sender, RoutedEventArgs e)
        {
            totalClicks += 1;
            CookiesCount += CookiesPerClick;
            TxtCookiesCount.Text = CookiesCount.ToString("0.00");

        }
    }
}