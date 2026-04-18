using GrokkingAlgorithms._01IntroToAlgorithms;

#region [GA0101] - Intro - Binary Search

int[] sortedNums = [1, 3, 5, 7, 9, 11, 13, 15, 17, 19];

int target = 7;
int result = BinarySearch.Search(sortedNums, target);
Console.WriteLine($"Search for {target}: index {result}"); // Expected: 3

target = 1;
result = BinarySearch.Search(sortedNums, target);
Console.WriteLine($"Search for {target}: index {result}"); // Expected: 0

target = 19;
result = BinarySearch.Search(sortedNums, target);
Console.WriteLine($"Search for {target}: index {result}"); // Expected: 9

target = 6;
result = BinarySearch.Search(sortedNums, target);
Console.WriteLine($"Search for {target}: index {result}"); // Expected: -1 (not found)

#endregion [GA0101] - Intro - Binary Search
