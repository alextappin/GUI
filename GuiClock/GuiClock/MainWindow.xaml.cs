//Alexander Tappin
//Gui Exam Clock
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Threading;

namespace GuiClock
{
    public partial class MainWindow : Window
    {
        Ellipse clockCircle = new Ellipse();
        Line hourHand = new Line();
        Line minuteHand = new Line();
        Line secondHand = new Line();
        TimeZone zone;

        public MainWindow()
        {
            InitializeComponent();
            InitializDrawItems();
            addToCanvas();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            TimeLabel.Content = DateTime.Now.ToLongTimeString();
        }

        void addToCanvas()
        {
            ClockCanvas.Children.Add(hourHand);
            ClockCanvas.Children.Add(minuteHand);
            ClockCanvas.Children.Add(secondHand);
            ClockCanvas.Children.Add(clockCircle);
        }

        void InitializDrawItems()
        {

            LeftClockNumber.Content = "9";
            TopClockNumber.Content = "12";
            BottomClockNumber.Content = "6";
            RightClockNumber.Content = "3";

            clockCircle.Width = ClockCanvas.Width;
            clockCircle.Height = ClockCanvas.Height;
            clockCircle.Stroke = Brushes.Black;

            hourHand.X1 = ClockCanvas.Width / 2;
            hourHand.Y1 = ClockCanvas.Height / 2;
            hourHand.StrokeThickness = 1.5;
            hourHand.Stroke = Brushes.Red;

            minuteHand.X1 = ClockCanvas.Width / 2;
            minuteHand.Y1 = ClockCanvas.Height / 2;
            minuteHand.StrokeThickness = 2;
            minuteHand.Stroke = Brushes.Black;

            secondHand.X1 = ClockCanvas.Width / 2;
            secondHand.Y1 = ClockCanvas.Height / 2;
            secondHand.StrokeThickness = .8;
            secondHand.Stroke = Brushes.Blue;

            secondHand.Y2 = (int)(-100 * Math.Cos(Math.PI / 30 * DateTime.Now.Second % 60)) + ClockCanvas.Height / 2;
            secondHand.X2 = (int)(100 * Math.Sin(Math.PI / 30 * DateTime.Now.Second % 60)) + ClockCanvas.Width / 2;

            minuteHand.Y2 = (int)(-95 * Math.Cos(Math.PI / 30 * DateTime.Now.Minute % 60)) + ClockCanvas.Height / 2;
            minuteHand.X2 = (int)(95 * Math.Sin(Math.PI / 30 * DateTime.Now.Minute % 60)) + ClockCanvas.Width / 2;

            hourHand.Y2 = (int)(-60 * Math.Cos(Math.PI / 6 * DateTime.Now.Hour)) + ClockCanvas.Height / 2;
            hourHand.X2 = (int)(60 * Math.Sin(Math.PI / 6 * DateTime.Now.Hour)) + ClockCanvas.Width / 2;

        }
        void timer_Tick(object sender, EventArgs e)
        {
            if ((bool)UniversalTimeCheckBox.IsChecked)
            {
                if ((bool)MilitaryTimeCheckBox.IsChecked)
                    TimeLabel.Content = TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).ToString("HH:mm:ss");
                else
                    TimeLabel.Content = TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).ToLongTimeString();
            }

            else
            {
                if ((bool)MilitaryTimeCheckBox.IsChecked)
                    TimeLabel.Content = DateTime.Now.ToString("HH:mm:ss");
                else
                    TimeLabel.Content = DateTime.Now.ToLongTimeString();
            }

            secondHand.Y2 = (int)(-100 * Math.Cos(Math.PI / 30 * DateTime.Now.Second % 60)) + ClockCanvas.Height / 2;
            secondHand.X2 = (int)(100 * Math.Sin(Math.PI / 30 * DateTime.Now.Second % 60)) + ClockCanvas.Width / 2;

            minuteHand.Y2 = (int)(-95 * Math.Cos(Math.PI / 30 * DateTime.Now.Minute % 60)) + ClockCanvas.Height / 2;
            minuteHand.X2 = (int)(95 * Math.Sin(Math.PI / 30 * DateTime.Now.Minute % 60)) + ClockCanvas.Width / 2;

            if ((bool)UniversalTimeCheckBox.IsChecked)
            {
                if ((bool)MilitaryTimeCheckBox.IsChecked)
                {
                    hourHand.Y2 = (int)(-60 * Math.Cos(Math.PI / 12 * TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).Hour)) + ClockCanvas.Height / 2;
                    hourHand.X2 = (int)(60 * Math.Sin(Math.PI / 12 * TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).Hour)) + ClockCanvas.Width / 2;
                }
                else
                {
                    hourHand.Y2 = (int)(-60 * Math.Cos(Math.PI / 6 * TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).Hour)) + ClockCanvas.Height / 2;
                    hourHand.X2 = (int)(60 * Math.Sin(Math.PI / 6 * TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).Hour)) + ClockCanvas.Width / 2;
                }
            }

            else
            {

                if ((bool)MilitaryTimeCheckBox.IsChecked)
                {
                    hourHand.Y2 = (int)(-60 * Math.Cos(Math.PI / 12 * DateTime.Now.Hour)) + ClockCanvas.Height / 2;
                    hourHand.X2 = (int)(60 * Math.Sin(Math.PI / 12 * DateTime.Now.Hour)) + ClockCanvas.Width / 2;
                }

                else
                {
                    hourHand.Y2 = (int)(-60 * Math.Cos(Math.PI / 6 * DateTime.Now.Hour)) + ClockCanvas.Height / 2;
                    hourHand.X2 = (int)(60 * Math.Sin(Math.PI / 6 * DateTime.Now.Hour)) + ClockCanvas.Width / 2;
                }
            }
        }



        private void MilitaryChecked(object sender, RoutedEventArgs e)
        {
            if ((bool)UniversalTimeCheckBox.IsChecked)
            {
                TimeLabel.Content = TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).ToString("HH:mm:ss");
                hourHand.Y2 = (int)(-60 * Math.Cos(Math.PI / 12 * TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).Hour)) + ClockCanvas.Height / 2;
                hourHand.X2 = (int)(60 * Math.Sin(Math.PI / 12 * TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).Hour)) + ClockCanvas.Width / 2;
            }
            else
            {
                TimeLabel.Content = DateTime.Now.ToString("HH:mm:ss");
                hourHand.Y2 = (int)(-60 * Math.Cos(Math.PI / 12 * DateTime.Now.Hour)) + ClockCanvas.Height / 2;
                hourHand.X2 = (int)(60 * Math.Sin(Math.PI / 12 * DateTime.Now.Hour)) + ClockCanvas.Width / 2;
            }
            LeftClockNumber.Content = "18";
            TopClockNumber.Content = "24";
            BottomClockNumber.Content = "12";
            RightClockNumber.Content = "6";
            Canvas.SetLeft(BottomClockNumber, 102);

        }

        private void MilitaryUnchecked(object sender, RoutedEventArgs e)
        {
            if ((bool)UniversalTimeCheckBox.IsChecked)
            {
                TimeLabel.Content = TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).ToLongTimeString();
                hourHand.Y2 = (int)(-60 * Math.Cos(Math.PI / 6 * TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).Hour)) + ClockCanvas.Height / 2;
                hourHand.X2 = (int)(60 * Math.Sin(Math.PI / 6 * TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).Hour)) + ClockCanvas.Width / 2;
            }
            else
            {
                TimeLabel.Content = DateTime.Now.ToLongTimeString();
                hourHand.Y2 = (int)(-60 * Math.Cos(Math.PI / 6 * DateTime.Now.Hour)) + ClockCanvas.Height / 2;
                hourHand.X2 = (int)(60 * Math.Sin(Math.PI / 6 * DateTime.Now.Hour)) + ClockCanvas.Width / 2;
            }
            LeftClockNumber.Content = "9";
            TopClockNumber.Content = "12";
            BottomClockNumber.Content = "6";
            RightClockNumber.Content = "3";
            Canvas.SetLeft(BottomClockNumber, 105);
        }

        private void UniversalTimeCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if ((bool)MilitaryTimeCheckBox.IsChecked)
            {
                hourHand.Y2 = (int)(-60 * Math.Cos(Math.PI / 12 * DateTime.Now.Hour)) + ClockCanvas.Height / 2;
                hourHand.X2 = (int)(60 * Math.Sin(Math.PI / 12 * DateTime.Now.Hour)) + ClockCanvas.Width / 2;
                TimeLabel.Content = DateTime.Now.ToString("HH:mm:ss");
            }
            else
            {
                hourHand.Y2 = (int)(-60 * Math.Cos(Math.PI / 6 * DateTime.Now.Hour)) + ClockCanvas.Height / 2;
                hourHand.X2 = (int)(60 * Math.Sin(Math.PI / 6 * DateTime.Now.Hour)) + ClockCanvas.Width / 2;
                TimeLabel.Content = DateTime.Now.ToLongTimeString();
            }
        }
        private void UniversalTimeCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)MilitaryTimeCheckBox.IsChecked)
            {
                TimeLabel.Content = TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).ToString("HH:mm:ss");
                hourHand.Y2 = (int)(-60 * Math.Cos(Math.PI / 12 * TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).Hour)) + ClockCanvas.Height / 2;
                hourHand.X2 = (int)(60 * Math.Sin(Math.PI / 12 * TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).Hour)) + ClockCanvas.Width / 2;
            }
            else
            {
                hourHand.Y2 = (int)(-60 * Math.Cos(Math.PI / 6 * TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).Hour)) + ClockCanvas.Height / 2;
                hourHand.X2 = (int)(60 * Math.Sin(Math.PI / 6 * TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).Hour)) + ClockCanvas.Width / 2;
                TimeLabel.Content = TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now).ToLongTimeString();
            }
        }
    }
}
