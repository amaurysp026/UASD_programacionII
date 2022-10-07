using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UASD_programacionIII
{
    internal class Ejercicio
    {
        public bool continua { get; set; }
        public string menu { get; set; }
        public Ejercicio()
        {
            continua = true;
            menu = @"

Escoje una opcion: 

1. Calcula la multolicacion de dos numeros.
2. Calcula el promedio de dos numeros.
3. Aceptar 2 catetos y encontra la hipotenusa.
4. Acepta 1 cateto e hipotenusam, encontrar el cateto faltante.
5. Acepta la base y altura de un triangulo, encontrar el area.
6. Acepta, a, b y c. econtrar el valor de x1 y x2 segun la formula de ecuaciones de segundo grado.
7. Acepta una frase. indica cuantos caracteres contiene la mima.
8. Acepta una cantidad de dinero, e indica cuantas veces se puede viajar en el metro con el dinero.
9. Calcula cuantas hamburguesas se pueden hacer segun la cantidad de materias primas.
10. Calcula la moneda de pesos a dolares.
11. Acepta un numero y muestra: Mitad, el cuadrado y el doble.
12. Calcula la cantidad de energia consumida y cuanto debe pagar al mes.
13. Determinar la edad de una persona por su fecha de nacimiento.
14. Convertir grados Cercius a Farenheight y a grados Kelvin
15. Calcula el costo de un viaje en vehiculo segun el precio del combustible.

 Precione X para salir
";
        }
        public int multiplica(int num1, int num2)
        {//multiplica dos numeros
            return num1 * num2;
        }
        public double promedio(double num1, double num2)
        {//promedio de dos numeros
            return (num1 + num2) / 2;
        }
        public double hipotenusa(double cat1, double cat2)
        {//encuentra la hipotenusa recibiendo los catetos
            return Math.Pow(cat1, 2) + Math.Pow(cat2, 2);
        }
        public double catfaltante(double cat, double hipo)
        {//encuentra un cateto faltante al introducir un cateto y la hipotenusa
            return Math.Sqrt(Math.Pow(cat, 2) - Math.Pow(hipo, 2));
        }
        public double areatrinagulo(double bas, double alt)
        {//encuentra el area de un retangulo al colocar la base por la altura / 2
            return (bas * alt) / 2;
        }
        public void esegundogrado(double a, double b, double c)
        {
            double raizPositiva = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
            double raizNegativa = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);

            if (raizNegativa.ToString() == "NaN" || raizPositiva.ToString() == "NaN")
            {
                Console.WriteLine("sin raices reales");
            }
            else if (raizPositiva != raizNegativa)
            {
                Console.WriteLine("{0:0.00}", raizNegativa);
                Console.WriteLine("{0:0.00}", raizPositiva);
            }
            else
            {
                Console.WriteLine("{0:0.00}", raizPositiva);
            }
        }
        public int frase(string frase)
        {//Devuelve la catidad de letras que tiene la frase
            return frase.Count();
        }
        public int viajemetro(int tikets, int dinero)
        {//Devuelve la cantidad de viajes en el metro
            return dinero / tikets;
        }
        public int hamburgueza(int pan, double carne, double tocineta)
        {//para hacer una hamburgueza se necesita 1 pan, 2 carnes, 1/5 de libra de tocineta.
            //calcule cuantas hanburguezas se puede hacer segun la cantidad de estas materias primas que existen en un almacen.
            int hamburguez = 0;
            //El bucle prepara una hamburguesa mientras existan ingredientes suficientes.
            while (pan > 0 && carne > 1 && tocineta > 0.1)
            {
                hamburguez++;
                pan--;
                // Console.WriteLine("Pan:"+pan);
                tocineta -= 0.2;
                // Console.WriteLine("tocineta "+tocineta);
                carne -= 2;
                // Console.WriteLine("carne " + carne);
            }

            return hamburguez;
        }

        public double pesoadolar(double pesos, double preciodolar)
        {

            return pesos * preciodolar;
        }

        public double[] pro11(double num)
        {
            //busca la mitad del numero
            double mitad = num / 2;
            //busca el cuadrado
            double cuadrado = Math.Pow(num, 2);
            //el doble 
            double doble = num * 2;
            double[] numeros = new double[] { mitad, cuadrado, doble };
            return numeros;
        }

        public double precioenergia(double kwcosnumidos)
        {//chequiar montos en factura de luz actual
            double monto;
            double cargofijo = 128.59;
            if (kwcosnumidos < 200)
            {//calcula el monto si el cusumo es menor a lo indicado
                monto = kwcosnumidos * 6.05;
                return monto + cargofijo;
            }
            else
            {//cacula el monto en caso de ser mayor y le suma lo que se consumiria anterior
                monto = 200 * 6.05;
                kwcosnumidos -= 200;
                monto += kwcosnumidos * 8.59;
                return monto + cargofijo;
            }

        }
        public double edad(DateTime fecha)
        {//optiene la edad introducida por el usuario y optiene los dias trasncurrido con la fecha actual

            double i = (DateTime.Now - fecha).TotalDays;
            //divide la cantidad de dias en 365 para optener la cantidad de años
            i /= 365;
            return i;
        }

        public double[] convtemperatura(double temcercius)
        {
            //calculamos los grados farenhigth
            double far = (temcercius * 1.8 + 32);
            //calcilamos los grados kelvin
            double kel = temcercius + 273.15;
            double[] convtemperatura = new double[] { far, kel};
            //retornamos los resultados
            return convtemperatura;

        }
        public double autogasolina(double kmpg,double pgasolina,double km)
        {
            return Math.Round( km / kmpg * pgasolina);
        }
    }

}
