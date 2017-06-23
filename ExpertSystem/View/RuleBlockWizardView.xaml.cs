using ExpertSystem.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public ObservableCollection<FuzzyVariable> _this_rule_block_fuzzyVar;
        public ObservableCollection<FuzzyVariable> _input_variable_fuzzyVar;
        public ObservableCollection<FuzzyVariable> _output_variable_fuzzyVar;

        public RuleBlockWizardView()
        {
            InitializeComponent();

            _this_rule_block_fuzzyVar = MainWindowView.VariableCollection;

            listBox_common_var.ItemsSource = _this_rule_block_fuzzyVar;     //fill listBox

            _input_variable_fuzzyVar = new ObservableCollection<FuzzyVariable>();
            _output_variable_fuzzyVar = new ObservableCollection<FuzzyVariable>();
        }

        private void OnInputBtnClick(object sender, RoutedEventArgs e)
        {
            if (listBox_common_var.SelectedItems == null || listBox_common_var.SelectedItems.Count == 0) return;

            List<int> selectedItems = new List<int>();

            foreach (var item in listBox_common_var.SelectedItems)
                selectedItems.Add(listBox_common_var.Items.IndexOf(item));

            foreach (int item in selectedItems)
            {
                _input_variable_fuzzyVar.Add(_this_rule_block_fuzzyVar.ToArray()[item]);
                _this_rule_block_fuzzyVar.RemoveAt(item);
            }
            
            listBox_inputVar.ItemsSource = _input_variable_fuzzyVar;
        }

        private void OnOutputBtnClick(object sender, RoutedEventArgs e)
        {
            if (listBox_common_var.SelectedItems == null || listBox_common_var.SelectedItems.Count == 0) return;

            List<int> selectedItems = new List<int>();

            foreach (var item in listBox_common_var.SelectedItems)
                selectedItems.Add(listBox_common_var.Items.IndexOf(item));

            foreach (int item in selectedItems)
            {
                _output_variable_fuzzyVar.Add(_this_rule_block_fuzzyVar.ToArray()[item]);
                _this_rule_block_fuzzyVar.RemoveAt(item);
            }
            
            listBox_outputVar.ItemsSource = _output_variable_fuzzyVar;
        }
    }
}
