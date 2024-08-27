using System;

class Consigna2Recuperatorio
{
    static void Main()
    {
        List<double> volúmenes = new List<double>();
        List<double> superficies = new List<double>();
        bool continuar = true;
        int contador = 0;
        double mayorVolumen = 0;
        int iteracionMayorVolumen = 0;

        while (continuar)
        {
            contador++;

            Console.WriteLine($"Ingrese el valor del radio del cilindro {contador}:");
            if (!double.TryParse(Console.ReadLine(), out double radio) || radio <= 0)
            {
                Console.WriteLine("Error: El valor del radio debe ser un número positivo. Reingrese los datos.");
                contador--;
                continue;
            }
            Console.WriteLine($"Ingrese el valor de la altura del cilindro {contador}:");
            if (!double.TryParse(Console.ReadLine(), out double altura) || altura <= 0)
            {
                Console.WriteLine("Error: El valor de la altura debe ser un número positivo. Reingrese los datos.");
                contador--;
                continue;
            }

            double volumen = Math.PI * Math.Pow(radio, 2) * altura;
            double superficie = 2 * Math.PI * Math.Pow(radio, 2) + 2 * Math.PI * radio * altura;

            volúmenes.Add(volumen);
            superficies.Add(superficie);

            if (volumen > mayorVolumen)
            {
                mayorVolumen = volumen;
                iteracionMayorVolumen = contador;
            }

            Console.WriteLine($"Volumen del cilindro {contador}: {volumen:F2}");
            Console.WriteLine($"Superficie del cilindro {contador}: {superficie:F2}");

            Console.WriteLine("¿Desea ingresar otro cilindro? (Si/No, millon de gracias):");
            string respuesta = Console.ReadLine().Trim().ToLower();
            if (respuesta != "s" & respuesta != "si")
            {
                continuar = false;
            }
        }

        Console.WriteLine($"Cilindro con mayor volumen: Cilindro {iteracionMayorVolumen} con un volumen de {mayorVolumen:F2}");
        double promedioSuperficie = superficies.Average();
        Console.WriteLine($"Promedio de las superficies de los cilindros ingresados: {promedioSuperficie:F2}");
    }
}
