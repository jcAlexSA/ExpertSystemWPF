using ExpertSystem.Model;
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
    /// Interaction logic for CommentorVariableWindow.xaml
    /// </summary>
    public partial class CommentorVariableWindowView : Window
    {
        public static string Comment { get; private set; }

        public CommentorVariableWindowView()
        {
            InitializeComponent();
        }

        private void OnEndButtonClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_CommentVar.Text))
            {
                Comment = textBox_CommentVar.Text;
            }

            FuzzyVariable variable = new FuzzyVariable(CreateVariableView.NameVar,
                CreateVariableView.Type, MBD_DefinitionView.Min, MBD_DefinitionView.Max,
                MBD_DefinitionView.TermsList == null ? null : MBD_DefinitionView.TermsList.ToList(), 
                CommentorVariableWindowView.Comment);

            MainWindowView.VariableCollection.Add(variable);
            
            ResetAllValues();
            this.Close();
        }

        private void OnCancelButtonClick(object sender, RoutedEventArgs e)
        {
            ResetAllValues();
            this.Close();
        }

        public static void ResetValue()
        {
            Comment = null;
        }

        private void ResetAllValues()
        {
            CreateVariableView.ResetValue();
            MBD_DefinitionView.ResetValue();
            CommentorVariableWindowView.ResetValue();
        }

    }
}
