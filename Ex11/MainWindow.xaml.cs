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

namespace Ex11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Closing += MainWindow_Closed;
        }

        private void MainWindow_Closed(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        void ChangeOutput(string str)
        {
            outputTextBox.Text += str;
        }

        private void runA()
        {
            while (true)
            {
                // outputTextBox.Text += "A ";
                Action<string> action = ChangeOutput;
                Dispatcher.BeginInvoke(action, "A ");
                Thread.Sleep(1000);
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Thread t = new Thread(runA);
            t.Start();
        }


    }
}