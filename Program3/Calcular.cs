using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    /* Título: Progrecion simple
     * Autor: Juan Sebastian Toledo 
     * Fecha de creación: 03/05/2019 
     * Descripción Simple: ingresar y hallar los resultados pedidos para tener la progrecion simple 
     * Versión: 1.0
     */
    class Calcular
    {
        //Creacion de las varibales
        public double[] vectorX = new double[10]; //vector de 10 posiciones para X y Y
        public double[] vectorY = new double[10];
        public double[] multiplMatrice = new double[10]; //Vector para almacenar la multiplicacion
        public double sumX = 0;  //Sumatoria de X
        public double sumY = 0;  //Sumatorias de Y
        public double xCuadrado;       //X elevado al cuadrado
        public double sumXCuad = 0;  //Sumatoria de X cuadrado
        public double yCuadrado = 0;    //Y elevado al cuadrado
        public double sumYCuad = 0; //Sumatoria de Y al cuadrado
        public double sumMultVector = 0;  //Sumatoria de la multiplicacion de vectores
        public double promedioX;   //Promedio de X
        public double promedioY;   //promedio de Y
        public double valorB1;    //Almacenar variables
        public double valorB0;
        public double valorrxy;
        public double valorr2;
        public double valoryk;
        public int i;   //Variable para FOR

        //Llenado de los datos de X
        public void cargarVectorX()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Hallar Regrecion y corelacion");
            Console.WriteLine("-----------------------------------------");
            for (i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Digito " + (i + 1) + " de la columna X: ");
                vectorX[i] = Convert.ToDouble(Console.ReadLine());
                sumX = sumX + vectorX[i];
                xCuadrado = Math.Pow(vectorX[i], 2);
                sumXCuad = sumXCuad + xCuadrado;
            }
            Console.WriteLine("-----------------------------------------");

        }

        //Llenado de los datos de Y
        public void cargarVectorY()
        {
            for (i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Digito " + (i + 1) + " de la columna Y: "); //Ciclo que llena el vector Y
                vectorY[i] = Convert.ToDouble(Console.ReadLine());
                sumY = sumY + vectorY[i];        //Sumºatoria de todo el vector
                yCuadrado = Math.Pow(vectorY[i], 2); //Elvacion al cuadarado
                sumYCuad = sumYCuad + yCuadrado;    // Sumatoria del cuadrado
            }
            Console.WriteLine("-----------------------------------------");
        }
        //Multiplicacion de x POR y
        public void multiplicacionVectores()
        {
            for (i = 0; i < 10; i++) //Recorre el nuevo vector para llenarlo y al mismo tiempo sumarlo y obtener el valor sumatorio
            {
                multiplMatrice[i] = vectorX[i] * vectorY[i]; //Multiplicacion de vectores
                sumMultVector = sumMultVector + multiplMatrice[i]; //sumatoria de vector almacenado
            }
        }

        //Hallar promedo de sumatorias
        public void promedio()
        {
            promedioY = sumY / 10; //Sumatoria sobre el promedio de numeros en el vector
            promedioX = sumX / 10;
        }

        //Hallar regresión
        public void regrecion()
        {
            valorB1 = (sumMultVector - (10 * promedioX * promedioY)) / 
                (sumXCuad - (10 * (Math.Pow(promedioX, 2))));  //Formulacion integrado en exponente al cuadrado
            valorB0 = promedioY - (valorB1 * promedioX);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----***----Resultados----***------------");
            Console.WriteLine("-----------------------------------------");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Valor B0 " + valorB0);
            Console.WriteLine("Valor B1 " + valorB1);
        }

        //Hallar valores de Correlación
        public void coheficiente()
        {
            valorrxy = (10 * sumMultVector - sumX * sumY) / 
                Math.Sqrt((10 * sumXCuad - Math.Pow(sumX, 2)) * ((10 * sumYCuad - Math.Pow(sumY, 2))));
            valorr2 = Math.Pow(valorrxy, 2);
            valoryk = valorB0 + valorB1 * 386;
            Console.WriteLine("Valor RXY " + valorrxy);
            Console.WriteLine("Valor R2 " + valorr2);
            Console.WriteLine("Valor YK " + valoryk);
 
        }
    }
}
