using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            //加载定时提醒任务
        }

        private void ExchangeClick(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            var Key = random.Next(1, 10);
            spirit.StartRow = Key;
            spirit.EndRow = Key;
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

       
    }
}
