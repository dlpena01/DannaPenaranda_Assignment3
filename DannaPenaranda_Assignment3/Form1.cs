using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DannaPenaranda_Assignment3
{ //Author: Danna Penaranda
  //Course: CIS199-01. Assignment 3
  //Created on Friday, March 7, 2014

    public partial class Form1 : Form
    {
        double subtotal, salestaxes, discounts, shipping, total;
        System.DateTime today;//within the class declared today var which will be used later for calendar
        const double SALES_TAX = 0.06;
        const double PURCHASED_600 = 600;
        const double PURCHASED_800 = 800;//constants 'if not discount' will have to be 0 always
        const double DISCOUNT_IF_MORE_THAN600 = 0.10;
        const double DISCOUNT_IF_MORE_THAN800 = 0.25;
        const double IF_NOT_DISCOUNT = 0.00;
        //Have to declare globally the constant and initialization as well declaring array.
        const int DESCRIPTION_OF_PRODUCTS = 5;//array to hold type string which is globally and 
        string[] detailsProductArray = new string[DESCRIPTION_OF_PRODUCTS];//not initialized just giving the #elements to hold
        //Creating  indexList to hold indexes of what's being bought/double click from productxartLstBox
        List<int> IndexList = new List<int>();

        
        //constants for THE PRICES of each product. Used an array. Used double since we have decimals.
        const int THE_PRICES = 5;
        double[] priceProductsArray = new double[THE_PRICES] { 999.99, 479.99, 349.99, 229.99, 149.99 };

        const int COUNT_FOR_SHIPPING_COSTS = 4;//array for the shipping costs 
        double[] shippingCosts = new double[COUNT_FOR_SHIPPING_COSTS] { 5.99, 14.99, 19.99, 24.99 };

        public Form1()
        {
            InitializeComponent();


             today= monthCalendar1.TodayDate;

            //Here is the details for each element, was easier tov use an array. Used strings since we are 'describing' the product.
            //Used the new line environment so each detail had its own line.
            detailsProductArray[0] = "Product name: Microsoft Surface Pro" + Environment.NewLine +
                                     "Screen Size: 10.6\"" + Environment.NewLine +      //Tricky part here with "" and inches(")
                                     "Storage capacity: 128.6 GB" + Environment.NewLine + //Backlslash will solve that.
                                     "Price: $999.99";
            detailsProductArray[1] = "Product name: Apple iPad Air" + Environment.NewLine +
                                    "Screen size: 9.7\"" + Environment.NewLine +
                                    "Storage capacity: 16 GB" + Environment.NewLine +
                                    "Price: $479.99";
            detailsProductArray[2] = "Product name: Samsung Galaxy Tab 3" + Environment.NewLine +
                                    "Screen size: 10.2\"" + Environment.NewLine +
                                    "Storage capacity: 10.1 GB" + Environment.NewLine +
                                    "Price: $349.99";
            detailsProductArray[3] = "Product name: Google Nexus 7" + Environment.NewLine +
                                     "Screen size: 7\"" + Environment.NewLine +
                                     "Storage capacity: 16 GB" + Environment.NewLine +
                                     "Price: $229.99";
            detailsProductArray[4] = "Product name: Amazon Kindle Fire HD" + Environment.NewLine +
                                     "Screen size: 7\"" + Environment.NewLine +
                                     "Storage capacity: 16 GB" + Environment.NewLine +
                                     "Price: $149.99";

        }

            
           
        //A mouse click method from the list box. Decided for a 'for' loop since
        //I need iterations and changes.
        //Inside loop, is the if statement that will compare if selected index is the same
        //as index in loop. If so, display the element from the detailsProductArray into the multiline textbx.
        private void productLstBx_MouseClick(object sender, MouseEventArgs e)
        {
            for (int index = 0; index <= detailsProductArray.Length; index++)
            {
                if (productLstBx.SelectedIndex == index)
                {
                    displayTextBx.Text = detailsProductArray[index].ToString();
                }
              
            }


        }

        private void productLstBx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            shopCartLstBx.Items.Add(productLstBx.SelectedItem);
            //Needed a mouse double click event for the productLstBx to activate purchasing.
            //Once opting to purchase an item, the item(s) will be added to the
            //shopcartLstBx

            elecTabControl1.SelectedIndex = 1;//Wanted the user to be automatically redirected to tab1
                                              //so he wouldn't have to.
            IndexList.Add(productLstBx.SelectedIndex);//My indexlist is adding the selected index from the productLstBx
                                                      //that was selected by user. with property of the list(.add)
        }

        private void shopCartLstBx_DoubleClick(object sender, EventArgs e)
        {
            IndexList.RemoveAt(shopCartLstBx.SelectedIndex);//Because once user double clicks within the shopcarList, it also
                                                        //needs to remove it from the IndexList.
            shopCartLstBx.Items.Remove(shopCartLstBx.SelectedItem);//If user changed mind then, he need to double 
                                                                   //click to clear the selected item from shopCartLst
                                                                   //.Remove will do that for shopcartLstBx
            
            
        }

        private void btnPurchase_Click(object sender, EventArgs e)//subtotal
        {
            if (deliveryCmBx.SelectedIndex == -1)//shipping
            {
                MessageBox.Show("Please choose a shipping date");//user needs to select a shipping date
                deliveryCmBx.Focus();//or else message will pop up. This way it won't process transaction unless
                                      //it chooses a shipping date.
            }
            else
            {
                for (int index = 0; index < shopCartLstBx.Items.Count; index++) //from shopcar whatever items are there, .count for the number
                {                                                                //of itmes currently in shopcarlistbox
                    int indexes = IndexList[index];//Created a variable to count the "index" at the loop in the IndexList

                    switch (indexes)//testexpression tests whether "indexes" have cases 0-4 where
                    {               //subtotal will add the subscript 0 and on
                        case 0:
                            subtotal = subtotal + priceProductsArray[0];
                            break;
                        case 1:

                            subtotal = subtotal + priceProductsArray[1];
                            break;
                        case 2:

                            subtotal = subtotal + priceProductsArray[2];
                            break;
                        case 3:
                            subtotal = subtotal + priceProductsArray[3];
                            break;
                        case 4:
                            subtotal = subtotal + priceProductsArray[4];
                            break;

                    }

                }
                lblSubtotal.Text = subtotal.ToString("c");


                if (subtotal > PURCHASED_800)//Discount comparing/testing if subtotal
                {                           //is greater than 800
                    discounts = (subtotal * DISCOUNT_IF_MORE_THAN800);//if so, subtotal=0 now will display
                    lblDiscount.Text = discounts.ToString("c");//the disocunted price
                }
                else if (subtotal > PURCHASED_600 && subtotal < PURCHASED_800)
                {
                    discounts = (subtotal * DISCOUNT_IF_MORE_THAN600);
                    lblDiscount.Text = discounts.ToString("c");
                }
                else
                {
                    lblDiscount.Text = IF_NOT_DISCOUNT.ToString("c");
                }




                if (deliveryCmBx.SelectedIndex == 0)
                {
                    shipping = shippingCosts[0];//taking values from my array and having the var shipping picking that value.
                    lblShipping.Text = shipping.ToString("c");//this var will display in lbl
                }
                else if (deliveryCmBx.SelectedIndex == 1)
                {
                    shipping = shippingCosts[1];
                    lblShipping.Text = shipping.ToString("c");

                }
                else if (deliveryCmBx.SelectedIndex == 2)
                {
                    shipping = shippingCosts[2];
                    lblShipping.Text = shipping.ToString("c");
                }
                else if (deliveryCmBx.SelectedIndex == 3)
                {
                    shipping = shippingCosts[3];
                    lblShipping.Text = shipping.ToString("c");

                }
              

                salestaxes = (SALES_TAX * subtotal);//Sale taxes
                lblSalesTax.Text = salestaxes.ToString("c");//needs to come before computing total
                //so that it will add to total later.




                if (deliveryCmBx.SelectedIndex == 0)//monthcalendar
                {                                   //if user selects default option
                    lblExpectDeliveryDate.Text = "Delivery in  14 day(s): " + today.AddDays(14).ToLongDateString();
                    monthCalendar1.SetDate(today.AddDays(14));//then, display and add 14 days to the calendar
                    //displaying as a long date
                }
                else if (deliveryCmBx.SelectedIndex == 1)
                {
                    lblExpectDeliveryDate.Text = "Delivery in 7 day(s): " + today.AddDays(7).ToLongDateString();
                    monthCalendar1.SetDate(today.AddDays(7));
                }
                else if (deliveryCmBx.SelectedIndex == 2)
                {
                    lblExpectDeliveryDate.Text = "Delivery in 2 day(s): " + today.AddDays(2).ToLongDateString();
                    monthCalendar1.SetDate(today.AddDays(2));
                }
                else if (deliveryCmBx.SelectedIndex == 3)
                {
                    lblExpectDeliveryDate.Text = "Delivery in 1 day: " + today.AddDays(1).ToLongDateString();
                    monthCalendar1.SetDate(today.AddDays(1));
                }

                total = (subtotal + salestaxes + shipping) - discounts;//total
                lblTotal.Text = total.ToString("c");//all my varaibles for computing transaction now
                //together to compute the total




                btnPurchase.Enabled = false;//Disabling buttons so user can't buy multiple times if clicks more than once
                //He will have to reset and start a new purchase if he desires to buy more of the same

            }
        }


        private void btnReset_Click_1(object sender, EventArgs e)
        {
            lblSubtotal.Text = "";//Clearing labels
            lblSalesTax.Text = "";
            lblDiscount.Text = "";
            lblShipping.Text = "";
            lblTotal.Text = "";
            lblExpectDeliveryDate.Text = "";

            deliveryCmBx.SelectedIndex = 0;//Setting default options for combx
            elecTabControl1.SelectedIndex = 0;//Taking user back to first tab
            shopCartLstBx.Items.Clear();//Clearing the items in the shopcartList itself after resetting
            productLstBx.SelectedIndex=-1;//Having no selection at the productLstBx

            IndexList.Clear();//Also need to clear my IndexLst box

            subtotal = 0;//Starting from zero with varaibles
            salestaxes = 0;
            discounts = 0;
            shipping = 0;
            total = 0;
            today=monthCalendar1.TodayDate;//Setting today's date back after resetting

            btnPurchase.Enabled = true;//Once resetting happens, enable btnPurchase for another purchase

        }

        
    }
    
}
