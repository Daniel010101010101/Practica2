using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DatosCarro
    {

        EntidadCarro carro1 = new EntidadCarro(1, "Toyota", "Hilux", "Negro, Blanco, Gris", 25000, 10);
        EntidadCarro carro2 = new EntidadCarro(2, "Nissan", "Frontier", "Blanco, Azul, Negro", 22000, 8);
        EntidadCarro carro3 = new EntidadCarro(3, "Ford", "Focus", "Azul, Verde", 15000, 10);
        EntidadCarro carro4 = new EntidadCarro(4, "Lamborghini", "Huracan", "Naranja, Blanco", 155000, 4);
        EntidadCarro carro5 = new EntidadCarro(5, "Ferrari", "F8", "Rojo", 2500000, 3);


        public EntidadCarro buscarCarroPorID(EntidadCarro carro) { 
            
            if (carro.Id == 1)
            {
                carro = carro1;

                return carro;
            }
            else if (carro.Id == 2)
            {
                carro = carro2;

                return carro;
            }
            else if (carro.Id == 3)
            {
                carro = carro3;

                return carro;
            }
            else if (carro.Id == 4)
            {
                carro = carro4;

                return carro;
            }
            else if (carro.Id == 5)
            {
                carro = carro5;

                return carro;
            }


            else
            {
                return null;
            }






        }

        public EntidadCarro venderCarro(EntidadCarro carro, int cantidad) {


            carro.Existencias = (carro.Existencias - cantidad);

            return carro;
        
        
        
        }




    }
}
