//Task -1
Console.WriteLine("Task -1");
List<Employee> employees = new List<Employee>
{
    new Employee { Name = "Mary", Age = 25, Position = "IT Specialist" },
    new Employee { Name = "Man", Age = 32, Position = "Manager" },
    new Employee { Name = "Women", Age = 35, Position = "Analitic" }
};
var result1= employees.Where(g => g.Age > 30)
    .Select(e => new { Name = e.Name, Age = e.Position });
foreach (var item in result1)
    Console.WriteLine(item);
Console.ReadLine();

//Task -2
Console.WriteLine("Task -2");
List<Product> products = new List<Product>
{
    new Product { Name = "Apple", Price = 100 },
    new Product { Name = "Watermelon", Price = 100 },
    new Product { Name = "Banana", Price = 150 }
};
var result2 = products.OrderByDescending(p => p.Price).ThenBy(p => p.Name)
    .Select(p => new { Name = p.Name, Price = p.Price });
foreach (var item in result2)
    Console.WriteLine(item);
Console.ReadLine();

//Task -3
Console.WriteLine("Task -3");
List<Student> students = new List<Student>
{
    new Student { Name = "Anna", Course = 1 },
    new Student { Name = "Boris", Course = 1 },
    new Student { Name = "Vera", Course = 2 }
};

var result3 = students
    .GroupBy(s => s.Course)
    .Select(g => new { Course = g.Key, Count = g.Count() })
    .ToList();
foreach (var item in result3)
    Console.WriteLine(item);
Console.ReadLine();

//Task -4
Console.WriteLine("Task -4");
List<Order> store1 = new List<Order> { new Order { ProductName = "Book" }, new Order { ProductName = "Pen" } };
List<Order> store2 = new List<Order> { new Order { ProductName = "Pen" }, new Order { ProductName = "Notebook" } };
var result4 = store1.Select(o => o.ProductName)
    .Intersect(store2.Select(o => o.ProductName)).ToList();
foreach (var item in result4)
    Console.WriteLine(item);
Console.ReadLine();

//Task -5
Console.WriteLine("Task -5");
List<Sale> sales = new List<Sale>
{
    new Sale { Amount = 200 },
    new Sale { Amount = 300 },
    new Sale { Amount = 500 }
};
var result5 = sales.Sum(s => s.Amount);
var average = sales.Average(s => s.Amount);
var result6 = new { Sum = result5, Average = average };
Console.WriteLine(result6);
Console.ReadLine();

//Task -6
Console.WriteLine("Task -6");
List<Book> books = new List<Book>
{
    new Book { Title = "Война и мир" },
    new Book { Title = "Анна Каренина" },
    new Book { Title = "Преступление и наказание" }
};
var result7 = books.OrderBy(b => b.Title).Skip(1).Take(2)
    .Select(b => new { Title = b.Title });
foreach (var itemBook in result7)
    Console.WriteLine(itemBook);

//Task -7
Console.WriteLine("Task -7");
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
double average2 = numbers.Average();
bool Filter(int n) => n > average;
var result8 = numbers.Where((Func<int, bool>)Filter).ToList();
foreach (var item in result8)
    Console.WriteLine(item);
Console.ReadLine();

//Task -8
Console.WriteLine("");
