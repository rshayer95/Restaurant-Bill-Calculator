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

namespace RestaurantBillCalculator
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }
        //Exit Handler
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit this application?",
"Exit Application", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                // Close the window  
                Application.Current.Shutdown();
            }
        }
        //Checkbox Checked Handler
        private void checkbox_Checked(object sender, RoutedEventArgs e)
        {
            
            var checkbox = (CheckBox)sender;
            var value ="";
            bool hasSpace = checkbox.Content.ToString().Contains(" ");
            if (hasSpace)
            {
                value = checkbox.Content.ToString().Replace(" ", "_").ToUpper();
            }
            else
            {
                value = checkbox.Content.ToString().ToUpper();
            }
            foreach (KeyValuePair<string, dynamic> item in MenuItems.items)
            {
                if(item.Key == value)
                {
                    Helper.bill.Add(new KeyValuePair<string, dynamic>(value, new Item() { PRICE = item.Value.PRICE, TYPE= item.Value.TYPE }));
                    break;
                }
            }
            Helper.UpdateBill();
            TotalBill.Content = "$" + Helper.total;
        }
        // Checkbox Unchcked Handler
        private void checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            var checkbox = (CheckBox)sender;
            var value = "";
            bool hasSpace = checkbox.Content.ToString().Contains(" ");

            if (hasSpace)
            {
                value = checkbox.Content.ToString().Replace(" ", "_").ToUpper();
            }
            else
            {
                value = checkbox.Content.ToString().ToUpper();
            }

            foreach (KeyValuePair<string, dynamic> item in Helper.bill)
            {
                if (item.Key == value)
                {
                    Helper.bill.Remove(item);
                    break;
                }
            }
            Helper.UpdateBill();
            TotalBill.Content = "$" + Helper.total;
        }
        //Helper to Find All Checkboxes in XAML
        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }
        //Clear Everything
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            
            foreach (CheckBox beverageCheckboxes in FindVisualChildren<CheckBox>(beverages))
            {
                // Clear All Beverage Checkboxes
                beverageCheckboxes.IsChecked = false;
            }
            foreach (CheckBox appetizerCheckboxes in FindVisualChildren<CheckBox>(appetizers))
            {
                // Clear All Appetizer Checkboxes
                appetizerCheckboxes.IsChecked = false;
            }
            foreach (CheckBox mainCourseCheckboxes in FindVisualChildren<CheckBox>(mainCourse))
            {
                // Clear All Main Course Checkboxes
                mainCourseCheckboxes.IsChecked = false;
            }
            foreach (CheckBox dessertCheckboxes in FindVisualChildren<CheckBox>(desserts))
            {
                // Clear All Main Course Checkboxes
                dessertCheckboxes.IsChecked = false;
            }

            //Delete All Items from Bill
            Helper.bill.Clear();   
            

            //Clear Total
            Helper.total = 0;

            //Clear Tax
            Helper.tax = 0;

            //Clear Bill
            TotalBill.Content = "$0";

        }
        //Create collection for single table number
        private void viewOrders_Click(object sender, RoutedEventArgs e)
        {
            Helper.bills.Add(new Bills() { tableNumber =Helper.tableNumber, waiterName = Helper.waiterName, total = Helper.total });
            OrdersAndBills window = new OrdersAndBills();
            window.Owner = this;
            this.Hide();
            window.ShowDialog();
        }
    }
}
