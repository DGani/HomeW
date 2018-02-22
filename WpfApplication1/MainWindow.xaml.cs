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
using GeneratorName;


namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            MyButton.Click += myButton_Click;
        }
        public void myButton_Click(object sender, RoutedEventArgs e) {
            //Generator g = new Generator();
           // labelName.Content = g.GenerateDefault(Gender.man);
           // MessageBox.Show("Hello");
        }
        //private void MyButton_Click_1(object sender, RoutedEventArgs e)
        
    }
}
