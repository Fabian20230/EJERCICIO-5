
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;



{
    {

        int radio;
        double area;



        Console.WriteLine("Calculador del área de un circulo, ingrese el radio");
        radio = Convert.ToInt32(Console.ReadLine());
        area = Math.PI * radio * radio;
        Console.WriteLine($"El area del círculo es:" + area);

        int altura;
        int ancho;
        int perimetro;

        Console.WriteLine("Calculador del perímtro de un rectangulo, ingrese la altura");
        altura = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese el ancho");
        ancho = Convert.ToInt32(Console.ReadLine());
        perimetro = 2 * (altura + ancho);
        Console.WriteLine($"El perimetro del rectangulo es:" + perimetro);


        List<int> a = new List<int>();
        Console.WriteLine("ingrese numeros enteros para agregarlos a la lista y calcular su promedio,(ingrese una cadena vacia para terminar):)");
        while (true)
        {
            string dato = Console.ReadLine();
            if (dato == "")
            {
                break;
            }

            int numero = Convert.ToInt32(dato);
            a.Add(numero);
        }

        Console.WriteLine("numeros en la lista:");

        foreach (int numero in a)
        {
            Console.WriteLine(numero);

        }

        int sum = 0;
        foreach (int numero in a)
        {
            sum += numero;
        }

        double promedio = (double)sum / a.Count;
        Console.WriteLine("El promedio de los numeros de la lista es: {0}", promedio);


        Console.WriteLine("ingrese un numero para verificar si es par o impar");
        int par = Convert.ToInt32(Console.ReadLine());
        if ((par % 2) == 0)
        {
            Console.WriteLine($"El numero {par} es par");
        }
        else
        {
            Console.WriteLine($"El numero {par} es impar");
        }

        Console.WriteLine("Ingrese una cadena de caracteres que desea convertir a mayusculas");
        string cadena = Console.ReadLine();
        cadena.ToUpper();
        Console.WriteLine(cadena.ToUpper());


        int x1;
        int x2;
        int y1;
        int y2;
        double distancia;

        Console.WriteLine("ingrese la cordenada x1:");
        x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese la cordenada x2:");
        x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese la cordenada y1:");
        y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese la cordenada y2:");
        y2 = Convert.ToInt32(Console.ReadLine());

        distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine("La distancia entre los puntos en el plano cartesiano es de:" + distancia);

        int sn;

        Console.WriteLine("ingrese un numero para realizar la suma de los numeros naturales:");
        int suman = Convert.ToInt32(Console.ReadLine());
        sn = suman * (suman + 1) / 2;
        Console.WriteLine($"la suma de los numeros naturales de {suman} es:" + sn);

        int fac = 1;

        Console.WriteLine("ingrese un numero que desee sacar el factorial");
        int f = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= f; i++)
        {
            fac = fac * i;

        }
        Console.WriteLine($"El factorial de {f} es: " + fac);
















    }
}
