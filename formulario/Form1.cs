using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelEjerciciosSubMenu.Visible = false;
            panelEjercicios2.Visible = false;
            panelintegrantes.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelEjerciciosSubMenu.Visible == true)
                panelEjerciciosSubMenu.Visible = false;
            if (panelEjercicios2.Visible == true)
                panelEjercicios2.Visible = false;
            if (panelintegrantes.Visible == true)
                panelintegrantes.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnEjercicios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEjerciciosSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Form8());
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Form9());
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void btnSeccion2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEjercicios2);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5());
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new Form6());
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7());
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new Form10());
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelintegrantes);
        }
    }
}
