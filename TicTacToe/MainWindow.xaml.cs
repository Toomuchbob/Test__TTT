using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacToe
{
    public partial class MainWindow : Window
    {
        // Holds the current results of cells in the active game
        private MarkType[] mResults;
        private bool mPlayer1Turn;
        private bool mGameEnded;

        public MainWindow()
        {
            InitializeComponent();

            NewGame();
        }

        private void NewGame()
        {
            //create a new black array of free cells
            mResults = new MarkType[9];

            for (var i = 0; i < mResults.Length; i++)
            {
                mResults[i] = MarkType.Free;
            }

            mPlayer1Turn = true;

            // iterate every button on the grid
            Container.Children.Cast<Button>().ToList().ForEach(Button =>
            {
                // change content default values
                Button.Content = string.Empty;
                Button.Background = Brushes.White;
                Button.Foreground = Brushes.Blue;
            });

            mGameEnded = false;

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
