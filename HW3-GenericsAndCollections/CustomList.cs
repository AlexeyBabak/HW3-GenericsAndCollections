namespace HW3_GenericsAndCollections
{
    public class CustomList<T>
    {
        private T[] items;
        private int count;

        public CustomList()
        {
            items = new T[4];
            count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                return items[index];
            }
            set
            {
                if (index < 0 || index >= count)
                    throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                items[index] = value;
            }
        }

        public int Count => count;

        public void Add(T item)
        {
            EnsureCapacity();
            items[count++] = item;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > count) throw new ArgumentOutOfRangeException(nameof(index));

            EnsureCapacity();
            Array.Copy(items, index, items, index + 1, count - index);
            items[index] = item;
            count++;
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index == -1) return false;

            RemoveAt(index);
            return true;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count) throw new ArgumentOutOfRangeException(nameof(index));

            Array.Copy(items, index + 1, items, index, count - index - 1);
            items[--count] = default;
        }

        public void Clear()
        {
            items = new T[4];
            count = 0;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (Equals(items[i], item)) return i;
            }
            return -1;
        }

        public T[] ToArray()
        {
            T[] array = new T[count];
            Array.Copy(items, array, count);
            return array;
        }

        public void Reverse()
        {
            Array.Reverse(items, 0, count);
        }

        private void EnsureCapacity()
        {
            if (count == items.Length)
            {
                T[] newItems = new T[items.Length * 2];
                Array.Copy(items, newItems, count);
                items = newItems;
            }
        }
    }
}
