# 30 LINQ Tasks for Intermediate Level

Below are 30 intermediate-level tasks for practicing LINQ with collections, using only the following methods: `Select`, `SelectMany`, `let`, anonymous types, `Where`, `OrderBy`, `ThenBy`, `OfType`, `Except`, `Intersect`, `Union`, `Concat`, aggregate functions, `Skip`, `Take`, `TakeWhile`, `SkipWhile`. Each task includes a description, input data, and the expected output.

---

## Task 1
**Description**: Given a list of integers, filter out numbers less than 10, sort them in ascending order, and return the first 4 numbers as an anonymous type with a field `Value`.

**Input**:
```csharp
var numbers = new List<int> { 5, 12, 3, 15, 8, 20, 7, 11 };
```

**Expected Output**:
```
{ Value = 11 }, { Value = 12 }, { Value = 15 }, { Value = 20 }
```

---

## Task 2
**Description**: Given a list of strings, select strings that contain the letter 'e', sort them by length, and return an anonymous type with a field `Word`.

**Input**:
```csharp
var words = new List<string> { "cat", "elephant", "dog", "bee", "apple" };
```

**Expected Output**:
```
{ Word = "bee" }, { Word = "apple" }, { Word = "elephant" }
```

---

## Task 3
**Description**: Given a list of lists of integers, use `SelectMany` to flatten the lists, filter numbers greater than 3, sort them in descending order, and return an anonymous type with a field `Number`.

**Input**:
```csharp
var numberLists = new List<List<int>> 
{ 
    new List<int> { 1, 4, 2 }, 
    new List<int> { 6, 3, 5 }, 
    new List<int> { 8, 7, 1 } 
};
```

**Expected Output**:
```
{ Number = 8 }, { Number = 7 }, { Number = 6 }, { Number = 5 }, { Number = 4 }
```

---

## Task 4
**Description**: Given a mixed list of objects (strings and integers), use `OfType` to select only integers, skip the first 2, take the next 3, and return an anonymous type with a field `Value`, sorted in ascending order.

**Input**:
```csharp
var mixed = new List<object> { "apple", 5, "banana", 2, 8, 1, 9 };
```

**Expected Output**:
```
{ Value = 1 }, { Value = 2 }, { Value = 8 }
```

---

## Task 5
**Description**: Given two lists of strings, find their intersection using `Intersect`, sort alphabetically, and return an anonymous type with a field `Text`.

**Input**:
```csharp
var list1 = new List<string> { "apple", "banana", "cat" };
var list2 = new List<string> { "banana", "dog", "apple" };
```

**Expected Output**:
```
{ Text = "apple" }, { Text = "banana" }
```

---

## Task 6
**Description**: Given a list of integers, use `let` to compute the cube of each number, filter those with cubes less than 100, and return an anonymous type with fields `Number` and `Cube`, sorted by cube.

**Input**:
```csharp
var numbers = new List<int> { 1, 2, 3, 4, 5 };
```

**Expected Output**:
```
{ Number = 1, Cube = 1 }, { Number = 2, Cube = 8 }, { Number = 3, Cube = 27 }, { Number = 4, Cube = 64 }
```

---

## Task 7
**Description**: Given two lists of integers, combine them using `Union`, skip numbers less than or equal to 4 using `SkipWhile`, and return the first 3 numbers as an anonymous type with a field `Value`, sorted in ascending order.

**Input**:
```csharp
var list1 = new List<int> { 1, 3, 5, 7 };
var list2 = new List<int> { 2, 4, 6, 8 };
```

**Expected Output**:
```
{ Value = 5 }, { Value = 6 }, { Value = 7 }
```

---

## Task 8
**Description**: Given a list of integers, calculate the product of all numbers greater than 2 using an aggregate function, and return an anonymous type with a field `Product`.

**Input**:
```csharp
var numbers = new List<int> { 1, 3, 4, 2, 5 };
```

**Expected Output**:
```
{ Product = 60 }
```

---

## Task 9
**Description**: Given two lists of integers, find numbers in the first list that are not in the second using `Except`, sort them in descending order, and return an anonymous type with a field `Number`.

**Input**:
```csharp
var list1 = new List<int> { 1, 2, 3, 4, 5 };
var list2 = new List<int> { 2, 4, 6 };
```

**Expected Output**:
```
{ Number = 5 }, { Number = 3 }, { Number = 1 }
```

---

## Task 10
**Description**: Given a list of strings, take strings until one with length greater than 4 is encountered using `TakeWhile`, sort alphabetically, and return an anonymous type with a field `Word`.

**Input**:
```csharp
var words = new List<string> { "cat", "dog", "apple", "bird" };
```

**Expected Output**:
```
{ Word = "cat" }, { Word = "dog" }
```

---

## Task 11
**Description**: Given a list of lists of strings, use `SelectMany` to flatten the lists, concatenate with another list of strings using `Concat`, filter strings containing 'a', and return the first 3 as an anonymous type with a field `Text`, sorted by length.

**Input**:
```csharp
var stringLists = new List<List<string>> 
{ 
    new List<string> { "cat", "dog" }, 
    new List<string> { "apple", "bat" } 
};
var extra = new List<string> { "banana", "rat" };
```

**Expected Output**:
```
{ Text = "cat" }, { Text = "bat" }, { Text = "apple" }
```

---

## Task 12
**Description**: Given a list of integers, filter numbers divisible by 3, sort by ascending order, and return an anonymous type with a field `Value`.

**Input**:
```csharp
var numbers = new List<int> { 3, 5, 6, 8, 9, 12 };
```

**Expected Output**:
```
{ Value = 3 }, { Value = 6 }, { Value = 9 }, { Value = 12 }
```

---

## Task 13
**Description**: Given a mixed list of objects (strings and doubles), use `OfType` to select only doubles, take the first 2, and return an anonymous type with a field `Number`, sorted in descending order.

**Input**:
```csharp
var mixed = new List<object> { "test", 3.5, "data", 1.2, 4.8 };
```

**Expected Output**:
```
{ Number = 3.5 }, { Number = 1.2 }
```

---

## Task 14
**Description**: Given a list of strings, use `let` to compute the length of each string, filter those with length greater than 3, and return an anonymous type with fields `Word` and `Length`, sorted by length then alphabetically.

**Input**:
```csharp
var words = new List<string> { "cat", "apple", "dog", "banana" };
```

**Expected Output**:
```
{ Word = "apple", Length = 5 }, { Word = "banana", Length = 6 }
```

---

## Task 15
**Description**: Given two lists of strings, combine them using `Concat`, skip the first 3 strings, and return the next 3 as an anonymous type with a field `Text`, sorted alphabetically.

**Input**:
```csharp
var list1 = new List<string> { "apple", "banana" };
var list2 = new List<string> { "cat", "dog", "elephant" };
```

**Expected Output**:
```
{ Text = "cat" }, { Text = "dog" }, { Text = "elephant" }
```

---

## Task 16
**Description**: Given a list of integers, calculate the sum of numbers less than 8 using an aggregate function, and return an anonymous type with a field `Sum`.

**Input**:
```csharp
var numbers = new List<int> { 2, 9, 4, 6, 10 };
```

**Expected Output**:
```
{ Sum = 12 }
```

---

## Task 17
**Description**: Given a list of lists of integers, use `SelectMany` to flatten the lists, filter numbers less than 5, sort in ascending order, and return an anonymous type with a field `Value`.

**Input**:
```csharp
var numberLists = new List<List<int>> 
{ 
    new List<int> { 1, 6, 3 }, 
    new List<int> { 2, 4, 7 } 
};
```

**Expected Output**:
```
{ Value = 1 }, { Value = 2 }, { Value = 3 }, { Value = 4 }
```

---

## Task 18
**Description**: Given two lists of integers, find their union using `Union`, sort in descending order, and return an anonymous type with a field `Number`.

**Input**:
```csharp
var list1 = new List<int> { 1, 2, 3 };
var list2 = new List<int> { 2, 3, 4 };
```

**Expected Output**:
```
{ Number = 4 }, { Number = 3 }, { Number = 2 }, { Number = 1 }
```

---

## Task 19
**Description**: Given a list of strings, skip strings until one starting with 'b' is encountered using `SkipWhile`, take the next 2, and return an anonymous type with a field `Word`, sorted alphabetically.

**Input**:
```csharp
var words = new List<string> { "apple", "cat", "banana", "dog" };
```

**Expected Output**:
```
{ Word = "banana" }, { Word = "dog" }
```

---

## Task 20
**Description**: Given a list of integers, use `let` to compute the square of each number, filter those with squares greater than 10, and return an anonymous type with fields `Number` and `Square`, sorted by square.

**Input**:
```csharp
var numbers = new List<int> { 1, 2, 3, 4, 5 };
```

**Expected Output**:
```
{ Number = 4, Square = 16 }, { Number = 5, Square = 25 }
```

---

## Task 21
**Description**: Given two lists of strings, find strings in the first list that are not in the second using `Except`, sort by length, and return an anonymous type with a field `Text`.

**Input**:
```csharp
var list1 = new List<string> { "apple", "banana", "cat" };
var list2 = new List<string> { "banana", "dog" };
```

**Expected Output**:
```
{ Text = "cat" }, { Text = "apple" }
```

---

## Task 22
**Description**: Given a list of integers, take numbers until one greater than 6 is encountered using `TakeWhile`, sort in ascending order, and return an anonymous type with a field `Value`.

**Input**:
```csharp
var numbers = new List<int> { 2, 4, 6, 8, 10 };
```

**Expected Output**:
```
{ Value = 2 }, { Value = 4 }, { Value = 6 }
```

---

## Task 23
**Description**: Given a mixed list of objects (integers and strings), use `OfType` to select only integers, filter those greater than 3, sort in descending order, and return an anonymous type with a field `Number`.

**Input**:
```csharp
var mixed = new List<object> { 2, "apple", 5, "banana", 4 };
```

**Expected Output**:
```
{ Number = 5 }, { Number = 4 }
```

---

## Task 24
**Description**: Given a list of lists of strings, use `SelectMany` to flatten the lists, filter strings longer than 3 characters, sort alphabetically, and return an anonymous type with a field `Word`.

**Input**:
```csharp
var stringLists = new List<List<string>> 
{ 
    new List<string> { "cat", "apple" }, 
    new List<string> { "dog", "banana" } 
};
```

**Expected Output**:
```
{ Word = "apple" }, { Word = "banana" }
```

---

## Task 25
**Description**: Given two lists of integers, combine them using `Union`, filter numbers divisible by 2, sort in ascending order, and return an anonymous type with a field `Value`.

**Input**:
```csharp
var list1 = new List<int> { 1, 2, 3, 4 };
var list2 = new List<int> { 4, 5, 6 };
```

**Expected Output**:
```
{ Value = 2 }, { Value = 4 }, { Value = 6 }
```

---

## Task 26
**Description**: Given a list of strings, calculate the total length of strings containing 'a' using an aggregate function, and return an anonymous type with a field `TotalLength`.

**Input**:
```csharp
var words = new List<string> { "cat", "apple", "dog", "banana" };
```

**Expected Output**:
```
{ TotalLength = 14 }
```

---

## Task 27
**Description**: Given a list of integers, skip the first 2 numbers, take the next 3, sort in descending order, and return an anonymous type with a field `Number`.

**Input**:
```csharp
var numbers = new List<int> { 1, 2, 5, 3, 4, 6 };
```

**Expected Output**:
```
{ Number = 5 }, { Number = 4 }, { Number = 3 }
```

---

## Task 28
**Description**: Given two lists of strings, find their intersection using `Intersect`, skip the first one, and return an anonymous type with a field `Text`, sorted alphabetically.

**Input**:
```csharp
var list1 = new List<string> { "apple", "banana", "cat" };
var list2 = new List<string> { "banana", "cat", "dog" };
```

**Expected Output**:
```
{ Text = "cat" }
```

---

## Task 29
**Description**: Given a list of integers, use `let` to compute the double of each number, filter those with doubles less than 10, and return an anonymous type with fields `Number` and `Double`, sorted by double.

**Input**:
```csharp
var numbers = new List<int> { 1, 2, 3, 4, 5 };
```

**Expected Output**:
```
{ Number = 1, Double = 2 }, { Number = 2, Double = 4 }, { Number = 3, Double = 6 }, { Number = 4, Double = 8 }
```

---

## Task 30
**Description**: Given a list of lists of integers, use `SelectMany` to flatten the lists, skip numbers until one greater than 5 is encountered using `SkipWhile`, take the next 3, and return an anonymous type with a field `Value`, sorted in ascending order.

**Input**:
```csharp
var numberLists = new List<List<int>> 
{ 
    new List<int> { 1, 3, 6 }, 
    new List<int> { 2, 7, 4 } 
};
```

**Expected Output**:
```
{ Value = 2 }, { Value = 4 }, { Value = 7 }
```

---