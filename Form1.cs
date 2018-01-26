using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podgotovka
{
    public partial class Form1 : Form
    {
        private List<Class1> list1 = new List<Class1>();
        
        private List<Class2> list2 = new List<Class2>();



        public Form1()
        {
            InitializeComponent();
            list1.Add(new Class1(Convert.ToInt32(textBox1.Text)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 cl = new Class1(Convert.ToInt32(textBox1.Text));
            textBox2.Text = cl.method1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 cl = new Class1(Convert.ToInt32(textBox1.Text));
            textBox2.Text =cl.method2( Convert.ToInt32(textBox3.Text));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
