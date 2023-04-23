using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class MainAddminForm : Form
    {
        public MainAddminForm()
        {
            InitializeComponent();
        }

        private void addDishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDishForm frm = new AddDishForm();
            frm.Show(this);
        }

        private void removeDishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveDishForm frm = new RemoveDishForm();
            frm.Show(this);
        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuList frm = new MenuList();
            frm.Show(this);
        }

        private void updateDishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditDishForm frm = new EditDishForm();
            frm.Show(this);
        }

        private void changeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStaffForm frm = new AddStaffForm();
            frm.Show(this);
        }

        private void staffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffListForm frm = new StaffListForm();
            frm.Show(this);
        }

        private void removeStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveUpdateStaffForm frm = new RemoveUpdateStaffForm();
            frm.Show(this);
        }
    }
}
