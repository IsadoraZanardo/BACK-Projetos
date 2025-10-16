using System.Runtime.CompilerServices;

namespace Models.BaseShape; //controlar fomras geométricas básicas

// classe abstradea nao pode ser instanciada
public abstract class Shape
{
    //ATRIBUTOS
    //toda forma geométrica vai ter isso
    protected int X; //posição eixo x
                     //protected só relaciona-se entre "família"
    protected int Y; //posição eixo y
    protected int SpeedX; //velocidade eixo x
    protected int SpeedY; //velocidade eixo y
    protected int Width; //base
    protected int Heigth; //altura
    public Color ColorShape { get; protected set; } //"Color" é do próprio sistema para selecionar cores


    //CONSTRUTORES
    public Shape(int x, int y, Color color, int width, int heigth)
    {
        X = x;
        Y = y;
        SpeedX = 20;
        SpeedY = 20;
        Width = width;
        Heigth = heigth;
        ColorShape = color;
    }


    //MÉTODOS
     public void Move(int xLimit, int yLimit)
    {
        if (X > xLimit - Width || X < 0)
            SpeedX = -SpeedX; //transforma positivo em negativo e vice-versa

        if (Y > yLimit - Heigth || Y < 0)
            SpeedY = -SpeedY; //transforma positivo em negativo e vice-versa

            X+=SpeedX;
            Y+=SpeedY;
    }


    //TO.STRING
    public override string ToString()
    {
        return $"X Position: {X} \nY Position: {Y} \nCor: {ColorShape}";
    }
}