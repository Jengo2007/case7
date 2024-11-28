// See https://aka.ms/new-console-template for more information
Console.WriteLine("1-килограмм,2-миллиграмм,3-грамм,4-тонна,5-центнер");
var vazn =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выберите число:");
var kg = Convert.ToInt32(Console.ReadLine());
double result =0;
switch (vazn)
{
    case 1:
        result = kg;
        break;
    case 2:
        result = kg * 1000000;
        break;
    case 3:
        result = kg * 1000;
        break;
    case 4:
        result = kg * 1000;
        break;
    case 5:
        result = kg * 100;
        break;
    default:
        Console.WriteLine("Nenhum valor informado");
        return;
}

Console.WriteLine($"Масса в килограммах:{result}");