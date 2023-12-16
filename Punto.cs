using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorGrafico
{
    internal class Punto : IGrafico
    {
        private int _x;
        private int _y;

        public int x { get => _x; set{
                if (value < 0 || value > EditorGrafico.alto) throw new ArgumentException();
                else _x = value;
            } 
        }
        public int y { get => _y; set {
                if (value > EditorGrafico.ancho || value < 0) throw new ArgumentException();
                else _y = value;
            }
        }

        //virtual permite sobreescribir el método
        public virtual string Dibujar() 
        {
            return $"x: {x}, y: {y}";
        }

        /// </returns>Devuelve true or false según los valores ingresados por parámetros</returns>
        public virtual Boolean Mover(int x, int y)
        {
            if((this.x+x)>=EditorGrafico.ancho && (this.y + y) >= EditorGrafico.alto)
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
