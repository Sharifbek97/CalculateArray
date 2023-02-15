Console.Write("\tEnter your value n ");
double summa=0;
double everagy=0;
var n = int.Parse(Console.ReadLine());
var array=new int[n];
Console.Write("\tElements of array ");
var rnd = new Random();
for (var i = 0; i < n; ++i)
{
    array[i] = rnd.Next(-20, 40);
    Console.Write("  "+array[i]);
    summa +=array[i] ;
    everagy = (summa / n);
}
Console.Write("\n\tSumma "+summa);
Console.Write("\n\tEveragy of arithmetic " + everagy);

