/*Jordan Ross
 * May 30, 2019
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.
 */
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

namespace Euler_Multiples_3_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int FinalSum;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < 334; i++)
            {
                FinalSum += i * 3;
            }

            for (int j = 1; j < 200; j++)
            {
                FinalSum += j * 5;
            }
            
            for (int k = 1; k < 67; k++)
            {
                FinalSum -= k * 15;
            }
            lblSum.Content = FinalSum;
        }
    }
}
