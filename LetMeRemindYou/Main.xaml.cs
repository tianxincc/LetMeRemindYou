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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LetMeRemindYou
{
    /// <summary>
    /// Main.xaml 的交互逻辑
    /// </summary>
    public partial class Main 
    {
        public Main()
        {
            InitializeComponent();
            //Loaded += NotifyWindow_Loaded;
        }

        private void NotifyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Left = SystemParameters.WorkArea.Right - this.Width;
            Top = SystemParameters.WorkArea.Bottom;
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(0.5)),
                To = SystemParameters.WorkArea.Bottom - this.Height,
            };
            this.BeginAnimation(TopProperty, animation);
        }
    }
}
