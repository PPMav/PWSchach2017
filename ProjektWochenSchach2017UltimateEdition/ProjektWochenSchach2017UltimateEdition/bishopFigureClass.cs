using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWochenSchach2017UltimateEdition
{
    class bishopFigureClass : figureClass
    {
        public override void Slaying()
        {
            throw new NotImplementedException();
        }
        public override bool Movement(int newPosX, int newPosY, bool player)
        {
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
