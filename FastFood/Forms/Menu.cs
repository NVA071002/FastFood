using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFood.Forms;
using FastFood.DBLayer;



namespace FastFood
{
    public partial class Menu : Form
    {
        private Button currentbutton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Menu()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColors.Colorlist.Count);
            while (tempIndex == index)
            {
              index=  random.Next(ThemeColors.Colorlist.Count);
            }tempIndex = index;
            string color = ThemeColors. Colorlist[index];
            return ColorTranslator.FromHtml(color);
        }

        private  void ActivateButton(object btnsender)
        {
            if (btnsender !=null)
            {
                if (currentbutton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentbutton = (Button)btnsender;
                    currentbutton.BackColor = color;
                    currentbutton.ForeColor = Color.White;
                    currentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColors.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }

            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelMenu.Text = childForm.Text;
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FastFood.Burger(), sender); 
        }

        private void btnHotdogs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FastFood.Forms.Hotdogs(), sender);

        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FastFood.Forms.Pizza(), sender);

        }

        private void btnSandwich_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FastFood.Forms.Sandwich(), sender);

        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FastFood.Forms.Drinks(), sender);

        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FastFood.Forms.Bill(), sender);

        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
