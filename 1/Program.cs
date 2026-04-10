// Solicitar al usuario la cantidad n de números enteros y 
//almacenarlos en un arreglo. Luego, recorrer el arreglo para calcular 
//el promedio general. Después, mostrar en pantalla el promedio y 
//listar únicamente los valores que están por encima del promedio. 
//Finalmente, indicar cuántos números cumplen esa condición.


int suma = 0;
Console.WriteLine("Ingrese la cantidad de números que quiera guardar:");
int n;

while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("Error ingrese un número válido mayor que 0");
}

int[] numeros = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Ingrese el número {i + 1}");

    while (!int.TryParse(Console.ReadLine(), out numeros[i]))
    {
        Console.WriteLine("Ingrese un número válido");
    }
}



for (int i = 0; i < n; i++)
{
    suma += numeros[i];
}

double promedio = (double)suma / n;

Console.WriteLine("El promedio total es = " + promedio);
