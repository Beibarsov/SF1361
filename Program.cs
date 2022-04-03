// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");


var text = File.ReadAllText(@"Text1.txt");


List<string> simpleList = new List<string>();
LinkedList<string> linkedList = new LinkedList<string>();

var stopWatch1 = Stopwatch.StartNew();
simpleList.Add(text);
double result1 = stopWatch1.Elapsed.TotalMilliseconds;
Console.WriteLine("Результат вставки в list: " + result1);

var stopWatch2 = Stopwatch.StartNew();
linkedList.AddFirst(text);
double result2 = stopWatch2.Elapsed.TotalMilliseconds;
Console.WriteLine("Результат вставки в LinkedList: " + result2);

Console.WriteLine("Вставка в обычный List быстрее на " + (result2 - result1));

