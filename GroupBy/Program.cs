//Task -1
Console.WriteLine("Task -1");
Console.WriteLine("List of top 3 scores:");
var scores1 = new List<int> { 85, 92, 78, 95, 88, 91, 75, 82, 89, 93 };
var result1 = scores1.OrderByDescending(s => s).Skip(6).Take(3)
    .Select(s => new { Score = s});
foreach(var item in result1)
    Console.Write(item);
Console.ReadLine();    

//Task -2
Console.WriteLine("Task -2");
List<int> scores2 = [60, 75, 80, 95, 85, 90, 70, 88];
var result2 = scores2.OrderByDescending(s=>s).Take(5).Average();
Console.Write($"Average of top 5 scores: {result2}");
Console.ReadLine();

//Task-3 
Console.WriteLine("Task -3");
Console.WriteLine("First 4 passing grades:");
var grades = new List<int> { 55, 78, 45, 82, 90, 67, 58, 85 };
var result3 = grades.Where(g => g >= 60).Take(4).Select(g => new { Grade = g });
foreach (var g in result3)
    Console.Write(g);
Console.ReadLine();
