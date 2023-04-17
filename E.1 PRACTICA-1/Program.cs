using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E._1_PRACTICA_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dime un numero entre 0 y 1000");
            int numero = Convert.ToInt32(Console.ReadLine());

            string resultado = Nliteral.Literal(numero);

            Console.WriteLine(resultado);
            Console.WriteLine(numero/10);
            Console.WriteLine(numero % 100);
            Console.WriteLine((numero /100)-1);
            Console.ReadKey();
        }

        public static class Nliteral 
        {
          static readonly string[] Unidades = { "", "uno",
                                                "dos", "tres", "cuatro",
                                                "cinco", "seis", "siete", 
                                                "ocho", "nueve" };
          static readonly string[] Decenas = { "diez", "once",
                                               "doce", "trece", "catorce",
                                               "quince", "dieciseis", "dieciocho",
                                               "diecinueve"};
          static readonly string[] Decenas1 = { "veinte", "treinta",
                                                "cuarenta", "cincuenta", "sesenta",
                                                "setenta", "ochenta", "noventa",
                                                };
            static readonly string[] Decenas2 = { "ciento","docientos", "trecientos",
                                                "cuatrocientos", "quinientos", "seisientos",
                                                "setesientos", "ochocientos","novecientos"
                                                };

            public static string Literal(int numero) 
            {
                if (numero < 0)
                    return "menos" + Literal(-numero);
                if (numero < 10)
                    return Unidades[numero];
                if (numero < 20)
                    return Decenas[numero-10];

                if (numero < 100)
                    return Decenas1[(numero / 10)-2] + (numero % 10 != 0 ? " y " :"")+ 
                        Unidades[numero % 10];
                if (numero == 100)
                    return "cien";
                if (numero < 1000 && numero > 100)
                    return Decenas2[(numero/100)-1] + " "+
                        Literal(numero % 100);
                return "";
            }
        }
    }
}
