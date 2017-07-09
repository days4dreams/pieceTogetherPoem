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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = " minutes in each day.";

            int hours = 24;
            int minutes = 60;

            double minutesInDay = minutes * hours;

            myLabel.Text = "Did you know? There are " + minutesInDay + name;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 4;
            string name = "Bobbo Junior.";

            if ((someValue ==3) && (name == "Joe"))
            {
                myLabel.Text = "x is 3 and the name is Joe.";
            }
            myLabel.Text = "This line runs no matter what.";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            while (count < 10)
            {
                count = count + 1;
            }

            for (int i = 0; i < 5; i++ )
            {
                count = count - 1;
            }

            myLabel.Text = "The answer is " + count;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;

            if (x == 10)
            {
                myLabel.Text = "x is equal to 10.";
            }
            else
            {
                myLabel.Text = "x is not equal to 10.";
            }
        }

        private void changeText_Click(object sender, RoutedEventArgs e)
        {
            if (enableCheckBox.IsChecked == true)
            {
                labelToChange.Text = "Way to go!";

            }
            else
            {
                labelToChange.Text = "Text changing is disabled. Try checkbox.";

            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            int x = 0;
            string poem = "";

            while ( x < 4)
            {
                poem = poem + "a";

                if (x < 1)
                {
                    poem = poem + " ";
                }

                poem = poem + "n";

                if (x > 1)
                {
                    poem = poem + " oyster";
                    x = x + 2;
                }

                if (x == 1)
                {
                    poem = poem + "noys ";
                }

                if ( x < 1)
                {
                    poem = poem + "oise ";
                }

                x = x + 1;
            }
            poemBlock.Text = poem;
        }
    }
}
