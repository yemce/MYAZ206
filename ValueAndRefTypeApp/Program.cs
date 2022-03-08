using ValueAndReferenceTypes;

//var p1 = new RefType
//{
//    X = 10,
//    Y = 20
//};

//var p2 = p1;
//p2.X = 30;

//Console.WriteLine($"p1 : {p1.X} {p1.Y}");
//Console.WriteLine($"p2 : {p2.X} {p2.Y}");


var p1 = new ValueAndReferenceTypes.ValueType
{
    X = 10,
    Y = 20
};

var p2 = p1;
p2.X = 30;

Console.WriteLine($"p1 : {p1.X} {p1.Y}");
Console.WriteLine($"p2 : {p2.X} {p2.Y}");



