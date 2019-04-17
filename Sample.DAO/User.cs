using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.DAO
{
    public class User
    {
        string _TC;
        public string TC
        {
            get { return _TC; }
            set
            {
                if (value.Length == 11)
                {
                    char a = value.ElementAt(0);
                    if(a != '0')
                    {
                        _TC = value;
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        private string _KullaniciAdi;
        public string Kullaniciadi
        {
            get { return _KullaniciAdi; }
            set
            {
                _KullaniciAdi = value;
                _KullaniciAdi = _KullaniciAdi.ToUpper();
            }
        }



        public DateTime DogumTarihi { get; set; }
        public string DogumYeri { get; set; }

        public bool Cinsiyet { get; set; }
    }
}
