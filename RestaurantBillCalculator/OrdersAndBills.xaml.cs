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
    /// Interaction logic for OrdersAndBills.xaml
    /// </summary>
    public partial class OrdersAndBills : Window
    {
        public OrdersAndBills()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            //Delete All Items from Bill
            Helper.bill.Clear();
            Helper.tableNumber = 0;
            Helper.waiterName = "";
            Helper.total = 0;
            Helper.tax = 0;
            
            WaiterInformation window = new WaiterInformation();
            window.Owner = this;
            this.Hide();
            window.ShowDialog();
        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application?",
"Quit Application", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                // Close the window  
                Application.Current.Shutdown();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SubTotal.Content = "$" + (Helper.total - Helper.tax);
            TotalBill.Content = "$" + Math.Round((Helper.total),2);
            Tax.Content = "$" + Math.Round((Helper.tax),2);

            foreach (KeyValuePair<string, dynamic> item in Helper.bill)
            {
                Grid grid = new Grid();
                grid.Margin = new Thickness(10,10,10,0);
                grid.Height = 20;
                grid.HorizontalAlignment = HorizontalAlignment.Stretch;
                grid.VerticalAlignment = VerticalAlignment.Center;

                TextBlock text = new TextBlock();
                text.Margin = new Thickness(15, 0, 0, 0);
                text.Width = 150;
                text.VerticalAlignment = VerticalAlignment.Center;
                text.FontSize = 13;
                text.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                text.HorizontalAlignment = HorizontalAlignment.Left;
                if (item.Key.ToString().Contains("_"))
                {
                    var purschaed_item = item.Key.Replace("_", " ").ToLower();
                    string captilized_item_name = "";
                    if (purschaed_item.Length == 1) {
                         captilized_item_name = char.ToUpper(purschaed_item[0]).ToString();
                    }
                    else if (purschaed_item.Length > 1)
                    {
                        captilized_item_name = char.ToUpper(purschaed_item[0]).ToString();
                        captilized_item_name = char.ToUpper(purschaed_item[0]) + purschaed_item.Substring(1);
                    }
                    
                    text.Text = captilized_item_name;
                }
                else
                {
                    var purschaed_item = item.Key.ToLower();
                    string captilized_item_name = "";
                    if (purschaed_item.Length == 1)
                    {
                        captilized_item_name = char.ToUpper(purschaed_item[0]).ToString();
                    }
                    else if (purschaed_item.Length > 1)
                    {
                        captilized_item_name = char.ToUpper(purschaed_item[0]).ToString();
                        captilized_item_name = char.ToUpper(purschaed_item[0]) + purschaed_item.Substring(1);
                    }

                    text.Text = captilized_item_name;
                }
                TextBlock priceTextBlock = new TextBlock();
                priceTextBlock.VerticalAlignment = VerticalAlignment.Center;
                priceTextBlock.FontSize = 13;
                priceTextBlock.FontWeight = FontWeights.Bold;
                priceTextBlock.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#d72631"));
                priceTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
                priceTextBlock.Text = item.Value.PRICE.ToString();
                //Add TextBlock To Grid
                grid.Children.Add(text);
                //Add Another TextBlock To Grid
                grid.Children.Add(priceTextBlock);
                //Add Grid to StackPanel
                items.Children.Add(grid);

            }
        }

    }
}
