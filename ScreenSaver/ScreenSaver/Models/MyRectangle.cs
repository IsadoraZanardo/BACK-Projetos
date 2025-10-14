namespace Models.BaseShape;

public class MyRectangle : Shape
{
    //ATRIBUTOS
    public int Width; //base
    public int Heigth; //altura


    //CONSTRUTORES
    public MyRectangle(int x, int y, Color color, int width, int heigth) : base(x, y, color)
    {
        //puxando x, y e color de Shape.cs e precisa repetir dentrp do base
        //inicializar atributos da classe pai antes da classe filho
        Width = width;
        Heigth = heigth;
    }


    //MÉTODOS
    public void Draw(Graphics g)
    {
        using var brush = new SolidBrush(ColorShape);
        //SolidBrush brush é uma classe já pronta para pintar figuras geométricas
        g.FillRectangle(brush, X, Y, Width, Heigth);
        //g é o objeto graphics que vou receber como parâmetro 
    }

    public void Move(int xLimit, int yLimit)
    {
        if (X<xLimit)
            X++;
        if (Y<yLimit)   
             Y++;
    }
} 