namespace FastFood
{
    partial class Menu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelMenu = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.btnDrink = new System.Windows.Forms.Button();
            this.btnSandwich = new System.Windows.Forms.Button();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnHotdogs = new System.Windows.Forms.Button();
            this.btnBurger = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnDrink);
            this.panelMenu.Controls.Add(this.btnSandwich);
            this.panelMenu.Controls.Add(this.btnPizza);
            this.panelMenu.Controls.Add(this.btnHotdogs);
            this.panelMenu.Controls.Add(this.btnBurger);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(301, 718);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.btnBill);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(301, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.labelMenu);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(301, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(955, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // labelMenu
            // 
            this.labelMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.Location = new System.Drawing.Point(420, 21);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(106, 37);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(301, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(955, 638);
            this.panelDesktopPane.TabIndex = 2;
            this.panelDesktopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPane_Paint);
            // 
            // btnDrink
            // 
            this.btnDrink.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrink.FlatAppearance.BorderSize = 0;
            this.btnDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrink.Font = new System.Drawing.Font("Montserrat", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrink.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDrink.Image = global::FastFood.Properties.Resources.icons8_drink_60__1_1;
            this.btnDrink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrink.Location = new System.Drawing.Point(0, 488);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDrink.Size = new System.Drawing.Size(301, 102);
            this.btnDrink.TabIndex = 5;
            this.btnDrink.Text = "    DRINKS";
            this.btnDrink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDrink.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDrink.UseVisualStyleBackColor = true;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // btnSandwich
            // 
            this.btnSandwich.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSandwich.FlatAppearance.BorderSize = 0;
            this.btnSandwich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSandwich.Font = new System.Drawing.Font("Montserrat", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSandwich.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSandwich.Image = global::FastFood.Properties.Resources.icons8_sandwich_64;
            this.btnSandwich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSandwich.Location = new System.Drawing.Point(0, 386);
            this.btnSandwich.Name = "btnSandwich";
            this.btnSandwich.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSandwich.Size = new System.Drawing.Size(301, 102);
            this.btnSandwich.TabIndex = 4;
            this.btnSandwich.Text = "   SANDWICH";
            this.btnSandwich.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSandwich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSandwich.UseVisualStyleBackColor = true;
            this.btnSandwich.Click += new System.EventHandler(this.btnSandwich_Click);
            // 
            // btnPizza
            // 
            this.btnPizza.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPizza.FlatAppearance.BorderSize = 0;
            this.btnPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPizza.Font = new System.Drawing.Font("Montserrat", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPizza.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPizza.Image = global::FastFood.Properties.Resources.icons8_pizza_64;
            this.btnPizza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPizza.Location = new System.Drawing.Point(0, 284);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPizza.Size = new System.Drawing.Size(301, 102);
            this.btnPizza.TabIndex = 3;
            this.btnPizza.Text = "    PIZZA";
            this.btnPizza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPizza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnHotdogs
            // 
            this.btnHotdogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHotdogs.FlatAppearance.BorderSize = 0;
            this.btnHotdogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotdogs.Font = new System.Drawing.Font("Montserrat", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotdogs.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHotdogs.Image = global::FastFood.Properties.Resources.icons8_bread_85;
            this.btnHotdogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotdogs.Location = new System.Drawing.Point(0, 182);
            this.btnHotdogs.Name = "btnHotdogs";
            this.btnHotdogs.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHotdogs.Size = new System.Drawing.Size(301, 102);
            this.btnHotdogs.TabIndex = 2;
            this.btnHotdogs.Text = " HOTDOGS";
            this.btnHotdogs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHotdogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHotdogs.UseVisualStyleBackColor = true;
            this.btnHotdogs.Click += new System.EventHandler(this.btnHotdogs_Click);
            // 
            // btnBurger
            // 
            this.btnBurger.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBurger.FlatAppearance.BorderSize = 0;
            this.btnBurger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBurger.Font = new System.Drawing.Font("Montserrat", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurger.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBurger.Image = global::FastFood.Properties.Resources.icons8_burger_85;
            this.btnBurger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBurger.Location = new System.Drawing.Point(0, 80);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBurger.Size = new System.Drawing.Size(301, 102);
            this.btnBurger.TabIndex = 1;
            this.btnBurger.Text = "  BURGER";
            this.btnBurger.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBurger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBurger.UseVisualStyleBackColor = true;
            this.btnBurger.Click += new System.EventHandler(this.btnBurger_Click);
            // 
            // btnBill
            // 
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Montserrat", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBill.Image = global::FastFood.Properties.Resources.icons8_shopping_cart_64;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(0, 0);
            this.btnBill.Name = "btnBill";
            this.btnBill.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBill.Size = new System.Drawing.Size(301, 80);
            this.btnBill.TabIndex = 6;
            this.btnBill.Text = "   BILL";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 718);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnBurger;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnSandwich;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnHotdogs;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Panel panelDesktopPane;
    }
}

