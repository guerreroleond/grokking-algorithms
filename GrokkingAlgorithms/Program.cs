using GrokkingAlgorithms._01IntroToAlgorithms;
using GrokkingAlgorithms._02SelectionSort;
using GrokkingAlgorithms._03Recursion;
using GrokkingAlgorithms._04Quicksort;

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

// OrderQueue queue = new();
// queue.Add("Order 1");
// queue.Add("Order 2");
// queue.Add("Order 3");

// Console.WriteLine(queue.Take()); // Expected: Order 1
// Console.WriteLine(queue.Take()); // Expected: Order 2

// queue.Add("Order 4");

// Console.WriteLine(queue.Take()); // Expected: Order 3
// Console.WriteLine(queue.Take()); // Expected: Order 4
// Console.WriteLine(queue.Take()); // Expected: (empty)

#endregion [GA0202] - SelectionSort - Order Queue

#region [GA0206] - SelectionSort

// int[] unsorted = [64, 25, 12, 22, 11];

// int[] sorted = SelectionSort.Sort(unsorted);

// Console.WriteLine($"Sorted: [{string.Join(", ", sorted)}]"); // Expected: [11, 12, 22, 25, 64]

#endregion [GA0206] - SelectionSort

#region [GA0301] - Recursion - Factorial

//Console.WriteLine($"Factorial of 0: {Factorial.Fact(0)}"); // Expected: 1
//Console.WriteLine($"Factorial of 1: {Factorial.Fact(1)}"); // Expected: 1
//Console.WriteLine($"Factorial of 5: {Factorial.Fact(5)}"); // Expected: 120
//Console.WriteLine($"Factorial of 10: {Factorial.Fact(10)}"); // Expected: 3628800

#endregion [GA0301] - Recursion - Factorial

#region [GA0401] - Quicksort - Recursive Sum

// RecursiveSum recursiveSum = new();

// int[] nums = [1, 2, 3, 4, 5];
// Console.WriteLine($"Sum: {RecursiveSum.Sum(nums)}"); // Expected: 15

int[] nums = [];
Console.WriteLine($"Sum: {RecursiveSum.Sum(nums)}"); // Expected: 0

#endregion [GA0401] - Quicksort - Recursive Sum

Console.ReadKey();