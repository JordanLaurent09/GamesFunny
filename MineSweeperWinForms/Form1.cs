using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeperWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateButtonField(10);
        }

        // Method for creating basic array with mines

        private int[,] CreateBasicMineArray(int size)
        {
            Random random = new Random();
            int[,] field = new int[size, size];
            for(int j = 0; j < size; j++)
            {
                for(int i = 0; i < size; i++)
                {
                    field[j, i] = random.Next(0, 10);
                }
            }
            return field;
        }

        // Method for auto-creation of buttons

        private void CreateButtonField(int size)
        {
            // Initial position of first button
            int initX = 200;
            int initY = 200;

            // Parameters of buttons
            int heightBtn = 20;
            int widthBtn = 20;

            // Creation of buttons array

            Button[,] buttons = new Button[size, size];

            for(int y = 0; y < size; y++)
            {
                for(int x = 0; x < size; x++)
                {
                    buttons[y, x] = new Button();
                    buttons[y, x].Font = new Font(Font.FontFamily, 16);
                    buttons[y, x].SetBounds(initX, initY, widthBtn, heightBtn);
                    Controls.Add(buttons[y, x]);
                    initX += 20;
                }
                initX = 200;
                initY += 20;
            }
        }


    }
}
