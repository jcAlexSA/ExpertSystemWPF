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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ExpertSystem.View
{
    public partial class MainWindowView : Window
    {
        public static ObservableCollection<FuzzyVariable> VariableCollection = new ObservableCollection<FuzzyVariable>();
        public static ObservableCollection<RuleBlock> RuleBlocksCollection = new ObservableCollection<RuleBlock>();

        public static Point LastMouseClick {get; private set;}

        public MainWindowView()
        {
            InitializeComponent();
            
            VariableCollection.CollectionChanged += VariableCollectionChanged;
            RuleBlocksCollection.CollectionChanged += RuleBlocksCollectionChanged; 
        }

        private void OnCreateNewVariableClick(object sender, RoutedEventArgs e)
        {
            CreateVariableView cvv = new CreateVariableView();
            cvv.ShowDialog();           
        }

        private void OnCreateRuleBlockClick(object sender, RoutedEventArgs e)
        {
            RuleBlockWizardView rb = new RuleBlockWizardView();
            rb.ShowDialog();
        }

        private void canvas_drawing_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            LastMouseClick = Mouse.GetPosition(canvas_drawing);

            Console.WriteLine("click : " + LastMouseClick.X + " " + LastMouseClick.Y);           
        }

        private ContextMenu GetContextMenuOfElement()
        {
            ContextMenu cm = new ContextMenu();

            MenuItem miProperty = new MenuItem();
            miProperty.Header = "Properties";
            MenuItem miDelete = new MenuItem();
            miDelete.Header = "Delete";
            miDelete.Click += ClickDeleteElement;

            cm.Items.Add(miProperty);
            cm.Items.Add(miDelete);
            
            return cm;
        }

        private void VariableCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //TODO LISTENING ON DELETING CHANGING AND ANDDING ELEMENT !!!!!!!!!
            var tempList = (sender as ObservableCollection<FuzzyVariable>);

            if (tempList == null || tempList.Count == 0) return;

            FuzzyVariable fuzzyVariable = tempList.ToList().Last();
            
            TextBlock textBlock = CreateTextBlockVariable(fuzzyVariable.Name, fuzzyVariable.Type);

            if(textBlock != null)
                SetElementOnCanvas(textBlock, LastMouseClick.X, LastMouseClick.Y);            
        }
        
        private void RuleBlocksCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            var tempList = (sender as ObservableCollection<RuleBlock>);

            if (tempList == null || tempList.Count == 0) return;

            RuleBlock ruleBlock = tempList.ToList().Last();

            
        }

        private TextBlock CreateTextBlockVariable(string name, VariableType type)
        {
            TextBlock textBlock = new TextBlock();

            textBlock.Name = "textBlock_" + name;
            textBlock.Text = name;
            textBlock.Width = 60;
            textBlock.AllowDrop = true;
            textBlock.MouseLeftButtonDown += textBlock_MouseLeftButtonDown;


            textBlock.ContextMenu = GetContextMenuOfElement();

            if (VariableType.Input == type)
                textBlock.Background = Brushes.Gainsboro;
            else if (VariableType.Output == type)
                textBlock.Background = Brushes.LightSalmon;
            else //intermediate
                return null;

            return textBlock;
        }

        void textBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine(Mouse.GetPosition(canvas_drawing).ToString());

            Canvas.SetLeft(sender as TextBlock, Mouse.GetPosition(canvas_drawing).X);
            Canvas.SetTop(sender as TextBlock, Mouse.GetPosition(canvas_drawing).Y);
        }

        private void ClickDeleteElement(object sender, RoutedEventArgs e)
        {
            //вжух и стучимся к textblock по которому кланули
            Console.WriteLine((((sender as MenuItem).Parent as ContextMenu).PlacementTarget as TextBlock).Name);
            DeleteElementFromCanvas((((sender as MenuItem).Parent as ContextMenu).PlacementTarget as TextBlock));   
        }

        private void SetElementOnCanvas(UIElement element, double X, double Y)
        {
            Canvas.SetLeft(element, X);
            Canvas.SetTop(element, Y);
            canvas_drawing.Children.Add(element);
        }

        private void DeleteElementFromCanvas(UIElement elementToDelete)
        {
            canvas_drawing.Children.Remove(elementToDelete);
        }

        private void OnCreateTextBlockClick(object sender, RoutedEventArgs e)
        {
            (new SpreadsheetRuleEditor()).Show();
            (new ResultWindow()).Show();
            (new VariableEditor()).Show();
        }
    }
}
