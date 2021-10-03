using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Ex20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TimerWindow : Window
    {
        private Stopwatch stopWatch;
        private bool isTimerRun;
        private Thread timerThread;

        public TimerWindow()
        {
            InitializeComponent();
            stopWatch = new Stopwatch();
        }

        void setTextInvok(string text)
        {
            this.timerTextBlock.Text = text;
        }

        private void startTimerButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isTimerRun)
            {
                stopWatch.Restart();
                isTimerRun = true;

                timerThread = new Thread(runTimer_v2);
                timerThread.Start();
            }
        }

        private void stopTimerButton_Click(object sender, RoutedEventArgs e)
        {
            if (isTimerRun)
            {
                stopWatch.Stop();
                isTimerRun = false;   
            }
        }

        //private void runTimer()
        //{
        //    while (isTimerRun)
        //    {
        //        string timerText = stopWatch.Elapsed.ToString();
        //        timerText = timerText.Substring(0, 8);

        //        Action<string> d = setTextInvok;
        //        Dispatcher.BeginInvoke(d, timerText);

        //        Thread.Sleep(1000);
        //    }
        //}


        void setTextInvok_v2(string timerText)
        {
            if (!CheckAccess())
            {
                Action<string> d = setTextInvok;
                Dispatcher.BeginInvoke(d, timerText);
            }
            else
            {
                this.timerTextBlock.Text = timerText;
            }
        }

        private void runTimer_v2()
        {
            while (isTimerRun)
            {
                string timerText = stopWatch.Elapsed.ToString();
                timerText = timerText.Substring(0, 8);

                setTextInvok_v2(timerText);
                Thread.Sleep(1000);
            }
        }


    }
}
