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
        public string Comment { get; private set; }
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
            //TODO END CREATION
        }

        private void OnCancelButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
