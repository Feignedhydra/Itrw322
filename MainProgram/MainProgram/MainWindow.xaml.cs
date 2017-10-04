using ChattingInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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

namespace MainProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static IChattingService Server;
        private static DuplexChannelFactory<IChattingService> _channelFactory;
        public MainWindow()
        {
            InitializeComponent();
            MessageTbx.IsEnabled = false;
            SendBtn.IsEnabled = false;
            TextDisplaytbx.IsEnabled = false;
            _channelFactory = new DuplexChannelFactory<IChattingService>(new ClientCallback(), "ChattingServiceEndPoint");
            Server = _channelFactory.CreateChannel();

            
        }
        public void TakeMessage(string message, string userName)
        {
            TextDisplaytbx.Text += userName + ": " + message + "\n";
            TextDisplaytbx.ScrollToEnd();
        }

        private void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageTbx.Text.Length == 0)
            {
                return;
            }

            Server.SendMessageToAll(MessageTbx.Text, UsernameTbx.Text);
            TakeMessage(MessageTbx.Text, "You");
            MessageTbx.Text = "";
        }

        private void Loginbtn_Click(object sender, RoutedEventArgs e)
        {
            int returnValue = Server.Login(UsernameTbx.Text);
            if(returnValue == 1)
            {
                MessageBox.Show("You are already logged in. Try again");
            }
            else if (returnValue == 0)
            {
                MessageBox.Show("You logged in!");
                WelcomeLbl.Content = "Welcome " + UsernameTbx.Text + "!";
                UsernameTbx.IsEnabled = false;
                Loginbtn.IsEnabled = false;
                MessageTbx.IsEnabled = true;
                SendBtn.IsEnabled = true;
                
            }
        }
    }
}
