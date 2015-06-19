using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface IPurchasable
    {
        int BaseCost { get; set; }
        string Name { get; set; }
    }
}
