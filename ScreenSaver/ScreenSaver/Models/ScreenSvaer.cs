namespace Models.Screens;

using System.Drawing;
using System.Windows.Forms;
using Models.BaseShape;

public class ScreenSaver : Form
// : é sinonimo de herança
{
    // ******* Declare suas formas geométricas aqui (escopo global) *******
    MyRectangle r; //r é o primeiro retângulo
    // ********************************************************************
    
    private Timer ControlTimer; //atributo fixo

    public ScreenSaver() //método ocnstrutor pois tem o mesmo nome da classe
    {
        this.DoubleBuffered = true;  //evitar flickering, objeto não ficar travando e deixa suave
        this.WindowState = FormWindowState.Maximized;   //maximizar a janela

        //BACKGROUND COLOR
        this.BackColor = Color.Black;

        //INICIALIAR TEMPORIZADOR
        ControlTimer = new Timer();
        ControlTimer.Interval = 16; // 16ms = ~60 fps, faz com que a tela atualize 60 vezes por segundo

        //CONTROLAR ANIMAÇÃO
        ControlTimer.Tick += (s, e) => //capturar o evento, é uma função anònima/arrow (não tem nome)
        {
            // ****** Mova suas formas geométricas aqui ******
            r.Move(ClientSize.Height, ClientSize.Height);
            // ***********************************************

            Invalidate(); //manda todos se movimentarem e depois invalida, faz com que o sitema precise redesenhar
        }; // Função anônima disparada pelo ControlTimer a cada Interval (ms) 

        ControlTimer.Start();
    } //FIM DO CONSTRUTOR


    //INSTANCIAR OS OBJETOS AQUI
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        // ****** Instancie suas formas geométricas aqui ******
        r = new MyRectangle(0, 500, Color.DarkRed, 200, 100);
        // ****************************************************
    }


    //DESENHAR AS FORMAS GEOMÉTRICAS NA TELA
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        // ****** Desenhe suas formas geométricas aqui *******
        r.Draw(e.Graphics);
        // ***************************************************

    }
}