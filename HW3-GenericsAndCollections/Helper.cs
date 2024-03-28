namespace HW3_GenericsAndCollections
{
    public class Helper
    {
        public static void PrintList<T>(CustomList<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + (i < list.Count - 1 ? ", " : "\n"));
            }
        }

        public static void PrintSinglyLinkedList<T>(SinglyLinkedList<T> list)
        {
            var array = list.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + (i < array.Length - 1 ? " -> " : ""));
            }
            Console.WriteLine();
        }

        public static void PrintDoublyLinkedList<T>(DoublyLinkedList<T> list)
        {
            var array = list.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + (i < array.Length - 1 ? " <-> " : ""));
            }
            Console.WriteLine();
        }

        public static void PrintCustomQueue<T>(CustomQueue<T> queue)
        {
            var array = queue.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + (i < array.Length - 1 ? " -> " : ""));
            }
            Console.WriteLine();
        }
    }
}
