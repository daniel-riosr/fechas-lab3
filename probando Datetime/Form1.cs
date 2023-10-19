using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace probando_Datetime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //funcion para calcular cuantos dias faltan para la proxima endulzada 
        private int CalcularDiasParaProximaEndulzada(DateTime fechaInicio, DateTime fechaFin, DateTime fechaX, int frecuencia)
        {
            if (fechaInicio <= fechaFin && frecuencia > 0)
            {
                if (fechaX >= fechaInicio && fechaX <= fechaFin)
                {
                    TimeSpan diferencia = fechaX - fechaInicio;
                    int diasTranscurridos = diferencia.Days;
                    int diasHastaProximaEndulzada = frecuencia - (diasTranscurridos % frecuencia);
                    return diasHastaProximaEndulzada;
                }
                else
                {
                    throw new ArgumentException("La fecha debe estar dentro del rango de fechas del juego.");
                }
            }
            else
            {
                throw new ArgumentException("La fecha de inicio debe ser anterior o igual a la fecha de fin, y la frecuencia debe ser mayor a cero.");
            }
        }

        private void btnProximaEndulzada_Click(object sender, EventArgs e)
        {
            DateTime fechaInicial = fechaInicio.Value;
            DateTime fechaFinal = fechaFin.Value;
            DateTime fechaX = fechaActual.Value;
            int frecuenciaEndulzadas = (int)frecuencia.Value;

            try
            {
                int diasParaProximaEndulzada = CalcularDiasParaProximaEndulzada(fechaInicial, fechaFinal, fechaX, frecuenciaEndulzadas);
                lblproxEndul.Text = "Faltan: " + diasParaProximaEndulzada.ToString() + "Días para la próxima endulzada";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}