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

namespace CookieClicker
{
    /// <summary>
    /// Interakční logika pro ShopWindow.xaml
    /// </summary>
    public partial class ShopWindow : Window
    {
        private GameState game;

        public ShopWindow(GameState gameState)
        {
            InitializeComponent();

            game = gameState;

            LepšíKurzorCena.Content = $"Cena: {game.LepšíKurzorCena}";
            DvojitéKliknutíCena.Content = $"Cena: {game.DvojitéKliknutíCena}";
            BabičkaCena.Content = $"Cena: {game.BabičkaCena}";
            PekárnaCena.Content = $"Cena: {game.PekárnaCena}";
            TovárnaCena.Content = $"Cena: {game.TovárnaCena}";



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (game.cookiesCount >= game.LepšíKurzorCena)
            {
                game.cookiesCount -= game.LepšíKurzorCena;
                game.cookiesPerClick += 1;
                game.LepšíKurzorCena *= 1.5;
                LepšíKurzorCena.Content = $"Cena: {game.LepšíKurzorCena}";
                game.upgradeCount++;


            }
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (game.cookiesCount >= game.DvojitéKliknutíCena)
            {
                game.cookiesCount -= game.DvojitéKliknutíCena;
                game.cookiesPerClick += 5;
                game.DvojitéKliknutíCena *= 1.5;
                DvojitéKliknutíCena.Content = $"Cena: {game.DvojitéKliknutíCena}";
                game.upgradeCount++;


            }
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (game.cookiesCount >= game.BabičkaCena)
            {
                game.cookiesCount -= game.BabičkaCena;
                game.cookiesPerSecond += 1;
                game.BabičkaCena *= 1.5;
                BabičkaCena.Content = $"Cena: {game.BabičkaCena}";
                game.upgradeCount++;


            }
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            if (game.cookiesCount >= game.PekárnaCena)
            {
                game.cookiesCount -= game.PekárnaCena;
                game.cookiesPerSecond += 5;
                game.PekárnaCena *= 1.5;
                PekárnaCena.Content = $"Cena: {game.PekárnaCena}";
                game.upgradeCount++;


            }
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            if (game.cookiesCount >= game.TovárnaCena)
            {
                game.cookiesCount -= game.TovárnaCena;
                game.cookiesPerSecond += 25;
                game.TovárnaCena *= 1.5;
                TovárnaCena.Content = $"Cena: {game.TovárnaCena}";
                game.upgradeCount++;


            }
        }
    }
}
