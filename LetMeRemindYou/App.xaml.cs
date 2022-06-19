using HandyControl.Controls;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace LetMeRemindYou
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {

            Sprite.Show(new AppSprite());
            //WindowIcon windowIcon = new WindowIcon();
            //windowIcon.Show();

        }
    }
}
