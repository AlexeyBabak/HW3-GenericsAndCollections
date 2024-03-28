namespace HW3_GenericsAndCollections
{
    public class SinglyLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;

        public int Count => count;
        public T First => head != null ? head.Data : default(T);
        public T Last => tail != null ? tail.Data : default(T);

        public SinglyLinkedList()
        {
            head = tail = null;
            count = 0;
        }

        public void Add(T data)
        {
            var newNode = new Node<T>(data);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
            count++;
        }

        public void AddFirst(T data)
        {
            var newNode = new Node<T>(data) { Next = head };
            head = newNode;
            if (count == 0)
            {
                tail = head;
            }
            count++;
        }

        public void Insert(int index, T data)
        {
            if (index < 0 || index > count) throw new ArgumentOutOfRangeException(nameof(index));
            if (index == 0)
            {
                AddFirst(data);
                return;
            }
            if (index == count)
            {
                Add(data);
                return;
            }

            var newNode = new Node<T>(data);
            var current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
            count++;
        }

        public void Clear()
        {
            head = tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            var current = head;
            while (current != null)
            {
                if (Equals(current.Data, data)) return true;
                current = current.Next;
            }
            return false;
        }

        public T[] ToArray()
        {
            var array = new T[count];
            var current = head;
            for (int i = 0; i < count; i++)
            {
                array[i] = current.Data;
                current = current.Next;
            }
            return array;
        }
    }
}
