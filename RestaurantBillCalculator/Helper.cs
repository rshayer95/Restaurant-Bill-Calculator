using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBillCalculator
{
    class Helper
    {
        //Collection for Table Information
        public static List<KeyValuePair<string,string>> tableInformation = new List<KeyValuePair<string, string>>();
        //Collection for Bill Information
        public static List<KeyValuePair<string, dynamic>> bill = new List<KeyValuePair<string, dynamic>>();
        public static double tableNumber;
        public static string waiterName;
        //Table Bill Collection
        public static List<Bills> bills = new List<Bills>();
        //Bill Total
        public static double total = 0.00;
        //Tax on Total
        public static double tax = 0.00;

        //Update Bill When User Buys Something
        public static void UpdateBill()
        {
            double totalWithoutTax = 0;
            //Calculate Bill
            foreach (KeyValuePair<string, dynamic> item in bill)
            {
                totalWithoutTax = totalWithoutTax + item.Value.PRICE;
            }
            tax= totalWithoutTax * 0.13;
            total = Math.Round(totalWithoutTax + tax,2);
        }

    }
}
