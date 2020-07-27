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
using WpfDemoApp.Models;

namespace WpfDemoApp
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      private List<ToDo> DemoToDoList { get; set; }

      public MainWindow()
      {
         InitializeComponent();

         DemoToDoList = new List<ToDo>()
         {
            new ToDo()
            {
               IsSelected = false,
               Name = "test 1"
            },
            new ToDo()
            {
               IsSelected = false,
               Name = "test 2"
            },
            new ToDo()
            {
               IsSelected = false,
               Name = "test 3"
            }
         };

         DemoDataGrid.ItemsSource = DemoToDoList;
         
      }

      private void On_RowDoubleClick(object sender, MouseButtonEventArgs e)
      {
         var dataGridRow = ((DataGridRow)sender);
         var dataItem = (ToDo)dataGridRow.Item;
         MessageBox.Show("Row Clicked: " + dataItem.Name);
      }
   }
}
