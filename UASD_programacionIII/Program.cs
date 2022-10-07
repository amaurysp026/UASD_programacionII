using UASD_programacionIII;

Ejercicio ejercicios = new Ejercicio();

do
{

  //esto es de replic
    Console.WriteLine("Hola, Como estas.");
    Console.WriteLine(ejercicios.menu);
    string ops = Console.ReadLine();
    switch (ops)
    {
        case "1":
            {
                try
                {
                    Console.WriteLine("Coloca primer numero a multiplicar:");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Coloca el segundo numero a multiplicar:");
                    int n2 = int.Parse(Console.ReadLine());
                    //llamamos al metodo y pasamos los datos optenidos el cual devolvera el resultado
                    Console.WriteLine("El resultado es: " + ejercicios.multiplica(n1, n2));

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al introducir los datos: " + e.Message + " Recuerda solo introducir Numeros");
                }
                break;
            }
        case "2":
            {
                try
                {
                    Console.WriteLine("Coloca primer numero para calcular promedio:");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Coloca el segundo numero para calcular promedio:");
                    double n2 = double.Parse(Console.ReadLine());
                    //llamamos al metodo y pasamos los datos optenidos el cual devolvera el resultado
                    Console.WriteLine("El resultado es: " + ejercicios.promedio(n1, n2));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al introducir los datos: " + e.Message + " Recuerda solo introducir Numeros");

                }
                break;
            }
        case "3":
            {
                try
                {
                    Console.WriteLine("Coloca primer cateto:");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Coloca el segundo cateto:");
                    double n2 = double.Parse(Console.ReadLine());
                    //llamamos al metodo y pasamos los datos optenidos el cual devolvera el resultado
                    Console.WriteLine("El resultado es: " + ejercicios.hipotenusa(n1, n2));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al introducir los datos: " + e.Message + " Recuerda solo introducir Numeros");

                }
                break;
            }
        case "4":
            {
                try
                {
                    Console.WriteLine("Coloca un cateto:");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Coloca la hipotenusa:");
                    double n2 = double.Parse(Console.ReadLine());
                    //llamamos al metodo y pasamos los datos optenidos el cual devolvera el resultado
                    Console.WriteLine("El cateto faltante es: " + ejercicios.catfaltante(n1, n2));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al introducir los datos: " + e.Message + " Recuerda solo introducir Numeros");

                }
                break;

            }
        case "5":
            {
                try
                {
                    Console.WriteLine("Coloca la base:");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Coloca la altura:");
                    double n2 = double.Parse(Console.ReadLine());
                    //llamamos al metodo y pasamos los datos optenidos el cual devolvera el resultado
                    Console.WriteLine("El el area es: " + ejercicios.areatrinagulo(n1, n2));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al introducir los datos: " + e.Message + " Recuerda solo introducir Numeros");

                }
                break;
            }
        case "6":
            {
                try
                {
                    //  Console.WriteLine("Coloca valor (a):");
                    //  double a = double.Parse(Console.ReadLine());
                    //  Console.WriteLine("Coloca valor (b):");
                    //  double b = double.Parse(Console.ReadLine());
                    //  Console.WriteLine("Coloca valor (c):");
                    //  double c = double.Parse(Console.ReadLine());
                    //llamamos al metodo y pasamos los datos optenidos el cual devolvera el resultado
                    //Console.WriteLine("El el area es: " + ejercicios.esegundogrado(a,b,c));
                    ejercicios.esegundogrado(15, 8, 0);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al introducir los datos: " + e.Message + " Recuerda solo introducir Numeros");

                }
                break;

            }
        case "7":
            {
                Console.WriteLine("Coloca una frase");
                Console.WriteLine("La frace tiene " + ejercicios.frase(Console.ReadLine()).ToString() + " letras");
                break;
            }
        case "8":
            {
                try
                {
                    //Se optiene la cantidad de dinero del usuario
                    Console.WriteLine("Por favor dijite la cantidad de dinero en pesos disponible para viajar: ");
                    int dinero = int.Parse(  Console.ReadLine());
                    int tikets = 35;
                    Console.WriteLine("Con " + dinero + " pesos dominicanos, puedes viajar " + ejercicios.viajemetro(tikets, dinero).ToString()
                        + " veses en el metro de Santo Domingo");
                }
                catch (Exception e)
                {
                    // EN caso de error de entrada de datos
                    Console.WriteLine("Error: " + e.Message + " Recuerda colocar el monto de dinero correcto");
                }
                break;
            }
        case "9":
            {
                try
                {
                    Console.WriteLine("Coloca la cantidad de pan: ");
                    int pan = int.Parse(Console.ReadLine());
                    Console.WriteLine("Coloca la cantidad de carne: ");
                    double carne = double.Parse(Console.ReadLine());
                    Console.WriteLine("coloca la cantidad en libras de tosineta");
                    double tos = double.Parse(Console.ReadLine());
                    Console.WriteLine("Con estos ingredientes se pueden preparar " + ejercicios.hamburgueza(pan,carne,tos)+" hamburgesas") ;
                    break;
                }
                catch (Exception e)
                {

                    Console.WriteLine("Error: " + e.Message + " Procura introducir los datos correctos");
                    break;
                }
            }
        case "10":
            {
                try
                {
                    Console.WriteLine("Coloca el valor en pesos que deseas convertir a dolares: ");
                    double pesos =double.Parse( Console.ReadLine());
                    Console.WriteLine("El monto en dolares es: " + ejercicios.pesoadolar(pesos,0.019));

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message + " recuerda introducir un valor correcto");
                   
                }
                break;
            }
        case "11":
            {
                try
                {
                    //pedir datos
                    Console.WriteLine("Coloca un numero para devolver los datos de Mitad, Cuadrado y el Doble de dicho numero: ");
                    double numero = double.Parse(Console.ReadLine());
                    Console.WriteLine(@"La mitad del numero es: " + ejercicios.pro11(numero)[0] + "\n " +
                        "El cuadrado del numero es: " + ejercicios.pro11(numero)[1] + "\n " +
                        "El doble del numero es: " + ejercicios.pro11(numero)[2]);
                }
                catch (Exception e)
                {

                    Console.WriteLine("Error: " +e.Message + " recuerda colocar un  numero valido");
                }
                break;
            }
        case "12":
            {
                try
                {
                    Console.WriteLine("Coloca la cantidad de energia consumida en un periodo de un mes, expresado en Kwh");

                    double kwconsumidos=double.Parse( Console.ReadLine());
                    Console.WriteLine("El monto a pagar por la energia consumida es: " + ejercicios.precioenergia(kwconsumidos));
                }
                catch (Exception e)
                {

                    Console.WriteLine("Error: " + e.Message + " recuerda colocar un numero valido");
                }
                break;

            }
        case "13":
            {
                try
                {
                    Console.WriteLine("Coloca tu fecha de nacimiento, formato(dia/mes/año)");
                    DateTime fecha = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Tu edad es: " + ejercicios.edad(fecha));
                }
                catch (Exception e)
                {

                    Console.WriteLine("Error: "+e.Message+" Recuerda colocar la fecha en formato correcto");
                }
                break;
            }
        case "14":
            {
                try
                {
                    Console.WriteLine("Por favor coloca la temperatura en Cercius a convertir:");
                    double temp = double.Parse(Console.ReadLine());
                    Console.WriteLine("La temperatura en grados Farenheight es:" + ejercicios.convtemperatura(temp)[0]);
                    Console.WriteLine("La temperatura en grados Kelvin es:" + ejercicios.convtemperatura(temp)[1]);

                }
                catch (Exception e)
                {

                    Console.WriteLine("Error: " + e.Message + " recuerda colocar la temperatura en el formato correcto");
                }
                break ;
            }
        case "15":
            {
                try
                {
                    //establece el precio de la gasolina de la semana de 6/10/2022
                    double preciogasolina = 243.30;
                    Console.WriteLine("El precio de la gasolina regular actual es: "+preciogasolina);
                    Console.WriteLine("Coloca la catidad de KM por galon que da el vehiculo de gasolina.");
                    double kmg = double.Parse(Console.ReadLine());
                    Console.WriteLine("Que distancia deseas recorrer en KM");
                    double km= double.Parse(Console.ReadLine());
                    Console.WriteLine("El costo del viaje es de " + ejercicios.autogasolina( kmg,preciogasolina,km)+" con el precio de la gasolina regular actual") ;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message + " deves colocar los valores de forma correcta");
                    
                }
                break;
            }
        case "x":
            {
                ejercicios.continua = false;
                break;
            }

        default:
            {
                Console.WriteLine("la opcion que a dijitado no es correcta por favor elija una opcion valida.\n"); 
                break;

            }
            
    }
    Console.WriteLine("\n Precione cualquier tecla para continuar....");
    Console.ReadKey();
} while (ejercicios.continua);