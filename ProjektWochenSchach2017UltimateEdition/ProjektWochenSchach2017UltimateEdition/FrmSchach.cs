using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektWochenSchach2017UltimateEdition;

namespace SchachTest
{
    public partial class FrmSchach : Form
    {
        #region Var
        bool Start = true;
        bool ErsterZug = true;
        //public List<Figur> Figuren = new List<Figur>();
        //List<PictureBox> Pbx = new List<PictureBox>();
        Figur[,] FigurenL = new Figur[8, 8];
        PictureBox[,] PictureL = new PictureBox[8, 8];        
        int MouseXAlt;
        int MouseYAlt;
        int AuswahlArrayX;
        int AuswahlArrayY;
        bool Auswahl = true;
        string[,] OriginalFarbe = new string[8,8];
        bool[,] Möglich = new bool[8, 8];
        string AktiverSpieler = "weiß";
        bool SchachBool;
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
                            //PictureL[x, y].BackgroundImage = ProjektWochenSchach2017UltimateEdition.Properties.Resources.
                        }
                        else
                        {
                            FigurenL[x, y].Spieler = "weiß";
                            PictureL[x, y].BackgroundImage = Image.FromFile(@"..\..\..\figuren\dw.PNG");
                        }
                    }
                    #endregion

                    else
                    {
                        FigurenL[x, y] = new Figur();                        
                        FigurenL[x, y].Rolle = "none";
                    }
                    positionX = positionX + 50;
                }
                positionX = 50;
                positionY = positionY + 50;
            }
            #endregion
            ErsterZug = false;
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
                        OriginalFarbe[x, y] = "Gray";
                    }
                    else
                    {                        
                        pb.BackColor = Color.White;
                        OriginalFarbe[x, y] = "White";
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
            #region Auswahl
            if (Auswahl == true)
            {
                MouseXAlt = Convert.ToInt32(this.PointToClient(Cursor.Position).X);
                MouseYAlt = Convert.ToInt32(this.PointToClient(Cursor.Position).Y);
                for (int y = 0; y < 8; y++)
                {
                    for (int x = 0; x < 8; x++)
                    {
                        if (MouseXAlt >= PictureL[x, y].Location.X && MouseXAlt < (PictureL[x, y].Location.X + 50))
                        {
                            if (MouseYAlt >= PictureL[x, y].Location.Y && MouseYAlt < (PictureL[x, y].Location.Y + 50))
                            {
                                AuswahlArrayX = x;
                                AuswahlArrayY = y;
                                PictureL[x, y].BackColor = Color.Aqua; 
                            }
                        }
                    }
                }


                Auswahl = false;
            }
            #endregion

            #region Bewegung
            else
            {
                int MouseX = Convert.ToInt32(this.PointToClient(Cursor.Position).X);
                int MouseY = Convert.ToInt32(this.PointToClient(Cursor.Position).Y);
                bool ok = true;
                Auswahl = true;
                if (OriginalFarbe[AuswahlArrayX,AuswahlArrayY] == "Gray")
                {
                    PictureL[AuswahlArrayX, AuswahlArrayY].BackColor = Color.Gray;         
                }
                else
                {
                    PictureL[AuswahlArrayX, AuswahlArrayY].BackColor = Color.White;        
                }

                for (int y = 0; y < 8; y++)
                {
                    for (int x = 0; x < 8; x++)
                    {
                        if (MouseX >= PictureL[x, y].Location.X && MouseX < (PictureL[x, y].Location.X + 50))
                        {
                            if (MouseY >= PictureL[x, y].Location.Y && MouseY < (PictureL[x, y].Location.Y + 50))
                            {
                                try
                                {
                                    ok = BewegungOK(FigurenL[AuswahlArrayX, AuswahlArrayY], AuswahlArrayX, AuswahlArrayY, x, y);
                                }
                                catch (Exception)
                                {
                                    ok = false;
                                }

                                if (FigurenL[AuswahlArrayX, AuswahlArrayY].Spieler != AktiverSpieler)
                                {
                                    ok = false;
                                }

                                if (ok == true)
                                {
                                    if (PictureL[x, y] != PictureL[AuswahlArrayX, AuswahlArrayY])
                                    {
                                        if (FigurenL[x, y].Spieler != FigurenL[AuswahlArrayX, AuswahlArrayY].Spieler)
                                        {                                            
                                            PictureL[x, y].BackgroundImage = PictureL[AuswahlArrayX, AuswahlArrayY].BackgroundImage;
                                            FigurenL[x, y] = FigurenL[AuswahlArrayX, AuswahlArrayY];
                                            FigurenL[AuswahlArrayX, AuswahlArrayY] = null;
                                            FigurenL[AuswahlArrayX, AuswahlArrayY] = new Figur();
                                            FigurenL[AuswahlArrayX, AuswahlArrayY].Rolle = "none";
                                            PictureL[AuswahlArrayX, AuswahlArrayY].BackgroundImage = null;
                                            //SchachBool = Schach();
                                            
                                            if (AktiverSpieler == "weiß")
                                            {
                                                AktiverSpieler = "schwarz";
                                                lblSpieler.Text = "Schwarz";
                                                if (SchachBool == true)
                                                {
                                                    MessageBox.Show("Spieler" + AktiverSpieler + "steht im Schach");
                                                }
                                            }
                                            else
                                            {
                                                AktiverSpieler = "weiß";
                                                lblSpieler.Text = "Weiß";
                                                if (SchachBool == true)
                                                {
                                                    MessageBox.Show("Spieler" + AktiverSpieler + "steht im Schach");
                                                }
                                            }                                            
                                        }                                        
                                    } 
                                }                                                               
                            }
                        }
                    }
                }
            }
            #endregion
        }       
        
        private bool FigurDazwischen(Figur F, int xAlt , int yAlt, int xNeu , int yNeu)
        {
            bool ok = true;
            switch (F.Rolle)
            {
                #region Bauer
                case "Bauer":
                    if (FigurenL[xNeu, yNeu].Spieler != null)
                    {
                        ok = false;
                    }
                    else if (F.Spieler == "weiß" && yAlt == 6 && yNeu == 4 && FigurenL[xNeu, (yAlt - 1)].Spieler != null)
                    {
                        ok = false;
                    }
                    else if (F.Spieler == "schwarz" && yAlt == 1 && yNeu == 3 && FigurenL[xNeu, (yAlt + 1)].Spieler != null)
                    {
                        ok = false;
                    }                    

                    break;
                #endregion

                #region Turm
                case "Turm":
                    if (xAlt == xNeu)
                    {
                        if (yAlt > yNeu)
	                    {
		                    for (int y = yAlt - 1; y > yNeu; y--)
                            {
                                if (FigurenL[xAlt, y].Spieler != null)
                                {
                                    ok = false;
                                }
	
                            }
	                    }
                        else
	                    {
                            for (int y = yAlt + 1; y < yNeu; y++)
                            {
                                if (FigurenL[xAlt, y].Spieler != null)
                                {
                                    ok = false;
                                }
                            }
	                    }
                        
                    }
                    else
                    {
                        if (xAlt > xNeu)
                        {
                            for (int x = xAlt - 1; x > xNeu; x--)
                            {
                                if (FigurenL[x, yAlt].Spieler != null)
                                {
                                    ok = false;
                                }

                            }
                        }
                        else
                        {
                            for (int x = xAlt + 1; x < xNeu; x++)
                            {
                                if (FigurenL[x, yAlt].Spieler != null)
                                {
                                    ok = false;
                                }
                            }
                        }
                    }                    

                    break;
                #endregion

                #region Läufer
                case "Läufer":
                    //unten rechts (geht)
                    if (xAlt < xNeu && yAlt < yNeu)
                    {
                        for (int i = xAlt + 1; i < xNeu; i++)
                        {
                            if (FigurenL[i, (i + yAlt) - xAlt].Spieler != null)
                            {
                                ok = false;
                            }
                        }
                    }
                    // oben links (geht)
                    if (xAlt > xNeu && yAlt > yNeu)
                    {
                        for (int i = xAlt - 1; i > xNeu; i--)
                        {
                            if (FigurenL[i, yAlt - (xAlt - i)].Spieler != null)
                            {
                                ok = false;
                            }
                        }
                    }
                    // oben rechts (geht)
                    if (xAlt < xNeu && yAlt > yNeu)
                    {
                        for (int i = xAlt + 1; i < xNeu; i++)
                        {
                            if (FigurenL[i, yAlt - (i - xAlt)].Spieler != null)
                            {
                                ok = false;
                            }
                        }
                    }
                    // unten links 
                    if (xAlt > xNeu && yAlt < yNeu)
                    {
                        for (int i = xAlt - 1; i > xNeu; i--)
                        {
                            if (FigurenL[i, yAlt + (xAlt - i)].Spieler != null)
                            {
                                ok = false;
                            }
                        }
                    }
                    
                    break;
                #endregion

                case "Springer":
                    ok = true;

                    break;

                #region Dame
                case "Dame":
                    if (xAlt == xNeu)
                    {
                        if (yAlt > yNeu)
                        {
                            for (int y = yAlt - 1; y > yNeu; y--)
                            {
                                if (FigurenL[xAlt, y].Spieler != null)
                                {
                                    ok = false;
                                }

                            }
                        }
                        else
                        {
                            for (int y = yAlt + 1; y < yNeu; y++)
                            {
                                if (FigurenL[xAlt, y].Spieler != null)
                                {
                                    ok = false;
                                }
                            }
                        }

                    }
                    else if(yAlt == yNeu)
                    {
                        if (xAlt > xNeu)
                        {
                            for (int x = xAlt - 1; x > xNeu; x--)
                            {
                                if (FigurenL[x, yAlt].Spieler != null)
                                {
                                    ok = false;
                                }

                            }
                        }
                        else
                        {
                            for (int x = xAlt + 1; x < xNeu; x++)
                            {
                                if (FigurenL[x, yAlt].Spieler != null)
                                {
                                    ok = false;
                                }
                            }
                        }
                    }  
                    if (xAlt < xNeu && yAlt < yNeu)
                    {
                        for (int i = xAlt + 1; i < xNeu; i++)
                        {
                            if (FigurenL[i, (i + yAlt) - xAlt].Spieler != null)
                            {
                                ok = false;
                            }
                        }
                    }
                    // oben links (geht)
                    if (xAlt > xNeu && yAlt > yNeu)
                    {
                        for (int i = xAlt - 1; i > xNeu; i--)
                        {
                            if (FigurenL[i, yAlt - (xAlt - i)].Spieler != null)
                            {
                                ok = false;
                            }
                        }
                    }
                    // oben rechts (geht)
                    if (xAlt < xNeu && yAlt > yNeu)
                    {
                        for (int i = xAlt + 1; i < xNeu; i++)
                        {
                            if (FigurenL[i, yAlt - (i - xAlt)].Spieler != null)
                            {
                                ok = false;
                            }
                        }
                    }
                    // unten links 
                    if (xAlt > xNeu && yAlt < yNeu)
                    {
                        for (int i = xAlt - 1; i > xNeu; i--)
                        {
                            if (FigurenL[i, yAlt + (xAlt - i)].Spieler != null)
                            {
                                ok = false;
                            }
                        }
                    }

                    break;
                #endregion

                case "König":
                    ok = true;

                    break;    
                default:
                    break;                    
            }
            return ok;
        }

        private bool Schach()
        {
            bool schach = false;
            int xKönig = 0;
            int yKönig = 0;

            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (FigurenL[x,y].Rolle == "König")
                    {
                        if (AktiverSpieler == "weiß" && FigurenL[x, y].Spieler == "schwarz")
                        {
                            xKönig = x;
                            yKönig = y;
                            //MessageBox.Show(xKönig + " , " + yKönig);
                        }
                        else if (AktiverSpieler == "schwarz" && FigurenL[x, y].Spieler == "weiß")
                        {
                            xKönig = x;
                            yKönig = y;
                        }   
                    }                    
                }
            }

            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (FigurenL[x,y].Spieler == AktiverSpieler)
                    {
                       
                            schach = BewegungOK(FigurenL[x, y], x, y, xKönig, yKönig);                            
                            if (schach == true)
                            {
                                //MessageBox.Show(FigurenL[x, y].Rolle + FigurenL[x, y].Spieler + x + y + xKönig + yKönig);
                                return true;
                            }
                        
                    }
                }
            }

            return schach;
        }

        private bool BewegungOK(Figur F, int PositionXAlt , int PositionYAlt, int x , int y)
        {
            bool ok = true;

            #region Logik
            switch (F.Rolle)//FigurenL[AuswahlArrayX, AuswahlArrayY].Rolle)
            {
                #region Bauer
                case "Bauer":
                    ok = Verwaltung.PawnMovement(AuswahlArrayX, AuswahlArrayY, x, y, FigurenL[AuswahlArrayX, AuswahlArrayY].Spieler);
                    
                    if (ok == true)
                    {
                        ok = FigurDazwischen(F, PositionXAlt, PositionYAlt, x, y);
                    }                    
                    if (FigurenL[AuswahlArrayX, AuswahlArrayY].Spieler == "weiß")
                    {
                        try
                        {
                            if (FigurenL[AuswahlArrayX + 1, AuswahlArrayY - 1] == FigurenL[x, y] || FigurenL[AuswahlArrayX - 1, AuswahlArrayY - 1] == FigurenL[x, y])
                            {
                                if (FigurenL[x, y].Spieler == "schwarz")
                                {
                                    ok = true;
                                }
                            } 
                        }
                        catch (Exception)
                        {                          
                            
                        }                        
                    }
                    else
                    {
                        try
                        {
                            if (FigurenL[AuswahlArrayX + 1, AuswahlArrayY + 1] == FigurenL[x, y] || FigurenL[AuswahlArrayX - 1, AuswahlArrayY + 1] == FigurenL[x, y])
                            {
                                if (FigurenL[x, y].Spieler == "weiß")
                                {
                                    ok = true;
                                }
                            } 
                        }
                        catch (Exception)
                        {                            
                           
                        }                        
                    }  

                    break;
                #endregion

                case "Turm":
                    ok = Verwaltung.Movement(AuswahlArrayX, AuswahlArrayY, x, y);
                    if (ok == true)
                    {
                        ok = FigurDazwischen(F, PositionXAlt, PositionYAlt, x, y);
                    }

                    break;

                case "Läufer":
                    ok = Verwaltung.BishopMovement(AuswahlArrayX, AuswahlArrayY, x, y);
                    if (ok == true)
                    {
                        ok = FigurDazwischen(F, PositionXAlt, PositionYAlt, x, y);
                    }

                    break;

                case "Springer":
                    ok = Verwaltung.HorseMovement(AuswahlArrayX, AuswahlArrayY, x, y);

                    break;

                case "Dame":
                    ok = Verwaltung.QueenMovement(AuswahlArrayX, AuswahlArrayY, x, y);
                    if (ok == true)
                    {
                        ok = FigurDazwischen(F, PositionXAlt, PositionYAlt, x, y);
                    }

                    break;

                case "König":
                    ok = Verwaltung.KingMovement(AuswahlArrayX, AuswahlArrayY, x, y);

                    break;

                default:
                    ok = false;
                    break;
            }
            #endregion
            return ok;            
        }
    }
}
