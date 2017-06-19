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
using System.Windows.Shapes;

namespace ExpertSystem.View
{
    /// <summary>
    /// Interaction logic for RuleBlockWizard.xaml
    /// </summary>
    public partial class RuleBlockWizardView : Window
    {
        public static string Name { get; set; }

        public RuleBlockWizardView()
        {
            InitializeComponent();

            listBox_common_var.ItemsSource = MainWindowView.VariableCollection;
        }

        private void OnInputBtnClick(object sender, RoutedEventArgs e)
        {
            List<int> selectedItems = new List<int>();
            foreach (int item in listBox_common_var.SelectedItems)
                selectedItems.Add(listBox_common_var.Items.IndexOf(item));

            
        }
    }
}
