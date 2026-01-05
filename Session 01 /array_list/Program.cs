int[] numbers = new int[5];
numbers[0] = 00;
numbers[1] = 01;
numbers[2] = 02;
numbers[3] = 03;
numbers[4] = 04;



int[] arr = {1, 2, 3, 4, 5};

foreach(int i in numbers)
{   
    Console.WriteLine(i);
}

int[] scores = { 85, 92, 78, 95, 88, 100 };

int[] num = { 1, 2, 3 };

Console.WriteLine("Scores:");
for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"Score {i + 1}: {scores[i]}");
}
Console.WriteLine($"\nArray Length: {scores.Length}");

List<string> students = new List<string>();

List<int> nums = new List<int>();
nums.Add(1212);
nums.Add(1123);
nums.Add(3312);

students.Add("Alice");
students.Add("jahid");
students.Add("Bob");

for(int i = 0; i<nums.Count; i++)
{
    Console.WriteLine(nums[i]);
}

for(int i = 0; i<students.Count; i++)
{
    Console.WriteLine(students[i]);
}

students.Remove("Bob"); 
Console.WriteLine("\nAfter removing Bob:");
foreach (string student in students)
{
    Console.WriteLine($"- {student}");
}

bool hasAlice = students.Contains("Alice");
Console.WriteLine($"\nContains Alice: {hasAlice}");

students.Insert(1, "Eve");
Console.WriteLine("\nAfter inserting Eve at position 1:");
foreach (string student in students)
{
    Console.WriteLine($"- {student}");
}