using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorGrafico
{
    internal class Circulo : Punto
    {

        private int radio;
        

        public Circulo(int x, int y, int radio)
        {
            if(x + radio <= EditorGrafico.alto || y + radio <= EditorGrafico.ancho)
            {
                this.x = x; 
                this.y = y;
                this.radio = radio;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
            
        }

        public override string Dibujar()
        {
            return base.Dibujar() + $" radio : {radio}";
        }

        public override Boolean Mover(int x, int y)
        {
            if((this.x+x+radio) >= EditorGrafico.ancho || (this.y+y+radio) >= EditorGrafico.alto) { 
                return false ;
            }
            else
            {
                return true;
            }
        }




    }
}
