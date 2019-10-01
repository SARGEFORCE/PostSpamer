using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSpamer.library.Entities
{
    public abstract class HumanEntity : NamedEntity
    {
        public string Address { get; set; }
    }
}
