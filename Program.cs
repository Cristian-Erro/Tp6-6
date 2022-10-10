using System;

namespace C_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            
            float nro1,nro2,resultado;
            string operacion;
            
            //inicializacion
            
            nro1=0f;
            nro2=0f;
            resultado=0f;
            operacion="0";
           
            //numeros de entrada
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("**Bienvenido a mi calculadora!**");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("**ingrese su primer numero**");
            nro1=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("**ingrese su segundo numero*");
            nro2=Convert.ToSingle(Console.ReadLine());
           Console.Clear();
            //seleccion de operaciones
           
            Console.WriteLine("ingrese que operacion desea realizar:(1)suma,(2)resta,(3)division,(4)multiplicacion");
            operacion=Console.ReadLine();
           
           //salida con switch

           switch (operacion){ 
                case "1":
                resultado = nro1+nro2;
                Console.WriteLine("el resultado de su suma es: {0}",resultado);
                break;
                case "2":
                resultado = nro1-nro2;
                Console.WriteLine("el resultado de su resta es: {0}",resultado);
                break;
                case "3":
                resultado = nro1/nro2;
                Console.WriteLine("el resultado de su division es: {0}",resultado);
                break;
                case "4":
                resultado = nro1*nro2;
                Console.WriteLine("el resultado de su multiplicacion es: {0}",resultado);
                break;
                default:
                Console.WriteLine("No es un caracter valido");
                break;
            }
             Console.WriteLine("*Presione una tecla para terminar*");
             Console.ReadKey();
             Console.WriteLine("////////////Gracias por usar mi calculadora :)/////////");
             

            


        }
    }
}
