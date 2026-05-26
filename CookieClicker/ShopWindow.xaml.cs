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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(game.cookiesCount >= game.LepšíKurzorCena)
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
                game.LepšíKurzorCena *= 1.5;
                LepšíKurzorCena.Content = $"Cena: {game.DvojitéKliknutíCena}";
                game.upgradeCount++;


            }
        }
    }
}
