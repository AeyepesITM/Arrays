using Arrays.Logic;

try
{
    Console.WriteLine("Hello, Arrays!\n");
    MyArray array = new(50);
    array.Fill();
    Console.WriteLine($"----------------------------------");
    Console.WriteLine(array);

    Console.WriteLine($"----------------------------------");
    var odds = array.GetOdds();
    Console.WriteLine(odds);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}