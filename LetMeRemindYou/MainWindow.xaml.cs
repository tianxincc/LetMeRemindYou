using HandyControl.Controls;
using HandyControl.Tools.Extension;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using MessageBox = HandyControl.Controls.MessageBox;

namespace LetMeRemindYou
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void FormSub_Click(object sender, RoutedEventArgs e)
        {
            Form form = new Form();
            form.ShowDialog();
        }

        private void JingLingClick(object sender, RoutedEventArgs e)
        {
            Sprite.Show(new AppSprite());
        }

        private void YiYan_Click(object sender, RoutedEventArgs e)
        {
            WebClient MyWebClient = new WebClient();
            MyWebClient.Credentials = CredentialCache.DefaultCredentials;
            Byte[] pageData = MyWebClient.DownloadData("https://v1.hitokoto.cn");
            string pageHtml = Encoding.UTF8.GetString(pageData);
            //PopupWindow.ShowDialog(pageHtml,"一言",false);
            //PopupWindow.Show(pageHtml, true);
            //Growl.Success(pageHtml);
        }

       


    }
}
