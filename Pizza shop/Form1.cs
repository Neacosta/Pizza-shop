using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
/*
    Project         Pizza shop lab 5
    Programmer   Nelson Acosta
    Date         Feb 2018
                
    	         Display orders
*/
namespace Pizza_shop
{
    public partial class pizzaShopForm : Form
    {
        public pizzaShopForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {   
            // makes sure the name and password is right
            if (nameTextBox.Text == "mike" && customerNumberTextBox.Text == "1111111")
            {
                MessageBox.Show("Welcome Mike");
                nameErrorProvider.SetError(nameTextBox, null);
                passwordErrorProvider.SetError(customerNumberTextBox, null);
                orderPizzaGroupBox.Visible = true;
            }
            else if (nameTextBox.Text == "nancy" && customerNumberTextBox.Text == "2222222")
            {
                MessageBox.Show("Welcome Nancy");
                nameErrorProvider.SetError(nameTextBox, null);
                passwordErrorProvider.SetError(customerNumberTextBox, null);
                orderPizzaGroupBox.Visible = true;

            }

            else
            {   // Message that tells ou your input is invalid plus error messages
                MessageBox.Show("Valid data needed-Try again", "Warning");
                nameErrorProvider.SetError(nameTextBox, "Must be lower case only");
                passwordErrorProvider.SetError(customerNumberTextBox, "Must be numbers only");
            }
        }

        
        private void pizzaShopForm_Load(object sender, EventArgs e)
        {   // adding items to combobox          

              pizzaSelectionComboBox.Items.Add("Cheese pizza");
              pizzaSelectionComboBox.Items.Add("Pepperoni pizza");
              pizzaSelectionComboBox.Items.Add("Beef pizza");
              pizzaSelectionComboBox.Items.Add("Clifornia pizza");
               
        }

        private void pizzaSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           // detects user selection in a combobox
            switch (pizzaSelectionComboBox.SelectedIndex)
            {
                case 0:
                    pizzaPictureBox.Image = Image.FromFile("Cheesepizza.png");
                    showPizzaLabel.Text = "Medium $12.99";
                     break;

                case 1:

                    pizzaPictureBox.Image = Image.FromFile("Pepperonipizza.jpg");
                    showPizzaLabel.Text = "Large $14.99";
                    break;

                case 2:
                    showPizzaLabel.Text = "Medium $11.99";
                    pizzaPictureBox.Image = Image.FromFile("Beefpizza.jpg");
                    break;
                case 3:
                    pizzaPictureBox.Image = Image.FromFile("Californiapizza.jpg");
                    showPizzaLabel.Text = "Small $11.99";
                    break;
                default:
                    MessageBox.Show("wrong pizza");
                    break;

            }   


                   
        }

        private void searchButton_Click(object sender, EventArgs e)
        {   
            string inputResponse = null;
            // brings out an input box
            inputResponse =

            Interaction.InputBox
            ("Do you Want to continue searching?" + Environment.NewLine + "Type YES to continue searching", "Ending");

            string myAnswer = inputResponse.ToLower();
            if (myAnswer == "yes")
            {
                inputResponse =
                Interaction.InputBox  // brings out another input box. depends on your answer.
                ("Enter the shopping item you need to search?", "Searching items");
                myAnswer = inputResponse.ToLower();
                if (myAnswer == "cheese pizza")
                {
                    MessageBox.Show("Pizza found cheese pizza", "Found it!");
                }
                else if (myAnswer == "pepperoni pizza")
                {
                    MessageBox.Show("Pizza found pepperoni pizza", "Found it!");
                }
                else if (myAnswer == "beef pizza")
                {
                    MessageBox.Show("Pizza found beef pizza", "Found it!");
                }
                else if (myAnswer == "california pizza")
                {
                    MessageBox.Show("Pizza found california pizza", "Found it!");
                }
                else
                {
                    MessageBox.Show("Pizza not found " + myAnswer, "Warning!");
                }

            }
              
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {  // adds pizza to the list box with the price.
           
            if (addPizzaTextBox.Text.ToLower() == "cheese pizza")
            {
                selectedPizzaListBox.Items.Add("cheese pizza");
                priceListBox.Items.Add(12.99);
                upperCaseErrorProvider.SetError(addPizzaTextBox, null);
            }
            else if (addPizzaTextBox.Text.ToLower() == "pepperoni pizza")
            {
                selectedPizzaListBox.Items.Add("pepperoni pizza");
                priceListBox.Items.Add(14.99);
                upperCaseErrorProvider.SetError(addPizzaTextBox, null);
            }

            else if (addPizzaTextBox.Text.ToLower() == "beef pizza")
            {
                selectedPizzaListBox.Items.Add("beef pizza");
                priceListBox.Items.Add(11.99);
                upperCaseErrorProvider.SetError(addPizzaTextBox, null);
            }

            else if (addPizzaTextBox.Text.ToLower() == "california pizza")
            {
                selectedPizzaListBox.Items.Add("california pizza");
                priceListBox.Items.Add(11.99);
                upperCaseErrorProvider.SetError(addPizzaTextBox, null);
            }
            else
            {
                MessageBox.Show("The pizza you were looking for we do not carry");
            }

             
        }

        private void clearButton_Click(object sender, EventArgs e)
        {   // clears everything on the order groupbox
            addPizzaTextBox.Clear();
            selectedPizzaListBox.Items.Clear();
            priceListBox.Items.Clear();
        }

        private void removeFromCartButton_Click(object sender, EventArgs e)
        { // removes items from the list box
            try
            {
                selectedPizzaListBox.Items.RemoveAt(selectedPizzaListBox.SelectedIndex);
                priceListBox.Items.RemoveAt(priceListBox.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("No item is selected");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        { // Cancels everything and hides the order pizza group box
            nameTextBox.Clear();
            customerNumberTextBox.Clear();
            orderPizzaGroupBox.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        { // terminates the program
            this.Close();
        }

        private void arrangeButton_Click(object sender, EventArgs e)
        { // sorts pizza selection
            pizzaSelectionComboBox.Sorted = true;
        }

        private void addPizzaTextBox_TextChanged(object sender, EventArgs e)
        { // error message
            upperCaseErrorProvider.SetError(addPizzaTextBox, "Must be upper case only");

        }
    }
}
