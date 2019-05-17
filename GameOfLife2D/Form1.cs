using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GameOfLife2D
{
    public partial class Form1 : Form
    {
        int maxSize;
        public Form1()
        {
            InitializeComponent();
            maxSize = (panel1.Width < panel1.Height) ? panel1.Width : panel1.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = (int)numericUpDown1.Value;
            int bH = (int)numericUpDown2.Value;
            int iterations = (int)numericUpDown3.Value;

            int cellSize = (size > bH) ? maxSize / size : maxSize / bH;

            int width = cellSize * size;
            int height = cellSize * bH;
            panel1.Width = width;
            panel1.Height = height;

            panel1.Refresh();
            Board board = new Board(size, bH);
            Game game = new Game(board, bH, cellSize);

            Pen pen = new Pen(Color.MediumVioletRed, 1f);
            SolidBrush brush = new SolidBrush(Color.MediumVioletRed);
            Graphics graphics = panel1.CreateGraphics();

            game.startBoard.setup_glider();
            game.drawResult(width, height, graphics, pen, brush);

            for (int i=1;i< iterations; i++)
            {
               
                Thread.Sleep(300);
                panel1.Refresh();
                game.startBoard.update();
                game.drawResult(width, height, graphics, pen, brush);
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int size = (int)numericUpDown1.Value;
            int bH = (int)numericUpDown2.Value;
            int iterations = (int)numericUpDown3.Value;

            int cellSize = (size > bH) ? maxSize / size : maxSize / bH;

            panel1.Width = cellSize * size;
            panel1.Height = cellSize * bH;

            panel1.Refresh();
            Board board = new Board(size, bH);
            Game game = new Game(board, bH, cellSize);

            Pen pen = new Pen(Color.MediumVioletRed, 1f);
            SolidBrush brush = new SolidBrush(Color.MediumVioletRed);
            Graphics graphics = panel1.CreateGraphics();

            game.startBoard.setup_oscylator();
            game.drawResult(panel1.Width, panel1.Height, graphics, pen, brush);

            for (int i = 1; i < iterations; i++)
            {

                Thread.Sleep(300);
                panel1.Refresh();
                game.startBoard.update();
                game.drawResult(panel1.Width, panel1.Height, graphics, pen, brush);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int size = (int)numericUpDown1.Value;
            int bH = (int)numericUpDown2.Value;
            int iterations = (int)numericUpDown3.Value;

            int cellSize = (size > bH) ? maxSize / size : maxSize / bH;

            panel1.Width = cellSize * size;
            panel1.Height = cellSize * bH;

            panel1.Refresh();
            Board board = new Board(size, bH);
            Game game = new Game(board, bH, cellSize);

            Pen pen = new Pen(Color.MediumVioletRed, 1f);
            SolidBrush brush = new SolidBrush(Color.MediumVioletRed);
            Graphics graphics = panel1.CreateGraphics();

            game.startBoard.setup_const();
            game.drawResult(panel1.Width, panel1.Height, graphics, pen, brush);

            for (int i = 1; i < iterations; i++)
            {

                Thread.Sleep(300);
                panel1.Refresh();
                game.startBoard.update();
                game.drawResult(panel1.Width, panel1.Height, graphics, pen, brush);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int size = (int)numericUpDown1.Value;
            int bH = (int)numericUpDown2.Value;
            int iterations = (int)numericUpDown3.Value;

            int cellSize = (size > bH) ? maxSize / size : maxSize / bH;

            panel1.Width = cellSize * size;
            panel1.Height = cellSize * bH;

            panel1.Refresh();
            Board board = new Board(size, bH);
            Game game = new Game(board, bH, cellSize);

            Pen pen = new Pen(Color.MediumVioletRed, 1f);
            SolidBrush brush = new SolidBrush(Color.MediumVioletRed);
            Graphics graphics = panel1.CreateGraphics();

            game.startBoard.setup_random();
            game.drawResult(panel1.Width, panel1.Height, graphics, pen, brush);

            for (int i = 1; i < iterations; i++)
            {

                Thread.Sleep(300);
                panel1.Refresh();
                game.startBoard.update();
                game.drawResult(panel1.Width, panel1.Height, graphics, pen, brush);
            }
        }
    }
}
