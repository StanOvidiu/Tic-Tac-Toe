using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        Table tabla = new Table();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 900;
            this.Height = tabla.buttonSize * 3 + 40;
            this.BackColor = Color.Beige;

            for(var i = 0; i<3; i++)
            {
                for(var j = 0; j<3; j++)
                {
                    Controls.Add(tabla.Buttons[i, j]);

                    tabla.Buttons[i, j].Click += tabla.Joc;
                }
            }

            tabla.Turn = new Label()
            {
                Text = "X picks!",
                Location = new Point(680, 200),
                AutoSize = true,
                Font = new Font("Calibri", 25),
                ForeColor = Color.Black,
                BackColor = Color.Beige
            };
            Controls.Add(tabla.Turn);

            tabla.GameOver = new Label()
            {
                Location = new Point(630, 280),
                AutoSize = true,
                Font = new Font("Calibri", 30),
                ForeColor = Color.Black,
                BackColor = Color.Beige
            };
            Controls.Add(tabla.GameOver);
        }
    }
}
