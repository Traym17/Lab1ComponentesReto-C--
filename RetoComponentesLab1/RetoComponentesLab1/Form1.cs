using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetoComponentesLab1
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> openWith = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openWith.Add("January", "Enero");
            openWith.Add("February", "Febrero");
            openWith.Add("March", "Marzo");
            openWith.Add("April", "Abril");
            openWith.Add("May", "Mayo");
            openWith.Add("June", "Junio");
            openWith.Add("July", "Julio");
            openWith.Add("August", "Agosto");
            openWith.Add("September", "Septiembre");
            openWith.Add("October", "Octubre");
            openWith.Add("November", "Noviembre");
            openWith.Add("December", "Diciembre");
            foreach (KeyValuePair<string, string> result in openWith)
            {
                this.comboBox1.Items.Add(result.Key);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String seleccion =this.comboBox1.SelectedItem.ToString();
            Console.WriteLine(seleccion);
            if (openWith.ContainsKey(seleccion))
            {
                this.textBox1.Text = openWith[seleccion];
                
            }
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
