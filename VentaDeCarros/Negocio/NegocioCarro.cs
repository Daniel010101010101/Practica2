using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NegocioCarro
    {

        DatosCarro datos = new DatosCarro();


        public EntidadCarro negocio_buscarCarroPoPorID(EntidadCarro carro) {

            if (carro.Id < 1 || carro.Id > 5)
            {
                return null;
            }
            else
            {
                carro = datos.buscarCarroPorID(carro);
                if (carro == null)
                {
                    return null;
                }
                else
                {
                    return carro;
                }
            }
        }

        public EntidadCarro venderCarro(EntidadCarro carro, int cantidad) {
            if (cantidad > carro.Existencias)
            {
                Console.WriteLine("Lo sentimos No puedes comprar más de " + carro.Existencias + "unidades.");
                return null;
            }
            else
            {
                carro = datos.venderCarro(carro, cantidad);

                //Factura

                Console.WriteLine("Se vendieron " + cantidad + " unidades de " + carro.Marca + "." +
                "\nTotal: $" + TotalVenta(carro.Precio, cantidad).ToString("00.00"));

                return carro;
            }
            
                       
        
        }

        public double TotalVenta(double precio, int cantidad) {
            double total;
            total = precio * cantidad;
            return total;
        
        
        }
    }
}
