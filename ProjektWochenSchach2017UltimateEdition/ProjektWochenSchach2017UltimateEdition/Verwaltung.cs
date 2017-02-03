using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWochenSchach2017UltimateEdition
{
    public static class Verwaltung
    {
        public static bool PawnMovement(int oldPosX, int oldPosY, int newPosX, int newPosY, string side)
        {
            if (oldPosX == newPosX)
            {
                if (side == "schwarz" && oldPosY == 1 && newPosY <= oldPosY + 2)
                {
                    return true;
                }
                else if (side == "weiß" && oldPosY == 6 && newPosY >= oldPosY - 2)
                {
                    return true;
                }
                else
                {
                    if (side == "schwarz" && newPosY == oldPosY + 1)
                    {
                        return true;
                    }
                    else if (side == "weiß" && newPosY == oldPosY - 1)
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

        public static bool KingMovement(int oldPosX , int oldPosY, int newPosX, int newPosY)
        {
            if (newPosY == oldPosY +1 && (newPosX == oldPosX +1 || newPosX == oldPosX -1))
            {
                return true;
            }
            else if(newPosY == oldPosY - 1 && (newPosX == oldPosX + 1 || newPosX == oldPosX - 1))
            {
                return true;
            }
            else if (newPosX == oldPosX && (newPosY == oldPosY +1 || newPosY == oldPosY -1))
            {
                return true;
            }
            else if (newPosY == oldPosY && (newPosX == oldPosX +1 || newPosX == oldPosX -1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool HorseMovement(int oldPosX, int oldPosY, int newPosX, int newPosY)
        {
            if ((newPosX == oldPosX + 1 || newPosX == oldPosX - 1) && newPosY == oldPosY - 2)
            {
                return true;
            }
            else if (newPosX == oldPosX - 2 && (newPosY == oldPosY - 1 || newPosY == oldPosY + 1))
            {
                return true;
            }
            else if ((newPosX == oldPosX + 1 || newPosX == oldPosX - 1) && newPosY == oldPosY + 2)
            {
                return true;
            }
            else if (newPosX == oldPosX + 2 && (newPosY == oldPosY - 1 || newPosY == oldPosY + 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool TowerMovement(int oldPosX, int oldPosY, int newPosX, int newPosY)
        {
            if (oldPosX == newPosX)
            {
                if (newPosY > oldPosY || newPosY < oldPosY)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (oldPosY == newPosX)
            {
                if (newPosX > oldPosX || newPosX < oldPosX)
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

        public static bool QueenMovement(int positionX, int positionY, int wantedPositionX, int wantedPositionY)
        {
            int differencePositionX = wantedPositionX - positionX;
            int absoluteDifferencePositionX = Math.Abs(differencePositionX);
            int differencePositionY = wantedPositionY - positionY;
            int absoluteDifferencePositionY = Math.Abs(differencePositionY);

            if (absoluteDifferencePositionX == absoluteDifferencePositionY || positionX == wantedPositionX || positionY == wantedPositionY) { return true; }
            else { return false; }

        }

        public static bool BishopMovement(int positionX, int positionY, int wantedPositionX, int wantedPositionY)
        {
            int differencePositionX = wantedPositionX - positionX;
            int absoluteDifferencePositionX = Math.Abs(differencePositionX);
            int differencePositionY = wantedPositionY - positionY;
            int absoluteDifferencePositionY = Math.Abs(differencePositionY);

            if (absoluteDifferencePositionX == absoluteDifferencePositionY) { return true; }
            else { return false; }

        }

        public static bool Movement(int positionX, int positionY, int wantedPositionX, int wantedPositionY)
        {
            if (positionX == wantedPositionX || positionY == wantedPositionY)
            {
                return true;
            }
            else { return false; }
        }
    }
}
