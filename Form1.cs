namespace Inicial_26_1_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            int Edad;
            char Genero;
            string respuesta;

            Edad=int.Parse(txt_Edad.Text);
            Genero=char.Parse(txt_Genero.Text);

            if (Edad>=18 && Genero == 'm')

            {
                respuesta="Eres hombre, entras pagando.";
            }
            else if (Edad>=18 && Genero== 'f')
            {
                respuesta= "Eres mujer, entras gratis";
            }

            else
            {
                respuesta ="No puedes entrar porque eres menor de edad.";
            }

            txt_Situacion.Text = respuesta;
        }



        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiar_Click_1(object sender, EventArgs e)
        {
            txt_Edad.Clear();
            txt_Genero.Clear();
            txt_Situacion.Clear();
        }

        private void txt_Situacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}