using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sample.DAO;

namespace Sample.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Kapattım Bunları
            //MessageBox.Show("Test");

            //txtName.BackColor = Color.Red;

            //this.BackColor = Color.Yellow;

            //Person p = new Person()
            //{
            //    Age = "1",
            //    surName = "Kadir"
            //}; 
            #endregion

            Person p = new Person();
            p.Age = txtAge.Text;
            p.surName = txtName.Text;

            DialogResult dg = MessageBox.Show(p.ToString(), "Bligi", MessageBoxButtons.YesNo);

            if(dg == DialogResult.Yes)
            {
                // diğer Forma gonder
                Form2 f = new Form2(p);
                f.Show();

            }
            else
            {
                // kullanıcıya bilgi ver
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
