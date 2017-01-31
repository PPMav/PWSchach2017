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
        bool Start = true;
        bool ErsterZug = true;
        public List<Figur> Figuren = new List<Figur>();
        List<PictureBox> Pbx = new List<PictureBox>();
        Figur[,] FigurenL = new Figur[8, 8];
        PictureBox[,] PictureL = new PictureBox[8, 8];
        


        public FrmSchach()
        {            
            InitializeComponent();
            if (Start == true)
            {                
                PbxErstellen();
                FigurenErzeugen();
            }            
        }
        
        private void A7_Click(object sender, EventArgs e)
        {
            if (ErsterZug == true)
            {

            }
            else
            {

            }
                  
        }

        private void FigurenErzeugen()
        {
            #region
            Start = false;
            int positionX = 50;
            int positionY = 50;
            int hochzählen = 0;
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    Figur F = new Figur();
                    FigurenL[x, y] = F;
                    FigurenL[x,y].Aktiv = true;
                    FigurenL[x,y].Rolle = "Bauer";                
                    
                   
                    if (positionY == 100 || positionY == 350)
                    {
                        //PictureL[x, y].BackgroundImage = Image.FromFile(@"C:\Users\iaf53troeger\Desktop\b.PNG");
                    } 
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
                    Figuren[i].Spieler = true;
                    Figuren[i].Rolle = "Bauer";
                    //Figuren[i].PositionX = Buchstaben[i];
                    //Figuren[i].PositionY = Zahlen[1];
                }
                else
                {
                    Figuren[i].Aktiv = true;
                    Figuren[i].Spieler = false;
                    Figuren[i].Rolle = "Bauer";
                    //Figuren[i].PositionX = Buchstaben[i/2];
                    //Figuren[i].PositionY = Zahlen[6];
                }
            }
        }

        private void FrmSchach_Load(object sender, EventArgs e)
        {

        }
        
    }
}
