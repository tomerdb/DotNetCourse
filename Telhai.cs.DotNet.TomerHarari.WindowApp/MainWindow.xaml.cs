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

namespace Telhai.cs.DotNet.TomerHarari.WindowApp
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

        public enum DisplayPointOptions
        {
            AllData = 0,
            JustValues = 1,
            AllDataAndDistances =2,
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTestTypes_OnClick(object sender, RoutedEventArgs e)
        
        {
                var x = 10;
                var t = DateTime.Now;
                int year = t.Year;
                DisplayPointOptions ptype1 = DisplayPointOptions.JustValues;
                DisplayPointOptions ptype2 = DisplayPointOptions.AllData;
    
                int? s = 10;
                s = null;
    
                float? f1 = null;
               
                if (!f1.HasValue)
                {
                    f1 = 2.5f;
                }
                if (f1.HasValue)
                {
                   float f = f1.Value;
                }
                string sf = f1.HasValue ? f1.Value.ToString() : "NO VAL";
    
                var tp1 = (Name: "Alice", Age: 12);
    
                var name = tp1.Name;
    
                List<string> items = new List<string>();
                items.Add("A");
                items.Add("A1");
                items.Add("B");
                items.RemoveAt(1);
                List<string> subList = items.FindAll(s => s.StartsWith("A"));
                string? found = items.Find(s => s.StartsWith("A"));
                if (found != null)
                {
                }
        

        }
    }
}