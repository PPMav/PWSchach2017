using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWochenSchach2017UltimateEdition
{
    class queenFigureClass : figureClass
    {
        public override void Slaying()
        {
            throw new NotImplementedException();
        }
        public override bool Movement(int newPosX, int newPosY, bool player)
        {
            if (positionX == newPosX)
            {
                if (newPosY > positionY || newPosY < positionY)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (positionY == newPosX)
            {
                if (newPosX > positionX || newPosX < positionX)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (newPosX == positionX + x && newPosY == positionY + y)
                    {
                        return true;
                    }
                    else if (newPosX == positionX - x && newPosY == positionY - y)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
