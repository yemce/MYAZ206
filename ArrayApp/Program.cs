var arr = Array.CreateInstance(typeof(int), 4);

arr.SetValue(5, 0);
arr.SetValue(10, 1);
arr.SetValue(15, 2);
arr.SetValue(20, 3);

Console.WriteLine(arr.GetValue(0));

try
{
    Console.WriteLine(arr.GetValue(5));

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

foreach (var item in arr)
{
    Console.WriteLine(item);
}

var _arr = new DataStructures.Array.Array(1,2,3);

foreach (var item in _arr)
{
    Console.WriteLine(item);
}
Console.ReadKey();