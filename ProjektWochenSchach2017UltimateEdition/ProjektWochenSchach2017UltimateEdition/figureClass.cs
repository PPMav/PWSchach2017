using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWochenSchach2017UltimateEdition
{
    abstract class figureClass
    {
        protected bool side;
        protected string role;
        protected string positionX;
        protected string positionY;
        protected bool active;

        public abstract void Movement();

        public abstract void Slaying();



    }
}
