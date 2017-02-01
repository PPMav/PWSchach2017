using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchachTest
{
    public partial class FrmSchach : Form
    {
        #region Var
        bool Start = true;
        bool ErsterZug = true;
        public List<Figur> Figuren = new List<Figur>();
        List<PictureBox> Pbx = new List<PictureBox>();
        Figur[,] FigurenL = new Figur[8, 8];
        PictureBox[,] PictureL = new PictureBox[8, 8];
        #endregion

        public FrmSchach()
        {            
            InitializeComponent();
            if (Start == true)
            {                
                PbxErstellen();
                FigurenErzeugen();
            }            
        }        
       
        private void FigurenErzeugen()
        {
            #region
            Start = false;
            int positionX = 50;
            int positionY = 50;
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    #region Bauer
                    if (positionY == 100)
                    {
                        Figur BW = new Figur();
                        FigurenL[x, y] = BW;
                        FigurenL[x, y].Aktiv = true;
                        FigurenL[x, y].Rolle = "Bauer";
                        FigurenL[x, y].Spieler = "schwarz";
                        PictureL[x, y].BackgroundImage = Image.FromFile(@"..\..\..\figuren\bs.PNG");
                    }
                    else if (positionY == 350)
                    {
                        Figur BS = new Figur();
                        FigurenL[x, y] = BS;
                        FigurenL[x, y].Aktiv = true;
                        FigurenL[x, y].Rolle = "Bauer";
                        FigurenL[x, y].Spieler = "weiß";
                        PictureL[x, y].BackgroundImage = Image.FromFile(@"..\..\..\figuren\bw.PNG");
                    }
                    #endregion

                    #region Turm
                    else if (positionY == 400 && (positionX == 50 || positionX == 400))
                    {
                        Figur BW = new Figur();
                        FigurenL[x, y] = BW;
                        FigurenL[x, y].Aktiv = true;
                        FigurenL[x, y].Rolle = "Turm";
                        FigurenL[x, y].Spieler = "weiß";
                        PictureL[x, y].BackgroundImage = Image.FromFile(@"..\..\..\figuren\tw.PNG");
                    }
                    else if (positionY == 50 && (positionX == 50 || positionX == 400))
                    {
                        Figur BW = new Figur();
                        FigurenL[x, y] = BW;
                        FigurenL[x, y].Aktiv = true;
                        FigurenL[x, y].Rolle = "Turm";
                        FigurenL[x, y].Spieler = "schwarz";
                        PictureL[x, y].BackgroundImage = Image.FromFile(@"..\..\..\figuren\ts.PNG");
                    }
                    #endregion

                    #region Springer
                    else if ((positionY == 50 && (positionX == 100 || positionX == 350)) || (positionY == 400 && (positionX == 100 || positionX == 350)))
                    {
                        Figur BW = new Figur();
                        FigurenL[x, y] = BW;
                        FigurenL[x, y].Aktiv = true;
                        FigurenL[x, y].Rolle = "Springer";
                        if (positionY == 50)
                        {
                            FigurenL[x, y].Spieler = "schwarz";
                            PictureL[x, y].BackgroundImage = Image.FromFile(@"..\..\..\figuren\ss.PNG");
                        }
                        else
                        {
                            FigurenL[x, y].Spieler = "weiß";
                            PictureL[x, y].BackgroundImage = Image.FromFile(@"..\..\..\figuren\sw.PNG");
                        }
                    }
                    #endregion

                    #region Läufer
                    else if (positionY == 50 && (positionX == 150 || positionX == 300) || positionY == 400 && (positionX == 150 || positionX == 300))
                    {
                        Figur BW = new Figur();
                        FigurenL[x, y] = BW;
                        FigurenL[x, y].Aktiv = true;
                        FigurenL[x, y].Rolle = "Läufer";
                        if (positionY == 50)
                        {
                            FigurenL[x, y].Spieler = "schwarz";
                            PictureL[x, y].BackgroundImage = Image.FromFile(@"..\..\..\figuren\ls.PNG");
                        }
                        else
                        {
                            FigurenL[x, y].Spieler = "weiß";
                            PictureL[x, y].BackgroundImage = Image.FromFile(@"..\..\..\figuren\lw.PNG");
                        }
                    }
                    #endregion

                    #region König
                    else if (positionY == 50 && positionX == 250 || positionY == 400 && positionX == 250)
                    {
                        Figur BW = new Figur();
                        FigurenL[x, y] = BW;
                        FigurenL[x, y].Aktiv = true;
                        FigurenL[x, y].Rolle = "König";
                        if (positionY == 50)
                        {
                            FigurenL[x, y].Spieler = "schwarz";
                            PictureL[x, y].BackgroundImage = Image.FromFile(@"..\..\..\figuren\ks.PNG");
                        }
                        else
                        {
                            FigurenL[x, y].Spieler = "weiß";
                            PictureL[x, y].BackgroundImage = Image.FromFile(@"..\..\..\figuren\kw.PNG");
                        }
                    }
                    #endregion

                    #region Dame
                    else if (positionY == 50 && positionX == 200 || positionY == 400 && positionX == 200)
                    {
                        Figur BW = new Figur();
                        FigurenL[x, y] = BW;
                        FigurenL[x, y].Aktiv = true;
                        FigurenL[x, y].Rolle = "Dame";
                        if (positionY == 50)
                        {
                            FigurenL[x, y].Spieler = "schwarz";
                            //System.IO.Directory.GetCurrentDirectory()
                            PictureL[x, y].BackgroundImage = Image.FromFile(@"..\..\..\figuren\ds.PNG");
                        }
                        else
                        {
                            PictureL[x, y].BackgroundImage = Image.FromFile(@"..\..\..\figuren\dw.PNG");
                        }
                    #endregion
                        
                    }
                    positionX = positionX + 50;
                }
                positionX = 50;
                positionY = positionY + 50;
            }
            #endregion
        }
                       
        private void PbxErstellen()
        {
            int positionX = 50;
            int positionY = 50;            
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    PictureBox pb = new PictureBox();
                    PictureL[x, y] = pb;                    
                    if (positionY % 100 == 0 && positionX % 100 == 0 || positionY % 100 == 50 && positionX % 100 == 50)
                    {
                        pb.BackColor = Color.Gray;                        
                    }
                    else
                    {                        
                        pb.BackColor = Color.White;                        
                    }                    
                    pb.Location = new System.Drawing.Point(positionX, positionY);
                    pb.Size = new System.Drawing.Size(50, 50);
                    pb.TabIndex = 49;
                    pb.TabStop = false;
                    pb.Click += new System.EventHandler(FigurBewegen);
                    positionX = positionX + 50;
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    Controls.Add(pb);

                }
                positionX = 50;
                positionY = positionY + 50;
            }
        }        
        
        private void FrmSchach_Load(object sender, EventArgs e)
        {

        }

        private void FigurBewegen(object sender, EventArgs e)
        {
            int MouseX = Convert.ToInt32(this.PointToClient(Cursor.Position).X);
            int MouseY = Convert.ToInt32(this.PointToClient(Cursor.Position).Y);
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {                    
                    if (MouseX >= PictureL[x,y].Location.X && MouseX < (PictureL[x,y].Location.X + 50))
                    {
                        if (MouseY >= PictureL[x, y].Location.Y && MouseY < (PictureL[x, y].Location.Y + 50))
                        {
                            PictureL[x, y + 2].BackgroundImage = Image.FromFile(@"..\..\..\figuren\tw.PNG");
                        }
                    }                                                       
                }
            }            
        }       
        
        private bool BewegungOK(Figur F, int PositionXAlt , int PositionYAlt, int PositionXNeu , int PositionYNeu)
        {
            bool ok = true;
            string gegner = "schwarz";
            if (F.Spieler != "weiß")
	        {
		        gegner = "weiß";
            }
            #region Turm
            if (F.Rolle == "Turm")
            {
                // nicht X und Y Achse gleichzeitig
                if (PositionXAlt != PositionXNeu && PositionYAlt != PositionYNeu)
                {
                    ok = false;
                }
                // Bewegung auf X-Achse
                else if (PositionXAlt != PositionXNeu && PositionYAlt == PositionYNeu)
                {
                    if (PositionXAlt > PositionXNeu)
                    {
                        for (int x = PositionXAlt; x > (PositionXNeu); x--)
                        {
                            // Keine eigenen Figuren angreifen/überspringen
                            if (FigurenL[PositionXAlt,PositionYAlt].Spieler == FigurenL[x, PositionYNeu].Spieler)
                            {
                                ok = false;
                            }
                            // Keine Gegner überspringen
                            else if (FigurenL[x + 1, PositionYNeu].Spieler == gegner)
                            {
                                ok = false;
                            }
                        }
                    }
                    else
                    {
                        for (int x = PositionXAlt; x > (PositionXNeu); x++)
                        {
                            // Keine eigenen Figuren angreifen/überspringen
                            if (FigurenL[PositionXAlt, PositionYAlt].Spieler == FigurenL[x, PositionYNeu].Spieler)
                            {
                                ok = false;
                            }
                            // Keine Gegner überspringen
                            else if (FigurenL[x - 1, PositionYNeu].Spieler == gegner)
                            {
                                ok = false;
                            }
                        }
                    }
                }
                // Bewegung Y-Achse
                else if (PositionXAlt == PositionXNeu && PositionYAlt != PositionYNeu)
                {
                    if (PositionYAlt > PositionYNeu)
                    {
                        for (int y = PositionXAlt; y > (PositionXNeu); y--)
                        {
                            // Keine eigenen Figuren angreifen/überspringen
                            if (FigurenL[PositionXAlt, PositionYAlt].Spieler == FigurenL[PositionXNeu, y].Spieler)
                            {
                                ok = false;
                            }
                            // Keine Gegner überspringen
                            else if (FigurenL[y + 1, PositionYNeu].Spieler == gegner)
                            {
                                ok = false;
                            }
                        }
                    }
                    else
                    {
                        for (int y = PositionXAlt; y > (PositionXNeu); y++)
                        {
                            // Keine eigenen Figuren angreifen/überspringen
                            if (FigurenL[PositionXAlt, PositionYAlt].Spieler == FigurenL[PositionXNeu, y].Spieler)
                            {
                                ok = false;
                            }
                            // Keine Gegner überspringen
                            else if (FigurenL[y - 1, PositionYNeu].Spieler == gegner)
                            {
                                ok = false;
                            }
                        }
                    }
                }
            #endregion
            }
            return ok;
        }
    }
}
