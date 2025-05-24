using Arrays.Logic;

Console.WriteLine("Hello, Arrays!\n");

MyArray array = new(20);

array.Fill(1, 100);
Console.WriteLine("Unsorted array:\n");
Console.WriteLine(array);

array.Sort();

Console.WriteLine("Sorted array:\n");
Console.WriteLine(array);