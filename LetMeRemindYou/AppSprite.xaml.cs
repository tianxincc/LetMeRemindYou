using HandyControl.Controls;
using HandyControl.Data;

using LetMeRemindYou.Common;
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
            var backNumber=BackRandom(CaseStatus.startRandom_1, CaseStatus.startRandom_10);
            spirit.EndRow = backNumber;
        }

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AboutMeClick(object sender, RoutedEventArgs e)
        {
            //AboutMe aboutMe = new AboutMe();
            //aboutMe.ShowDialog();
        }

        private void ExecuteWaterTimer() 
        {
            Timer t = new Timer();
            t.Interval = CaseStatus.startInterval;
            t.Elapsed += new ElapsedEventHandler(Message);
            t.AutoReset = true;
            t.Enabled = true;
            t.Start(); 
        }

        private void Message(object sender,ElapsedEventArgs e)
        {
            var time = DateTime.Now.ToString("HH:mm:ss");
            var BackCode = BackRandom(CaseStatus.startRandom_1,CaseStatus.endRandom_50);
            var _morning=MorningMessage.Messages;
            var _message=JObject.Parse(_morning)["Name" + BackCode].ToString();
            switch (time)
            {
                case Water.OneWaterTime:
                    Dispatcher.BeginInvoke(new Action(delegate {
                        Notification.Show(new NotificationMessage(Water.OneWaterMessage, _message), ShowAnimation.VerticalMove, false);
                    }));
                    break;
                case Water.TwoWaterTime:
                    Dispatcher.BeginInvoke(new Action(delegate {
                        Notification.Show(new NotificationMessage(Water.TwoWaterMessage, _message), ShowAnimation.VerticalMove, false);
                    }));
                    break;
                case Water.ThreeWaterTime:
                    Dispatcher.BeginInvoke(new Action(delegate {
                        Notification.Show(new NotificationMessage(Water.ThreeWaterMessage, _message), ShowAnimation.VerticalMove, false);
                    }));
                    break;
                case Water.FourWaterTime:
                    Dispatcher.BeginInvoke(new Action(delegate {
                        Notification.Show(new NotificationMessage(Water.FourWaterMessage, _message), ShowAnimation.VerticalMove, false);
                    }));
                    break;
                case Water.FiveWaterTime:
                    Dispatcher.BeginInvoke(new Action(delegate {
                        Notification.Show(new NotificationMessage(Water.FiveWaterMessage, _message), ShowAnimation.VerticalMove, false);
                    }));
                    break;
                case Water.SixWaterTime:
                    Dispatcher.BeginInvoke(new Action(delegate {
                        Notification.Show(new NotificationMessage(Water.SixWaterMessage, _message), ShowAnimation.VerticalMove, false);
                    }));
                    break;
                default:
                    var BackDefault = BackRandom(CaseStatus.startRandom_1, CaseStatus.startRandom_10);
                    if (BackDefault == CaseStatus.startRandom_1)
                    {
                        var _endeavor = MorningMessage.Messages;
                        var _endeavorMessage = JObject.Parse(_endeavor)["Name" + BackCode].ToString();
                        Dispatcher.BeginInvoke(new Action(delegate {
                            Notification.Show(new NotificationMessage(Water.CommonWaterName, _endeavorMessage), ShowAnimation.VerticalMove, false);
                        }));
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

        private void SettingsClick(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }
    }
}
