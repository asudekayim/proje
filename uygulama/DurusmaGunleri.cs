using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama
{
    public class DurusmaGunleri
    {
        public string kontrol(string secilenGun)
        {
            switch (secilenGun)
            {
                case "PAZARTESİ":
                    return secilenGun;
                    break;

                case "SALI":
                    return secilenGun;
                    break;

                case "ÇARŞAMBA":
                    return secilenGun;
                    break;

                case "PERŞEMBE":
                    return secilenGun;
                    break;

                case "CUMA":
                    return secilenGun;
                    break;

                default:
                    return "Geçersiz Seçim";
            }
        }
    }
}
