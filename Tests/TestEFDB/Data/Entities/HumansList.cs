using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFDB.Data.Entities
{
    public class HumansList : BaseEntity
    {
        public ObservableCollection<Human> Humans = new ObservableCollection<Human>();
    }
}
