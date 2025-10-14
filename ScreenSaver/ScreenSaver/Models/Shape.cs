using System.Runtime.CompilerServices;

namespace Models.BaseShape; //controlar fomras geométricas básicas

public class Shape
{
    //ATRIBUTOS
    //toda forma geométrica vai ter isso
    public int X; //posição eixo x
    public int Y; //posição eixo y
    public Color ColorShape; //"Color" é do próprio sistema para selecionar cores


    //CONSTRUTORES
    public Shape(int x, int y, Color color)
    {
        X = x;
        Y = y;
        ColorShape = color;
    }


    //MÉTODOS


    //TO.STRING
    public override string ToString()
    {
        return $"X Position: {X} \nY Position: {Y} \nCor: {ColorShape}";
    }
}