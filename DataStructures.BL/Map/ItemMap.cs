namespace DataStructures.BL.Map
{
    class ItemMap<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public ItemMap(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
