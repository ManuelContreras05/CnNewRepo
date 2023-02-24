
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Manuel
{
    class ToolsTwo
    {
        public static float number = 0;
        public static float numberTwo = 0;
        public static float numberThree = 0;

        public static void Main(string[] args)
        {
            //Creamos una instacia de la clase 'Ejercicio'
            Exercise MyExercise = new Exercise();
            //Constructores
            MyExercise.AreaOfSquare();
            MyExercise.AreaOfTriangle();
            MyExercise.AreaOfCircle();
            MyExercise.CelsiusAFahrenheit();
            MyExercise.Practice();

            Console.WriteLine("menu ingresa opcion del 1-9");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    {
                        Console.WriteLine("Sr.Usuario por favor ingrese un numero a sumar");
                        number = float.Parse(Console.ReadLine());

                        Console.WriteLine("Sr.Usuario por favor ingrese el segundo numero a sumar");
                        numberTwo = float.Parse(Console.ReadLine());

                        //llamamos la funcion y le damos como parametros lo que el usuario ingrese
                        float sumResult = Addition(number, numberTwo, numberThree);

                        Console.WriteLine(sumResult);
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("Sr.Usuario por favor ingrese un numero a dividir");
                        number = float.Parse(Console.ReadLine());

                        Console.WriteLine("Sr.Usuario por favor ingrese el segundo numero a dividir");
                        numberTwo = float.Parse(Console.ReadLine());

                        if (number == 0 || numberTwo == 0)
                        {
                            Console.WriteLine("No puedes dividir por cero");
                        }

                        double result = number / numberTwo;
                        Console.WriteLine("Sr.Usuario el resultado de la division es: " + result);

                        //llamamos la funcion y le damos como parametros lo que el usuario ingrese
                        double residualResult = Residue(number, numberTwo);
                        Console.WriteLine(residualResult);
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("Sr.Usuario por favor ingrese un numero a sumar ");
                        number = float.Parse(Console.ReadLine());

                        Console.WriteLine("Sr.Usuario por favor ingrese el segundo numero a sumar ");
                        numberTwo = float.Parse(Console.ReadLine());

                        Console.WriteLine("Sr.Usuario por favor ingrese el tercer numero a sumar ");
                        numberThree = float.Parse(Console.ReadLine());

                        float sumResult = Addition(number, numberTwo, numberThree);
                        Console.WriteLine(sumResult);
                    }
                    break;

                case 4:
                    {
                        Console.WriteLine("Sr.Usuario ingrese numero para mostrar la tabla de multiplicar");
                        number = int.Parse(Console.ReadLine());

                        MultiplicationTable(number);
                    }
                    break;

                case 5:
                    {
                        Console.WriteLine("Sr.Usuario Ingresa la cantidad de grados celsius: ");
                        number = float.Parse(Console.ReadLine());

                        Convert(number);
                    }
                    break;

                case 6:
                    {
                        Console.WriteLine("Sr.Usuario ingrese la cantidad de millas para saber la equivalencia en metros: ");
                        number = float.Parse(Console.ReadLine());

                        Equivalence(number);
                    }
                    break;

                case 7:
                    {
                        Console.WriteLine("Sr.Usuario ingresa un numero entero");
                        number = int.Parse(Console.ReadLine());

                        MultiplesOfTen(number);

                        Console.WriteLine("Sr.Usuario ingresa un numero entero");
                        number = int.Parse(Console.ReadLine());

                        MultiplesOfTen(number);
                    }
                    break;

                case 8:
                    {

                        Console.WriteLine("Sr.Usuario ingrese un numero entero a multiplicar");
                        number = int.Parse(Console.ReadLine());

                        IntegerMultiplication(number);

                        Console.WriteLine("Sr.,Usuario ingresa un segundo numero a multiplicar");
                        numberTwo = int.Parse(Console.ReadLine());

                        IntegerMultiplication(numberTwo);

                        Console.WriteLine("Sr.Usuario la multiplicacion de los dos numeros es " + number * numberTwo);

                    }
                    break;

                case 9:
                    {
                        Console.WriteLine("Sr.Usuario ingrese un numero entero");
                        number = int.Parse(Console.ReadLine());

                        Console.WriteLine("Sr.Usuario ingrese un segundo numero entero");
                        numberTwo = int.Parse(Console.ReadLine());

                        Compare(numberTwo);

                    }
                    break;
            }
        }
        //funcion suma
        public static float Addition(float param1, float param2, float param3)
        {
            Console.WriteLine("Sr.Usuario el resultado se la suma es: ");
            return param1 + param2 + param3;
        }
        //funcion residuo
        public static float Residue(float param1, float param2)
        {
            //La cantidad que sobra luego de una división (como pasa si un número no puede ser dividido exactamente por otro).
            //Ejemplo: 19 no puede ser dividido exactamente por 5.
            //Lo más cerca que se puede llegar sin pasarse es 3 x 5 = 15, lo cual es 4 menos que 19

            Console.WriteLine("Sr.Usuario el residuo de la division es: ");
            return param1 % param2;
        }
        //funcion tabla de multiplicar
        public static void MultiplicationTable(float param1)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(param1 + " X " + i + " = " + param1 * i);
            }
        }
        //funcion de conversor 
        public static void Convert(float param1)
        {
            float kelvin = param1 + 273;
            float fahrenheit = param1 * 18 / 10 + 32;

            Console.WriteLine("{0} grados Celsius son {1} Kelvin y {2} grados Fahrenheit.", param1, kelvin, fahrenheit);

        }
        //funcion equivalencia 
        public static void Equivalence(float param1)
        {
            float milla = 1609.344F;

            Console.WriteLine("Sr.Usuario la equivalencia de millas a metros es de: " + param1 * milla);
        }
        //funcion multiplo de Diez
        public static void MultiplesOfTen(float param1)
        {
            if (param1 % 10 == 0)
            {
                Console.WriteLine("Sr.Usuario el numero " + param1 + " es multiplo de 10");
            }
            else
            {
                Console.WriteLine("Sr.Usuario el numero " + param1 + " no es multiplo de 10");
            }
        }
        //funcion MultiplicarEnteros 
        public static void IntegerMultiplication(float param1)
        {
            if (param1 == 0)
            {
                Console.WriteLine("Sr.Usuario el producto de '0' por cualquier numero es 0");
            }
        }
        //funcion Comparar
        public static void Compare(float param1)
        {
            if (param1 != 0)
            {
                Console.WriteLine("Sr.Usuario el resultado es " + number / param1);
            }
            else
            {
                Console.WriteLine("Sr.Usuario Error: no se puede dividir entre '0'");
            }
        }
    }
}
//Creamos una clase donde vamos a plantear los ejercicios pedidos
class Exercise
{
    public double @long = 0;
    public double broad = 0;
    public double height = 0;
    public double radio = 0;
    public double area = 0;
    public void AreaOfSquare()
    {
        Console.WriteLine("Sr.Usuario ingrese el largo del cuadrado ");
        @long = double.Parse(Console.ReadLine());

        Console.WriteLine("Sr.Usuario ingrese el ancho del cuadrado");
        broad = double.Parse(Console.ReadLine());

        area = Math.Pow(@long, broad);
        Console.WriteLine("Sr.Usuario el Area del cuadrado es " + area);
    }
    public void AreaOfTriangle()
    {
        Console.WriteLine("Sr.Usuario ingrese la altura del triangulo ");
        height = double.Parse(Console.ReadLine());

        Console.WriteLine("Sr.Usuario ingrese la base del triangulo ");
        broad = double.Parse(Console.ReadLine());

        area = Math.Pow(@long, broad);
        Console.WriteLine("Sr.Usuario el area del triangulo es " + area);

    }
    public void AreaOfCircle()
    {
        Console.WriteLine("Sr.Usuario ingrese el radio del circulo ");
        radio = double.Parse(Console.ReadLine());

        area = radio * radio * 3.1416;

        Console.WriteLine("Sr.Usuario el area del circulo es " + area);
    }
    public void CelsiusAFahrenheit()
    {
        double temperature, result;
        string option;

        Console.WriteLine("Conversor de temperatura Celsius a Fahrenheit y viceversa");
        Console.WriteLine("-----------------------------------------------------------");

        do
        {
            Console.WriteLine("Sr.Usuario seleccione una opción:");
            Console.WriteLine("1 - Convertir de Celsius a Fahrenheit");
            Console.WriteLine("2 - Convertir de Fahrenheit a Celsius");
            Console.WriteLine("0 - Salir");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    {
                        Console.WriteLine("Sr.Usuario ingrese la temperatura en grados Celsius: ");
                        temperature = double.Parse(Console.ReadLine());
                        result = CelsiusAFahrenheit(temperature);
                        Console.WriteLine("{0} grados Celsius son {1} grados Fahrenheit ", temperature, result);
                    }
                    break;

                case "2":
                    {
                        Console.WriteLine("Sr.Usuario ingrese la temperatura en grados Fahrenheit: ");
                        temperature = double.Parse(Console.ReadLine());
                        result = FahrenheitACelsius(temperature);
                        Console.WriteLine("{0} grados Fahrenheit son {1} grados Celsius ", temperature, result);
                    }
                    break;

                case "0":
                    {
                        Console.WriteLine("Sr.Usuario saliendo del programa.");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Sr.Usuario opción no válida, intente de nuevo");
                    }
                    break;
            }

        } while (option != "0");

        static double CelsiusAFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }

        static double FahrenheitACelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
    public void Practice()
    {
        double costOfHouse;
        double buyerIncome;
        string headOfFamily;

        //Entrada de datos
        Console.WriteLine("Sr.Usuario ingrese el costo de la casa: $");
        costOfHouse = double.Parse(Console.ReadLine());

        Console.WriteLine("Sr.Usuario ingrese los ongresos del comprador: $");
        buyerIncome = double.Parse(Console.ReadLine());

        Console.WriteLine("Es cabeza de familia (si/no): ");
        headOfFamily = Console.ReadLine().ToLower();

        DownPayment(buyerIncome, costOfHouse, headOfFamily);

        //calculo del enganche
        static void DownPayment(double buyerIncome, double costOfHouse, string headOfFamily)
        {
            double hitch;

            if (buyerIncome < 600000)
            {
                hitch = costOfHouse * 0.15;
            }
            else
            {
                hitch = costOfHouse * 0.3;
            }
            //descuento adicional para cabeza de familia 
            if (headOfFamily == "si")
            {
                hitch *= 0.97;
            }
            //Calculo de la cuota mensual
            double mountOfLoans = costOfHouse - hitch;
            double monthlyFee;

            if (buyerIncome < 600000)
            {
                monthlyFee = mountOfLoans / 120; // 10 years = 120 months
            }
            else
            {
                monthlyFee = mountOfLoans / 84; // 7 years = 84 months 
            }

            // Salida de resultados
            Console.WriteLine("Sr.Usuario el enganche es: ${0:0,0.00} ", hitch);
            Console.WriteLine("Sr Usuario la cuota mensual es: ${0:0,0.00} ", monthlyFee);
        }
    }
}
