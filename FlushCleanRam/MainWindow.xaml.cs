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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlushCleanRam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Create the stack panel
            StackPanel pnl_Stack = new StackPanel();
            this.Content = pnl_Stack;

            // Create the TextBlock
            TextBlock blk_Text = new TextBlock();
            blk_Text.Text = "Welcome to XAML Tutorial";
            blk_Text.Height = 20;
            blk_Text.Width = 200;
            blk_Text.Margin = new Thickness(5);
            pnl_Stack.Children.Add(blk_Text);

            // Create the Button
            Button btn = new Button();
            btn.Content = "OK!";
            btn.Height = 20;
            btn.Width = 50;
            btn.Margin = new Thickness(20);
            pnl_Stack.Children.Add(btn);
        }
    }
}
