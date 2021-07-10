using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBillCalculator
{
    class MenuItems
    {
        public static List<KeyValuePair<string, dynamic>> items = new List<KeyValuePair<string, dynamic>>();
        public static void Load_PRICES()
        {
            //Add Beverages
            items.Add(new KeyValuePair<string, dynamic>("SODA", new Item() { PRICE= 1.95 , TYPE= "BEVERAGE" }));
            items.Add(new KeyValuePair<string, dynamic>("TEA", new Item() { PRICE = 1.50, TYPE = "BEVERAGE" }));
            items.Add(new KeyValuePair<string, dynamic>("COFFEE", new Item() { PRICE = 1.25, TYPE = "BEVERAGE" }));
            items.Add(new KeyValuePair<string, dynamic>("MINERAL_WATER", new Item() { PRICE = 2.95, TYPE = "BEVERAGE" }));
            items.Add(new KeyValuePair<string, dynamic>("JUICE", new Item() { PRICE = 2.50, TYPE = "BEVERAGE" }));
            items.Add(new KeyValuePair<string, dynamic>("MILK", new Item() { PRICE = 1.50, TYPE = "BEVERAGE" }));
            //Add Appetizers
            items.Add(new KeyValuePair<string, dynamic>("BUFFALO_WINGS", new Item() { PRICE = 5.95, TYPE = "APPETIZER" }));
            items.Add(new KeyValuePair<string, dynamic>("BUFFALO_FINGERS", new Item() { PRICE = 6.95, TYPE = "APPETIZER" }));
            items.Add(new KeyValuePair<string, dynamic>("POTATO_SKINS", new Item() { PRICE = 8.95, TYPE = "APPETIZER" }));
            items.Add(new KeyValuePair<string, dynamic>("NACHOS", new Item() { PRICE = 8.95, TYPE = "APPETIZER" }));
            items.Add(new KeyValuePair<string, dynamic>("MUSHROOM_CAPS", new Item() { PRICE = 10.95, TYPE = "APPETIZER" }));
            items.Add(new KeyValuePair<string, dynamic>("SHRIMP_COCKTAIL", new Item() { PRICE = 12.95, TYPE = "APPETIZER" }));
            items.Add(new KeyValuePair<string, dynamic>("CHIPS_AND_SALSA", new Item() { PRICE = 6.95, TYPE = "APPETIZER" }));
            //Add Main Courses
            items.Add(new KeyValuePair<string, dynamic>("CHICKEN_ALFREDO", new Item() { PRICE = 13.95, TYPE = "MAIN_COURSE" }));
            items.Add(new KeyValuePair<string, dynamic>("CHICKEN_PICATTA", new Item() { PRICE = 13.95, TYPE = "MAIN_COURSE" }));
            items.Add(new KeyValuePair<string, dynamic>("TURKEY_CLUB", new Item() { PRICE = 11.95, TYPE = "MAIN_COURSE" }));
            items.Add(new KeyValuePair<string, dynamic>("LOBSTER_PIE", new Item() { PRICE = 19.95, TYPE = "MAIN_COURSE" }));
            items.Add(new KeyValuePair<string, dynamic>("PRIME_RIB", new Item() { PRICE = 20.95, TYPE = "MAIN_COURSE" }));
            items.Add(new KeyValuePair<string, dynamic>("SHRIMP_SCAMPI", new Item() { PRICE = 18.95, TYPE = "MAIN_COURSE" }));
            items.Add(new KeyValuePair<string, dynamic>("TURKEY_DINNER", new Item() { PRICE = 13.95, TYPE = "MAIN_COURSE" }));
            items.Add(new KeyValuePair<string, dynamic>("STUFFED_CHICKEN", new Item() { PRICE = 14.95, TYPE = "MAIN_COURSE" }));
            items.Add(new KeyValuePair<string, dynamic>("SEAFOOD_ALFREDO", new Item() { PRICE = 15.95, TYPE = "MAIN_COURSE" }));
            //Add Desserts
            items.Add(new KeyValuePair<string, dynamic>("APPLE_PIE", new Item() { PRICE = 5.95, TYPE = "DESSERT" }));
            items.Add(new KeyValuePair<string, dynamic>("SUNDAE", new Item() { PRICE = 3.95, TYPE = "DESSERT" }));
            items.Add(new KeyValuePair<string, dynamic>("CARROT_CAKE", new Item() { PRICE = 5.95, TYPE = "DESSERT" }));
            items.Add(new KeyValuePair<string, dynamic>("MUD_PIE", new Item() { PRICE = 4.95, TYPE = "DESSERT" }));
            items.Add(new KeyValuePair<string, dynamic>("APPLE_CRIPS", new Item() { PRICE = 5.95, TYPE = "DESSERT" }));
        }
    }
}
