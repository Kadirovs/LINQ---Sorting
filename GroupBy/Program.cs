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
    Console.WriteLine($"{item.Month:MMMM yyyy}: {item.Total}");
Console.ReadLine();

//Task -9
Console.WriteLine("Task -9");
List<int> transactions = [50, 100, 150, 200, 250, 300, 350, 400];

Console.ReadLine();

//Task -10
Console.WriteLine("Task -10");
List<Product> products =
[
    new Product { Category = "Electronics", Price = 500 },
    new Product { Category = "Clothing", Price = 50 },
    new Product { Category = "Electronics", Price = 700 },
    new Product { Category = "Books", Price = 20 },
    new Product { Category = "Clothing", Price = 80 }
];

var result10 = products
    .GroupBy(p => p.Category)
    .Where(g => g.Count() >= 2)
    .Select(g => new { Product = g.Key, MaxPrice = g.Max(p => p.Price) });
Console.Write("Max price of products in each category:");    
foreach (var item in result10)
    Console.WriteLine($"{item.Product}: {item.MaxPrice}");
Console.ReadLine();

//Task- 11
Console.WriteLine("Task -11");
List<int> ages = [15, 70, 25, 68, 17, 66, 30];
var result11 = ages
    .Where(a => a >= 65)
    .Take(3)
    .ToList();
Console.WriteLine("First 3 ages >= 65:");
result11.ForEach(Console.WriteLine);
Console.ReadLine();

//Task -12
Console.WriteLine("Task -12");
List<Player> players =
[
    new Player { Team = "Red", Score = 10 },
    new Player { Team = "Blue", Score = 15 },
    new Player { Team = "Red", Score = 20 },
    new Player { Team = "Blue", Score = 25 },
    new Player { Team = "Green", Score = 30 }
];
var result12 = players
    .GroupBy(p => p.Team)
    .Where(g => g.Count() >= 2)
    .ToDictionary(g => g.Key, g => g.Sum(p => p.Score));
foreach (var item in result12)
    Console.WriteLine($"{item.Key}: {item.Value}");
Console.ReadLine();

//Task -13
Console.WriteLine("Task -13");
List<int> donations = [100, 200, 300, 400, 500, 600, 700];
var result13 = donations.Skip(2).Take(4).Sum();
Console.WriteLine($"Sum of donations after skipping first 2: {result13}");
Console.ReadLine();

//Task -14
Console.WriteLine("Task -14");
List<int> prices = [30, 75, 120, 45, 90, 150];
var result14 = prices.GroupBy(p =>
{
    if (p <= 50) return "0-50";
    else if (p <= 100) return "51-100";
    else return "101-200";
}).Where(g => g.Count() > 1);
foreach (var group in result14)
    Console.WriteLine($"{group.Key}: {group.Count()}");
Console.ReadLine();

//Task -15
Console.WriteLine("Task -15");
List<Employee> employees = [
    new Employee { Department = "HR", Salary = 50000 },
    new Employee { Department = "IT", Salary = 60000 },
    new Employee { Department = "HR", Salary = 55000 },
    new Employee { Department = "IT", Salary = 70000 },
    new Employee { Department = "Sales", Salary = 45000 }
];
var result15 = employees.GroupBy(e => e.Department);
Console.WriteLine("Top 2 salaries per department:");
foreach (var group in result15)
{
    var topSalaries = group.OrderByDescending(e => e.Salary).Take(2);
    Console.Write($"{group.Key}: ");
    foreach (var s in topSalaries)
        Console.Write($"{s.Salary} ");
}
Console.ReadLine();

//Task -16
Console.WriteLine("Task -16");
List<CustomerOrder> orders1 = [
    new CustomerOrder { Customer = "Alice", Amount = 100 },
    new CustomerOrder { Customer = "Bob", Amount = 200 },
    new CustomerOrder { Customer = "Alice", Amount = 150 },
    new CustomerOrder { Customer = "Bob", Amount = 300 },
    new CustomerOrder { Customer = "Alice", Amount = 200 },
    new CustomerOrder { Customer = "Charlie", Amount = 50 }
];
var result16 = orders1.GroupBy(o => o.Customer).Where(g => g.Count() >= 3);
foreach (var group in result16)
{
    var avg = group.Average(o => o.Amount);
    Console.WriteLine($"{group.Key}: {avg}");
}
Console.ReadLine();

//Task -17
Console.WriteLine("Task -17");
List<int> expenses = [50, 150, 200, 75, 300, 400, 90, 500];
var result17 = expenses.Where(e => e > 100).Take(5).Sum();
Console.WriteLine($"Sum of first 5 expenses > 100: {result17}");
Console.ReadLine();

//Task -18
Console.WriteLine("Task -18");
List<YearlySale> sales2 = [
    new YearlySale { Year = 2021, Amount = 100 },
    new YearlySale { Year = 2022, Amount = 200 },
    new YearlySale { Year = 2021, Amount = 150 },
    new YearlySale { Year = 2023, Amount = 300 },
    new YearlySale { Year = 2022, Amount = 250 }
];
var result18 = sales2.GroupBy(s => s.Year)
    .Select(g => new { Year = g.Key, MaxSale = g.Max(s => s.Amount) })
    .OrderByDescending(x => x.MaxSale)
    .Take(2);

foreach (var item in result18)
    Console.WriteLine($"{item.Year}: {item.MaxSale}");
Console.ReadLine();

//Task -19
Console.WriteLine("Task -19");
List<int> scores19 = [60, 65, 68, 75, 80, 85, 90];
var result19 = scores19
    .GroupBy(s => s > 70 ? "Above 70" : "Below 70");
foreach (var group in result19)
    Console.Write($"{group.Key}: {group.Count()}");
Console.ReadLine();

//Task -20
Console.WriteLine("Task -20");
List<int> prices2= [10, 20, 30, 40, 50, 60, 70, 80];
var result20 = prices2
    .Select((value, index) => new { value, index })
    .GroupBy(x => x.index / 4)
    .Take(2);
Console.WriteLine("Task -20 Output:");
foreach (var page in result20)
{
    var total = page.Sum(x => x.value);
    Console.WriteLine(total);
}
Console.ReadLine();

