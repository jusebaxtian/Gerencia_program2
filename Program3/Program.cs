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

    class Program
    {
        static void Main(string[] args)
        {
            //Creando el objeto con sus metodos para ejecutarlos
            Calcular calulos = new Calcular();

            calulos.cargarVectorX();
            calulos.cargarVectorY();
            calulos.multiplicacionVectores();
            calulos.promedio();
            calulos.regrecion();
            calulos.coheficiente();

            Console.ReadKey();
        }
    }
}
