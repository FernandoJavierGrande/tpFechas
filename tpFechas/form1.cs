using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpFechas.clases;


namespace tpFechas
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            
        }
        ModificarFecha nuevaFecha = new ModificarFecha();
        Fecha fecha = new Fecha();
        Fecha diaSIG = new Fecha();
        string contenido;
        string mes = "";
        

        private void boton_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            txt_fecha.BackColor = Color.White;
            txt_fecha.Text = "";
            label_FechaNueva.Text = "";
            contenido = "";
            mes = "";
        }

        private void Boton_diaSig_Click(object sender, EventArgs e)
        {
            try
            {
                contenido = txt_fecha.Text.Trim();


                Console.WriteLine(contenido.Substring(0, 2));
                Console.WriteLine(contenido.Substring(3, 2));
                Console.WriteLine(contenido.Substring(6, 4));

                fecha.Dia = int.Parse(contenido.Substring(0, 2));

                fecha.Mes = int.Parse(contenido.Substring(3, 2));

                fecha.Anio = int.Parse(contenido.Substring(6, 4));



                diaSIG = nuevaFecha.AumentarUnDia(fecha);


                //Console.WriteLine(diaSIG.ControlError.ToString());

                cortarTry(diaSIG.ControlError);

                switch (diaSIG.Mes)
                {
                    case 1:
                        mes = " de enero de ";
                        break;
                    case 2:
                        mes = " de febrero de ";
                        break;
                    case 3:
                        mes = " de marzo de ";
                        break;
                    case 4:
                        mes = " de abril de ";
                        break;
                    case 5:
                        mes = " de mayo de ";
                        break;
                    case 6:
                        mes = " de junio de ";
                        break;
                    case 7:
                        mes = " de julio de ";
                        break;
                    case 8:
                        mes = " de agosto de ";
                        break;
                    case 9:
                        mes = " de septiembre de ";
                        break;
                    case 10:
                        mes = " de octubre de ";
                        break;
                    case 11:
                        mes = " de noviembre de ";
                        break;
                    case 12:
                        mes = " de diciembre de ";
                        break;



                }

                label_FechaNueva.Text = diaSIG.Dia.ToString() + mes + diaSIG.Anio.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("El formato no corresponde");
                limpiar();
            }

        
        }
        private bool cortarTry(bool aux)
        {
            if (aux == false)
            {
                throw new ArgumentNullException();
            }
            else
            {
                aux = true;
            }

            return aux;
        }
    }
}
