using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Count { get; set; }
        public bool plus;
        public bool minus;
        public MainWindow()
        {
            InitializeComponent();
            Count = 0;
            plus = false;
            minus = false;
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!plus)
            {
                plus = true;
                minus = false;

                Task.Run(() => CountPlus());
            }
        }

        public async void CountPlus()
        {
            while (plus) 
            {
                await Task.Run(() => Count++);
                this.Dispatcher.Invoke(()=>TbCount.Text = Count.ToString());
                Thread.Sleep(1000);
            }
        }
        public async Task CountMinus()
        {
            while (minus)
            {
                await Task.Run(() => Count--);
                this.Dispatcher.Invoke(() => TbCount.Text = Count.ToString());
                Thread.Sleep(1000);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!minus)
            {
                minus = true;
                plus = false;
                Task.Run(() => CountMinus());
            }
        }
    }
}
