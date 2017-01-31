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
                        PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\BS.PNG");
                    }
                    else if (positionY == 350)
                    {
                        Figur BS = new Figur();
                        FigurenL[x, y] = BS;
                        FigurenL[x, y].Aktiv = true;
                        FigurenL[x, y].Rolle = "Bauer";
                        FigurenL[x, y].Spieler = "weiß";
                        PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\BW.PNG");
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
                        PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\TW.PNG");
                    }
                    else if (positionY == 50 && (positionX == 50 || positionX == 400))
                    {
                        Figur BW = new Figur();
                        FigurenL[x, y] = BW;
                        FigurenL[x, y].Aktiv = true;
                        FigurenL[x, y].Rolle = "Turm";
                        FigurenL[x, y].Spieler = "schwarz";
                        PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\TS.PNG");
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
                            PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\SS.PNG");
                        }
                        else
                        {
                            FigurenL[x, y].Spieler = "weiß";
                            PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\SW.PNG");
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
                            PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\LS.PNG");
                        }
                        else
                        {
                            FigurenL[x, y].Spieler = "weiß";
                            PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\LW.PNG");
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
                            PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\KÖS.PNG");
                        }
                        else
                        {
                            FigurenL[x, y].Spieler = "weiß";
                            PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\KÖW.PNG");
                        }
                    }
                    #endregion

                    #region Königin
                    else if (positionY == 50 && positionX == 200 || positionY == 400 && positionX == 200)
                    {
                        Figur BW = new Figur();
                        FigurenL[x, y] = BW;
                        FigurenL[x, y].Aktiv = true;
                        FigurenL[x, y].Rolle = "Königin";
                        if (positionY == 50)
                        {
                            FigurenL[x, y].Spieler = "schwarz";
                            PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\KS.PNG");
                        }
                        else
                        {
                            PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\KW.PNG");
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
                    pb.Click += new System.EventHandler(TurmBewegen);
                    positionX = positionX + 50;
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    Controls.Add(pb);

                }
                positionX = 50;
                positionY = positionY + 50;
            }
        }
        
        public void FigurenZuweisen(List<Figur> Figuren)
        {
            string[] Buchstaben = new string[]{"A", "B", "C", "D", "E", "F", "G", "H"};
            string[] Zahlen = new string[] {"1", "2", "3", "4", "5", "6", "7", "8"};
            for (int i = 0; i < 16; i++)
            {
                if (i >= 0 && i < 16)
                {
                    Figuren[i].Aktiv = true;
                    Figuren[i].Spieler = "weiß";
                    Figuren[i].Rolle = "Bauer";
                    //Figuren[i].PositionX = Buchstaben[i];
                    //Figuren[i].PositionY = Zahlen[1];
                }
                else
                {
                    Figuren[i].Aktiv = true;
                    Figuren[i].Spieler = "schwarz";
                    Figuren[i].Rolle = "Bauer";
                    //Figuren[i].PositionX = Buchstaben[i/2];
                    //Figuren[i].PositionY = Zahlen[6];
                }
            }
        }

        private void FrmSchach_Load(object sender, EventArgs e)
        {

        }

        private void TurmBewegen(object sender, EventArgs e)
        {
            
        }       
        
        private bool BewegungOK(Figur F, int PositionXAlt , int PositionYAlt, int PositionXNeu , int PositionYNeu)
        {
            bool ok = true;
            string gegner = "schwarz";
            if (F.Spieler != "weiß")
	        {
		        gegner = "weiß";
	        }
            if (F.Rolle == "Turm")
            {
                if (PositionXAlt != PositionXNeu && PositionYAlt != PositionYNeu)
                {
                    ok = false;
                }
                else if (PositionXAlt != PositionXNeu && PositionYAlt == PositionYNeu)
                {
                    if (PositionXAlt > PositionXNeu)
                    {
                        for (int i = PositionXAlt; i > (PositionXNeu); i--)
                        {
                            if (FigurenL[PositionXAlt,PositionYAlt].Spieler == FigurenL[i, PositionYNeu].Spieler)
                            {
                                ok = false;
                            }
                            else if (FigurenL[i - 1, PositionYNeu].Spieler == gegner)
                            {
                                ok = false;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 8 - PositionXAlt; i++)
                        {

                        }
                    }
                }
                else if (PositionXAlt == PositionXNeu && PositionYAlt != PositionYNeu)
                {
                    
                }
            }
            return ok;
        }
    }
}
