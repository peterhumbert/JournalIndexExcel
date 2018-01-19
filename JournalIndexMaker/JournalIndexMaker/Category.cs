using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalIndexMaker
{
    class Category
    {
        private string Name { get; set; }
        private Dictionary<string, Subcategory> Subcategories = new Dictionary<string, Subcategory>();

        public Category(string Name)
        {
            this.Name = Name;
        }

        public Category(string Name, string subcatName, DateTime dt) : this(Name)
        {
            Subcategories.Add(subcatName, new Subcategory(subcatName, dt));
        }

        public void addEntry(string subcatName, DateTime dt)
        {
            if (!Subcategories.ContainsKey(subcatName))
            {
                Subcategories.Add(subcatName, new Subcategory(subcatName, dt));
            }
            else
            {
                if (Subcategories.TryGetValue(subcatName, out Subcategory currentSubcat))
                {
                    currentSubcat.addEntry(dt);
                }
                else
                {
                    throw new Exception("Dictionary does not contain subcategory " + subcatName);
                }

            }

        }

        
    }
}
