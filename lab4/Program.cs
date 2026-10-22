//1
// int b=1;
// while(b<11)
// {
//     Console.Write($"{b} ");
//     b++;
// }
// Console.WriteLine("");
// for (int x = 1;x<11;x++)
// {
//     Console.Write($"{x} ");
// }
// int z=1;
// Console.WriteLine("");
// do
// {
//     Console.Write($"{z} ");
//     z++;
// }
// while (z<11);
//1
// for (int i =1;i<11;i++)
// {
//     Console.Write($"{i} ");
// }
// Console.WriteLine("");
// for (int i=10;i >= 1;i--)
// {
//     Console.Write($"{i} ");
// }
// Console.WriteLine("");
// for (int i=0;i <= 20;i += 2)
// {
//     Console.Write($"{i} ");
// }
//Console.WriteLine("Start!");
//2
// int lacznezloto =0;
// int powyzej10 =0;
// Console.Write("ilosc dni wyprawy:");
// int dniwyprawy = int.Parse(Console.ReadLine());
// for (int i = 1;i <= dniwyprawy;i++)
// {
// Console.Write("zloto w dniu:");
// int zloto = int.Parse(Console.ReadLine());
// lacznezloto += zloto;
// if (zloto>10)
//     {
//         powyzej10 ++;
//     }
// }
// Console.WriteLine($"{lacznezloto}");
// Console.WriteLine($"{powyzej10}");
//3
int wysokosc = int.Parse(Console.ReadLine);
for (int i;i<wysokosc;i++)
{
    for (int z; < wysokosc; z--)
    {
        Console.Write(" ");
    }
    Console.Write("*");
}
//4
// int liczbaTur;
// while (true)
// {
//     Console.Write("podaj liczbe tur od 1 do 10: ");
//     bool poprawnaLiczba = int.TryParse(Console.ReadLine(), out liczbaTur); 
//     if (!poprawnaLiczba)
//     {
//         Console.WriteLine("wpisz liczbe calkowita.");
//         continue;

//     }
//     if (liczbaTur < 1 || liczbaTur > 10)
//     {
//         Console.WriteLine("liczba musi byc w zakrese 1-10.");
//         continue;
//     }
//     break;
// }
// Console.WriteLine($"Wybrano {liczbaTur} tur.");
//5