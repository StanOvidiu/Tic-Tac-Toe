using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    internal class Table
    {
        public Button[,] Buttons = new Button[3,3];
        public int buttonSize = 200;
        private int turn=1;
        private int game=0;
        private int ct=0;

        public Label Turn;
        public Label GameOver;

        public Table() {
            SetProp();
        }

        public void SetProp()
        {
            for(var i = 0;i<3;i++) 
            {
                for(var j=0;j<3;j++)
                {
                    Buttons[i, j] = new Button()
                    {
                        Size = new Size(buttonSize, buttonSize),
                        Location = new Point(buttonSize * i, buttonSize * j),
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.PowderBlue
                    };
                }
            }
        }

        public void Joc(object sender, EventArgs args)
        {
            var button = sender as Button;
            button.BackgroundImageLayout = ImageLayout.Stretch;
            if (turn == 1)
            {
                button.BackgroundImage = Image.FromFile("New Folder/X.png");
                button.Tag = 1;
                turn = 0;
                Turn.Text = "O picks!";
            }
            else
            {
                button.BackgroundImage = Image.FromFile("New Folder/O.png");
                button.Tag = 0;
                turn = 1;
                Turn.Text = "X picks!";
            }
            button.Enabled = false;
            ct++;
            CheckIfWin();
            if (game == 1 || (game == 0 && ct == 9)) 
            {
                for (var i = 0; i < 3; i++)
                    for (var j = 0; j < 3; j++)
                        Buttons[i, j].Enabled = false;
                GameOver.Text = "GAME OVER!";
                Turn.Text = null;
            }
        }
        public void CheckIfWin()
        {
            if (Buttons[0,0].Tag != null && Buttons[1, 0].Tag != null && Buttons[2, 0].Tag != null)
            {
                if (Buttons[0, 0].Tag.Equals(Buttons[1, 0].Tag) && Buttons[0, 0].Tag.Equals(Buttons[2,0].Tag))
                    game = 1;
            }
            if (Buttons[0,0].Tag != null && Buttons[0, 1].Tag != null && Buttons[0, 2].Tag != null)
            {
                if (Buttons[0, 0].Tag.Equals(Buttons[0, 1].Tag) && Buttons[0, 0].Tag.Equals(Buttons[0, 2].Tag))
                    game = 1;
            }
            if (Buttons[2, 0].Tag != null && Buttons[2, 1].Tag != null && Buttons[2, 2].Tag != null)
            {
                if (Buttons[2, 0].Tag.Equals(Buttons[2, 1].Tag) && Buttons[2, 0].Tag.Equals(Buttons[2, 2].Tag))
                    game = 1;
            }
            if (Buttons[0, 2].Tag != null && Buttons[1, 2].Tag != null && Buttons[2, 2].Tag != null)
            {
                if (Buttons[0, 2].Tag.Equals(Buttons[1, 2].Tag) && Buttons[0, 2].Tag.Equals(Buttons[2,2].Tag))
                    game = 1;
            }
            if (Buttons[0, 0].Tag != null && Buttons[1, 1].Tag != null && Buttons[2, 2].Tag != null)
            {
                if (Buttons[0, 0].Tag.Equals(Buttons[1, 1].Tag) && Buttons[0, 0].Tag.Equals(Buttons[2,2].Tag))
                    game = 1;
            }
            if (Buttons[0, 2].Tag != null && Buttons[1, 1].Tag != null && Buttons[0, 2].Tag != null)
            {
                if (Buttons[0, 2].Tag.Equals(Buttons[1, 1].Tag) && Buttons[0, 2].Tag.Equals(Buttons[2,0].Tag))
                    game = 1;
            }
            if (Buttons[1, 0].Tag != null && Buttons[1, 1].Tag != null && Buttons[1, 2].Tag != null)
            {
                if (Buttons[1, 0].Tag.Equals(Buttons[1, 1].Tag) && Buttons[1, 0].Tag.Equals(Buttons[1, 2].Tag))
                    game = 1;
            }
            if (Buttons[0, 1].Tag != null && Buttons[1, 1].Tag != null && Buttons[2, 1].Tag != null)
            {
                if (Buttons[0, 1].Tag.Equals(Buttons[1, 1].Tag) && Buttons[0, 1].Tag.Equals(Buttons[2,1].Tag))
                    game = 1;
            }
        }
    }
}
