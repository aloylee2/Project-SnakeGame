﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Rewards
    {
        List<Position> appleList;
        Board mainBoard;

        public Rewards(int size, Board mainBoard)
        {
            this.mainBoard = mainBoard;
            appleList = new List<Position>();
            for (int i=0;i< size;i++)
            {
                int rowNo, colNo;

                //Generate an apple at random position but not duplicated
                do
                {
                    //Generate a random number between 1 and MaxRowNo
                    rowNo = (new Random()).Next(1, mainBoard.getMaxRowNo()+1);

                    //Generate a random number between 1 and MaxColNo
                    colNo = (new Random()).Next(1, mainBoard.getMaxColNo()+1);

                } while (isDuplicate(rowNo, colNo) == true);

                appleList.Add(new Position(rowNo, colNo));
            }
        }

        private Boolean isDuplicate(int row, int col)
        {
            Boolean result = false;

            for (int i=0;i< appleList.Count;i++)
            {
                if (appleList[i].getRowNo() == row && appleList[i].getColNo() == col)
                    result = true;
            }

            return result;
        }
        
        public void draw()
        {
            for (int i = 0; i < appleList.Count; i++)
            {
                mainBoard.draw(appleList[i], Properties.Resources.hamster);
            }     
        }

        public Boolean checkIFSnakeHeadEatApple(Position snakeHead)
        {
            Boolean result = false;

            for (int i = 0; i < appleList.Count; i++)
            {
                if (snakeHead.getRowNo() == appleList[i].getRowNo() && snakeHead.getColNo() == appleList[i].getColNo())
                    result = true;
            }
            return result;
        }

        public Boolean checkIFSnakeEatApple(Position snakeHead)
        {
            Boolean result = false;

            for (int i = 0; i < appleList.Count; i++)
            {
                if (snakeHead.getRowNo() == appleList[i].getRowNo() && snakeHead.getColNo() == appleList[i].getColNo())
                    result = true;
            }
            return result;
        }

        public int eatAppleAtPostion(Position p)
        {
            for (int i = 0; i < appleList.Count; i++)
            {
                if (p.getRowNo() == appleList[i].getRowNo() && p.getColNo() == appleList[i].getColNo())
                {
                    appleList.RemoveAt(i);
                }
            }
            return 30;
        }

        public Boolean noMoreApples()
        {
            if (appleList.Count > 0)
                return false;
            else
                return true;
        }
    }
}
