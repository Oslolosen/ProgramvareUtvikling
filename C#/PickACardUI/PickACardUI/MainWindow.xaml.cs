using PickACardUI;
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

namespace PickACardUI
{
    public partial class MainWindow : Window
    {
        BlackJack blackJack = new BlackJack();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            blackJack.startBlackJack();

            foreach (string card in blackJack.dealerCards)
            {
                listOfCards.Items.Add(card);
            }
            
            foreach (string card in blackJack.playerCards)
            {
                listOfCards.Items.Add(card);
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            blackJack.resetBlackJack();

            listOfCards.ClearValue();

        }

        private void listOfCards_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
