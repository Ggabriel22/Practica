using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compra_de_100_unidades
{
    public partial class Compras : Form
    {
        const double PORC40 = 0.4;//40% de descuento
        const double PORC20 = 0.2;//20% de descuento
        const double PORC10 = 0.1;//10% de descuento
        public Compras()
        {
            InitializeComponent();
        }

        
        private void BtnCalcular_Click(object sender, EventArgs e)
        {


            int und =  Convert.ToInt32(txtcantidad.Text); //Obtener el valor de la caja de texto


            double descuento;
            double monto = 0.0;
            double precio = Convert.ToDouble(txtprecio.Text); ;

            if (und > 100)
            {
                monto = und * precio;
                descuento = monto * PORC40;
                monto = monto - descuento;
            }
            else
                if (und >= 25 && und <= 100)
            {
                monto = und * precio;
                descuento = monto * PORC20;
                monto = monto - descuento;
            }
             else 
                if (und >= 10 &&  und < 25)
                {

                monto = und * precio;
                descuento = monto * PORC10;
                monto = monto - descuento;
                    }

            txtMonto.Text = monto.ToString();

        }//Fin del mètodo

        private void Compras_Load(object sender, EventArgs e)
        {

        }
    } //Fin de declar de clase
} //Fin del espacio de nombre
