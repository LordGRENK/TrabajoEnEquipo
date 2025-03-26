using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
                        Console.Clear();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Verificar Matrices");
            Console.WriteLine("2. Generar Matriz de Ceros");
            Console.WriteLine("3. Obtener Inverso Aditivo");
            Console.WriteLine("4. Restar Matrices");
            Console.WriteLine("5. Multiplicar por Escalar");
            Console.WriteLine("6. Multiplicar Matrices");
            Console.WriteLine("7. Generar Matriz Identidad");
            Console.WriteLine("8. Obtener Matriz Inversa");
            Console.WriteLine("9. Obtener Determinante");
            Console.WriteLine("0. Salir");
            Console.Write("->");
            opcion = ValidacionDeEntradaProgram();
            switch (opcion )
        {
            case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                case 1:
                VerificarMatrices();
                break;
            case 2:
                GenerarMatrizCeros();
                break;
            case 3:
                ObtenerInversoAditivo();
                break;
            case 4:
                RestarMatrices();
                break;
            case 5:
                MultiplicarPorEscalar();
                break;
            case 6:
                MultiplicarMatrices();
                break;
            case 7:
                GenerarMatrizIdentidad();
                break;
            case 8:
                ObtenerMatrizInversa();
                break;
            case 9:
                ObtenerDeterminante();
                break;
            default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            if (opcion != 0)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 0);
    }

    /*Todo lo de verificar matrices*/
    static void VerificarMatrices()
    {
        int filas, columnas;

        // Solicitar dimensiones de la matriz con validación
        Console.Write("Ingrese el número de filas: ");
        filas = LeerEnteroPositivo();

        Console.Write("Ingrese el número de columnas: ");
        columnas = LeerEnteroPositivo();

        // Declarar e inicializar las matrices
        int[,] matriz1 = new int[filas, columnas];
        int[,] matriz2 = new int[filas, columnas];

        Console.WriteLine("Ingrese el número de columnas de la segunda matriz: ");
        LlenarMatriz(matriz1);

        Console.WriteLine("Ingrese los valores de la segunda matriz: ");
        LlenarMatriz(matriz2);

        // Verificar si las matrices son iguales
        if (SonIguales(matriz1, matriz2))
        {
            Console.WriteLine("Las matrices son iguales.");
        }
        else
        {
            Console.WriteLine("Las matrices NO son iguales.");
        }
    }
    /**/
    static int LeerEnteroPositivo()
    {
        int numero;
        while (true)
        {
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out numero) && numero > 0)
            {
                return numero;
            }
            Console.Write("Entrada inválida. Ingrese un número entero positivo: ");
        }
    }
    static int ValidacionDeEntradaProgram()
    {
        int numero;
        while (true)
        {
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out numero) && numero >= 0 && numero <= 9)
            {
                return numero;
            }
            Console.WriteLine("Entrada inválida. Ingrese un número entre 0 y 9");
            Console.Write("->");
        }
    }
    /**/

    /**/
    static void LlenarMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"[{i},{j}]: ");
                matriz[i, j] = LeerEntero();
            }
        }
    }
    static int LeerEntero()
    {
        int numero;
        while (true)
        {
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out numero))
            {
                return numero;
            }
            Console.Write("Entrada inválida. Ingrese un número entero (positivo o negativo): ");
        }
    }
    /**/



    static bool SonIguales(int[,] matriz1, int[,] matriz2)
    {
        for (int i = 0; i < matriz1.GetLength(0); i++)
        {
            for (int j = 0; j < matriz1.GetLength(1); j++)
            {
                if (matriz1[i, j] != matriz2[i, j])
                {
                    return false;
                }
            }
        }
        return true;
    }/*Genera matrices de ceros*/
    static void GenerarMatrizCeros()
    {
        Console.Write("Ingrese el número de filas: ");
        int filas = LeerEnteroPositivo();

        Console.Write("Ingrese el número de columnas: ");
        int columnas = LeerEnteroPositivo();

        int[,] matriz = new int[filas, columnas]; // La matriz ya se inicializa con ceros en C#

        Console.WriteLine("Matriz generada:");
        ImprimirMatriz(matriz);
    }
    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    /*Matriz inversa*/
    static void ObtenerInversoAditivo()
    {
        Console.Write("Ingrese el número de filas: ");
        int filas = LeerEntero();

        Console.Write("Ingrese el número de columnas: ");
        int columnas = LeerEntero();

        int[,] matriz = new int[filas, columnas];

        Console.WriteLine("Ingrese los valores de la matriz:");
        LlenarMatriz(matriz);

        Console.WriteLine("Matriz original:");
        ImprimirMatriz(matriz);

        CalcularInversoAditivo(matriz);

        Console.WriteLine("Matriz con inverso aditivo:");
        ImprimirMatriz(matriz);
    }
    /**/
    static void CalcularInversoAditivo(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = -matriz[i, j]; // Calcula el inverso aditivo en la misma matriz
            }
        }
    }
    /**/

    /**/
    static void RestarMatrices()
    {
        Console.Write("Ingrese el número de filas: ");
        int filas = LeerEnteroPositivo();

        Console.Write("Ingrese el número de columnas: ");
        int columnas = LeerEnteroPositivo();

        int[,] matrizA = new int[filas, columnas];
        int[,] matrizB = new int[filas, columnas];
        int[,] matrizResultado = new int[filas, columnas];

        Console.WriteLine("Ingrese los valores de la primera matriz (A): ");
        LlenarMatriz(matrizA);

        Console.WriteLine("Ingrese los valores de la segunda matriz (B): ");
        LlenarMatriz(matrizB);

        CalcularResta(matrizA, matrizB, matrizResultado);

        Console.WriteLine("Matriz A:");
        ImprimirMatriz(matrizA);

        Console.WriteLine("Matriz B:");
        ImprimirMatriz(matrizB);

        Console.WriteLine("Resultado de A - B:");
        ImprimirMatriz(matrizResultado);
    }
    /**/

    /**/
    static void CalcularResta(int[,] matrizA, int[,] matrizB, int[,] resultado)
    {
        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                resultado[i, j] = matrizA[i, j] - matrizB[i, j]; // Resta A - B
            }
        }
    }
    /*Multp por escalar*/
    static void MultiplicarPorEscalar()
    {
        Console.Write("Ingrese el número de filas: ");
        int filas = LeerEnteroPositivo();

        Console.Write("Ingrese el número de columnas: ");
        int columnas = LeerEnteroPositivo();

        int[,] matriz = new int[filas, columnas];

        Console.WriteLine("Ingrese los valores de la matriz:");
        LlenarMatriz(matriz);

        Console.Write("Ingrese el escalar por el que desea multiplicar la matriz: ");
        int escalar = LeerEntero(); // Permite cualquier número entero

        MultiplicarMatrizPorEscalar(matriz, escalar);

        Console.WriteLine("Matriz resultante después de la multiplicación:");
        ImprimirMatriz(matriz);
    }
    /**/
    static void MultiplicarMatrizPorEscalar(int[,] matriz, int escalar)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] *= escalar; // Multiplica cada elemento por el escalar
            }
        }
    }
    /**/

    /*Multp Matrices que coincidan*/
    static void MultiplicarMatrices()
    {
        Console.Write("Ingrese el número de filas de la primera matriz: ");
        int filasA = LeerEnteroPositivo();

        Console.Write("Ingrese el número de columnas de la primera matriz (y filas de la segunda): ");
        int columnasA_FilasB = LeerEnteroPositivo();

        Console.Write("Ingrese el número de columnas de la segunda matriz: ");
        int columnasB = LeerEnteroPositivo();

        int[,] matrizA = new int[filasA, columnasA_FilasB];
        int[,] matrizB = new int[columnasA_FilasB, columnasB];
        int[,] matrizResultado = new int[filasA, columnasB];

        Console.WriteLine("Ingrese los valores de la primera matriz (A): ");
        LlenarMatriz(matrizA);

        Console.WriteLine("Ingrese los valores de la segunda matriz (B): ");
        LlenarMatriz(matrizB);

        CalcularMultiplicacion(matrizA, matrizB, matrizResultado);

        Console.WriteLine("Matriz A:");
        ImprimirMatriz(matrizA);

        Console.WriteLine("Matriz B:");
        ImprimirMatriz(matrizB);

        Console.WriteLine("Resultado de A * B:");
        ImprimirMatriz(matrizResultado);
    }

    /**/
    static void CalcularMultiplicacion(int[,] matrizA, int[,] matrizB, int[,] resultado)
    {
        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizB.GetLength(1); j++)
            {
                resultado[i, j] = 0;
                for (int k = 0; k < matrizA.GetLength(1); k++)
                {
                    resultado[i, j] += matrizA[i, k] * matrizB[k, j]; // Producto escalar fila x columna
                }
            }
        }
    }
    /*Generar matriz de identidad*/
    static void GenerarMatrizIdentidad()
    {
        Console.Write("Ingrese el tamaño de la matriz identidad (n): ");
        int n = LeerEnteroPositivo();

        int[,] matrizIdentidad = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            matrizIdentidad[i, i] = 1; // Pone unos en la diagonal principal
        }

        Console.WriteLine("Matriz Identidad generada:");
        ImprimirMatriz(matrizIdentidad);
    }
    /**/

    /*Obtener la inversa de una matriz de tamaño n*/
    static void ObtenerMatrizInversa()
    {
        Console.Write("Ingrese el tamaño de la matriz cuadrada (n): ");
        int n = LeerEnteroPositivo();

        double[,] matriz = new double[n, n];
        double[,] identidad = new double[n, n];

        Console.WriteLine("Ingrese los valores de la matriz: ");
        LlenarMatrizDoble(matriz);

        // Inicializar la matriz identidad
        for (int i = 0; i < n; i++)
        {
            identidad[i, i] = 1.0;
        }

        if (!CalcularInversa(matriz, identidad, n))
        {
            Console.WriteLine("La matriz no es invertible (su determinante es 0).");
        }
        else
        {
            Console.WriteLine("Matriz inversa:");
            ImprimirMatrizDoble(identidad);
        }
    }
    /*Utilizando metodo Gauss-Jordan*/
    static bool CalcularInversa(double[,] matriz, double[,] identidad, int n)
    {
        for (int i = 0; i < n; i++)
        {
            // Buscar el pivote
            if (matriz[i, i] == 0)
            {
                bool cambiado = false;
                for (int j = i + 1; j < n; j++)
                {
                    if (matriz[j, i] != 0)
                    {
                        // Intercambiar filas
                        IntercambiarFilas(matriz, identidad, i, j, n);
                        cambiado = true;
                        break;
                    }
                }
                if (!cambiado) return false; // Si no se encuentra un pivote, la matriz no es invertible
            }

            double pivote = matriz[i, i];

            // Normalizar la fila dividiéndola por el pivote
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] /= pivote;
                identidad[i, j] /= pivote;
            }

            // Hacer ceros en la columna del pivote
            for (int j = 0; j < n; j++)
            {
                if (i != j)
                {
                    double factor = matriz[j, i];
                    for (int k = 0; k < n; k++)
                    {
                        matriz[j, k] -= factor * matriz[i, k];
                        identidad[j, k] -= factor * identidad[i, k];
                    }
                }
            }
        }
        return true; // La matriz es invertible
    }
    /*Auxiliares*/
    static void IntercambiarFilas(double[,] matriz, double[,] identidad, int fila1, int fila2, int n)
    {
        for (int i = 0; i < n; i++)
        {
            double temp = matriz[fila1, i];
            matriz[fila1, i] = matriz[fila2, i];
            matriz[fila2, i] = temp;

            temp = identidad[fila1, i];
            identidad[fila1, i] = identidad[fila2, i];
            identidad[fila2, i] = temp;
        }
    }

    static void LlenarMatrizDoble(double[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"[{i},{j}]: ");
                matriz[i, j] = LeerDoble();
            }
        }
    }

    static double LeerDoble()
    {
        double numero;
        while (true)
        {
            string entrada = Console.ReadLine();
            if (double.TryParse(entrada, out numero))
            {
                return numero;
            }
            Console.WriteLine("Entrada inválida. Ingrese un número válido:");
        }
    }

    static void ImprimirMatrizDoble(double[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"{matriz[i, j]:F2}  ");
            }
            Console.WriteLine();
        }
    }
    /*Obtener el determinante*/
    static void ObtenerDeterminante()
    {
        Console.WriteLine("Ingrese el tamaño de la matriz cuadrada (n):");
        int n = LeerEnteroPositivo();

        double[,] matriz = new double[n, n];

        Console.WriteLine("Ingrese los valores de la matriz:");
        LlenarMatrizDoble(matriz);

        double determinante = CalcularDeterminante(matriz, n);

        Console.WriteLine($"El determinante de la matriz es: {determinante:F4}");
    }
    /*Metodo de eliminacion de gauss*/
    static double CalcularDeterminante(double[,] matriz, int n)
    {
        double det = 1;
        for (int i = 0; i < n; i++)
        {
            // Si el pivote es 0, intercambiar filas
            if (matriz[i, i] == 0)
            {
                bool cambiado = false;
                for (int j = i + 1; j < n; j++)
                {
                    if (matriz[j, i] != 0)
                    {
                        IntercambiarFilas(matriz, i, j, n);
                        det *= -1; // Cambiar el signo del determinante al intercambiar filas
                        cambiado = true;
                        break;
                    }
                }
                if (!cambiado) return 0; // Si no se encuentra un pivote, el determinante es 0
            }

            det *= matriz[i, i];

            // Hacer ceros en la columna debajo del pivote
            for (int j = i + 1; j < n; j++)
            {
                double factor = matriz[j, i] / matriz[i, i];
                for (int k = i; k < n; k++)
                {
                    matriz[j, k] -= factor * matriz[i, k];
                }
            }
        }
        return det;
    }
    static void IntercambiarFilas(double[,] matriz, int fila1, int fila2, int n)
    {
        for (int i = 0; i < n; i++)
        {
            double temp = matriz[fila1, i];
            matriz[fila1, i] = matriz[fila2, i];
            matriz[fila2, i] = temp;
        }
    }
    /**/
}
