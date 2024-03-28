using HW3_GenericsAndCollections;
using static HW3_GenericsAndCollections.Helper;


/*-----------
Task 1: Complex number
-----------*/
Console.WriteLine("\nTask 1: Complex number:");
var complexNumber1 = new ComplexNumber<int>(2, 3);
var complexNumber2 = new ComplexNumber<int>(1, 4);

var sum = complexNumber1 + complexNumber2;
var difference = complexNumber1 - complexNumber2;

Console.Write("Sum: ");
sum.Print();
Console.Write("Diff: ");
difference.Print();


/*-----------
Task 2: Point
-----------*/
Console.WriteLine("\nTask 2: Point Class:");
var myPoint = new Point(5.0, 10.0);
myPoint.PrintCoordinates();

// Change the point
myPoint.X = 20.0;
myPoint.Y = 30.0;
myPoint.PrintCoordinates();


/*-----------
Task 3: Custom List
-----------*/
Console.WriteLine("\nTask 3: Custom List:");
var intList = new CustomList<int>();

// Adding elements
intList.Add(1);
intList.Add(2);
intList.Add(3);
Console.WriteLine("After adding elements: 1, 2, 3");
PrintList(intList);

// Inserting an element
intList.Insert(1, 5);
Console.WriteLine("After inserting 5 at index 1:");
PrintList(intList);

// Accessing elements using indexer
Console.WriteLine($"Element at index 2: {intList[2]}");

// Removing elements
intList.Remove(2);
Console.WriteLine("After removing the element 2:");
PrintList(intList);

// Removing element at specific index
intList.RemoveAt(0);
Console.WriteLine("After removing the first element:");
PrintList(intList);

// Checking if a specific element is in the list
Console.WriteLine($"Contains 3: {intList.Contains(3)}");
Console.WriteLine($"Contains 99: {intList.Contains(99)}");

// Reversing the list
intList.Reverse();
Console.WriteLine("After reversing the list:");
PrintList(intList);

// To Array
int[] ints = intList.ToArray();
Console.WriteLine($"Array: {string.Join(", ", ints)}");

// Clear
intList.Clear();
Console.WriteLine($"Count after clearing: {intList.Count}");


/*-----------
Task 4: Singly Linked List
-----------*/
Console.WriteLine("\nTask 4: Singly Linked List:");
var list = new SinglyLinkedList<string>();

// Adding elements
list.Add("Hello");
list.AddFirst("World");
list.Insert(1, "42");
Console.WriteLine("After adding elements: Hello, World, 42");
PrintSinglyLinkedList(list);

// Properties
Console.WriteLine($"Count: {list.Count}");
Console.WriteLine($"First: {list.First}");
Console.WriteLine($"Last: {list.Last}");

// Checking if a specific element is in the list
Console.WriteLine($"Contains 3: {list.Contains("3")}");
Console.WriteLine($"Contains 42: {list.Contains("42")}");

// To Array
var array = list.ToArray();
Console.WriteLine($"Array: {string.Join(", ", array)}");

// Clear
list.Clear();
Console.WriteLine($"Count after clearing: {list.Count}");


/*-----------
Task 5: Doubly Linked List
-----------*/
Console.WriteLine("\nTask 5: Doubly Linked List:");
var doublyList = new DoublyLinkedList<string>();

// Adding elements
doublyList.Add("Hello");
doublyList.Add("World");
doublyList.AddFirst("Start");
Console.WriteLine("After adding elements: Hello, World, Start");
PrintDoublyLinkedList(doublyList);

// Removing elements
doublyList.Remove("World");
doublyList.RemoveFirst();
doublyList.RemoveLast();
Console.WriteLine("After removing elements");
PrintDoublyLinkedList(doublyList);

// Adding
doublyList.Add("Again");
Console.WriteLine("After adding element: Again");
PrintDoublyLinkedList(doublyList);

// Properties
Console.WriteLine($"Count: {doublyList.Count}");
Console.WriteLine($"First: {doublyList.First}");
Console.WriteLine($"Last: {doublyList.Last}");

// Checking if a specific element is in the list
Console.WriteLine($"Contains 'Again': {doublyList.Contains("Again")}");

// To Array
var doublyArray = doublyList.ToArray();
Console.WriteLine($"Array: {string.Join(", ", doublyArray)}");

/*-----------
Task 6: CustomQueue
-----------*/
Console.WriteLine("\nTask 6: Custom Queue:");
var queue = new CustomQueue<string>();

// Adding elements
queue.Enqueue("First");
queue.Enqueue("Second");
queue.Enqueue("Third");
Console.WriteLine("After adding elements: First, Second, Third");
PrintCustomQueue(queue);

Console.WriteLine($"First in queue (Peek): {queue.Peek()}");
Console.WriteLine($"Dequeue: {queue.Dequeue()}");
Console.WriteLine($"Next in queue (Peek after Dequeue): {queue.Peek()}");
PrintCustomQueue(queue);

// Checking if a specific element is in the queue
Console.WriteLine($"Queue contains 'Second': {queue.Contains("Second")}");

// To Array
var queueArray = queue.ToArray();
Console.WriteLine($"Array: {string.Join(", ", queueArray)}");

// Clear
queue.Clear();
Console.WriteLine($"Queue count after clear: {queue.Count}");
