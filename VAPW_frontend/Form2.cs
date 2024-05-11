using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAPW_frontend
{
    public partial class Form2 : Form
    {

        public bool useEvents { get; set; } = true;

        public Form2()
        {
            InitializeComponent();

            radioButton2.Checked = true;

        }
        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            radioButton1.Checked = false;

            useEvents = true;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;

            useEvents = false;
        }

        
    }
}
