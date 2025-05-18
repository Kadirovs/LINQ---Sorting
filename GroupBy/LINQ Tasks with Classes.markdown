# 20 Medium-Level LINQ Tasks: Skip, Take, Aggregate Methods, and GroupBy with Class Definitions

Below are 20 programming tasks designed to practice `Skip`, `Take`, aggregate methods (e.g., `Sum`, `Average`, `Min`, `Max`, `Count`), and `GroupBy` operations in LINQ (C#). Each task is of medium difficulty and includes class definitions for structured data where applicable. The tasks provide a description, input data, and expected output format. Solutions are not provided, but example outputs clarify the expected results.

## Task 1: Paginate Student Scores
Given a list of student scores, retrieve the 3rd page of scores (3 scores per page) ordered by score descending.
- **Input**: `List<int> scores = [85, 92, 78, 95, 88, 91, 75, 82, 89, 93]`
- **Output**: List of scores on the 3rd page
- **Example Output**: `[88, 85, 82]`

## Task 2: Top 5 Average
Calculate the average of the top 5 scores from a list of exam results.
- **Input**: `List<int> scores = [60, 75, 80, 95, 85, 90, 70, 88]`
- **Output**: Average of top 5 scores
- **Example Output**: `87.6`

## Task 3: Skip Failing Grades
From a list of grades, skip all failing grades (< 60) and take the first 4 passing grades.
- **Input**: `List<int> grades = [55, 78, 45, 82, 90, 67, 58, 85]`
- **Output**: First 4 passing grades
- **Example Output**: `[78, 82, 90, 67]`

## Task 4: Group Students by Grade Range
Group students by their grade ranges (0-59, 60-79, 80-100) and count the number in each range.
- **Input**: `List<int> grades = [45, 78, 92, 55, 85, 60, 72, 88]`
- **Output**: Dictionary with grade range as key and count as value
- **Example Output**: `{ "0-59": 2, "60-79": 3, "80-100": 3 }`

## Task 5: Total Sales by Region
Given a list of sales records, group by region and calculate the total sales amount for each region, skipping the first 2 regions after sorting by region name.
- **Class Definition**:
  ```csharp
  public class Sale
  {
      public string Region { get; set; }
      public int Amount { get; set; }
  }
  ```
- **Input**: `List<Sale> sales = [new Sale { Region = "North", Amount = 100 }, new Sale { Region = "South", Amount = 150 }, new Sale { Region = "East", Amount = 200 }, new Sale { Region = "West", Amount = 120 }, new Sale { Region = "North", Amount = 80 }, new Sale { Region = "South", Amount = 90 }]`
- **Output**: Dictionary with region as key and total sales as value, excluding the first 2 regions alphabetically
- **Example Output**: `{ "North": 180, "West": 120 }`

## Task 6: Average Scores by Class
Group students by class and calculate the average score for each class, taking only the top 3 classes by average score.
- **Class Definition**:
  ```csharp
  public class StudentScore
  {
      public string ClassName { get; set; }
      public int Score { get; set; }
  }
  ```
- **Input**: `List<StudentScore> scores = [new StudentScore { ClassName = "Math", Score = 85 }, new StudentScore { ClassName = "Science", Score = 90 }, new StudentScore { ClassName = "Math", Score = 75 }, new StudentScore { ClassName = "History", Score = 80 }, new StudentScore { ClassName = "Science", Score = 95 }, new StudentScore { ClassName = "History", Score = 70 }]`
- **Output**: List of class names and their average scores, top 3 only
- **Example Output**: `[("Science", 92.5), ("Math", 80), ("History", 75)]`

## Task 7: Skip Lowest Salaries
From a list of employee salaries, skip the 3 lowest salaries and calculate the average of the next 5.
- **Input**: `List<int> salaries = [30000, 45000, 25000, 60000, 40000, 55000, 35000, 50000]`
- **Output**: Average of the 5 salaries after skipping the 3 lowest
- **Example Output**: `49000`

## Task 8: Group Orders by Month
Group customer orders by month and calculate the total order amount for each month, taking only the top 2 months by total.
- **Class Definition**:
  ```csharp
  public class Order
  {
      public DateTime Date { get; set; }
      public int Amount { get; set; }
  }
  ```
- **Input**: `List<Order> orders = [new Order { Date = new DateTime(2023, 1, 1), Amount = 100 }, new Order { Date = new DateTime(2023, 1, 15), Amount = 200 }, new Order { Date = new DateTime(2023, 2, 1), Amount = 150 }, new Order { Date = new DateTime(2023, 3, 1), Amount = 300 }]`
- **Output**: List of months and their total order amounts, top 2 only
- **Example Output**: `[(January 2023, 300), (March 2023, 300)]`

## Task 9: Take Every Nth Record
From a list of transactions, take every 3rd transaction and calculate their total amount.
- **Input**: `List<int> transactions = [50, 100, 150, 200, 250, 300, 350, 400]`
- **Output**: Total of every 3rd transaction
- **Example Output**: `600`

## Task 10: Group by Product Category
Group products by category and find the maximum price in each category, skipping categories with fewer than 2 products.
- **Class Definition**:
  ```csharp
  public class Product
  {
      public string Category { get; set; }
      public int Price { get; set; }
  }
  ```
- **Input**: `List<Product> products = [new Product { Category = "Electronics", Price = 500 }, new Product { Category = "Clothing", Price = 50 }, new Product { Category = "Electronics", Price = 700 }, new Product { Category = "Books", Price = 20 }, new Product { Category = "Clothing", Price = 80 }]`
- **Output**: Dictionary with category as key and max price as value
- **Example Output**: `{ "Electronics": 700, "Clothing": 80 }`

## Task 11: Skip and Take by Condition
From a list of ages, skip ages below 18 and take the first 3 ages that are 65 or older.
- **Input**: `List<int> ages = [15, 70, 25, 68, 17, 66, 30]`
- **Output**: First 3 ages >= 65
- **Example Output**: `[70, 68, 66]`

## Task 12: Aggregate Scores by Team
Group players by team and calculate the total score for each team, taking only teams with more than 2 players.
- **Class Definition**:
  ```csharp
  public class Player
  {
      public string Team { get; set; }
      public int Score { get; set; }
  }
  ```
- **Input**: `List<Player> players = [new Player { Team = "Red", Score = 10 }, new Player { Team = "Blue", Score = 15 }, new Player { Team = "Red", Score = 20 }, new Player { Team = "Blue", Score = 25 }, new Player { Team = "Green", Score = 30 }]`
- **Output**: Dictionary with team as key and total score as value
- **Example Output**: `{ "Red": 30, "Blue": 40 }`

## Task 13: Skip and Sum
From a list of donations, skip the first 2 donations and sum the next 4.
- **Input**: `List<int> donations = [100, 200, 300, 400, 500, 600, 700]`
- **Output**: Sum of the 4 donations after skipping the first 2
- **Example Output**: `1800`

## Task 14: Group by Price Range
Group items by price range (0-50, 51-100, 101-200) and count items in each range, taking only ranges with more than 1 item.
- **Input**: `List<int> prices = [30, 75, 120, 45, 90, 150]`
- **Output**: Dictionary with price range as key and count as value
- **Example Output**: `{ "0-50": 2, "51-100": 2, "101-200": 2 }`

## Task 15: Top N by Group
Group employees by department and take the top 2 employees by salary in each department.
- **Class Definition**:
  ```csharp
  public class Employee
  {
      public string Department { get; set; }
      public int Salary { get; set; }
  }
  ```
- **Input**: `List<Employee> employees = [new Employee { Department = "HR", Salary = 50000 }, new Employee { Department = "IT", Salary = 60000 }, new Employee { Department = "HR", Salary = 55000 }, new Employee { Department = "IT", Salary = 70000 }, new Employee { Department = "Sales", Salary = 45000 }]`
- **Output**: List of department and top 2 salaries
- **Example Output**: `[("HR", [55000, 50000]), ("IT", [70000, 60000]), ("Sales", [45000])]`

## Task 16: Skip and Average by Group
Group orders by customer and calculate the average order amount for each customer, skipping customers with fewer than 3 orders.
- **Class Definition**:
  ```csharp
  public class CustomerOrder
  {
      public string Customer { get; set; }
      public int Amount { get; set; }
  }
  ```
- **Input**: `List<CustomerOrder> orders = [new CustomerOrder { Customer = "Alice", Amount = 100 }, new CustomerOrder { Customer = "Bob", Amount = 200 }, new CustomerOrder { Customer = "Alice", Amount = 150 }, new CustomerOrder { Customer = "Bob", Amount = 300 }, new CustomerOrder { Customer = "Alice", Amount = 200 }, new CustomerOrder { Customer = "Charlie", Amount = 50 }]`
- **Output**: Dictionary with customer as key and average amount as value
- **Example Output**: `{ "Alice": 150 }`

## Task 17: Take and Sum by Condition
From a list of expenses, take the first 5 expenses greater than 100 and calculate their sum.
- **Input**: `List<int> expenses = [50, 150, 200, 75, 300, 400, 90, 500]`
- **Output**: Sum of the first 5 expenses > 100
- **Example Output**: `1550`

## Task 18: Group by Year and Max
Group sales by year and find the maximum sale amount for each year, taking only the top 2 years by max sale.
- **Class Definition**:
  ```csharp
  public class YearlySale
  {
      public int Year { get; set; }
      public int Amount { get; set; }
  }
  ```
- **Input**: `List<YearlySale> sales = [new YearlySale { Year = 2021, Amount = 100 }, new YearlySale { Year = 2022, Amount = 200 }, new YearlySale { Year = 2021, Amount = 150 }, new YearlySale { Year = 2023, Amount = 300 }, new YearlySale { Year = 2022, Amount = 250 }]`
- **Output**: List of years and their max sale amounts, top 2 only
- **Example Output**: `[(2023, 300), (2022, 250)]`

## Task 19: Skip and Group
From a list of scores, skip the first 3 scores and group the rest by whether they are above or below 70, counting each group.
- **Input**: `List<int> scores = [60, 65, 68, 75, 80, 85, 90]`
- **Output**: Dictionary with "Above 70" or "Below 70" as key and count as value
- **Example Output**: `{ "Above 70": 3, "Below 70": 1 }`

## Task 20: Aggregate and Paginate
From a list of product prices, calculate the total price for each page (4 products per page) and return the totals for the first 2 pages.
- **Input**: `List<int> prices = [10, 20, 30, 40, 50, 60, 70, 80]`
- **Output**: List of total prices for the first 2 pages
- **Example Output**: `[100, 260]`