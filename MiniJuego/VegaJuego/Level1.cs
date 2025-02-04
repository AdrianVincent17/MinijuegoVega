using System.Runtime.CompilerServices;

namespace VegaJuego
{
    public partial class Level1 : Form
    {
        Link Player;
        Broncas Enemigo1;
        public Level1()
        {
            InitializeComponent();
            IniciarPersonajes();
        }

        private void IniciarOpcionesDelMapa()
        {
            labelVida.Text = "Salud->" + Player.Salud;
            labelEscudo.Text = "Escudo->" + Player.Escudo;
            labelArma.Text = "Arma->" + Player.Arma;
        }

        private void IniciarPersonajes()
        {
            //Lienzo, coordenadaX, coordenadaY, salud, escudo y arma
            Player = new Link(this, 0, 0, 30, 10, 100);
            Enemigo1 = new Broncas(this, 0, 300);
        }



        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Player.mover(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelVida.Text = "Salud->" + Player.Salud;
            labelEscudo.Text = "Escudo->" + Player.Escudo;
            labelArma.Text = "Arma->" + Player.Arma;

            if (Player.Caja.Bounds.IntersectsWith(Enemigo1.Caja.Bounds))

            {   if(Player.Salud>0)
                    Player.Escudo = Player.Escudo - 1;

                if (Player.Escudo <=0)
                {
                    Player.Escudo = 0;
                    Player.Salud = Player.Salud - 1;
                }

                if(Player.Salud == 0)
                {
                    this.Hide();
                    Final End= new Final();
                    //Paramos el temporizados
                    MovEnemigos.Stop();
                    End.Show(); 
                }
                
            }
            Enemigo1.mover();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
