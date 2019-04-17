using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.DAO
{
    public class Person
    {
        public string surName { get; set; }
        public string Age { get; set; }
        public string Section
        {
            get { return "Yazılım"; }
            set { Section = value; }
        }

        public override string ToString()
        {
            return string.Format("Adınız :{0} Yaşınız :{1}",
                                    surName, Age);


        }
    }
}
