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
using System.Collections;

namespace JournalIndexMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, Category> d = new Dictionary<string, Category>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(txt.GetLineText(0).GetHashCode());
            string[] allLines = txt.Text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.None);

            for (int i = 0; i < txt.LineCount; i++)
            {
                string line = allLines[i];
                string[] splitLine = line.Split(',');
                string catName = splitLine[0].Trim();
                string subcatName = splitLine[1].Trim();
                string date = splitLine[2].Trim();
                if (!d.ContainsKey(catName))
                {
                    d.Add(catName, new Category(catName));
                }

                if (d.TryGetValue(catName, out Category currentCat))
                {
                    Console.WriteLine(DateTime.Parse(date));
                    currentCat.addEntry(subcatName, DateTime.Parse(date));
                    
                }
                else
                {
                    throw new Exception("Dictionary does not contain category " + catName);
                }                
            }
        }
    }
}
