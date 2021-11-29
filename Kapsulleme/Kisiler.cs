using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    class Kisiler
    {
        public int ID { get; set; }
        private string _adi;
        public string Adi
        {
            get
            {
                string ilkHarf = _adi.Substring(0, 1).ToUpper();
                string gerikalan = _adi.Substring(0, 1).ToLower();
                _adi = ilkHarf + gerikalan;
                return _adi;
            }
            set
            {
                _adi = value;
            }
        }
        private string _soyadi;
        public string soyadi
        {
            get
            {
                return _soyadi;
            }
            set
            {
                _soyadi = value;
            }
        }
        private int _yas;
        public int yas
        {
            get
            {
                return _yas;
            }
            //Kapsulleme aracılığı ile kontrol edelim throw ile hata fırlatılır
            set
            {
                _yas = value;
                if (_yas<0)
                {
                    _yas = 0;
                    throw new FormatException("Yaş sıfırdan küçük olamaz. ");

                }
            }
        }
        public DateTime DogumTarihi { get; set; }
        
    }
}
