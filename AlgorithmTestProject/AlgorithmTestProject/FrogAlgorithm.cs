using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTestProject
{
    class FrogAlgorithm
    {
        public int findShortestWay((int, int) startPosition, (int, int) endPosition, int[,] arr)
        {
            int positionX = startPosition.Item1;
            int positionY = startPosition.Item2;
            int count = 0;

            while (endPosition.Item2 - positionY != 0 || endPosition.Item1 - positionX != 0)
            {
                int lengthByX = endPosition.Item1 - positionX;
                int lengthByY = Math.Abs(endPosition.Item2 - positionY);

                if (lengthByX == 0)//умова коли ми знаходимось на одному кільці з кінцевою точкою
                {
                    int residual = lengthByY % 3;
                    if (residual == 0 && !(arr[positionX, positionY] == 1))//умова коли нам треба стрибнути на 3 позиції вперед
                    {
                        positionY += 3;
                    }
                    else if (residual == 0 && arr[positionX, positionY + 3 > 16 ? positionY - 16 : positionY] == 1)//умова коли нам треба стрибнути і оминути перешкоду
                    {

                        if (positionX > 2 && positionX <= 16 && !(arr[positionX-2, positionY + 1 > 16 ? positionY - 16 : positionY] == 1))
                        {
                            positionX -= 2;
                            positionY += 1;
                        }
                        else if (positionX >= 0 && positionX < 15 && !(arr[positionX + 2, positionY + 1 > 16 ? positionY - 16 : positionY] == 1))
                        {
                            positionX += 2;
                            positionY += 1;
                        }
                    }
                    else if (residual == 1)//умова коли треба стрибнути на 4 позиції вперед
                    {
                        if (positionX > 1 && positionX <= 16 && !(arr[positionX - 1, positionY + 2 > 16 ? positionY - 16 : positionY] == 1))
                        {
                            positionX -= 1;
                            positionY += 2;
                        }
                        else if (positionX >= 0 && positionX < 16 && !(arr[positionX  +1 , positionY + 2 > 16 ? positionY - 16 : positionY] == 1))
                        {
                            positionX += 1;
                            positionY += 2;
                        }
                    }
                    else if (residual == 2)
                    {
                        if (positionX > 2 && positionX <= 16 && !(arr[positionX - 2, positionY + 1 > 16 ? positionY - 16 : positionY] == 1))
                        {
                            positionX -= 2;
                            positionY += 1;
                        }
                        else if (positionX >= 0 && positionX < 15 && !(arr[positionX + 2, positionY + 1 > 16 ? positionY - 16 : positionY] == 1))
                        {
                            positionX += 2;
                            positionY += 1;
                        }
                    }

                }
                else if (lengthByX < 0)//умова коли кінцева точка знаходиться нижче по Х ніж позиція жаби
                {
                    int residual = Math.Abs(lengthByX % 2);

                    if (residual == 0 && !(arr[positionX - 2, positionY + 1 > 16 ? positionY - 16 : positionY] == 1))//умова коли нам треба стрибнути на 2 позиції вниз
                    {
                        positionX -= 2;
                        positionY += 1;
                    }
                    else //умова коли нам треба стрибнути на 1 позиції вниз
                    {
                        positionX -= 1;
                        positionY += 2;
                    }
                }
                else if (lengthByX > 0)//умова коли кінцева точка знаходиться вище по Х ніж позиція жаби
                {
                    int residual = lengthByX % 2;
                    if (residual == 0 && !(arr[positionX + 2, positionY + 1 > 16 ? positionY - 16 : positionY] == 1))//умова коли нам треба стрибнути на 2 позиції вгору
                    {
                        positionX += 2;
                        positionY += 1;
                    }
                    else//умова коли нам треба стрибнути на 1 позиції вгору
                    {
                        positionX += 1;
                        positionY += 2;
                    }
                }
                if (positionY > 16)
                {
                    positionY -= 16;
                }
                count++;
                if (count == 1000)
                {
                    break;
                }
            }
            return count;
        }
    }
}