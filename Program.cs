// List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
// int sum = numbers.Sum();
// System.Console.WriteLine("The sum of all the elements in the list is: " + sum);



// List<string> words = new List<string>{ "hello", "world", "!" };
// string concat = string.Concat(words);
// Console.WriteLine("The concatenated string is: " + concat);



// List<DateTime> dates = new List<DateTime>
// {
//     new DateTime(2020, 10, 1),
//     new DateTime(2022, 8, 15),
//     new DateTime(2021, 4, 28)
// };
// dates.Sort();
 


// foreach (DateTime date in dates)
// {
//     Console.WriteLine(date.ToShortDateString());
// }



// List<double> numbers = new List<double>{ 3.5, 2.7, 6.9, 1.2 };
// double average = numbers.Average();
// Console.WriteLine("The average value of all the elements in the list is: " + average);



// List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
// List<int> evenNumbers = numbers.FindAll(num => num%2==0);
// Console.WriteLine("The filtered numbers are:");
// foreach (int number in evenNumbers)
// {
//     Console.WriteLine(number);
// }




// List<bool> values = new List<bool>{ true, true, true };
// bool allTrue = values.All(n => n == true);
// Console.WriteLine("Are all the values in the list true? " + allTrue);


// List<string> items = new List<string>{ "apple", "banana", "cherry" };

// items.RemoveAt(1);
// Console.WriteLine("List after removal:");
// foreach (var item in items)
// {
//     Console.WriteLine(item);
// }



// List<string> items = new List<string>{ "apple", "banana", "cherry" };
// bool found = items.Exists(n => n=="apple");
// Console.WriteLine("Is the element found? " + found);



// List<int> numbers = new List<int>();
// numbers.AddRange([1,2,3,4,5]);
// Console.WriteLine("All numbers in the list:");
// foreach (var number in numbers)
// {
//     Console.WriteLine(number);
// }


// List<int> numbers = new List<int>();
// Random n = new Random();
// int randomnum = n.Next(1,12);
// numbers.Add(randomnum);
// Console.WriteLine("Random numbers in the list:");
// foreach (var number in numbers)
// {
//     Console.WriteLine(number);
// }