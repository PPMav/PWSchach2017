using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWochenSchach2017UltimateEdition
{
    class pawnFigureClass : figureClass
    {
        public override void Slaying()
        {
            throw new NotImplementedException();
        }
        public override bool Movement(int newPosX, int newPosY, bool player)
        {
            if (positionX == newPosX)
            {
                if (side == player && !side && positionY == 1 && newPosY <= positionY +2)
                {
                    return true;
                }
                else if (side == player && side && positionY == 7 && newPosY >= positionY -2)
                {
                    return true;
                }
                else
                {
                    if (side == player && !side && newPosY == positionY +1)
                    {
                        return true;
                    }
                    else if (side == player && side && newPosY == positionY - 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }
    }
}
