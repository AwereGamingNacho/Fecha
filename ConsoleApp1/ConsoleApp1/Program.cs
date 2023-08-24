using System;

namespace Dia
{
    class Program
    {
        public static void Main(string[] args)
        {

            int dia;
            int mes;
            int ano;

            Console.Write("Introduce el dia: ");
            
            dia = Int16.Parse(Console.ReadLine());

            Console.Write("Introduce el mes: ");

            mes = Int16.Parse(Console.ReadLine());

            Console.Write("Introduce el año: ");

            ano = Int16.Parse(Console.ReadLine());

            if ((dia >= 1 && dia <= 31) && (mes >= 1 && mes <= 12) && (ano > 0))
            {
                switch (mes)
                {
                    case 1:
                        Console.WriteLine(dia + " de enero de " + ano); break;
                    case 2:
                        Console.WriteLine(dia + " de febrero de " + ano); break;
                    case 3:
                        Console.WriteLine(dia + " de marzo de " + ano); break;
                    case 4:
                        Console.WriteLine(dia + " de abril de " + ano); break;
                    case 5:
                        Console.WriteLine(dia + " de mayo de " + ano); break;
                    case 6:
                        Console.WriteLine(dia + " de junio de " + ano); break;
                    case 7:
                        Console.WriteLine(dia + " de julio de " + ano); break;
                    case 8:
                        Console.WriteLine(dia + " de agosto de " + ano); break;
                    case 9:
                        Console.WriteLine(dia + " de septiembre de " + ano); break;
                    case 10:
                        Console.WriteLine(dia + " de octubre de " + ano); break;
                    case 11:
                        Console.WriteLine(dia + " de noviembre de " + ano); break;
                    case 12:
                        Console.WriteLine(dia + " de diciembre de " + ano); break;
                }
            } 
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}