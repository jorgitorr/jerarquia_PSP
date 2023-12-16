using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorGrafico 
{
    public interface IGrafico
    {
        public abstract Boolean Mover(int x, int y);

        public abstract string Dibujar();
    }
}
