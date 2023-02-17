using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btn_resul_Click(object sender, EventArgs e)
        {
            {
                int s1;
                int s2;
                int s3;
                int s4;

                s1 = Convert.ToInt32(sueldo1.Text);
                s2 = Convert.ToInt32(sueldo2.Text);
                s3 = Convert.ToInt32(sueldo3.Text);
                s4 = Convert.ToInt32(sueldo4.Text);


                if (s1 <= 1000 && s2 <= 1000 && s3 <= 1000 && s4 <= 1000)
                {
                    resul.Text = ("Todos los sueldos son menores a 1000");
                }
                else
                {
                    if (s1 <= 1000 && s2 <= 1000 && s3 <= 1000)
                    {
                        resul.Text = ("Hay tres sueldos menores a 1000");
                    }
                    else if (s3 <= 1000 && s2 <= 1000 && s4 <= 1000)
                    {
                        resul.Text = ("Hay tres sueldos menores a 1000");
                    }
                    else if (s1 <= 1000 && s3 <= 1000 && s4 <= 1000)
                    {
                        resul.Text = ("Hay tres sueldos menores a 1000");
                    }
                    else if (s1 <= 1000 && s2 <= 1000 && s4 <= 1000)
                    {
                        resul.Text = ("Hay tres sueldos menores a 1000");
                    }
                    else
                    {
                        if (s1 <= 1000 && s2 <= 1000)
                        {
                            resul.Text = ("Hay dos sueldos menores a 1000");
                        }
                        else if (s1 <= 1000 && s3 <= 1000)
                        {
                            resul.Text = ("Hay dos sueldos menores a 1000");
                        }
                        else if (s1 <= 1000 && s4 <= 1000)
                        {
                            resul.Text = ("Hay dos sueldos menores a 1000");
                        }
                        else if (s2 <= 1000 && s3 <= 1000)
                        {
                            resul.Text = ("Hay dos sueldos menores a 1000");
                        }
                        else if (s2 <= 1000 && s4 <= 1000)
                        {
                            resul.Text = ("Hay dos sueldos menores a 1000");
                        }
                        else if (s3 <= 1000 && s4 <= 1000)
                        {
                            resul.Text = ("Hay dos sueldos menores a 1000");
                        }
                        else if (s1 <= 1000)
                        {
                            resul.Text = ("Hay un sueldo menor a 1000");
                        }
                        else if (s2 <= 1000)
                        {
                            resul.Text = ("Hay un sueldo menor a 1000");
                        }
                        else if (s3 <= 1000)
                        {
                            resul.Text = ("Hay un sueldo menor a 1000");
                        }
                        else if (s4 <= 1000)
                        {
                            resul.Text = ("Hay un sueldo menor a 1000");
                        }
                    }
                }
                if (s1 >= 1000 && s1 <= 2500 && s2 >= 1000 && s2 <= 2500 && s3 >= 1000 && s3 <= 2500 && s4 >= 1000 && s4 <= 2500)
                {
                    resul1.Text = ("Todos los sueldos entre 1000 y 2500");
                }
                else
                {
                    if (s1 >= 1000 && s1 <= 2500 && s2 >= 1000 && s2 <= 2500 && s3 >= 1000 && s3 <= 2500)
                    {
                        resul1.Text = ("Tres sueldos entre 1000 y 2500");
                    }
                    else if (s3 >= 1000 && s3 <= 2500 && s2 >= 1000 && s2 <= 2500 && s4 >= 1000 && s4 <= 2500)
                    {
                        resul1.Text = ("Tres sueldos entre 1000 y 2500");
                    }
                    else if (s1 >= 1000 && s1 <= 2500 && s3 >= 1000 && s3 <= 2500 && s4 >= 1000 && s4 <= 2500)
                    {
                        resul1.Text = ("Tres sueldos entre 1000 y 2500");
                    }
                    else if (s1 >= 1000 && s1 <= 2500 && s2 >= 1000 && s2 <= 2500 && s4 >= 1000 && s4 <= 2500)
                    {
                        resul.Text = ("Tres sueldos entre 1000 y 2500");
                    }

                    else
                    {
                        if (s1 >= 1000 && s1 <= 2500 && s2 >= 1000 && s2 <= 2500)
                        {
                            resul1.Text = ("Dos sueldos entre 1000 y 2500");
                        }
                        else if (s1 >= 1000 && s1 <= 2500 && s3 >= 1000 && s3 <= 2500)
                        {
                            resul1.Text = ("Dos sueldos entre 1000 y 2500");
                        }
                        else if (s1 >= 1000 && s1 <= 2500 && s4 >= 1000 && s4 <= 2500)
                        {
                            resul1.Text = ("Dos sueldos entre 1000 y 2500");
                        }
                        else if (s2 >= 1000 && s2 <= 2500 && s3 >= 1000 && s3 <= 2500)
                        {
                            resul1.Text = ("Dos sueldos entre 1000 y 2500");
                        }
                        else if (s2 >= 1000 && s2 <= 2500 && s4 >= 1000 && s4 <= 2500)
                        {
                            resul1.Text = ("Dos sueldos entre 1000 y 2500");
                        }
                        else if (s3 >= 1000 && s3 <= 2500 && s4 >= 1000 && s4 <= 2500)
                        {
                            resul1.Text = ("Dos sueldos entre 1000 y 2500");
                        }
                        else if (s1 >= 1000 && s1 <= 2500)
                        {
                            resul1.Text = ("Un sueldo entre 1000 y 2500");
                        }
                        else if (s2 >= 1000 && s2 <= 2500)
                        {
                            resul1.Text = ("Un sueldo entre 1000 y 2500");
                        }
                        else if (s3 >= 1000 && s3 <= 2500)
                        {
                            resul1.Text = ("Un sueldo entre 1000 y 2500");
                        }
                        else if (s4 >= 1000 && s4 <= 2500)
                        {
                            resul1.Text = ("Un sueldo entre 1000 y 2500");
                        }
                    }
                }
                if (s1 >= 2500 && s2 >= 2500 && s3 >= 2500 && s4 >= 2500)
                {
                    resul2.Text = ("Todos los sueldos son mayores a 2500");
                }
                else
                {
                    if (s1 >= 2500 && s2 >= 2500 && s3 >= 2500)
                    {
                        resul2.Text = ("Hay tres sueldos mayores a 2500");
                    }
                    else if (s3 >= 2500 && s2 >= 2500 && s4 >= 2500)
                    {
                        resul2.Text = ("Hay tres sueldos mayores a 2500");
                    }
                    else if (s1 <= 2500 && s3 >= 2500 && s4 >= 2500)
                    {
                        resul2.Text = ("Hay tres sueldos mayores a 2500");
                    }
                    else if (s1 >= 2500 && s2 >= 2500 && s4 >= 2500)
                    {
                        resul2.Text = ("Hay tres sueldos mayores a 2500");
                    }
                    else
                    {
                        if (s1 >= 2500 && s2 >= 2500)
                        {
                            resul2.Text = ("Hay dos sueldos mayores a 2500");
                        }
                        else if (s1 >= 2500 && s3 >= 2500)
                        {
                            resul2.Text = ("Hay dos sueldos mayores a 2500");
                        }
                        else if (s1 >= 2500 && s4 >= 2500)
                        {
                            resul2.Text = ("Hay dos sueldos mayores a 2500");
                        }
                        else if (s2 >= 2500 && s3 >= 2500)
                        {
                            resul2.Text = ("Hay dos sueldos mayores a 2500");
                        }
                        else if (s2 >= 2500 && s4 >= 2500)
                        {
                            resul2.Text = ("Hay dos sueldos mayores a 2500");
                        }
                        else if (s3 >= 2500 && s4 >= 2500)
                        {
                            resul2.Text = ("Hay dos sueldos mayores a 2500");
                        }
                        else if (s1 >= 2500)
                        {
                            resul2.Text = ("Hay un sueldo mayor a 2500");
                        }
                        else if (s2 >= 2500)
                        {
                            resul2.Text = ("Hay un sueldo mayor a 2500");
                        }
                        else if (s3 >= 250000)
                        {
                            resul2.Text = ("Hay un sueldo menor a 1000");
                        }
                        else if (s4 >= 2500)
                        {
                            resul2.Text = ("Hay un sueldo mayor a 2500");
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sueldo1.Text = "";
            sueldo2.Text = "";
            sueldo3.Text = "";
            sueldo4.Text = "";
            resul.Text = "";
            resul1.Text = "";
            resul2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
