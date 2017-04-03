using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Xml.Linq;

namespace RPRZadaca1
{
    [Serializable]
    public class Uposleni : Osoba
    {
        [XmlIgnore]
        public Image Slika { get; set; }

       
        

        public Uposleni() { }

        

        public Uposleni(string pime, string pprezime, string pmaticni_broj, DateTime pdatum_rodjenja, string pkomentar, string korisnicko, string lozinka, Image sl)
                : base(pime, pprezime, pmaticni_broj, pdatum_rodjenja, pkomentar, korisnicko, lozinka)
        {
           
            Slika = sl;
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("Slika")]
        public byte[] _Slika
        {
            get
            { // serialize
                if (Slika == null) return null;
                using (MemoryStream ms = new MemoryStream())
                {
                    Slika.Save(ms, ImageFormat.Bmp);
                    return ms.ToArray();
                    ms.Close();
                }
            }
            set
            { // deserialize
                if (value == null)
                {
                    Slika = null;
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream(value))
                    {
                        Slika = new Bitmap(ms);
                        ms.Close();
                    }
                }
            }
        }

        //[XmlIgnore]
        /* public Image Slika
         {
             get
             {
                 return slika;
             }

             set
             {
                 slika = value;
             }
         }
         */
        public override void DodajKnjigu(Knjiga k)
        {
            base.DodajKnjigu(k);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void azuriraj(string pime, string pprezime, string pmaticni_broj, DateTime pdatum_rodjenja, string pkomentar, string korisnicko, string lozinka, Image sl)
        {
            
            Slika = sl;
            Ime = pime;
            Prezime = pprezime;
            Datum_rodjenja = pdatum_rodjenja;
            if (validacija(pmaticni_broj))
                Maticni_broj = pmaticni_broj;
            else throw new ArgumentException("Maticni broj nije validan. ");
            Username = korisnicko;
            Password = lozinka;
        }

        

    }
}
