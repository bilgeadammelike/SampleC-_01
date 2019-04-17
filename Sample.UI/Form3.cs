using Sample.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample.UI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //validate
            //Hata kontrolü
            //Forma Gönder

            if(true == Kontrolet())
            {

            }
            else
            {
                MessageBox.Show("Arayüzde Hata Var");
            }

            try
            {
                User user = new User()
                {
                    TC = txtmsk.Text,
                    DogumTarihi = dtpickerDogumTarihi.Value,
                    DogumYeri = cmboxDogumYeri.SelectedText,
                    Kullaniciadi = txtKullaniciAdi.Text,
                    Cinsiyet = rdbKadin.Checked == true ? true : false
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool Kontrolet()
        {
            if(cmboxDogumYeri.SelectedItem == null)
            {
                
            }
            else
            {

            }

            return true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Yukle(4);
        }

        private void Yukle(int v)
        {
            cmboxDogumYeri.("Ankara");
            cmboxDogumYeri.ControlAdded("Istanbul");
            cmboxDogumYeri.ControlAdded("Izmir");
            cmboxDogumYeri.ControlAdded("Kayseri");

            rdbKadin.Checked = true;

            dtpickerDogumTarihi.Value = DateTime.Now;
        }
    }
}
