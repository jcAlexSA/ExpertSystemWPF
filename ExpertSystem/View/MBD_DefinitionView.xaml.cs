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
    /// Interaction logic for MBD_Definition.xaml
    /// </summary>
    public partial class MBD_DefinitionView : Window
    {
        public static int Min { get; private set; }
        public static int Max { get; private set; }

        public static ObservableCollection<Term> TermsList = new ObservableCollection<Term>();// { get; private set; }
        
        public MBD_DefinitionView()
        {
            InitializeComponent();

            //reset values
            TermsList = null;

            Min = Max = 0;

            ListBoxTerms.ItemsSource = TermsList;
        }

        private void OnAddTermBtnClick(object sender, RoutedEventArgs e)
        {
            float low, mid, high;
            try
            {
                low = System.Convert.ToSingle(textBox_lowVal.Text);
                mid = System.Convert.ToSingle(textBox_midVal.Text);
                high = System.Convert.ToSingle(textBox_highVal.Text);
            }
            catch (Exception) { MessageBox.Show("Input validate function data!"); return; }

            if (low > mid || mid > high)
            {
                MessageBox.Show("Incorrect values of triangle function!"); return;
            }

            if (string.IsNullOrEmpty(textBox_NameTerm.Text))
            {
                MessageBox.Show("Input name of term!"); return;
            }

            string nameTerm = textBox_NameTerm.Text;
            TriangleFunction function = new TriangleFunction(low, mid, high);
            if (TermsList == null)
            {
                TermsList = new ObservableCollection<Term>();
                ListBoxTerms.ItemsSource = TermsList;
            }
            TermsList.Add(new Term(nameTerm, function));

            textBox_NameTerm.Text = null;
            //Console.WriteLine("terms list: ");
            //foreach (var item in TermsList)
            //{
            //    Console.WriteLine("name : {0}; functionName: {1};" , item.Name, item.Function.ToString());
            //}
        }

        private void OnNextBtnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Min = System.Convert.ToInt32(textBox_minVarValue.Text);
                Max = System.Convert.ToInt32(textBox_maxVarValue.Text);
            }
            catch (Exception) { MessageBox.Show("Input validate border data!"); return; }

            this.Close();

            new CommentorVariableWindowView().ShowDialog();
            
        }

        private void OnDeleteTermBtnClick(object sender, RoutedEventArgs e)
        {
            int index = ListBoxTerms.SelectedIndex;
            if (index >= 0 && index < TermsList.Count)
            {
                TermsList.RemoveAt(index);
            }
        }

        public static void ResetValue()
        {
            Min = Max = 0;
            TermsList = null;
        }
    }
}
