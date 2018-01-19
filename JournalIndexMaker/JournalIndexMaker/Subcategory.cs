using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalIndexMaker
{
    class Subcategory
    {
        private string Name { get; set; }
        private List<DateTime> Entries = new List<DateTime>();

        public Subcategory(string Name)
        {
            this.Name = Name;
        }

        public Subcategory(string Name, DateTime dt) : this(Name)
        {
            Entries.Add(dt);
        }

        public void addEntry(DateTime dt)
        {
            if (!Entries.Contains(dt))
            {
                Entries.Add(dt);
            }
        }

        public List<DateTime> getEntries()
        {
            Entries.Sort();
            return Entries;
        }
    }
}
