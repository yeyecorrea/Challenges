int a = 30;
int b = 30;

b = a - b;
a = a - b;
b = a + b;

Console.WriteLine($"{a} ---------> {b}");
