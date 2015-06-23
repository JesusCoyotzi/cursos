using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CodeWindow
{
    class Program : Form
    {

        private Label etiqueta;
        private Button boton;

        public Program()
        {
            InitComponents();
        }

        
        public void InitComponents() 
        {
            ClientSize = new Size(250,200);
            Name = "Ventana";
            Text = "Saludo";

            //Label
            etiqueta = new Label();
            etiqueta.Name = "etiqueta";
            etiqueta.Text = "Etiqueta";
            etiqueta.Location = new Point(50, 50);
            etiqueta.Size = new Size(100,50);
            etiqueta.Font = new Font("Microsoft Sans Serif",18,FontStyle.Regular);
            etiqueta.TextAlign = ContentAlignment.TopLeft;
            Controls.Add(etiqueta);


            //boton
            boton = new Button();
            boton.Name = "boton";
            boton.Text = "Clc aqui";
            boton.Size = new Size(100, 50);
            boton.Location = new Point(50, 100);
            boton.Click += new EventHandler(boton_clic);
            Controls.Add(boton);
        }

        public void boton_clic(object sender, EventArgs e)
        {
            etiqueta.Text = "Hola Mundo";
        }
        

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
           
        }


        static void Main(string[] args)
        {
            Application.Run(new Program());
        }
    }
}
