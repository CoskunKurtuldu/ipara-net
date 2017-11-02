using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPara.DeveloperPortal.Core
{
    /// <summary>
    /// Tüm çağrılarda kullanılacak ayarların tutulduğu sınıftır. 
    /// Bu sınıf üzerinde size özel parametreler fonksiyonlar arasında taşınabilir.
    /// </summary>
    public class Settings
    {      
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
        public string BaseUrl { get; set; }
        public string Mode { get; set; }
        public string Version { get; set; }
        public string HashString { get; set; }
        public string transactionDate { get; set; }

    }
}
