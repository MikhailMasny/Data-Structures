namespace DataStructures.BL.List
{
    public class DuplexItemList<T>
    {
        public T Data { get; set; }
        public DuplexItemList<T> Previous { get; set; }
        public DuplexItemList<T> Next { get; set; }

        public DuplexItemList(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
