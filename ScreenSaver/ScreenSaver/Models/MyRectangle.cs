namespace Models.BaseShape;

public class MyRectangle : Shape
{
    //ATRIBUTOS
    public int Width; //base
    public int Heigth; //altura


    //CONSTRUTORES
    public MyRectangle(int x, int y, Color color, int width, int heigth) : base(x, y, color, heigth, width)
    {
        //: base chama a classe pai
        //puxando x, y e color de Shape.cs e precisa repetir dentrp do base
        //inicializar atributos da classe pai antes da classe filho
        Width = width;
        Heigth = heigth;
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
    
        public void Draw(Graphics g)
    {
        using var brush = new SolidBrush(ColorShape);
        //SolidBrush brush é uma classe já pronta para pintar figuras geométricas
        g.FillRectangle(brush, X, Y, Width, Heigth);
        //g é o objeto graphics que vou receber como parâmetro 
    }

} 