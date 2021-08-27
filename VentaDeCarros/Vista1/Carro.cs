using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Negocio;


namespace Vista1
{
    class Carro
    {
        static void Main(string[] args)
        {
            EntidadCarro carro = new EntidadCarro();

            NegocioCarro negocio = new NegocioCarro();

            Console.WriteLine("¿Qué coche desea comprar?" +
                "\n1 - Toyota." +
                "\n2 - Nissan." +
                "\n3 - Ford." +
                "\n4 - Lamborghini." +
                "\n5 - Ferrari.");

            carro.Id = int.Parse(Console.ReadLine());

            carro = negocio.negocio_buscarCarroPoPorID(carro);
            if (carro == null)
            {
                Console.WriteLine("El coche seleccionado no esta disponible! ");
            }
            else
            {
                Console.WriteLine("Datos sobre el vehiculo: " +
                    "\nMarca: " + carro.Marca + "." +
                    "\nModelo: " + carro.Modelo + "." +
                    "\nColor: " + carro.Color + "." +
                    "\nPrecio: " + carro.Precio.ToString("00.00") + "." +
                    "\nExistencias: " + carro.Existencias + ".");

                Console.WriteLine("¿Cuántas unidades desea comprar?");
                int cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Usted comprara " + cantidad + " unidades de: " + carro.Marca + " del modelo: " + carro.Modelo + ".");
                Console.WriteLine("Procesando su compra" +
                    "\nPor favor espere");


                carro = negocio.venderCarro(carro, cantidad);

                if (carro != null)
                {
                    Console.WriteLine("Unidades disponibles : " + carro.Existencias + " de este modelo. ");
                    Console.ReadKey();
                }
            }
        }
    }
}
   

