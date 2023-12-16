using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorGrafico
{
    internal class Rectangulo : Punto
    {
        private int ancho;
        private int alto;

        public Rectangulo(int x, int y, int ancho, int alto)
        {
            this.x = x;
            this.y = y;
            this.ancho = ancho;
            this.alto = alto;
        }

        public override string Dibujar()
        {
            return base.Dibujar() + $", ancho : {ancho}, alto : {alto}";
        }


        public override Boolean Mover(int x, int y)
        {
            if((x+ancho) >= EditorGrafico.ancho || (y+alto) >= EditorGrafico.alto)
            {
                return false;
            }
            else
            {
                return true;
            }
        }




    }
}
