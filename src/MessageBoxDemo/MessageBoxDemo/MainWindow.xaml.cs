using MessageBoxDemo.Components;

using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MessageBoxDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxHelper.Success("你是最胖的！", "系统提示");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxHelper.Error("系统要崩了！", "系统提示");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxHelper.Ask("叼毛开发者抛出了一个异常，请问您要跳转百度帮开发者解决一下这个问题吗？", "系统提示", callback =>
            {
                if (callback == MessageBoxResult.OK)
                {
                    Process.Start("https://www.cnblogs.com/chonglu/");
                }
            });
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBoxHelper.Info("就是一条普通消息啦~", "系统提示");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("WPF自带原生消息弹窗","系统提示");
        }
    }
}
