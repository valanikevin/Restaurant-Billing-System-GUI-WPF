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

namespace GurpreetSinghTest01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numItems = 0;
        int numBills = 0;
        double billTotal = 0.0;
        List<Item> allItems = new List<Item>();
        List<Bill> allBills = new List<Bill>();

        public void initMenu()
        {
            tbTotal.Text = "Total: $0.00";
            Item item1 = new Item("bev1", "Soda", 1.95, 0);
            Item item2 = new Item("bev2", "Tea", 1.50, 0);
            Item item3 = new Item("bev3", "Coffee", 1.25, 0);
            Item item4 = new Item("bev4", "Mineral Water", 2.95, 0);
            Item item5 = new Item("bev5", "Juice", 2.50, 0);
            Item item6 = new Item("bev6", "Milk", 1.50, 0);
            Item item7 = new Item("app1", "Buffalo Wings ", 5.90, 0);
            Item item8 = new Item("app2", "Buffalo Fingers", 6.95, 0);
            Item item9 = new Item("app3", "Potato Skins", 8.95, 0);
            Item item10 = new Item("app4", "Nachos", 8.95, 0);
            Item item11 = new Item("app5", "Mushroom Caps", 10.95, 0);
            Item item12 = new Item("app6", "Shrimp Cocktail", 12.95, 0);
            Item item27 = new Item("app7", "Chips and Salsa", 6.95, 0);
            Item item13 = new Item("mai1", "Chicken Alfredo", 13.95, 0);
            Item item14 = new Item("mai2", "Chicken Picata", 13.95, 0);
            Item item15 = new Item("mai3", "Turkey Club", 11.95, 0);
            Item item16 = new Item("mai4", "Lobster Pie", 19.95, 0);
            Item item17 = new Item("mai5", "Prime Rib", 20.95, 0);
            Item item18 = new Item("mai6", "Shrimp Scampi", 18.95, 0);
            Item item19 = new Item("mai7", "Turkey Dinner", 13.95, 0);
            Item item20 = new Item("mai8", "Stuffed Chicken", 14.95, 0);
            Item item21 = new Item("mai9", "Seafood Alfredo", 15.95, 0);
            Item item22 = new Item("des1", "Apple Pie", 5.95, 0);
            Item item23 = new Item("des2", "Sundae", 3.95, 0);
            Item item24 = new Item("des3", "Carrot Cake", 5.95, 0);
            Item item25 = new Item("des4", "Mud Pie", 4.95, 0);
            Item item26 = new Item("des5", "Apple Crips", 5.95, 0);
            allItems.Add(item1);
            allItems.Add(item2);
            allItems.Add(item3);
            allItems.Add(item4);
            allItems.Add(item5);
            allItems.Add(item6);
            allItems.Add(item6);
            allItems.Add(item7);
            allItems.Add(item8);
            allItems.Add(item9);
            allItems.Add(item10);
            allItems.Add(item11);
            allItems.Add(item12);
            allItems.Add(item13);
            allItems.Add(item14);
            allItems.Add(item15);
            allItems.Add(item16);
            allItems.Add(item17);
            allItems.Add(item18);
            allItems.Add(item19);
            allItems.Add(item20);
            allItems.Add(item21);
            allItems.Add(item22);
            allItems.Add(item23);
            allItems.Add(item24);
            allItems.Add(item25);
            allItems.Add(item26);
            allItems.Add(item27);
        }
       
        public void addToBill(Item item)
        {
            numItems++;
            billTotal += item.iPrice;
            tbTotal.Text = String.Format("Total: $ {0:0.##}", billTotal);
            tbPreview.AppendText(String.Format("*{0}* - {1} - {2}{3}", numItems, item.iName, item.iPrice, Environment.NewLine));
        }

        public void removeFromBill(Item item)
        {
            numItems--;
            billTotal -= item.iPrice;
            tbTotal.Text = String.Format("Total: $ {0:0.##}", billTotal);
            tbPreview.AppendText(String.Format("*VOID* - {1} - {2}{3}", numItems, item.iName, item.iPrice, Environment.NewLine));
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBills_Click(object sender, RoutedEventArgs e)
        {
            btnActive(btnBills);
            allBillPrint();

        }

        private void allBillPrint()
        {
            foreach (Bill bi in allBills)
            {
                tbPreview.Text = "******Last Bill******"+Environment.NewLine;
                
                tbPreview.AppendText(String.Format("Employee Name:{0} {1}", tbEmpName.Text, Environment.NewLine));
                tbPreview.AppendText(String.Format("Date: {0}{1}", DateTime.Now, Environment.NewLine));
                tbPreview.AppendText(String.Format("Bill Total: {0}{1}", bi.grandTotal, Environment.NewLine));
                
                tbPreview.AppendText("******END******" + Environment.NewLine);

            }
        }

        private void btnActive(System.Windows.Controls.Button btn)
        {
            btnHome.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
            btnBills.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
            btnEmployee.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
            btnAbout.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
            btn.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF444466"));
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            btnActive(btnHome);
            //mainFrame.Content = new HomePage();
        }

        private void btnEmployee_Click(object sender, RoutedEventArgs e)
        {
            btnActive(btnEmployee);
            MessageBox.Show("Employee Name: "+tbEmpName.Text+Environment.NewLine+"Table Number: "+tbTabNum.Text);
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            btnActive(btnAbout);
            MessageBox.Show("Name: Kevin Valani" + Environment.NewLine+"Assignment: Mid Term Exam");
        }

        private void bev1_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x =>x.iID=="bev1");
            addToBill(item);
        }

        private void bev2_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "bev2");
            addToBill(item);
        }

        private void bev3_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "bev3");
            addToBill(item);
        }

        private void bev4_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "bev4");
            addToBill(item);
        }

        private void bev5_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "bev5");
            addToBill(item);
        }

        private void bev6_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "bev6");
            addToBill(item);
        }

        private void app1_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "app1");
            addToBill(item);
        }

        private void app2_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "app2");
            addToBill(item);
        }

        private void app3_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "app3");
            addToBill(item);
        }

        private void app4_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "app4");
            addToBill(item);
        }

        private void app5_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "app5");
            addToBill(item);
        }

        private void app6_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "app6");
            addToBill(item);
        }

        private void app7_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "app7");
            addToBill(item);
        }

        private void mai1_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai1");
            addToBill(item);
        }

        private void mai2_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai2");
            addToBill(item);
        }

        private void mai3_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai3");
            addToBill(item);
        }

        private void mai4_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai4");
            addToBill(item);
        }

        private void mai5_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai5");
            addToBill(item);
        }

        private void mai6_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai6");
            addToBill(item);
        }

        private void mai7_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai7");
            addToBill(item);
        }

        private void mai8_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai8");
            addToBill(item);
        }

        private void mai9_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai9");
            addToBill(item);
        }

        private void des1_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "des1");
            addToBill(item);
        }

        private void des2_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "des2");
            addToBill(item);
        }

        private void des3_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "des3");
            addToBill(item);
        }

        private void des4_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "des4");
            addToBill(item);
        }

        private void des5_Checked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "des5");
            addToBill(item);
        }

        private void des5_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "des5");
            removeFromBill(item);
        }

        private void bev1_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "bev1");
            removeFromBill(item);
        }

        private void bev2_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "bev2");
            removeFromBill(item);
        }

        private void bev3_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "bev3");
            removeFromBill(item);
        }

        private void bev4_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "bev4");
            removeFromBill(item);
        }

        private void bev5_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "bev5");
            removeFromBill(item);
        }

        private void bev6_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "bev6");
            removeFromBill(item);
        }

        private void app1_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "app1");
            removeFromBill(item);
        }

        private void app2_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "app2");
            removeFromBill(item);
        }

        private void app3_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "app3");
            removeFromBill(item);
        }

        private void app4_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "app4");
            removeFromBill(item);
        }

        private void app5_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "app5");
            removeFromBill(item);
        }

        private void app6_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "app6");
            removeFromBill(item);
        }

        private void app7_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "app7");
            removeFromBill(item);
        }

        private void mai1_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai1");
            removeFromBill(item);
        }

        private void mai2_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai2");
            removeFromBill(item);
        }

        private void mai3_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai3");
            removeFromBill(item);
        }

        private void mai4_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai4");
            removeFromBill(item);
        }

        private void mai5_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai5");
            removeFromBill(item);
        }

        private void mai6_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai6");
            removeFromBill(item);
        }

        private void mai7_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai7");
            removeFromBill(item);
        }

        private void mai8_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai8");
            removeFromBill(item);
        }

        private void mai9_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "mai9");
            removeFromBill(item);
        }

        private void des1_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "des1");
            removeFromBill(item);
        }

        private void des2_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "des2");
            removeFromBill(item);
        }

        private void des3_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "des3");
            removeFromBill(item);
        }

        private void des4_Unchecked(object sender, RoutedEventArgs e)
        {
            Item item = allItems.Find(x => x.iID == "des4");
            removeFromBill(item);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainTitle.Content = "Let's Start ->";
            mainGrid.IsEnabled = false;
            
            initMenu();
        }

        private void btnGenBill_Click(object sender, RoutedEventArgs e)
        {
            Bill bill = new Bill(numBills, allItems, billTotal);
            allBills.Add(bill);
            clearAll();
            tbTotal.Text = "Total $0.0";
            billTotal = 0;
            allItems = new List<Item>();
            initMenu();

        }

        private void clearAll()
        {
         
            bev1.IsChecked = false;
            bev2.IsChecked = false;
            bev3.IsChecked = false;
            bev4.IsChecked = false;
            bev5.IsChecked = false;
            bev6.IsChecked = false;
            app1.IsChecked = false;
            app2.IsChecked = false;
            app3.IsChecked = false;
            app4.IsChecked = false;
            app5.IsChecked = false;
            app6.IsChecked = false;
            app7.IsChecked = false;
            mai1.IsChecked = false;
            mai2.IsChecked = false;
            mai3.IsChecked = false;
            mai4.IsChecked = false;
            mai5.IsChecked = false;
            mai6.IsChecked = false;
            mai7.IsChecked = false;
            mai8.IsChecked = false;
            mai9.IsChecked = false;
            des1.IsChecked = false;
            des2.IsChecked = false;
            des3.IsChecked = false;
            des4.IsChecked = false;
            des5.IsChecked = false;
            tbPreview.Text = "";
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (tbTabNum.Text!=""&&tbEmpName.Text!="")
            {
                tbTabNum.Visibility = Visibility.Collapsed;
                lbTabNum.Visibility = Visibility.Collapsed;
                tbEmpName.Visibility = Visibility.Collapsed;
                lbEmpName.Visibility = Visibility.Collapsed;
                empWel.Content = "Welcome";
                empName.Content = tbEmpName.Text;
                mainTitle.Content = "Dashboard";
                mainGrid.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Please Enter Valid Name and Table Number", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            clearAll();
        }
    }

    public class Item
    {
        public string iID { get; set; }
        public string iName { get; set; }
        public double iPrice { get; set; }
        private int iQTY;
        public double iTotal { get; set; }

        public Item(string iID, string iName, double iPrice, int iQTY)
        {
            this.iID = iID;
            this.iName = iName;
            this.iPrice = iPrice;
            this.iQTY = iQTY;
            this.iTotal = iQTY * iPrice;
        }

        public int getQTY()
        {
            return iQTY;
        }

        public void setQTY(int iQTY)
        {
            this.iQTY = iQTY;
            this.iTotal = iQTY * iPrice;
        }


    }

    public class Bill
    {
        public int bID { get; set; }
        public List<Item> allItems { get; set; }
        public double grandTotal { get; set; }

        public Bill(int bID, List<Item> allItems, double grandTotal)
        {
            this.bID = bID;
            this.allItems = allItems;
            this.grandTotal = grandTotal;
        }
    }
}
