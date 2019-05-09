using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife2D
{
    class Cell
    {
        public bool Life { get; set; }
        public int[] id = new int[2];
        public int [,] neighbors = new int[8,2];

        public Cell()
        {
            this.Life = false;
            this.id[0] = 0;
            this.id[1] = 0;
        }

        public Cell(int[] id, bool life, int boardSize)
        {
            this.id = id;
            this.Life = life;

        }

        public void setNeighbors(int boardSize, int boardH)
        {
            if (this.id[1] == 0)
            {
                this.neighbors[0,1]=boardSize - 1;
                this.neighbors[4,1] = id[1] + 1;

                //if(this.id[0]==0)
                //{
                    this.neighbors[1,1] = boardSize - 1;
                    this.neighbors[2,1] = id[1] ;
                    this.neighbors[3,1] = id[1]+1;
               //
                    this.neighbors[7,1] = boardSize - 1;
                    this.neighbors[6,1] = id[1];
                    this.neighbors[5,1] = id[1]+1;
               // }
            }
            else if (this.id[1] == (boardSize - 1))
            {
                this.neighbors[0,1] = id[1] - 1;
                this.neighbors[4,1] = 0;

                this.neighbors[1, 1] = id[1] - 1;
                this.neighbors[2, 1] = id[1];
                this.neighbors[3, 1] = 0;

                this.neighbors[7, 1] = id[1] - 1;
                this.neighbors[6, 1] = id[1];
                this.neighbors[5, 1] = 0;
            }
            else
            {
                this.neighbors[0,1] = id[1] - 1;
                this.neighbors[4,1] = id[1] + 1;

                this.neighbors[1, 1] = id[1] - 1;
                this.neighbors[2, 1] = id[1];
                this.neighbors[3, 1] = id[1] + 1;

                this.neighbors[7, 1] = id[1] - 1;
                this.neighbors[6, 1] = id[1];
                this.neighbors[5, 1] = id[1] + 1;
            }

            this.neighbors[0, 0] = id[0];
            this.neighbors[4, 0] = id[0];

            if(id[0]==0)
            {
                this.neighbors[1, 0] = boardH - 1;
                this.neighbors[2, 0] = boardH - 1;
                this.neighbors[3, 0] = boardH - 1;
            }
            else
            {
                this.neighbors[1, 0] = id[0] - 1;
                this.neighbors[2, 0] = id[0] - 1;
                this.neighbors[3, 0] = id[0] - 1;
            }

            if(id[0]==boardH-1)
            {
                this.neighbors[7, 0] = 0;
                this.neighbors[6, 0] = 0;
                this.neighbors[5, 0] = 0;
            }
            else
            {
                this.neighbors[1, 0] = id[0] + 1;
                this.neighbors[2, 0] = id[0] + 1;
                this.neighbors[3, 0] = id[0] + 1;
            }
        }
    }
}
