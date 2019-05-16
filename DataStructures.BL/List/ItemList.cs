using System;

namespace DataStructures.BL.List
{
    public class ItemList<T>
    {
        private T data = default(T);

        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }

        public ItemList<T> Next { get; set; }

        public ItemList(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
