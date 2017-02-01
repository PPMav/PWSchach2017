using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWochenSchach2017UltimateEdition
{
    class kingFigureClass : figureClass 
    {
        public override bool Movement(int newPosX, int newPosY, bool player)
        {
            if (newPosY == positionY +1 && (newPosX == positionX +1 || newPosX == positionX -1))
            {
                return true;
            }
            else if(newPosY == positionY - 1 && (newPosX == positionX + 1 || newPosX == positionX - 1))
            {
                return true;
            }
            else if (newPosX == positionX && (newPosY == positionY +1 || newPosY == positionY -1))
            {
                return true;
            }
            else if (newPosY == positionY && (newPosX == positionX +1 || newPosX == positionX -1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void Slaying()
        {
            throw new NotImplementedException();
        }

    }
}
