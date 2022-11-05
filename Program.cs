 //int a = 0;

//for (int i = 0; i < 100; i++)

 /*int a = new Random().Next(10, 100);
 Console.Write($"{a}\n");    

 int b1 = a / 10;
 int b2 = a % 10;

 if (b1 > b2)
     Console.Write($"max = {b1}");
 else
     Console.Write($"max = {b2}"); */  
/*int i = 0;     
int a = new Random().Next();
while (a > 1000 || a < 100)
{
    i++;
    a = new Random().Next();
}
Console.Write($"{a}    {i} ");*/

/*for (int i = 0; i < 200; i++)
{
int a = new Random().Next() % 45 * 2 + 10;
Console.Write($"{a} ");
}*/


    
/*int a = new Random().Next(99, 999);

Console.Write($"{a} -> ");

int b1 = a / 100;
int b2 = a % 10; 

Console.Write($"{b1}{b2}");*/

/*int a = new Random().Next(99, 999);

Console.Write($"{a} -> {a.ToString().Remove(1, 1)}");


//Console.Write($"{a} -> {a / 100 *10 + a % 10} ");*/

int a = new Random().Next(10, 51);
int b = new Random().Next(1, 21);

Console.Write($"{a}  {b}\n");

if (a % b == 0)
    Console.Write($"{a} и {b} - кратны");
else
    Console.Write($"остаток от деления {a} на {b} = {a % b}");



