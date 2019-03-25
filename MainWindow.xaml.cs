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

namespace Fibonacci_sequence_drawing
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

        private void btnNumber_Click(object sender, RoutedEventArgs e)
        {
            int s1 = 0;
            int s2 = 1;
            int numberofItem = 2;
            int.TryParse(txtNumber.Text, out numberofItem);
            string fib = "";
            if (numberofItem >= 1)
            {
                fib = s1.ToString();
            }
            if (numberofItem >= 1)
            {
                fib += "," + s2.ToString();
            }
            for (int i = 2; i < numberofItem; i++)
            {
                int next = s1 + s2;
                fib += "," + next.ToString();
                s1 = s2;
                s2 = next;
            }
            MessageBox.Show(fib);
        }
       // int fibn;
   //     int.TryParse (fib,out int fibn);
  //      result = Convert.ToInt32(fib);
        Rectangle r = new Rectangle();
        r.height = next;
        r.width = fib.ToConvert;
        canvas.Children.Add(r);
        Canvas.SetTop (r, );
        Canvas.SetLeft (r, );
    }
}

