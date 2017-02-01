using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWochenSchach2017UltimateEdition
{
    class horseFigureClass : figureClass
    {
        public override void Slaying()
        {
            throw new NotImplementedException();
        }
        public override bool Movement(int newPosX, int newPosY, bool player)
        {
            if ((newPosX == positionX + 1 || newPosX == positionX - 1) && newPosY == positionY - 2)
            {
                return true;
            }
            else if (newPosX == positionX - 2 && (newPosY == positionY - 1 || newPosY == positionY + 1))
            {
                return true;
            }
            else if ((newPosX == positionX + 1 || newPosX == positionX - 1) && newPosY == positionY + 2)
            {
                return true;
            }
            else if (newPosX == positionX + 2 && (newPosY == positionY - 1 || newPosY == positionY + 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
