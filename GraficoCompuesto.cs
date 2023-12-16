using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorGrafico
{
    internal class GraficoCompuesto : IGrafico
    {
        private List<IGrafico>elements = new List<IGrafico>();

        
        public void agregarGrafico(IGrafico grafico)
        {
            elements.Add(grafico);
        }

        public void eliminarGrafico(IGrafico grafico)
        {
            elements.Remove(grafico);
        }

       
        public void recorrerGrafico()
        {
            foreach(IGrafico grafico in elements) { 
                Console.WriteLine(grafico);
            }
        }

        public virtual Boolean Mover(int x, int y)
        {
            var esCorrecto = true;
            foreach (var item in elements)
            {
                if (item.Mover(x, y) == true)
                {
                    esCorrecto = true;
                }
                else
                {
                    esCorrecto = false;
                    break;
                }
            }
            return esCorrecto;
        }

        ///dibuja los gráficos uno a uno 
        public virtual string Dibujar()
        {
            var grafico = "Dibujo Gráfico Compuesto: \n";
            foreach (var item in elements)
            {
                grafico += item.Dibujar() + "\n";
            }
            return grafico;
        }


    }
}
