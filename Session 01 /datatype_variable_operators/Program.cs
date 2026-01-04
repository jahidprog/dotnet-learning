
int age = 25; // 32bit int
long population = 20000; // 64bit int
float temperature = 36.6f; // Use 'f' suffix for float
double price = 99.99;
decimal salary = 5000.50m;  // Use 'm' suffix for decimal

char grade = 'A';
string name = "John Doe";
string multilinestr = "";

bool isStudent = true;

// Display values
Console.WriteLine("=== Variable Examples ===");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Grade: {grade}");
Console.WriteLine($"Is Student: {isStudent}");
Console.WriteLine($"Salary: ${salary}");

Console.WriteLine("\n=== Operators ===");


int a = 10, b = 3;
Console.WriteLine($"Addition: {a} + {b} = {a + b}");
Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
Console.WriteLine($"Division: {a} / {b} = {a / b}");
Console.WriteLine($"Modulus: {a} % {b} = {a % b}");


Console.WriteLine($"\n{a} > {b}: {a > b}");
Console.WriteLine($"{a} == {b}: {a == b}");
Console.WriteLine($"{a} != {b}: {a != b}");


bool condition1 = true, condition2 = false;
Console.WriteLine($"\nAND: {condition1} && {condition2} = {condition1 && condition2}");
Console.WriteLine($"OR: {condition1} || {condition2} = {condition1 || condition2}");
Console.WriteLine($"NOT: !{condition1} = {!condition1}");

int counter = 5;
Console.WriteLine($"\nCounter: {counter}"); // Counter: 5
counter++;
Console.WriteLine($"After increment: {counter}"); // Counter 6
counter--;
Console.WriteLine($"After decrement: {counter}"); // Counter 5