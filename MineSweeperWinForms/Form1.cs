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

        // Create an array with numbers, where number 0 means mine, and other numbers are "safe spots"
        private int[] AllFieldCells(int size)
        {
            int[] cells = new int[size];
            Random random = new Random();
            for(int i = 0; i <size; i++)
            {
                cells[i] = random.Next(0, 10);
            }
            return cells;
        }

        // Method for auto-creation of buttons

        private void CreateButtonField(int size)
        {
            // Initial position of first button
            int initX = 200;
            int initY = 50;

            // Parameters of buttons
            int heightBtn = 50;
            int widthBtn = 50;

            // Creation of buttons array

            Button[,] buttons = new Button[size, size];

            for(int y = 0; y < size; y++)
            {
                for(int x = 0; x < size; x++)
                {
                    buttons[y, x] = new Button();
                    buttons[y, x].Font = new Font(Font.FontFamily, 16);
                    buttons[y, x].SetBounds(initX, initY, widthBtn, heightBtn);
                    buttons[y, x].Click += new System.EventHandler(Button_Click);
                    Controls.Add(buttons[y, x]);
                    initX += 50;
                }
                initX = 200;
                initY += 50;
            }
        }


        private void Button_Click(object sender, System.EventArgs e)
        {
            int[] cells = AllFieldCells(100);
            int count = new Random().Next(0, cells.Length);
           
            
                Button button = (Button)sender;
                if (cells[count] == 0)
                {
                    button.Text = "*";
                    MessageBox.Show("ТЫ ВЗОРВАН! НУ И НУ!");
                    
                }
                else
                {
                    button.Text = "-";
                    MessageBox.Show("СПАСИБО, ЧТО ЖИВОЙ");
                }
            
        }

    }
}
