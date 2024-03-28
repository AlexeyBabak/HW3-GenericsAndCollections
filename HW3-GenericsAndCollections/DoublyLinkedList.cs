namespace HW3_GenericsAndCollections
{
    public class DoublyLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;

        public int Count => count;
        public T First => head != null ? head.Data : default(T);
        public T Last => tail != null ? tail.Data : default(T);

        public void Add(T data)
        {
            var newNode = new Node<T>(data);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Prev = tail;
                tail.Next = newNode;
                tail = newNode;
            }
            count++;
        }

        public void AddFirst(T data)
        {
            var newNode = new Node<T>(data);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
            count++;
        }

        public bool Remove(T data)
        {
            var current = head;
            while (current != null)
            {
                if (Equals(current.Data, data))
                {
                    if (current.Prev != null)
                    {
                        current.Prev.Next = current.Next;
                    }
                    else
                    {
                        head = current.Next;
                    }

                    if (current.Next != null)
                    {
                        current.Next.Prev = current.Prev;
                    }
                    else
                    {
                        tail = current.Prev;
                    }

                    count--;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void RemoveFirst()
        {
            if (head != null)
            {
                head = head.Next;
                if (head != null)
                {
                    head.Prev = null;
                }
                else
                {
                    tail = null;
                }
                count--;
            }
        }

        public void RemoveLast()
        {
            if (tail != null)
            {
                tail = tail.Prev;
                if (tail != null)
                {
                    tail.Next = null;
                }
                else
                {
                    head = null;
                }
                count--;
            }
        }

        public bool Contains(T data)
        {
            var current = head;
            while (current != null)
            {
                if (Equals(current.Data, data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public T[] ToArray()
        {
            var result = new T[count];
            var current = head;
            for (int i = 0; i < count; i++)
            {
                result[i] = current.Data;
                current = current.Next;
            }
            return result;
        }

        public void Clear()
        {
            head = tail = null;
            count = 0;
        }
    }
}
