// Task -1
Console.WriteLine("Task -1");
var numbers1 = new List<int> { 5, 12, 3, 15, 8, 20, 7, 11 };
var result1 = numbers1.Where(n => n > 10).OrderBy(n => n)
    .Take(4)
    .Select(n => new { Value = n });

foreach (var item in result1)
    Console.Write($"{item}, ");
Console.ReadLine();

//Task -2
Console.WriteLine("Task -2");
var words = new List<string> { "cat", "elephant", "dog", "bee", "apple" };
var result2 = words.Where(w => w.Contains('e')).OrderBy(w => w.Length)
    .Select(w => new { Word = w });

foreach (var item in result2)
    Console.Write(item);
Console.ReadLine();

//Task -3
Console.WriteLine("Task -3");
var numberLists = new List<List<int>> 
{ 
    new List<int> { 1, 4, 2 }, 
    new List<int> { 6, 3, 5 }, 
    new List<int> { 8, 7, 1 } 
};

var result3 = from numlist in numberLists
    from n in numlist
    where n > 3
    orderby n descending
    select new { Number = n};

foreach (var item in result3)
    Console.Write(item);
Console.ReadLine(); 

//Task -4
Console.WriteLine("Task -4");
var mixed = new List<object> { "apple", 5, "banana", 2, 8, 1, 9 }; // 5 2 8 1 9
var result4 = mixed.OfType<int>().Skip(2)
    .Take(3)
    .OrderBy(n => n)
    .Select(n => new { Value = n });

foreach (var item in result4)
    Console.Write(item);
Console.ReadLine();

//Task -5
Console.WriteLine("Task -5");
var list1 = new List<string> { "apple", "banana", "cat" };
var list2 = new List<string> { "banana", "dog", "apple" };
var result5 = list1.Intersect(list2).OrderBy(s => s).Select(s => new { Text = s });
foreach (var item in result5)
    Console.Write(item);
Console.ReadLine();

//Task -6
Console.WriteLine("Task -6");
var numbers = new List<int> { 1, 2, 3, 4, 5 };
var result6 = from n in numbers
    let cube = n*n*n
    where cube < 100
    select new { Number = n, Cube = cube };
foreach (var item in result6)
    Console.Write(item);
Console.ReadLine();

//Task -7
Console.WriteLine("Task -7 ");
var list3 = new List<int> { 1, 3, 5, 7 };
var list4 = new List<int> { 2, 4, 6, 8 };
var result7 = list3.Union(list4).OrderBy(n => n)
    .SkipWhile(n => n <= 4).Take(3)
    .Select(n => new { Value = n });
foreach (var item in result7)
    Console.Write(item);
Console.ReadLine();

//Task -8
Console.WriteLine("Task -8");
var numbers3 = new List<int> { 1, 3, 4, 2, 5 };
var product = numbers3.Where(n => n>2).Aggregate((product,n)=> product*n);
var  result  = new  { Product = product };
    Console.Write(result);
Console.ReadLine();

//Task -9
Console.WriteLine("Task -9");
var list5 = new List<int> { 1, 2, 3, 4, 5 };
var list6 = new List<int> { 2, 4, 6 };
var result8 = list5.Except(list6).OrderByDescending(n => n)
    .Select(n => new { Number = n });
foreach (var item in result8)
    Console.Write(item);
Console.ReadLine();

//Task -10
Console.WriteLine("Task -10");
var words2 = new List<string> { "cat", "dog", "apple", "bird" };
var result9 = words2.TakeWhile(w => w.Length < 5).OrderBy(w => w)
    .Select(w => new { Word = w });
foreach (var item in result9)
    Console.Write(item);
Console.ReadLine();

//Task -11
Console.WriteLine("Task -11");
var stringLists = new List<List<string>> 
{ 
    new List<string> { "cat", "dog" }, 
    new List<string> { "apple", "bat" } 
};
var extra1 = new List<string> { "banana", "rat" };

var flattensequence = stringLists.SelectMany(x => x).Concat(extra1);

var result10 = (from s in flattensequence
    where s.Contains('a')
    orderby s.Length
    select new { Text = s }).Take(3);

foreach (var item in result10)
    Console.Write(item);
Console.ReadLine();

//Task -12
Console.WriteLine("Task -12");
var numbers4 = new List<int> { 3, 5, 6, 8, 9, 12 };
var results11 = numbers4.Where(n=>n%3==0).OrderBy(n => n)
    .Select(n => new { Number = n });
foreach (var item in results11)
    Console.Write(item);
Console.ReadLine();

//Task -13
Console.WriteLine("Task -13");
var mixed1 = new List<object> { "test", 3.5, "data", 1.2, 4.8 };
var result12 = mixed1.OfType<double>().OrderBy(n => n)
    .Take(2)
    .Select(n => new { Value = n });

foreach (var item in result12)
    Console.Write(item);
Console.ReadLine();

//Task-14
Console.WriteLine("Task -14");
var words3 = new List<string> { "cat", "apple", "dog", "banana" };
var result13 = from n in words3
    let length = n.Length
    where length > 3
    select new { Word = n, Length = length };
foreach (var item in result13)
    Console.Write(item);
Console.ReadLine();


//Task -15
Console.WriteLine("Task -15");
var list7 = new List<string> { "apple", "banana" };
var list8 = new List<string> { "cat", "dog", "elephant" };
var result14 = list7.Concat(list8).Skip(3).Take(3).OrderBy(s => s).Select(s => new { Text = s });
foreach (var item in result14)
    Console.Write(item);
Console.ReadLine();

//Task -16
Console.WriteLine("Task -16");
var numbers5 = new List<int> { 2, 9, 4, 6, 10 };
var result15 = numbers5.Where(n => n < 8).Sum();
var result16 = new { Sum = result15 };
Console.Write(result16);
Console.ReadLine();

//Task -17
Console.WriteLine("Task -17");
var numberLists2 = new List<List<int>> 
{ 
    new List<int> { 1, 6, 3 }, 
    new List<int> { 2, 4, 7 } 
};
var result17 = numberLists2.SelectMany(x => x).Where(n => n < 5).OrderBy(n => n)
    .Select(n => new { Value = n });
foreach (var item in result17)
    Console.Write(item);
Console.ReadLine();

//Task -18
Console.WriteLine("Task -18");
var list9 = new List<int> { 1, 2, 3 };
var list10 = new List<int> { 2, 3, 4 };
var result18 = list9.Union(list10).OrderByDescending(n => n)
    .Select(n => new { Number = n });
foreach (var item in result18)
    Console.Write(item);
Console.ReadLine();

//Task -19
Console.WriteLine("Task -19");
var words4 = new List<string> { "apple", "cat", "banana", "dog" };
var result19 = words4.SkipWhile(w => w.Length < 5).Take(2).OrderBy(w => w)
    .Select(w => new { Word = w });
foreach (var item in result19)
    Console.Write(item);
Console.ReadLine();

//Task -20
Console.WriteLine("Task -20");
var numbers6 = new List<int> { 1, 2, 3, 4, 5 };
var result20 = from n in numbers6
    let square = n*n
    where square > 10
    select new { Number = n, Square = square };
foreach (var item in result20)
    Console.Write(item);
Console.ReadLine();

//Task -21
Console.WriteLine("Task -21");
var list11 = new List<string> { "apple", "banana", "cat" };
var list12 = new List<string> { "banana", "dog" };
var result21 = list11.Except(list12).OrderBy(s => s.Length)
    .Select(s => new { Text = s });
foreach (var item in result21)
    Console.Write(item);
Console.ReadLine();

//Task -22
Console.WriteLine("Task -22");
var numbers7 = new List<int> { 2, 4, 6, 8, 10 };
var result22 = numbers7.TakeWhile(n => n < 6).OrderBy(n => n)
    .Select(n => new { Value = n });
foreach (var item in result22)
    Console.Write(item);
Console.ReadLine();

//Task -23
Console.WriteLine("Task -23");
var mixed2 = new List<object> { 2, "apple", 5, "banana", 4 };
var result23 = mixed2.OfType<int>().Where(n => n<3).OrderByDescending(n => n)
    .Select(n => new { Number = n });
foreach (var item in result23)
    Console.Write(item);
Console.ReadLine();

//Task -24
Console.WriteLine("Task -24");
var stringLists2 = new List<List<string>> 
{ 
    new List<string> { "cat", "apple" }, 
    new List<string> { "dog", "banana" } 
};
var result24 = stringLists2.SelectMany(x => x).Where(w => w.Length > 3).OrderBy(w => w)
    .Select(w => new { Word = w });
foreach (var item in result24)
    Console.Write(item);
Console.ReadLine();

//Task -25
Console.WriteLine("Task -25");
var list13 = new List<int> { 1, 2, 3, 4 };
var list14 = new List<int> { 4, 5, 6 };
var result25 = list13.Union(list14).Where(n => n % 2 == 0).OrderBy(n => n)
    .Select(n => new { Value = n });
foreach (var item in result25)
    Console.Write(item);
Console.ReadLine();

//Task -26
Console.WriteLine("Task -26");
var words8 = new List<string> { "cat", "apple", "dog", "banana" };
var result26 = words8.Where(w => w.Contains('a')).Sum(w => w.Length);
var result27 = new { TotalLength = result26 };
Console.Write(result27);
Console.ReadLine();

//Task -27
Console.WriteLine("Task -27");
var numbers8 = new List<int> { 1, 2, 5, 3, 4, 6 };
var result28 = numbers8.Skip(2).Take(3).OrderByDescending(n => n)
    .Select(n => new { Number = n });
foreach (var item in result28)
    Console.Write(item);

//Task -28
Console.WriteLine("Task -28");
var list15 = new List<string> { "apple", "banana", "cat" };
var list16 = new List<string> { "banana", "cat", "dog" };
var result29 = list15.Intersect(list16).OrderBy(s => s).Select(s => new { Text = s });
foreach (var item in result29)
    Console.Write(item);
Console.ReadLine();

//Task -29
Console.WriteLine("Task -29");
var numbers9 = new List<int> { 1, 2, 3, 4, 5 };
var result30 = from n in numbers9
    let doubled = n*2
    where doubled < 10
    select new { Number = n, Double = doubled };
foreach (var item in result30)
    Console.Write(item);
Console.ReadLine();

//Task -30
Console.WriteLine("Task -30");
var numberLists3 = new List<List<int>> 
{ 
    new List<int> { 1, 3, 6 }, 
    new List<int> { 2, 7, 4 } 
};
var result31 = numberLists3.SelectMany(x => x).SkipWhile(n => n < 5).Take(3).OrderBy(n => n)
    .Select(n => new { Value = n });
foreach (var item in result31)
    Console.Write(item);
Console.ReadLine();


    






