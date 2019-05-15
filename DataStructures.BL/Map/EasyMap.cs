using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.BL.Map
{
    class EasyMap<TKey, TValue> : IEnumerable
    {
        private List<ItemMap<TKey, TValue>> Items = new List<ItemMap<TKey, TValue>>();
        private List<TKey> Keys = new List<TKey>();

        public int Count => Items.Count;

        public EasyMap()
        {

        }

        public void Add(ItemMap<TKey, TValue> item)
        {
            if (!Keys.Contains(item.Key))
            {
                Keys.Add(item.Key);
                Items.Add(item);
            }
        }

        public TValue Search(TKey key)
        {
            if (Keys.Contains(key))
            {
                return Items.Single(i => i.Key.Equals(key)).Value;
            }

            return default(TValue);
        }

        public void Remove(TKey key)
        {
            if (Keys.Contains(key))
            {
                Keys.Remove(key);
                Items.Remove(Items.Single(i => i.Key.Equals(key)));
            }
        }

        public IEnumerator GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
}
