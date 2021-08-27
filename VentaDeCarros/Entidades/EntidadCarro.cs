using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadCarro
    {

        private int id;
        private String marca;
        private String modelo;
        private String color;
        private double precio;
        private int existencias;


        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Existencias { get => existencias; set => existencias = value; }
        public string Color { get => color; set => color = value; }


        public EntidadCarro() { }


        public EntidadCarro(int id, string marca, string modelo, string color, double precio, int existencias)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.precio = precio;
            this.existencias = existencias;
        }



    }
}
