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
var grades1 = new List<int> { 55, 78, 45, 82, 90, 67, 58, 85 };
var result3 = grades1.Where(g => g >= 60).Take(4).Select(g => new { Grade = g });
foreach (var g in result3)
    Console.Write(g);
Console.ReadLine();

//Task -4
Console.WriteLine("Task -4");
List<int> grades2 = [45, 78, 92, 55, 85, 60, 72, 88];
var result4 = grades2.GroupBy(g =>
{
    if (g < 60) return "0-59";
    else if (g < 70) return "60-69";
    else if(g<80) return "70-79";
    else return "80-100";
}).Select(g => new { Grade = g.Key, Count = g.Count() });
foreach (var g in result4)
    Console.Write(g);
Console.ReadLine();

//Task -5 
Console.WriteLine("Task -5");
var sales = new List<Sale>
{
    new Sale { Region = "Regar", Amount = 100 },
    new Sale { Region = "Dushanbe", Amount = 150 },
    new Sale { Region = "Shahrinav", Amount = 200 },
    new Sale { Region = "Bokhtar", Amount = 120 },
    new Sale { Region = "Shahrinav", Amount = 200 },
    new Sale { Region = "Regar", Amount = 100 }
};

var grouped5 = sales
    .GroupBy(s => s.Region)
    .OrderBy(g => g.Key)
    .Skip(2);

Console.WriteLine("Dictionary with region as key and total sales as value, excluding the first 2 regions alphabetically");
foreach (var group in grouped5) 
    Console.Write($"{group.Key}: {group.Sum(s => s.Amount)}");
Console.ReadLine();

//Task -6
Console.WriteLine("Task -6");
var scores6 = new List<StudentScore>
{
    new StudentScore { ClassName = "Math", Score = 85 },
    new StudentScore { ClassName = "Science", Score = 90 },
    new StudentScore { ClassName = "Math", Score = 75 },
    new StudentScore { ClassName = "History", Score = 80 },
    new StudentScore { ClassName = "Science", Score = 95 },
    new StudentScore { ClassName = "History", Score = 70 }
};

var grouped6 = scores6.GroupBy(s => s.ClassName)
    .Select(g => new { ClassName = g.Key, AverageScore = g.Average(s => s.Score) })
    .OrderByDescending(g => g.AverageScore);
foreach (var group in grouped6) 
    Console.Write($"{group.ClassName}: {group.AverageScore}");
Console.ReadLine();

//Task -7
Console.WriteLine("Task -7");
List<int> salaries = [30000, 45000, 25000, 60000, 40000, 55000, 35000, 50000];
var result5 = salaries.OrderBy(s => s).Skip(3).Take(5).Average();
Console.Write($"Average of top 5 salaries: {result5}");
Console.ReadLine();

//Task -8
Console.WriteLine("Task -8");
List<Order> orders =
[
    new Order { Date = new DateTime(2023, 1, 1), Amount = 100 },
    new Order { Date = new DateTime(2023, 1, 15), Amount = 200 },
    new Order { Date = new DateTime(2023, 2, 1), Amount = 150 },
    new Order { Date = new DateTime(2023, 3, 1), Amount = 300 }
];
var result8 = orders
    .GroupBy(o => new { o.Date.Year, o.Date.Month })
    .Select(g => new 
    { 
        Month = new DateTime(g.Key.Year, g.Key.Month, 1),
        Total = g.Sum(o => o.Amount)
    })
    .OrderByDescending(x => x.Total)
    .Take(2);

Console.WriteLine("Task 8 Output:");
foreach (var item in result8)
{
    Console.WriteLine($"{item.Month:MMMM yyyy}: {item.Total}");
}