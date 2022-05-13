using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    class Program
    {
        public static int retiro;
        public static int[] caja = new int[10];
        public static int[] billete = new int[10];
        public static int[] moneda = new int[10];
        static void Main(string[] args)
        {
            int op;
            bool Menu = true;

            while (Menu)
            {
                Console.Clear();
                Console.WriteLine("**************************Banco*************************");
                Console.WriteLine("* 1. Ingresa cantidad de retiros hechos por usuarios.  *");
                Console.WriteLine("* 2. Revisar Cantidad entregada de Billetes y Monedas. *");
                Console.WriteLine("* 3. Salir del Programa.                               *");
                Console.WriteLine("********************************************************");
                Console.WriteLine("Ingresa la Opcion : ");
                do
                {
                    op = int.Parse(Console.ReadLine());
                } while (op < 1 || op > 3);
                Console.Clear();
                if (op == 1)
                {
                    Console.WriteLine("Cuantos retiros se hicieron ? [ Maximo 10 ]");
                    do
                    {
                        retiro = int.Parse(Console.ReadLine());
                    } while (retiro < 1 || retiro > 10);
                    for (int i = 0; i < retiro; i++)
                    {
                        Console.WriteLine("Ingresa la cantidad del retiro #" + (i + 1) + " : ");
                        do
                        {
                            caja[i] = Convert.ToInt32(Console.ReadLine());
                        } while (caja[i] < 0 || caja[i] > 50000);
                    }
                }
                if (op == 2)
                {
                    for (int i = 0; i < retiro; i++)
                    {
                        int flag = 0;
                        billete[i] = caja[i] / 500; // BILLETES DE 500
                        flag = caja[i] / 500;
                        caja[i] = caja[i] - (flag * 500);
                        billete[i] += caja[i] / 200;  // BILLETES DE 200
                        flag = caja[i] / 200;
                        caja[i] = caja[i] - (flag * 200);
                        billete[i] += caja[i] / 100;  // BILLETES DE 100
                        flag = caja[i] / 100;
                        caja[i] = caja[i] - (flag * 100);
                        billete[i] += caja[i] / 50;   // BILLETE DE 50
                        flag = caja[i] / 50;
                        caja[i] = caja[i] - (flag * 50);
                        billete[i] += caja[i] / 20;   // BILLETE DE 20
                        flag = caja[i] / 20;
                        caja[i] = caja[i] - (flag * 20);
                        moneda[i] = caja[i] / 10;     //MONEDA DE 10
                        flag = caja[i] / 10;
                        caja[i] = caja[i] - (flag * 10);
                        moneda[i] += caja[i] / 5;     //MONEDA DE 5
                        flag = caja[i] / 5;
                        caja[i] = caja[i] - (flag * 5);
                        moneda[i] += caja[i] / 1;    //MONEDA DE 1
                        flag = caja[i] / 1;
                        caja[i] = caja[i] - (flag * 1);
                    }
                    for (int i = 0; i < retiro; i++)
                    {
                        Console.WriteLine("Retiro #" + (i + 1));
                        Console.WriteLine("Billetes Entregados : " + billete[i]);
                        Console.WriteLine("Monedas Entregados : " + moneda[i]);
                        Console.ReadKey();
                    }
                    Console.WriteLine("Presiona Enter para Continuar : ");
                    string s = Console.ReadLine();
                }
                if (op == 3)
                {
                    Menu = false;
                }
            }
        }
    }
}
