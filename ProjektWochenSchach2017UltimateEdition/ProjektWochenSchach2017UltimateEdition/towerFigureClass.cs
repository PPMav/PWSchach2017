using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWochenSchach2017UltimateEdition
{
    public class towerFigureClass : figureClass
    {
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
