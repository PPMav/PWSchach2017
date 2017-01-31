using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWochenSchach2017UltimateEdition
{
    public abstract class figureClass
    {
        //true = white | false = black
        public bool side;
        public string role;
        public int positionX;
        public int positionY;
        public bool active;

        public abstract bool Movement();

        public abstract void Slaying();



    }
}
