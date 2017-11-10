using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Written_For_Errors_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.show("Hello World!");
            MessageBox.Show(Type your name in the text box, then press button 2.")
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        
        private void button2_Click(object sender, EventArgs e)
        {
            Messagebox.Show("Hello, " + textBox1.Text ".");
        }
    }
}
