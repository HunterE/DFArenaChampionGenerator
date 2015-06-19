using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Equipment : IPurchasable
    {
        public virtual List<Tier> Tiers { get; set; }
        public virtual int BaseCost { get; set; }
        public virtual string Name { get; set; }
    }
}
