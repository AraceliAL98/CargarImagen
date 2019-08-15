using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace TrabajoChidoImagen2._0
{
    public partial class Form1 : Form
    {

        Image<Bgr, byte> _InputColor;
        public Form1()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            //Variable ruta de ña imagen
                string imagen = "C:\\Users\\alumno\\Pictures\\Ace.jpg";
                _InputColor = new Image<Bgr, byte>(imagen);

                if (_InputColor == null)
                {
                    MessageBox.Show("No se cargo la imagen");
                    return;

                }

                imageBox1.Image = _InputColor;

            

        }
    }
}
