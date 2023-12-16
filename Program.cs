using EditorGrafico;


try
{
    Console.WriteLine("Punto 1: ");
    Punto punto1 = new Punto();
    punto1.x = 23;
    punto1.y = 54;
    Console.WriteLine(punto1.Dibujar());
    Console.WriteLine(punto1.Mover(20, 100));
   
    Console.WriteLine("Circulo: ");
    Circulo Circulo1 = new Circulo(32, 64, 12);
    Console.WriteLine(Circulo1.Dibujar());
    Console.WriteLine(Circulo1.Mover(23, 4));

    Console.WriteLine("Rectángulo"); 

    Rectangulo Rectangulo1 = new Rectangulo(34, 27, 12, 22);
    Console.WriteLine(Rectangulo1.Dibujar());
    Console.WriteLine(Rectangulo1.Mover(200, 210));

    Console.WriteLine("Punto 2: ");
    Punto punto2 = new Punto();
    punto2.x = 21;
    punto2.y = 43;
    Console.WriteLine(punto2.Dibujar());
    Console.WriteLine(punto2.Mover(120, 50));

    Console.WriteLine("--------------------");

   
    Punto punto3 = new Punto();
    punto3.x = 65;
    punto3.y = 23;
    Rectangulo rectangulo2 = new Rectangulo(100, 120, 10, 12);
    GraficoCompuesto grafico = new GraficoCompuesto();
    Console.WriteLine("Gráfico: ");
    grafico.agregarGrafico(punto3);
    grafico.agregarGrafico(rectangulo2);
    Console.WriteLine(grafico.Dibujar());

    Console.WriteLine("Da un espacio para salir del programa.");
    Console.ReadLine();
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Las coordenadas no son correctas");
}
