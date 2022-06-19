using HandyControl.Controls;
using HandyControl.Data;

using LetMeRemindYou.Status;

using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace LetMeRemindYou
{
    /// <summary>
    /// Sprite.xaml 的交互逻辑
    /// </summary>
    public partial class AppSprite
    {
        public AppSprite()
        {
            InitializeComponent();
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            ExecuteWaterTimer();
        }

        private void ExchangeClick(object sender, RoutedEventArgs e)
        {
            var backNumber=BackRandom(1,10);
            spirit.EndRow = backNumber;
        }

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AboutMeClick(object sender, RoutedEventArgs e)
        {
            AboutMe aboutMe = new AboutMe();
            aboutMe.ShowDialog();
        }

        private void ExecuteWaterTimer() 
        {
            Timer t = new Timer();
            t.Interval= 600000;
            t.Elapsed += new ElapsedEventHandler(Message);
            t.AutoReset = false;
            t.Enabled = true;
            t.Start(); 
        }

        private void Message(object sender, System.Timers.ElapsedEventArgs e)
        {
            var time = DateTime.Now.ToString("HH:mm:ss");
            var BackCode = BackRandom(1,50);
            var _morning=MorningMessage.Messages;
            var _message=JObject.Parse(_morning)["Name" + BackCode].ToString();
            switch (time)
            {
                case Water.OneWaterTime:
                    Notification.Show(new NotificationMessage(Water.OneWaterMessage, _message), ShowAnimation.VerticalMove, false);
                    break;
                case Water.TwoWaterTime:
                    Notification.Show(new NotificationMessage(Water.TwoWaterMessage, _message), ShowAnimation.VerticalMove, false);
                    break;
                case Water.ThreeWaterTime:
                    Notification.Show(new NotificationMessage(Water.ThreeWaterMessage, _message), ShowAnimation.VerticalMove, false);
                    break;
                case Water.FourWaterTime:
                    Notification.Show(new NotificationMessage(Water.FourWaterMessage, _message), ShowAnimation.VerticalMove, false);
                    break;
                case Water.FiveWaterTime:
                    Notification.Show(new NotificationMessage(Water.FiveWaterMessage, _message), ShowAnimation.VerticalMove, false);
                    break;
                case Water.SixWaterTime:
                    Notification.Show(new NotificationMessage(Water.SixWaterMessage, _message), ShowAnimation.VerticalMove, false);
                    break;
                default:
                    var BackDefault = BackRandom(1, 10);
                    if (BackDefault == 1)
                    {
                        var _endeavor = MorningMessage.Messages;
                        var _endeavorMessage = JObject.Parse(_morning)["Name" + BackCode].ToString();
                        Notification.Show(new NotificationMessage(Water.CommonWaterName, _endeavorMessage), ShowAnimation.VerticalMove, false);
                    }
                    break;
            }
        }

        private int BackRandom(int startNumber,int endNumber) 
        {
            Random random = new Random();
            var Key = random.Next(startNumber, endNumber);
            return Key;
        }
    }
}
