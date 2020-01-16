namespace Pizza_shop
{
    partial class pizzaShopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.myMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialsStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.customerNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderPizzaGroupBox = new System.Windows.Forms.GroupBox();
            this.showPizzaLabel = new System.Windows.Forms.Label();
            this.pizzaPictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.selectedPizzaListBox = new System.Windows.Forms.ListBox();
            this.orderGroupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.removeFromCartButton = new System.Windows.Forms.Button();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.addPizzaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.specialsGroupBox = new System.Windows.Forms.GroupBox();
            this.arrangeButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.pizzaSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.upperCaseErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.myMenuStrip.SuspendLayout();
            this.logInGroupBox.SuspendLayout();
            this.orderPizzaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaPictureBox)).BeginInit();
            this.orderGroupBox.SuspendLayout();
            this.specialsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperCaseErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // myMenuStrip
            // 
            this.myMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.myMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.specialsStripMenuItem1,
            this.orderToolStripMenuItem});
            this.myMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.myMenuStrip.Name = "myMenuStrip";
            this.myMenuStrip.Size = new System.Drawing.Size(1332, 28);
            this.myMenuStrip.TabIndex = 0;
            this.myMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // specialsStripMenuItem1
            // 
            this.specialsStripMenuItem1.Name = "specialsStripMenuItem1";
            this.specialsStripMenuItem1.Size = new System.Drawing.Size(75, 24);
            this.specialsStripMenuItem1.Text = "&Specials";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.orderToolStripMenuItem.Text = "&Order";
            // 
            // logInGroupBox
            // 
            this.logInGroupBox.Controls.Add(this.exitButton);
            this.logInGroupBox.Controls.Add(this.cancelButton);
            this.logInGroupBox.Controls.Add(this.loginButton);
            this.logInGroupBox.Controls.Add(this.nameTextBox);
            this.logInGroupBox.Controls.Add(this.customerNumberTextBox);
            this.logInGroupBox.Controls.Add(this.label2);
            this.logInGroupBox.Controls.Add(this.label1);
            this.logInGroupBox.Location = new System.Drawing.Point(12, 55);
            this.logInGroupBox.Name = "logInGroupBox";
            this.logInGroupBox.Size = new System.Drawing.Size(794, 184);
            this.logInGroupBox.TabIndex = 1;
            this.logInGroupBox.TabStop = false;
            this.logInGroupBox.Text = "Log In";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(480, 121);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 25);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.myToolTip.SetToolTip(this.exitButton, "Will terminate the program");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(313, 121);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 25);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "&Cancel";
            this.myToolTip.SetToolTip(this.cancelButton, "Clear all and exit");
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(57, 121);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 25);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "&Login";
            this.myToolTip.SetToolTip(this.loginButton, "Log into the program");
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(313, 37);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // customerNumberTextBox
            // 
            this.customerNumberTextBox.Location = new System.Drawing.Point(313, 83);
            this.customerNumberTextBox.Name = "customerNumberTextBox";
            this.customerNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.customerNumberTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter 7 digits customer number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter customer name all in lower case";
            // 
            // orderPizzaGroupBox
            // 
            this.orderPizzaGroupBox.Controls.Add(this.showPizzaLabel);
            this.orderPizzaGroupBox.Controls.Add(this.pizzaPictureBox);
            this.orderPizzaGroupBox.Controls.Add(this.label7);
            this.orderPizzaGroupBox.Controls.Add(this.label6);
            this.orderPizzaGroupBox.Controls.Add(this.priceListBox);
            this.orderPizzaGroupBox.Controls.Add(this.selectedPizzaListBox);
            this.orderPizzaGroupBox.Controls.Add(this.orderGroupBox);
            this.orderPizzaGroupBox.Controls.Add(this.specialsGroupBox);
            this.orderPizzaGroupBox.Location = new System.Drawing.Point(21, 273);
            this.orderPizzaGroupBox.Name = "orderPizzaGroupBox";
            this.orderPizzaGroupBox.Size = new System.Drawing.Size(1149, 404);
            this.orderPizzaGroupBox.TabIndex = 7;
            this.orderPizzaGroupBox.TabStop = false;
            this.orderPizzaGroupBox.Text = "Order Pizza";
            this.orderPizzaGroupBox.Visible = false;
            // 
            // showPizzaLabel
            // 
            this.showPizzaLabel.AutoSize = true;
            this.showPizzaLabel.Location = new System.Drawing.Point(1005, 304);
            this.showPizzaLabel.Name = "showPizzaLabel";
            this.showPizzaLabel.Size = new System.Drawing.Size(0, 17);
            this.showPizzaLabel.TabIndex = 7;
            // 
            // pizzaPictureBox
            // 
            this.pizzaPictureBox.Location = new System.Drawing.Point(1008, 160);
            this.pizzaPictureBox.Name = "pizzaPictureBox";
            this.pizzaPictureBox.Size = new System.Drawing.Size(112, 116);
            this.pizzaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pizzaPictureBox.TabIndex = 6;
            this.pizzaPictureBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(838, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Your selected pizza";
            // 
            // priceListBox
            // 
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.ItemHeight = 16;
            this.priceListBox.Location = new System.Drawing.Point(841, 160);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(92, 116);
            this.priceListBox.TabIndex = 3;
            // 
            // selectedPizzaListBox
            // 
            this.selectedPizzaListBox.FormattingEnabled = true;
            this.selectedPizzaListBox.ItemHeight = 16;
            this.selectedPizzaListBox.Location = new System.Drawing.Point(632, 160);
            this.selectedPizzaListBox.Name = "selectedPizzaListBox";
            this.selectedPizzaListBox.Size = new System.Drawing.Size(203, 116);
            this.selectedPizzaListBox.TabIndex = 2;
            // 
            // orderGroupBox
            // 
            this.orderGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderGroupBox.Controls.Add(this.clearButton);
            this.orderGroupBox.Controls.Add(this.removeFromCartButton);
            this.orderGroupBox.Controls.Add(this.addToCartButton);
            this.orderGroupBox.Controls.Add(this.addPizzaTextBox);
            this.orderGroupBox.Controls.Add(this.label5);
            this.orderGroupBox.Controls.Add(this.label4);
            this.orderGroupBox.Location = new System.Drawing.Point(6, 210);
            this.orderGroupBox.Name = "orderGroupBox";
            this.orderGroupBox.Size = new System.Drawing.Size(398, 188);
            this.orderGroupBox.TabIndex = 1;
            this.orderGroupBox.TabStop = false;
            this.orderGroupBox.Text = "Order";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(6, 157);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(144, 25);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "&Clear all";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // removeFromCartButton
            // 
            this.removeFromCartButton.Location = new System.Drawing.Point(6, 110);
            this.removeFromCartButton.Name = "removeFromCartButton";
            this.removeFromCartButton.Size = new System.Drawing.Size(144, 25);
            this.removeFromCartButton.TabIndex = 4;
            this.removeFromCartButton.Text = "&Remove from cart";
            this.removeFromCartButton.UseVisualStyleBackColor = true;
            this.removeFromCartButton.Click += new System.EventHandler(this.removeFromCartButton_Click);
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(6, 69);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(144, 25);
            this.addToCartButton.TabIndex = 3;
            this.addToCartButton.Text = "&Add to shopping cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // addPizzaTextBox
            // 
            this.addPizzaTextBox.Location = new System.Drawing.Point(264, 44);
            this.addPizzaTextBox.Name = "addPizzaTextBox";
            this.addPizzaTextBox.Size = new System.Drawing.Size(100, 22);
            this.addPizzaTextBox.TabIndex = 2;
            this.addPizzaTextBox.TextChanged += new System.EventHandler(this.addPizzaTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "No Duplicates-All Cap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add pizza to the shopping cart";
            // 
            // specialsGroupBox
            // 
            this.specialsGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.specialsGroupBox.Controls.Add(this.arrangeButton);
            this.specialsGroupBox.Controls.Add(this.searchButton);
            this.specialsGroupBox.Controls.Add(this.pizzaSelectionComboBox);
            this.specialsGroupBox.Controls.Add(this.label3);
            this.specialsGroupBox.Location = new System.Drawing.Point(6, 21);
            this.specialsGroupBox.Name = "specialsGroupBox";
            this.specialsGroupBox.Size = new System.Drawing.Size(225, 168);
            this.specialsGroupBox.TabIndex = 0;
            this.specialsGroupBox.TabStop = false;
            this.specialsGroupBox.Text = "Specials";
            // 
            // arrangeButton
            // 
            this.arrangeButton.Location = new System.Drawing.Point(42, 132);
            this.arrangeButton.Name = "arrangeButton";
            this.arrangeButton.Size = new System.Drawing.Size(75, 25);
            this.arrangeButton.TabIndex = 3;
            this.arrangeButton.Text = "&Arrange";
            this.arrangeButton.UseVisualStyleBackColor = true;
            this.arrangeButton.Click += new System.EventHandler(this.arrangeButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(42, 92);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 25);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "&Search ";
            this.myToolTip.SetToolTip(this.searchButton, "Searchs for the pizza you want");
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // pizzaSelectionComboBox
            // 
            this.pizzaSelectionComboBox.FormattingEnabled = true;
            this.pizzaSelectionComboBox.Location = new System.Drawing.Point(32, 51);
            this.pizzaSelectionComboBox.Name = "pizzaSelectionComboBox";
            this.pizzaSelectionComboBox.Size = new System.Drawing.Size(121, 24);
            this.pizzaSelectionComboBox.TabIndex = 1;
            this.pizzaSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.pizzaSelectionComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Click to see our specials";
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // passwordErrorProvider
            // 
            this.passwordErrorProvider.ContainerControl = this;
            // 
            // upperCaseErrorProvider
            // 
            this.upperCaseErrorProvider.ContainerControl = this;
            // 
            // pizzaShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 702);
            this.Controls.Add(this.orderPizzaGroupBox);
            this.Controls.Add(this.logInGroupBox);
            this.Controls.Add(this.myMenuStrip);
            this.MainMenuStrip = this.myMenuStrip;
            this.Name = "pizzaShopForm";
            this.Text = "Pizza Shop";
            this.Load += new System.EventHandler(this.pizzaShopForm_Load);
            this.myMenuStrip.ResumeLayout(false);
            this.myMenuStrip.PerformLayout();
            this.logInGroupBox.ResumeLayout(false);
            this.logInGroupBox.PerformLayout();
            this.orderPizzaGroupBox.ResumeLayout(false);
            this.orderPizzaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaPictureBox)).EndInit();
            this.orderGroupBox.ResumeLayout(false);
            this.orderGroupBox.PerformLayout();
            this.specialsGroupBox.ResumeLayout(false);
            this.specialsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperCaseErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip myMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialsStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.GroupBox logInGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox customerNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.GroupBox orderPizzaGroupBox;
        private System.Windows.Forms.GroupBox specialsGroupBox;
        private System.Windows.Forms.ComboBox pizzaSelectionComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button arrangeButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox orderGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addPizzaTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button removeFromCartButton;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox priceListBox;
        private System.Windows.Forms.ListBox selectedPizzaListBox;
        private System.Windows.Forms.PictureBox pizzaPictureBox;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.ErrorProvider passwordErrorProvider;
        private System.Windows.Forms.Label showPizzaLabel;
        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.ErrorProvider upperCaseErrorProvider;
    }
}

