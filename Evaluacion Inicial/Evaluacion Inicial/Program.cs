// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
DateTime ahora = DateTime.Now;
if (ahora.Hour > 14)
{
    Console.WriteLine("Buenas Tardes");
} else {
    Console.WriteLine("Buenos Dias");
}
Console.WriteLine($"Son las {ahora:t} del {ahora:D}");

Console.WriteLine("Introduce tu frase");
String frase = Console.ReadLine();
Console.WriteLine();    
Console.WriteLine("Tu frase letra por letra");
for(int i = 0; i < frase.Length; i++)
{
    Console.WriteLine(frase[i]);
}
Console.WriteLine();
Console.WriteLine("Tu frase al reves");
Console.WriteLine();
for (int i = frase.Length-1; i >= 0; i--)
{ 
    Console.Write(frase[i]);
}
Console.WriteLine();
String[] palabras = frase.Split(" ");
Console.WriteLine($"Tu frase tiene {palabras.Length} palabras");
String[] desordenada = new String[palabras.Length];

int cont = 0;
do
{
    Random r = new Random();    
    int posi = r.Next(palabras.Length);
    if (!desordenada.Contains(palabras[posi]))
    {
        desordenada[cont] = palabras[posi];
        cont++;
    }
} while (cont<palabras.Length);

foreach(String palabra in desordenada)
{
    Console.Write(palabra + " ");
}
