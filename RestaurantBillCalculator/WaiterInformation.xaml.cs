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
    /// Interaction logic for WaiterInformation.xaml
    /// </summary>
    public partial class WaiterInformation : Window
    {
        public WaiterInformation()
        {
            InitializeComponent();
            MenuItems.Load_PRICES();
        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to clear the textboxes?",
"Clear Inputs", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                tableNumber.Text = "";
                waiterName.Text = "";
            }
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            if (tableNumber.Text == "" && waiterName.Text == "")
            {
                MessageBox.Show("Please Enter Table Number and Waiter Name");
            }
            else if (tableNumber.Text == "")
            {
                MessageBox.Show("Please Enter Table Number");
            }
            else if (waiterName.Text == "")
            {
                MessageBox.Show("Please Enter Waiter Name");
            }
            else
            {
                try
                {


                    Helper.tableNumber = Convert.ToDouble(tableNumber.Text);
                    Helper.waiterName = waiterName.Text;
                    Menu window = new Menu();
                    window.Owner = this;
                    this.Hide();
                    window.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter Valid Data");
                }
            }
        }
    }
}
