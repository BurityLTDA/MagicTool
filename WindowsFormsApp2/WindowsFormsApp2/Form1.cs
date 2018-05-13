using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        //Global Variables 
       // TextBox txtValue = null;
      //  Label lblFinalValue = null;
       // Button btnSwap, btnConvert = null;
       // ComboBox cboxFrom, cboxTo = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtboxInputValue.Text);
           
        }
    }
}
