using GrokkingAlgorithms._01IntroToAlgorithms;
using GrokkingAlgorithms._02SelectionSort;

#region [GA0101] - Intro - Binary Search

// int[] sortedNums = [1, 3, 5, 7, 9, 11, 13, 15, 17, 19];

// int target = 7;
// int result = BinarySearch.Search(sortedNums, target);
// Console.WriteLine($"Search for {target}: index {result}"); // Expected: 3

// target = 1;
// result = BinarySearch.Search(sortedNums, target);
// Console.WriteLine($"Search for {target}: index {result}"); // Expected: 0

// target = 19;
// result = BinarySearch.Search(sortedNums, target);
// Console.WriteLine($"Search for {target}: index {result}"); // Expected: 9

// target = 6;
// result = BinarySearch.Search(sortedNums, target);
// Console.WriteLine($"Search for {target}: index {result}"); // Expected: -1 (not found)

#endregion [GA0101] - Intro - Binary Search

#region [GA0202] - SelectionSort - Order Queue

OrderQueue queue = new();
queue.Add("Order 1");
queue.Add("Order 2");
queue.Add("Order 3");

Console.WriteLine(queue.Take()); // Expected: Order 1
Console.WriteLine(queue.Take()); // Expected: Order 2

queue.Add("Order 4");

Console.WriteLine(queue.Take()); // Expected: Order 3
Console.WriteLine(queue.Take()); // Expected: Order 4
Console.WriteLine(queue.Take()); // Expected: (empty)

#endregion [GA0202] - SelectionSort - Order Queue
