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

namespace Telhai.cs.DotNet.TomerHarari.DataTypesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void test_Click(object sender, RoutedEventArgs e)
        {
            int x = 0;
            int y = 0;
            bool isError = false;
            try
            {
               x = int.Parse(txtBoxX.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("X is not a number");
                isError = true;
            }

            bool isOkParsed = int.TryParse(txtBoxY.Text,out y);
            if (!isOkParsed)
            {
                MessageBox.Show("Y is not a number");
                isError = true;
            }

            //No Error
            if (!isError)
            {
                Point p = new Point(x, y);
                LogTextLine(p);
            }
            
          
            
           
          
           
           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="txt"></param>
        private void LogTextLine(string txt)
        {
            txtLogBox.Text += txt + Environment.NewLine;
        }

        /// <summary>
        /// object
        /// </summary>
        /// <param name="obj"></param>
        private void LogTextLine(object objPoint)
        {
            txtLogBox.Text += objPoint.ToString() + Environment.NewLine;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="txt"></param>
        private void LogText(string txt)
        {
            txtLogBox.Text += txt;
        }



    }
}