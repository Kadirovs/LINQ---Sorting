//Task -1
Console.WriteLine("Task -1");
List<Employee> employees = new List<Employee>
{
    new Employee { Name = "Алексей", Age = 25, Position = "Разработчик" },
    new Employee { Name = "Мария", Age = 32, Position = "Менеджер" },
    new Employee { Name = "Иван", Age = 35, Position = "Аналитик" }
};
var result1= employees.Where(g => g.Age > 30)
    .Select(e => new { Name = e.Name, Age = e.Age });
foreach (var item in result1)
    Console.Write(item);
Console.ReadLine();

//Task -2
Console.WriteLine("Task -2");