using System.Collections.Generic;

namespace Indexers
{
    class ItemIndexer
    {
        private List<Item> Items = new();
        private Dictionary<string, Item> Dictionary = new();
        public Item this[int Id]
        {
            get
            {
                Item r = Items.Find(x => x.Id == Id);
                r ??= new Item() { Id = 999, name = "Default" };
                return r;
            }
            set
            {
                Items.Add(value);
            }
        }

        public Item this[string name]
        {
            get
            {
                if (Dictionary.ContainsKey(name))
                {
                    return Dictionary[name];
                }
                return new Item() { Id = 999, name = "Default" };
            }
            set
            {

                Dictionary.Add(name, value);
            }
        }
    }
}
