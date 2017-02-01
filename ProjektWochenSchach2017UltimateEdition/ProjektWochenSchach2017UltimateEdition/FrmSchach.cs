using ProjektWochenSchach2017UltimateEdition;
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
        bool playerTurn = true; //true = white , false = black
        int[] selectedFigure = new int[2];
        PictureBox[,] chessboardArray = new PictureBox[8, 8];
        PictureBox[,] figurepicturesArray = new PictureBox[8, 8];
        figureClass[,] figureArray = new figureClass[8, 8];
        #endregion

        public FrmSchach()
        {            
            InitializeComponent();
                      
        }        
       
        
                       
        private void InitializeFigures()
        {
            int posX = 50;
            int posY = 50;

            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    #region Pawn
                    if (posY == 100)
                    {
                        pawnFigureClass pawnBlack = new pawnFigureClass();
                        figureArray[x, y] = pawnBlack;
                        pawnBlack.side = false;
                        pawnBlack.active = true;
                        pawnBlack.positionX = x;
                        pawnBlack.positionY = y;
                        pawnBlack.role = "Pawn";

                        figurepicturesArray[x, y] = new PictureBox();
                        figurepicturesArray[x, y].Location = new Point(posX, posY);
                        figurepicturesArray[x, y].Name = "Black Pawn" + x;
                        figurepicturesArray[x, y].Size = new Size(50, 50);
                        figurepicturesArray[x, y].Image = ProjektWochenSchach2017UltimateEdition.Properties.Resources.bS;
                        figurepicturesArray[x, y].Click += new EventHandler(this.MoveFigure);
                    }
                    else if (posY == 350)
                    {
                        pawnFigureClass pawnWhite = new pawnFigureClass();
                        figureArray[x, y] = pawnWhite;
                        figureArray[x, y].side = true;
                        figureArray[x, y].active = true;
                        figureArray[x, y].positionX = x;
                        figureArray[x, y].positionY = y;
                        figureArray[x, y].role = "Pawn";

                        figurepicturesArray[x, y] = new PictureBox();
                        figurepicturesArray[x, y].Location = new Point(posX, posY);
                        figurepicturesArray[x, y].Name = "Black Pawn" + x;
                        figurepicturesArray[x, y].Size = new Size(50, 50);
                        figurepicturesArray[x, y].Image = ProjektWochenSchach2017UltimateEdition.Properties.Resources.bw;
                        figurepicturesArray[x, y].Click += new EventHandler(this.MoveFigure);
                    }
                    #endregion
                    #region Towers
                    else if (posY == 400 && (posX == 50 || posX == 400))
                    {
                        towerFigureClass towerBlack = new towerFigureClass();
                        figureArray[x, y] = towerBlack;
                        figureArray[x, y].side = false;
                        figureArray[x, y].active = true;
                        figureArray[x, y].positionX = x;
                        figureArray[x, y].positionY = y;
                        figureArray[x, y].role = "Tower";

                        figurepicturesArray[x, y] = new PictureBox();
                        figurepicturesArray[x, y].Location = new Point(posX, posY);
                        figurepicturesArray[x, y].Name = "Black Tower" + x;
                        figurepicturesArray[x, y].Size = new Size(50, 50);
                        figurepicturesArray[x, y].Image = ProjektWochenSchach2017UltimateEdition.Properties.Resources.tw;
                        figurepicturesArray[x, y].Click += new EventHandler(this.MoveFigure);

                    }
                    else if (posY == 50 && (posX == 50 || posX == 400))
                    {
                        towerFigureClass towerWhite = new towerFigureClass();
                        figureArray[x, y] = towerWhite;
                        figureArray[x, y].side = true;
                        figureArray[x, y].active = true;
                        figureArray[x, y].positionX = x;
                        figureArray[x, y].positionY = y;
                        figureArray[x, y].role = "Tower";

                        figurepicturesArray[x, y] = new PictureBox();
                        figurepicturesArray[x, y].Location = new Point(posX, posY);
                        figurepicturesArray[x, y].Name = "White Tower" + x;
                        figurepicturesArray[x, y].Size = new Size(50, 50);
                        figurepicturesArray[x, y].Image = ProjektWochenSchach2017UltimateEdition.Properties.Resources.ts;
                        figurepicturesArray[x, y].Click += new EventHandler(this.MoveFigure);
                    }
                    #endregion
                    #region Bishops
                    else if ((posY == 50 && (posX == 100 || posX == 350)) || (posY == 400 && (posX == 100 || posX == 350)))
                    {
                        bishopFigureClass bishop = new bishopFigureClass();
                        figureArray[x, y] = bishop;
                        figureArray[x, y].active = true;
                        figureArray[x, y].positionX = x;
                        figureArray[x, y].positionY = y;
                        figureArray[x, y].role = "Bishop";

                        if (posY == 50)
                        {
                            figureArray[x, y].side = false;

                            figurepicturesArray[x, y] = new PictureBox();
                            figurepicturesArray[x, y].Location = new Point(posX, posY);
                            figurepicturesArray[x, y].Name = "Black Bishop" + x;
                            figurepicturesArray[x, y].Size = new Size(50, 50);
                            figurepicturesArray[x, y].Image = ProjektWochenSchach2017UltimateEdition.Properties.Resources.ls;
                            figurepicturesArray[x, y].Click += new EventHandler(this.MoveFigure);
                        }
                        else
                        {
                            figureArray[x, y].side = true;

                            figurepicturesArray[x, y] = new PictureBox();
                            figurepicturesArray[x, y].Location = new Point(posX, posY);
                            figurepicturesArray[x, y].Name = "White Bishop" + x;
                            figurepicturesArray[x, y].Size = new Size(50, 50);
                            figurepicturesArray[x, y].Image = ProjektWochenSchach2017UltimateEdition.Properties.Resources.lw;
                            figurepicturesArray[x, y].Click += new EventHandler(this.MoveFigure);
                            //PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\SW.PNG");
                        }
                        
                        
                    }
                    #endregion
                    #region Kings
                    else if (posY == 50 && posX == 250 || posY == 400 && posX == 250)
                    {
                        figureArray[x, y] = new kingFigureClass();
                        figureArray[x, y].active = true;
                        figureArray[x, y].role = "King";
                        figureArray[x, y].positionX = x;
                        figureArray[x, y].positionY = y;
                        if (posY == 50)
                        {
                            figureArray[x, y].side = false;

                            figurepicturesArray[x, y] = new PictureBox();
                            figurepicturesArray[x, y].Location = new Point(posX, posY);
                            figurepicturesArray[x, y].Name = "Black King";
                            figurepicturesArray[x, y].Size = new Size(50, 50);
                            figurepicturesArray[x, y].Image = ProjektWochenSchach2017UltimateEdition.Properties.Resources.kS;
                            figurepicturesArray[x, y].Click += new EventHandler(this.MoveFigure);
                            //PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\KÖS.PNG");
                        }
                        else
                        {
                            figureArray[x, y].side = true;

                            figurepicturesArray[x, y] = new PictureBox();
                            figurepicturesArray[x, y].Location = new Point(posX, posY);
                            figurepicturesArray[x, y].Name = "White King";
                            figurepicturesArray[x, y].Size = new Size(50, 50);
                            figurepicturesArray[x, y].Image = ProjektWochenSchach2017UltimateEdition.Properties.Resources.kw;
                            figurepicturesArray[x, y].Click += new EventHandler(this.MoveFigure);
                            //PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\KÖW.PNG");
                        }
                    }
                    #endregion
                    #region Queens
                    else if (posY == 50 && posX == 200 || posY == 400 && posX == 200)
                    {
                        figureArray[x, y] = new queenFigureClass();
                        figureArray[x, y].active = true;
                        figureArray[x, y].positionX = x;
                        figureArray[x, y].positionY = y;
                        figureArray[x, y].role = "Queen";
                        if (posY == 50)
                        {
                            figureArray[x, y].side = false;

                            figurepicturesArray[x, y] = new PictureBox();
                            figurepicturesArray[x, y].Location = new Point(posX, posY);
                            figurepicturesArray[x, y].Name = "Black Queen";
                            figurepicturesArray[x, y].Size = new Size(50, 50);
                            figurepicturesArray[x, y].Image = ProjektWochenSchach2017UltimateEdition.Properties.Resources.ds;
                            figurepicturesArray[x, y].Click += new EventHandler(this.MoveFigure);
                            //PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\KS.PNG");
                        }
                        else
                        {
                            figureArray[x, y].side = true;

                            figurepicturesArray[x, y] = new PictureBox();
                            figurepicturesArray[x, y].Location = new Point(posX, posY);
                            figurepicturesArray[x, y].Name = "White Queen";
                            figurepicturesArray[x, y].Size = new Size(50, 50);
                            figurepicturesArray[x, y].Image = ProjektWochenSchach2017UltimateEdition.Properties.Resources.dw;
                            figurepicturesArray[x, y].Click += new EventHandler(this.MoveFigure);
                            //PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\KW.PNG");
                        }
                    }
                    #endregion

                    Controls.Add(figurepicturesArray[x, y]);
                    posX += 50;
                }
                posX = 50;
                posY += 50;
            }
        }

        private void InitializeChessboard()
        {
            int posX = 50;
            int posY = 50;

            int posXLabels = 70;
            string[] labelLetters = new string[] { "A", "B", "C","D", "E", "F","G","H" };
            for (int i = 0; i < 8; i++)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Location = new Point(posXLabels, 35);
                label.Size = new Size(20, 13);
                label.Text = labelLetters[i];
                Controls.Add(label);
                posXLabels += 50;
            }

            int posYLabels = 70;
            string[] labelNumbers = new string[] { "1", "2", "3", "4", "5", "6", "7", "8" };
            for (int i = 0; i < 8; i++)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Location = new Point(35, posYLabels);
                label.Size = new Size(20, 13);
                label.Text = labelNumbers[(labelNumbers.Length - 1) - i];
                Controls.Add(label);
                posYLabels += 50;
            }


            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    PictureBox pb = new PictureBox();
                    chessboardArray[x, y] = pb;                    
                    if (posY % 100 == 0 && posX % 100 == 0 || posY % 100 == 50 && posX % 100 == 50)
                    {
                        pb.BackColor = Color.White;                        
                    }
                    else
                    {                        
                        pb.BackColor = Color.Gray;                        
                    }                    
                    pb.Location = new Point(posX, posY);
                    pb.Size = new Size(50, 50);
                    posX = posX + 50;
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    Controls.Add(pb);

                }
                posX = 50;
                posY = posY + 50;
            }
        }
        
        private void FrmSchach_Load(object sender, EventArgs e)
        {
            InitializeFigures();
            InitializeChessboard();
            
        }

        private void MoveFigure(object sender, EventArgs e)
        {
          
        }

        
    }
}
