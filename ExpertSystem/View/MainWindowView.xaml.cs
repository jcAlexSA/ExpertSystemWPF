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


namespace ExpertSystem.View
{
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
        }



        private void OnCreateNewVariableClick(object sender, RoutedEventArgs e)
        {
            CreateVariableView cvv = new CreateVariableView();
            cvv.ShowDialog();

            Console.WriteLine("name: " + CreateVariableView.NameVar);
        }

        

    }
}
