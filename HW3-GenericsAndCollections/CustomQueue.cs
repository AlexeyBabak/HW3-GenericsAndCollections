namespace HW3_GenericsAndCollections
{
    public class CustomQueue<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;

        public int Count => count;

        public void Enqueue(T item)
        {
            var newNode = new Node<T>(item);
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

        public T Dequeue()
        {
            if (head == null) throw new InvalidOperationException("Queue is empty");

            T value = head.Data;
            head = head.Next;
            if (head == null)
            {
                tail = null;
            }
            count--;
            return value;
        }

        public void Clear()
        {
            head = tail = null;
            count = 0;
        }

        public bool Contains(T item)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (Equals(current.Data, item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public T Peek()
        {
            if (head == null) throw new InvalidOperationException("Queue is empty");
            return head.Data;
        }

        public T[] ToArray()
        {
            var array = new T[count];
            Node<T> current = head;
            int index = 0;
            while (current != null)
            {
                array[index++] = current.Data;
                current = current.Next;
            }
            return array;
        }
    }

}
