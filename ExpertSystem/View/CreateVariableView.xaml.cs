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
    /// Interaction logic for Create_Variable.xaml
    /// </summary>
    public partial class CreateVariableView : Window
    {
        public static string NameVar { get; set; }
        public static VariableType Type { get; private set; }

        public CreateVariableView()
        {
            InitializeComponent();
        }

        private void OnCancelBtnClick(object sender, RoutedEventArgs e)
        {
            //reset values and close window
            NameVar = null;
            Type = VariableType.Input;
            this.Close();
        }

        private void OnNextBtnClick(object sender, RoutedEventArgs e)
        {
            NameVar = textBox_NameVar.Text;
            if (string.IsNullOrEmpty(NameVar)) return;

            this.Close();
            (new MBD_DefinitionView()).ShowDialog();
        }

        private void OnRadioBtnTypeChecked(object sender, RoutedEventArgs e)
        {
            Console.WriteLine((sender as RadioButton).Name);
            Type = (VariableType) Enum.Parse(typeof(VariableType), (sender as RadioButton).Name.ToString());
            Console.WriteLine("TYPE : " + Type);
        }

        public static void ResetValue()
        {
            NameVar = null;
            Type = VariableType.Input;
        }

    }
}
