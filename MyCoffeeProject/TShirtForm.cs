using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCoffeeProject
{
    public partial class TShirtForm : Form
    {
        public TShirtForm()
        {
            InitializeComponent();

            ArrayList tShirtList = new ArrayList();

            //Customer YodasCustomer = new Customer(fNametextBox.Text, lastNametextBox.Text, phoneNumtextBox.Text, favCoffeeTxtBox.Text);
            TShirts yodaShirt = new TShirts("Yoda", "Green", "Large");
            tShirtList.Add(yodaShirt.DisplayTShirt());

            comboBoxTShirts.Items.Add(yodaShirt.DisplayTShirt());
        }
       
    }
}
