using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Multiy
{
    public class HERO
    {
        public int X, Y;
        public List<Bitmap> imgs=new List<Bitmap>();
        public int ID;
    }
    public class ENmpol
    {
        public int X, Y;
        public List<Bitmap> img=new List<Bitmap>();
        public int ID;
    }
    public class Tinin
    {
        public int X, Y;
        public List<Bitmap> imgs = new List<Bitmap>();
        public int ID;
        public int dir;
    }
    public class Garden
    {
        public int X, Y;
        public Bitmap img;
    }
    public class SAlAM
    {
        public int X, Y;
        public Bitmap img;
    }
    public class Rock
    {
        public int X, Y;
        public Bitmap img;
    }
    public class ENEMY1
    {
        public int X, Y;
        public List< Bitmap>img=new List<Bitmap>();
        public int dir;
        public int ID;
    }
    public class ENEMY2
    {
        public int X, Y;
        public List<Bitmap> img=new List<Bitmap>();
        public int dir;
        public int ID;
    }
    public class LAZiER
    {
        public int X, Y;
        public Bitmap img;
        public int diry;
    }
    public class LITE
    {
        public int X, Y;
        public Bitmap img;
        public int diry;
    }
    public class HEROPOLL
    {
        public int X, Y;
        public List<Bitmap> img = new List<Bitmap>();
        public int ID;
        public int speed;
        public int dir;
    }
    public class DARAG
    {
        public int X, Y;
        public Bitmap img;
        public int diry;
    }
    public class ENEMY3
    {
        public int X, Y;
        public Bitmap img;
    }
    public class SAHRBOLL
    {
        public int X, Y;
        public List<Bitmap> imgs=new List<Bitmap>();
        public int speed;
        public int posd;
        public int ID;
    }
    public class GWHARA
    {
        public int X, Y;
        public Bitmap img;
    }
    public class HART
    {
        public int X, Y;
        public Bitmap img;
    }
    public class SHPAHBOLL
    {
        public int X, Y;
        public Bitmap img;
    }
    public class MOKAP
    {
        public int X, Y;
        public Bitmap img;
    }
    public class GAMEOVER
    {
        public int X, Y;
        public Bitmap img;
    }
    public class SALAM2
    {
        public int X, Y;
        public Bitmap img;
    }
    public class Door
    {
        public int X, Y;
        public List<Bitmap> imgs=new List<Bitmap>();
        public int ID;
    }
    public class Acotr
    {
        public int XD, YD;
        public int XS, YS;
        public Bitmap img;
    }
    public class Bomm
    {
        public int X, Y;
        public List<Bitmap> imgs = new List<Bitmap>();
        public int ID;
    }
    public class smalspah
    {
        public int X, Y, dir;
        public List<Bitmap> imgs = new List<Bitmap>();
        public int ID;
    }

    class Program:Form
    {
        List<HERO> LHE = new List<HERO>();
        List<Tinin> ltinins = new List<Tinin>();
        List<ENmpol> lnpol = new List<ENmpol>();
        List<Garden> lGN = new List<Garden>();
        List<Rock> lrk = new List<Rock>();
        List<SAlAM> lsm = new List<SAlAM>();
        List<HEROPOLL> LHPOLL = new List<HEROPOLL>();
        List<ENEMY1> lEN1 = new List<ENEMY1>();
        List<ENEMY2> lEN2 = new List<ENEMY2>();
        List<ENEMY3> lEN3 = new List<ENEMY3>();
        List<LAZiER> lAZIR = new List<LAZiER>();
        List<LITE> LIT = new List<LITE>();
        List<DARAG> ldarg = new List<DARAG>();
        List<SAHRBOLL> lSHBoll = new List<SAHRBOLL>();
        List<GWHARA> lGWA = new List<GWHARA>();
        List<HART> LHart = new List<HART>();
        List<SHPAHBOLL> lSHPahBLL = new List<SHPAHBOLL>();
        List<MOKAP> LMO = new List<MOKAP>();
        List<GAMEOVER> GAM = new List<GAMEOVER>();
        List<SALAM2> lsm2 = new List<SALAM2>();
        List<Door> ldoor = new List<Door>();
        List<Bomm> lBmm = new List<Bomm>();
        List<Acotr> lac = new List<Acotr>();
        List<smalspah> lsmall = new List<smalspah>();

        Bitmap off;
        public int SSX = -200;
        public int isdrows = 0, oldxs = 0, isrits = 0, islfts = 0, wbw = 0, wbh = 0,isqw=2;

        public int m = 1, z = 1, n = 8, flagH1 = 0, flagH2 = 0, V = 1, V2 = 3, ptlazer = 1, isclear = 1, isdarg = 1, isSHAHER = 1, V3 = 1, COUNTSAHB = 0, flagstop = 0, isEN2DID=0,isLAZDED=0, shdorr=2, shoow =0,lpomm=0, catshhhx=0;
        public int oldy = 0, oldy2 = 0, oldx = 0, cdm2 = 0, cdm22 = 0, ISAYDAMG = 0, isstart = 1, cr = 0, cdm3 = 0, nocreat = 0, ishapah=0,flagmo=0,flover=0,f2=0,stopsh=0,php=-1,matsh=0,fshp=-1,Win=0,flwin=0,ispomm=2, catshhhx2=0;
        Timer THjomp = new Timer();
        Timer Tdown = new Timer();
        Timer Tmtin = new Timer();
        Timer tt = new Timer();
        Program()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Load += Program_Load;
            this.Paint += Program_Paint;
            this.KeyDown += Program_KeyDown;
            this.MouseDown += Program_MouseDown;
            THjomp.Tick += THjomp_Tick;
            Tdown.Tick += Tdown_Tick;
            Tmtin.Tick += Tmtin_Tick;
            tt.Tick += Tt_Tick;
            Tmtin.Start();
        }

        private void Tt_Tick(object sender, EventArgs e)
        {
            if (oldxs != LHE[0].X)
            {
                oldxs = LHE[0].X;
                if (isrits == 1)
                {
                    SSX += 5;
                }
                if (islfts == 1)
                {
                    SSX -= 5;
                }
            }
            else
            {
                tt.Stop();
            }
            //DrowDupp(CreateGraphics());
        }

        private void Program_MouseDown(object sender, MouseEventArgs e)
        {
            Creat_HERPoLT();
        }
        public void Creat_HERPoLT()
        {
            HEROPOLL pnn = new HEROPOLL();
            if (flagH1 > 0)
            {
                pnn.X = LHE[0].X + LHE[0].imgs[0].Width;
                pnn.dir = 1;
            }
            if (flagH2 > 0)
            {
                pnn.X = LHE[0].X - LHE[0].imgs[0].Width;
                pnn.dir = -1;
            }
            if (flagH1 == 0 && flagH2 == 0)
            {
                pnn.X = LHE[0].X + LHE[0].imgs[0].Width;
                pnn.dir = 1;
            }
            pnn.Y = LHE[0].Y + LHE[0].imgs[0].Height / 2-38;
            for(int j = 0; j < 4; j++)
            {
                Bitmap ig = new Bitmap("ap"+(j+1)+".png");
                ig.MakeTransparent(ig.GetPixel(0, 0));
                ig.MakeTransparent(Color.White);
                pnn.img.Add(ig);
            }
            pnn.ID = 0;
            pnn.speed = 1;
            LHPOLL.Add(pnn);
        }
        int istic = 0,count=0;
        private void Tmtin_Tick(object sender, EventArgs e)
        {
            if (istic%160==0)
            {
                if (count != 4)
                {
                    Creat_Tinins();
                    count++;
                }
                
            }
            
            if (istic%2==0)
            {
                if (istic % 30 == 0) 
                {
                    for (int i = 0; i < ltinins.Count; i++)
                    {
                        if (ltinins[i].X > (ClientSize.Width + ltinins[i].imgs[0].Width))
                        {
                            ltinins[i].X = 20;
                        }
                    }
                }
                move_tinins();
            }
            istic++;
           DrowDupp(CreateGraphics());
        }
        public void move_polet()
        {
            for (int i = 0; i < lnpol.Count; i++)
            {
                lnpol[i].Y += 15;
                if ((lnpol[i].Y + lnpol[i].img[0].Height) >=lGN[3].Y+30)
                {
                    lnpol[i].ID = 1;
                }
                if (LHE[0].ID!=10) 
                {
                    if ((lnpol[i].X >= LHE[0].X - 27) && (lnpol[i].X <= (LHE[0].X + LHE[0].imgs[0].Width - 25)) && ((lnpol[i].Y + lnpol[i].img[0].Height) >= LHE[0].Y + 15) && ((LHE[0].Y + LHE[0].imgs[0].Height) >= lnpol[i].Y + lnpol[i].img[0].Height))
                    {
                        lnpol[i].ID = 1;
                        LHE[0].ID = 4;
                        LHE[0].Y = lGN[4].Y - 116;
                        lnpol.Remove(lnpol[i]);
                        cr = 1;
                    }
                    if ((lnpol[i].X >= LHE[0].X - 30) && (lnpol[i].X <= (LHE[0].X + LHE[0].imgs[8].Width - 25)) && ((lnpol[i].Y + lnpol[i].img[0].Height) >= LHE[0].Y + 15) && ((LHE[0].Y + LHE[0].imgs[8].Height) >= lnpol[i].Y + lnpol[i].img[0].Height))
                    {
                        int ct4 = 0;
                        if (ct4 == 0) { oldy2 = LHE[0].Y; ct4++; }
                        lnpol[i].ID = 1;
                        LHE[0].ID = 4;
                        LHE[0].Y = lGN[4].Y - 116;
                        lnpol.Remove(lnpol[i]);
                        cr = 1;
                    }

                    if (cr > 0)
                    {
                        if (cr == 1)
                        {
                            LHart.Remove(LHart[LHart.Count - 1]);
                            cr++;
                        }
                        if (isstart % 15 == 0)
                        {
                            LHE[0].ID = 0;
                            m = 0; n = 0;
                            LHE[0].X = 5;
                            LHE[0].Y = ClientSize.Height - 126;
                            cr = 0;
                        }
                        if (LHart.Count == 0)
                        {
                            Tmtin.Stop();
                            GAMEOVER pnn = new GAMEOVER();
                            pnn.X = ClientSize.Width / 2 - 280;
                            pnn.Y = 60;
                            pnn.img = new Bitmap("gm.jpg");
                            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                            GAM.Add(pnn);
                            flover = 1;
                        }
                        isstart++;
                    }
                }
                if ((lnpol[i].Y + lnpol[i].img[1].Height) > lGN[3].Y+100 && lnpol[i].ID == 1)
                {
                    lnpol.Remove(lnpol[i]);
                }
            }

   ////////////////MOVE HERO BOLIT/////////////////

            if (flagH1 > 0)
            {
                for (int i = 0; i < LHPOLL.Count; i++)
                {
                    LHPOLL[i].X += LHPOLL[i].dir * 60;
                    LHPOLL[i].ID = V;
                }
                V++;
                if (V == 4)
                {
                    V = 0;
                }
            }
            if (flagH2 > 0)
            {
                
                for (int i = 0; i < LHPOLL.Count; i++)
                {
                    LHPOLL[i].X +=LHPOLL[i].dir * 60;
                    LHPOLL[i].ID = V2;
                }
                V2--;
                if (V2 == 0)
                {
                    V2 = 3;
                }
            }
            if (flagH1 == 0 && flagH2 == 0)
            {
                for (int i = 0; i < LHPOLL.Count; i++)
                {
                    LHPOLL[i].X += LHPOLL[i].dir * 60;
                    LHPOLL[i].ID = V;
                }
                V++;
                if (V == 4)
                {
                    V = 0;
                }
            }

   ////////////////   MOVE HERO BOLIT END  /////////////////

            for(int i = 0; i < LHPOLL.Count; i++)
            {
                for(int j = 0; j < lSHPahBLL.Count; j++)
                {
                    if (LHPOLL[i].Y >= lSHPahBLL[j].Y && LHPOLL[i].Y <= lSHPahBLL[j].Y + lSHPahBLL[j].img.Height&&LHPOLL[i].X>=lSHPahBLL[j].X&&LHPOLL[i].X<=lSHPahBLL[j].X+lSHPahBLL[j].img.Width)
                    {
                        lSHPahBLL.Remove(lSHPahBLL[j]);
                        LHPOLL.Remove(LHPOLL[i]);
                    }
                }
            }

   //////////////  move ENemy1  ////////////////////
            for (int i = 0; i < lEN1.Count; i++)
            {
                lEN1[i].X += lEN1[i].dir * 20;
                if (lEN1[i].X < 500)
                {
                    lEN1[i].dir = 1;
                    lEN1[i].ID = 1;
                    ishapah = 0;
                }
                if (lEN1[i].X > 900)
                {
                    lEN1[i].dir = -1;
                    lEN1[i].ID = 0;
                }
                if (lEN1[i].dir == 1&&LHE[0].Y<lGN[4].Y-40&&stopsh!=1 && ldarg[0].X>LHE[0].X)
                {
                    if (ishapah % 8 == 0)
                    {
                        creat_SHPAHBOLL();
                        ishapah = 0;
                    }
                    ishapah++;
                }
                
            }

   /////////////////  move ENemy2  //////////////////
            for (int i = 0; i < lEN2.Count; i++)
            {
                if (isEN2DID != 1)
                {
                    lEN2[i].X += lEN2[i].dir * 19;
                    if (lEN2[i].X < 630)
                    {
                        lEN2[i].dir = 1;
                    }
                    if (lEN2[i].X > 1050)
                    {
                        lEN2[i].dir = -1;
                    }
                    if (LHE[0].X + LHE[0].imgs[0].Width - 20 >= lEN2[0].X && lEN2[0].X + lEN2[0].img[0].Width >= LHE[0].X + LHE[0].imgs[0].Width && LHE[0].Y + 50 >= lEN2[0].Y && LHE[0].Y/*+ LHE[0].imgs[0].Height*/<= lEN2[0].Y + lEN2[0].img[0].Height)
                    {
                        LHart.Remove(LHart[LHart.Count - 1]);
                        LHE[0].X = 5;
                        if (LHart.Count == 0)
                        {
                            Tmtin.Stop();
                            
                            GAMEOVER pnn =new GAMEOVER();
                            pnn.X = ClientSize.Width/2-300;
                            pnn.Y = 60;
                            pnn.img = new Bitmap("gm.jpg");
                            pnn.img.MakeTransparent(pnn.img.GetPixel(0,0));
                            GAM.Add(pnn);
                            flover = 1;
                            //MessageBox.Show("  GAME OVERR  ):  ");
                        }
                    }
                }
            }

   //////////////move lazer/////////////////////
            for (int i = 0; i < lAZIR.Count; i++)
            {
                lAZIR[i].Y += lAZIR[i].diry * 15;
                if (ptlazer % 20 == 0)
                {
                    Creat_LIte();
                    ptlazer = 0;
                }
                move_Lite();
                ptlazer++;
                if (lAZIR[i].Y <= lGN[4].Y+ lGN[4].img.Height + 4)
                {
                    lAZIR[i].diry = 1;
                }
                if ((lAZIR[i].Y+lAZIR[i].img.Height)>= lGN[0].Y+3)
                {
                    lAZIR[i].diry = -1;
                }
                if (isclear % 35==0)
                {
                    LIT.Clear();
                    isclear = 0;
                }
                isclear++;
            }

   ////////////////// move DARAG /////////////////////////
            for(int i = 0; i < ldarg.Count; i++)
            {
                if (isdarg % 6 == 0)
                {
                    ldarg[i].Y += ldarg[i].diry * 30;
                    if (((LHE[0].X + LHE[0].imgs[0].Width) >= ldarg[i].X+30) && ((LHE[0].X + LHE[0].imgs[0].Width) <= (ldarg[i].X + ldarg[i].img.Width + 30)))
                    {
                        LHE[0].Y = ldarg[i].Y-80;
                    }
                    
                    isdarg = 0;
                }
                if (ldarg[i].Y <= lGN[4].Y + 30)
                {
                    ldarg[i].diry = 1;
                }
                if ((ldarg[i].Y + ldarg[i].img.Height) > lGN[0].Y+17)
                {
                    ldarg[i].diry = -1;
                }
                isdarg++;
            }

  ////////////////move SHAHER BOLLIT////////////////////
            if (flagstop!=1)
            {
                if (nocreat != 1)
                {
                    if (isSHAHER % 22 == 0)
                    {
                        Creat_SAHERBOLL();
                        isSHAHER = 0;
                    }
                }
                move_SAHERBOLL();
                isSHAHER++;
            }

  //////////////////laser did//////////////////////////
            for (int i = 0; i < LHPOLL.Count; i++)
            {
                if (isLAZDED != 1)
                {
                    if ((LHPOLL[i].X + LHPOLL[i].img[LHPOLL[0].ID].Width) >= lAZIR[0].X && (LHPOLL[i].X + LHPOLL[i].img[LHPOLL[0].ID].Width) <= lAZIR[0].X + lAZIR[0].img.Width && (LHPOLL[i].Y + LHPOLL[i].img[LHPOLL[0].ID].Height) >= lAZIR[0].Y && (LHPOLL[i].Y + LHPOLL[i].img[LHPOLL[0].ID].Height) <= lAZIR[0].Y + lAZIR[0].img.Height)
                    {
                        lAZIR[0].diry = 0;
                        LHPOLL.Remove(LHPOLL[i]);
                        break;
                        //isLAZDED = 1;
                    }
                }
            }

  //////////////////// ENMEY2 did /////////////////////////////
            for (int i = 0; i < LHPOLL.Count; i++)
            {
                ///enmay2 did///
                if (isEN2DID != 1)
                {
                    if ((LHPOLL[i].X + LHPOLL[i].img[0].Width - 33) >= lEN2[0].X && (LHPOLL[i].X + LHPOLL[i].img[0].Width - 33) <= lEN2[0].X + lEN2[0].img[0].Width && (LHPOLL[i].Y + LHPOLL[i].img[0].Height) >= lEN2[0].Y && (LHPOLL[i].Y + LHPOLL[i].img[0].Height) <= lEN2[0].Y + lEN2[0].img[0].Height)
                    {
                        //lEN2[0].Y -= 24;
                        if (cdm2 == 0)
                        {
                            lEN2[0].ID = 1;
                            LHPOLL.Remove(LHPOLL[i]);
                            ISAYDAMG = 1;
                        }
                        if (cdm2 == 1)
                        {
                            lEN2[0].ID = 2;
                            LHPOLL.Remove(LHPOLL[i]);
                            ISAYDAMG = 1;

                        }
                        if (cdm2 == 2)
                        {

                            lEN2[0].ID = 3;
                            lEN2[0].dir = 0;
                            lEN2[0].Y -= 24;
                            cdm22 = 2;
                            LHPOLL.Remove(LHPOLL[i]);
                            ISAYDAMG = 1;
                        }
                        cdm2++;
                        //lEN2.Clear();
                        //isEN2DID = 1;
                    }
                }
            }
            if (cdm22 > 0)
            {
                if (cdm22 % 8 == 0)
                {
                    lEN2.Clear();
                    isEN2DID = 1;
                    cdm22 = 0;
                    cdm2 = 0;
                }
                cdm22++;
            }

                         
   ///////////////// DELETE GWHARA ////////////////////
            for(int i=0; i < lGWA.Count; i++)
            {
                for (int j = 0; j < LHPOLL.Count; j++)
                {
                    if (lGWA[i].X + lGWA[i].img.Width >= LHPOLL[j].X && LHPOLL[j].X >= lGWA[i].X && LHPOLL[j].Y+25>=lGWA[i].Y&&LHPOLL[j].Y<=lGWA[i].Y+lGWA[i].img.Height)
                    {
                        LHPOLL.Remove(LHPOLL[j]);
                        lGWA.Remove(lGWA[i]);
                        if (lGWA.Count == 0)
                        {
                            flagstop = 0;
                        }
                        break;
                    }
                }
            }

  ////////////////////  DELETE SAHERR  //////////////////////
            for (int i = 0; i < lEN3.Count; i++)
            {
                for (int j = 0; j < LHPOLL.Count; j++)
                {
                    if (nocreat != 1)
                    {
                        if (lEN3[i].X + lEN3[i].img.Width >= LHPOLL[j].X && LHPOLL[j].X >= lEN3[i].X && LHPOLL[j].Y + 25 >= lEN3[i].Y && LHPOLL[j].Y <= lEN3[i].Y + lEN3[i].img.Height)
                        {

                            LHPOLL.Remove(LHPOLL[j]);
                            if (cdm3 == 4)
                            {
                                lEN3.Clear();
                                nocreat = 1;
                            }
                            cdm3++;
                            break;
                        }
                    }
                }
            }

            if (nocreat == 1)
            {
                if (shdorr % 15 == 0)
                {
                    Win = 1;
                    shdorr = 0;
                }
                shdorr++;
            }

  /////////////////////// LSAPAHH BOLL & KIL HERO /////////////////////////////////
            for(int i = 0; i < lSHPahBLL.Count; i++)
            {
                lSHPahBLL[i].X += 40;
            }

            for (int i = 0; i < lSHPahBLL.Count; i++)
            {
                if (LHE[0].ID != 4&&LHE[0].ID!=10)
                {
                    if (lSHPahBLL[i].X + lSHPahBLL[i].img.Width - 10 >= LHE[0].X && LHE[0].X + LHE[0].imgs[0].Width >= lSHPahBLL[i].X + lSHPahBLL[i].img.Width && lSHPahBLL[i].Y + lSHPahBLL[i].img.Height >= LHE[0].Y && lSHPahBLL[i].Y + lSHPahBLL[i].img.Height <= LHE[0].Y + LHE[0].imgs[0].Height)
                    {
                        lSHPahBLL.Remove(lSHPahBLL[i]);
                        LHE[0].ID = 10;
                        LHart.Remove(LHart[LHart.Count - 1]);
                        if (LHart.Count == 0)
                        {
                            Tmtin.Stop();
                            GAMEOVER pnn = new GAMEOVER();
                            pnn.X = ClientSize.Width / 2 - 300;
                            pnn.Y = 60;
                            pnn.img = new Bitmap("gm.jpg");
                            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                            GAM.Add(pnn);
                            flover = 1;
                        }
                    }
                }
            }

            if (LHE[0].ID == 10)
            {
                LHE[0].Y -= 15;
                if (LHE[0].Y < 0)
                {
                    LHE[0].ID = 0;
                    m = 0; n = 0;
                    LHE[0].X = 5;
                    LHE[0].Y = ClientSize.Height - 126;
                }
            }

  ///////////////////// KIll SHAPPAH /////////////////////////
            for(int i = 0; i < lEN1.Count; i++)
            {
                for(int j = 0; j < LHPOLL.Count; j++)
                {
                    if (LHPOLL[j].X >= lEN1[i].X && LHPOLL[j].X <= lEN1[i].X + lEN1[i].img[0].Width && LHPOLL[j].Y >= lEN1[i].Y && lEN1[i].Y + lEN1[i].img[0].Height >= LHPOLL[j].Y)
                    {
                       
                        if (php < 0)
                        {
                            lEN1[i].ID = 2;
                            lEN1[i].dir = 0;
                            fshp = 0;
                            php = i;
                            matsh = 2;
                            LHPOLL.Remove(LHPOLL[j]);
                        }
                        stopsh = 1;
                    }
                }
            }
            if (fshp==0 && fshp !=1)
            {
                if (matsh % 15 == 0)
                {
                    Creat_samllshapahh();
                    catshhhx = lEN1[0].X + lEN1[0].img[0].Width;
                    catshhhx2 = lEN1[0].X-20;
                    lEN1.Remove(lEN1[php]);
                    fshp = 1;
                    matsh = 0;
                }
                matsh++;
            }

   /////////////////// up to SOLam  ///////////////////////
            if (LHE[0].X > lsm2[0].X && lsm2[0].X + lsm2[0].img.Width > LHE[0].X && LHE[0].Y >= ClientSize.Height / 2 && LHE[0].Y + LHE[0].imgs[0].Height <= lsm2[0].Y +lsm2[0].img.Height-25)
            {
                f2 = 1;
            }
            else
            {
                f2 = 0;
            }
   //////////////////  HERO WIN  ////////////////////////
            for(int i = 0; i < ldoor.Count; i++)
            {
                if (LHE[0].X-30 >= ldoor[i].X && ldoor[i].X + ldoor[i].imgs[0].Width >= LHE[0].X-30 && ldoor[i].Y <= LHE[0].Y && ldoor[i].Y + ldoor[i].imgs[0].Height >= LHE[0].Y&&ldoor[i].ID==1)
                {
                    GAMEOVER pnn = new GAMEOVER();
                    pnn.X = ClientSize.Width / 2 - 400;
                    pnn.Y = 70;
                    pnn.img = new Bitmap("wn.jpg");
                    pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                    GAM.Add(pnn);
                    flwin = 1;
                }
            }


   ////////////////////////  BOMM IS BOMM AND KILL HERO ///////////////////////////
            for(int i = 0; i < lBmm.Count; i++) 
            {
                if (shoow == 1)
                {
                    if (lpomm < 4)
                    {
                        if (ispomm % 10 == 0)
                        {

                            wbw += 10;
                            wbh += 10;
                            lBmm[i].Y -= 10;
                            ispomm = 0;
                            lpomm++;
                        }
                        ispomm++;
                    }
                    else
                    {
                        lBmm[i].ID = 1;
                        if (ispomm % 10 == 0)
                        {
                            shoow = 0;
                            lBmm.Clear();
                            ispomm = 0;
                        }
                        ispomm++;
                    }
                }

            }
            for (int i = 0; i < lBmm.Count; i++)
            {
                if (LHE[0].X + LHE[0].imgs[0].Width + 20 >= lBmm[i].X && LHE[0].X + LHE[0].imgs[0].Width + 20 <= lBmm[i].X + lBmm[i].imgs[0].Width && LHE[0].Y + LHE[0].imgs[0].Height >= lBmm[i].Y && LHE[0].Y + LHE[0].imgs[0].Height <= lBmm[i].Y + lBmm[i].imgs[0].Height)
                {
                    LHE[0].Y = ClientSize.Height - 165;
                    lBmm[i].ID = 1;
                    LHE[0].ID = 4;
                    lBmm.Clear();
                    LHart.Clear();
                    break;
                }
                
            }
            if (isqw % 15 == 0)
            {
                if (LHart.Count == 0)
                {
                    Tmtin.Stop();
                    GAMEOVER pnn = new GAMEOVER();
                    pnn.X = ClientSize.Width / 2 - 300;
                    pnn.Y = 60;
                    pnn.img = new Bitmap("gm.jpg");
                    pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                    GAM.Add(pnn);
                    flover = 1;
                }
                isqw = 0;
            }
            isqw++;
  ////////////////////////   end BOMM    /////////////////////////////////
    
            for(int i = 0; i < lsmall.Count; i++)
            {
                lsmall[i].X += lsmall[i].dir*6;
                if (lsmall[i].X + lsmall[i].imgs[i].Width >= 1200)
                {
                    lsmall[i].dir = -1;
                }
                if (lsmall[i].X <=600)
                {
                    lsmall[i].dir = 1;
                }
                if (lsmall[i].dir < 0)
                {
                    lsmall[i].ID = 1;
                    
                }
                else
                {
                    lsmall[i].ID = 0;
                }
                for (int j = 0; j < LHE.Count; j++)
                {
                    if (lsmall[i].X + lsmall[i].imgs[0].Width >= LHE[j].X && LHE[j].X + LHE[j].imgs[0].Width >= lsmall[i].X + lsmall[i].imgs[0].Width && LHE[j].Y >= lsmall[i].Y&&LHE[j].Y+LHE[j].imgs[0].Height<=lsmall[i].Y+lsmall[i].imgs[0].Height)
                    {
                        LHE[i].ID = 11;
                        LHE[i].Y = lGN[3].Y+3;
                        LHart.Remove(LHart[LHart.Count - 1]);
                        //LHE[0].X = 5;
                        if (LHart.Count == 0)
                        {
                            Tmtin.Stop();

                            GAMEOVER pnn = new GAMEOVER();
                            pnn.X = ClientSize.Width / 2 - 300;
                            pnn.Y = 60;
                            pnn.img = new Bitmap("gm.jpg");
                            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                            GAM.Add(pnn);
                            flover = 1;
                            //MessageBox.Show("  GAME OVERR  ):  ");
                        }
                        break;
                    }
                    if (lsmall[i].X >= LHE[j].X && LHE[j].X + LHE[j].imgs[0].Width >= lsmall[i].X  && LHE[j].Y >= lsmall[i].Y && LHE[j].Y + LHE[j].imgs[0].Height <= lsmall[i].Y + lsmall[i].imgs[0].Height)
                    {
                        LHE[i].ID = 11;
                        LHE[i].Y = lGN[3].Y + 3;
                        LHart.Remove(LHart[LHart.Count - 1]);
                        //LHE[0].X = 5;
                        if (LHart.Count == 0)
                        {
                            Tmtin.Stop();

                            GAMEOVER pnn = new GAMEOVER();
                            pnn.X = ClientSize.Width / 2 - 300;
                            pnn.Y = 60;
                            pnn.img = new Bitmap("gm.jpg");
                            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                            GAM.Add(pnn);
                            flover = 1;
                            //MessageBox.Show("  GAME OVERR  ):  ");
                        }
                        break;
                    }
                }
            }

            for(int i = 0; i < LHPOLL.Count; i++)
            {
                for(int j = 0; j < lsmall.Count; j++)
                {
                    if (LHPOLL[i].X<=lsmall[j].X+lsmall[j].imgs[0].Width&&lsmall[j].X<=LHPOLL[i].X&&LHPOLL[i].Y>=lsmall[j].Y&&lsmall[j].Y+lsmall[j].imgs[0].Height>=LHPOLL[i].Y)
                    {
                        lsmall.Remove(lsmall[j]);
                        LHPOLL.Remove(LHPOLL[i]);
                        break;
                    }
                }
            }
        }

        public void Creat_samllshapahh()
        {
            smalspah pnn = new smalspah();
            pnn.X = lEN1[0].X + lEN1[0].img[0].Width;
            for(int i = 0; i < 2; i++)
            {
                Bitmap im = new Bitmap("sm"+(i+1)+".png");
                im.MakeTransparent(im.GetPixel(0, 0));
                im.MakeTransparent(Color.White);
                pnn.imgs.Add(im);
            }
            pnn.ID = 0;
            pnn.dir = 1;
            pnn.Y = lGN[3].Y - pnn.imgs[pnn.ID].Height+40;
            lsmall.Add(pnn);
        }
        public void creat_SHPAHBOLL()
        {
            SHPAHBOLL pnn = new SHPAHBOLL();
            pnn.X = lEN1[0].X + lEN1[0].img[0].Width-40;
            pnn.Y = lEN1[0].Y+ lEN1[0].img[0].Height/2-25;
            pnn.img = new Bitmap("pp.png");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.img.MakeTransparent(Color.White);
            lSHPahBLL.Add(pnn);
        }
        public void move_SAHERBOLL()
        {
            for(int i = 0; i < lSHBoll.Count; i++)
            {
                lSHBoll[i].X += lSHBoll[i].speed * 3;
                lSHBoll[i].ID = V3;
                if ((lSHBoll[i].X + lSHBoll[i].imgs[lSHBoll[i].ID].Width) >= lSHBoll[i].posd&&lSHBoll[i].ID!=5)
                {
                    lSHBoll[i].ID = 5;
                    lSHBoll[i].Y = (lSHBoll[i].Y + lSHBoll[i].imgs[lSHBoll[i].ID].Height);
                    GWHARA pnn = new GWHARA();
                    pnn.X = lSHBoll[i].X;
                    pnn.Y = lSHBoll[i].Y-60;
                    pnn.img = lSHBoll[i].imgs[5];
                    if (lSHBoll[i].ID == 5 && COUNTSAHB == 7)
                    {
                        flagstop = 1;
                    }
                    lGWA.Add(pnn);
                    lSHBoll.Remove(lSHBoll[i]);
                    COUNTSAHB++;
                    
                }
            }
            V3++;
            if (V3 == 4)
            {
                V3 = 0;
            }
        }
        public void Creat_SAHERBOLL()
        {
            Random rr = new Random();
            SAHRBOLL pnn = new SAHRBOLL();
            pnn.X = lEN3[0].X + lEN3[0].img.Width;
            pnn.Y = (lEN3[0].Y + lEN3[0].img.Height / 2 - 20);
            pnn.ID = 0;
            pnn.speed =rr.Next(3,30);
            pnn.posd = rr.Next(90, 590);
            for(int j = 0; j < 6; j++)
            {
                Bitmap ig = new Bitmap("sh" + (j + 1) + ".png");
                ig.MakeTransparent(ig.GetPixel(0, 0));
                ig.MakeTransparent(Color.White);
                pnn.imgs.Add(ig);
            }
            lSHBoll.Add(pnn);
        }
        public void move_Lite()
        {
            if (LHE[0].ID != 4 )
            {
                for (int i = 0; i < LIT.Count; i++)
                {
                    LIT[i].Y = lAZIR[0].Y + lAZIR[0].img.Height - 22;
                    if (LIT[i].Y > LHE[0].Y && LIT[i].Y + LIT[i].img.Height <= LHE[0].Y + LHE[0].imgs[0].Height && LHE[0].X + LHE[0].imgs[0].Width >= 650 && LHE[0].X + LHE[0].imgs[0].Width <= lsm[0].X)
                    {
                        LHart.Remove(LHart[LHart.Count - 1]);
                        LHE[0].ID = 9;
                        LHE[0].X = 450;
                        LHE[0].Y = ClientSize.Height - 126;
                        if (LHart.Count == 0)
                        {
                            Tmtin.Stop();
                            GAMEOVER pnn = new GAMEOVER();
                            pnn.X = ClientSize.Width / 2 - 300;
                            pnn.Y = 60;
                            pnn.img = new Bitmap("gm.jpg");
                            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                            GAM.Add(pnn);
                            flover = 1;
                            //MessageBox.Show("  GAME OVERR  ):  ");
                        }
                    }
                }
            }
        }
        public void Creat_LIte()
        {
            int x = lAZIR[0].X - 24;
            for (int i = 0; i < 7; i++)
            {
                LITE pnn = new LITE();
                pnn.X = x;
                pnn.Y = lAZIR[0].Y + lAZIR[0].img.Height - 17;
                pnn.img = new Bitmap("pl.png");
                pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                pnn.img.MakeTransparent(Color.White);
                LIT.Add(pnn);
                x -=pnn.img.Height+29;
            }
            x = lAZIR[0].X + lAZIR[0].img.Width-20;
            for (int i = 0; i < 7; i++)
            {
                LITE pnn = new LITE();
                pnn.X = x;
                pnn.Y = lAZIR[0].Y + lAZIR[0].img.Height - 17;
                pnn.img = new Bitmap("pl.png");
                pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                pnn.img.MakeTransparent(Color.White);
                LIT.Add(pnn);
                x +=45;
            }
        }
        public void creat_ENbol()
        {
            for (int i = 0; i < ltinins.Count; i++)
            {
                ENmpol pnn = new ENmpol();
                pnn.X = ltinins[i].X + 97;
                pnn.Y = ltinins[i].Y + 68;
                for(int j = 0; j < 2; j++)
                {
                    Bitmap ig = new Bitmap("p"+(j+1)+".png");
                    ig.MakeTransparent(ig.GetPixel(0, 0));
                    pnn.img.Add(ig);
                }
                pnn.ID = 0;
                lnpol.Add(pnn);
            }
        }
        int iscount = 0, pos = 0;
        public void move_tinins()
        {
            
            for (int i = 0; i < ltinins.Count; i++)
            {
                ltinins[i].X += ltinins[i].dir * 20;
                pos = i;
                ltinins[i].ID = z;
            }
            if (iscount % 14 == 0)
            {
                creat_ENbol();
            }
            iscount++;
            move_polet();
            z++;
            if (z == 3)
            {
                z = 0;
            }
        }
        private void Tdown_Tick(object sender, EventArgs e)
        {
            move_acdown();
           
            for (int i = 0; i < LMO.Count; i++)
            {
                if (LHE[0].X + LHE[0].imgs[0].Width+10 >= LMO[i].X && LMO[i].X + LMO[i].img.Width-30 >= LHE[0].X + LHE[0].imgs[0].Width&&lGN[4].Y<=LHE[0].Y)
                {
                    LHE[0].Y = LMO[i].Y - LHE[0].imgs[0].Height+20;
                    flagmo = 1;
                    THjomp.Stop();
                    Tdown.Stop();
                    break;
                }
            }
            if (LHE[0].Y == oldy)
            {
                Tdown.Stop();
                if (flagH1 > 0)
                {
                    LHE[0].ID = 0;
                }
                if (flagH2 > 0)
                {
                    LHE[0].ID = 8;
                }
                if (flagH1 == 0 && flagH2 == 0)
                {
                    LHE[0].ID = 0;
                }
                
            }
            DrowDupp(CreateGraphics());
        }
        private void THjomp_Tick(object sender, EventArgs e)
        {
            move_actor();

            if (LHE[0].Y <=oldy-90)
            {
                THjomp.Stop();
                Tdown.Start();
            }
            DrowDupp(CreateGraphics());
        }
        public void move_actor()
        {
            LHE[0].Y -= 20;
            if (flagH1 > 0)
            {
                LHE[0].ID = 1;
            }
            if (flagH2 > 0)
            {
                LHE[0].ID = 7;
            }
            if (flagH1 == 0 && flagH2 == 0)
            {
                LHE[0].ID = 1;
            }
        }
        public void move_acdown()
        {
            LHE[0].Y += 20;
            
        }
        private void Program_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                   
                    if (LHE[0].ID != 4 && LHE[0].ID != 10)
                    {
                        if (flagH1 == 0)
                        {
                            m = 0;
                            flagH1++;
                            flagH2 = 0;
                        }
                        if (LHE[0].X + LHE[0].imgs[0].Width >= LMO[3].X + LMO[3].img.Width && LHE[0].X + LHE[0].imgs[0].Width <=lrk[1].X && lGN[4].Y < LHE[0].Y)
                        {
                            LHE[0].Y= ClientSize.Height - 126;
                        }
                        if (LHE[0].X+LHE[0].imgs[0].Width>=lrk[0].X && LHE[0].X + LHE[0].imgs[0].Width <= lrk[0].X+lrk[0].img.Width && LHE[0].Y==ClientSize.Height-126)
                        {
                            LHE[0].X += 0;
                        }
                        else
                        {
                            isrits = 1;
                            islfts = 0;
                            LHE[0].X += 10;
                            LHE[0].ID = m;
                            m++;
                            if (m == 4)
                            {
                                m = 0;
                            }
                            tt.Start();
                        }
                        if (LHE[0].Y <= lGN[3].Y + 20&&LHE[0].X< (1170 + 50))
                        {
                            LHE[0].Y = lGN[3].Y-59;
                        }
                    }
                    if (LHE[0].X + LHE[0].imgs[0].Width >= 1000)
                    {
                        shoow = 1;
                    }
                    break;
                case Keys.A:
                    if (LHE[0].ID != 4 && LHE[0].ID!=10)
                    {
                        if (flagH2 == 0)
                        {
                            n = 8;
                            flagH2++;
                            flagH1 = 0;
                        }
                        isrits = 0;
                        islfts = 1;
                        LHE[0].X -= 10;
                        LHE[0].ID = n;
                        n--;
                        if (n == 5)
                        {
                            n = 8;
                        }
                        
                        if (LHE[0].Y <= lGN[3].Y + 20 && LHE[0].X < (1170+ 50))
                        {
                            LHE[0].Y = lGN[3].Y-59;
                        }
                        tt.Start();
                    }
                    break;
                case Keys.Space:
                    if (LHE[0].ID != 4 && LHE[0].ID != 10)
                    {
                        THjomp.Start();
                        flagmo = 0;
                        if (flagmo != 1)
                        {
                            oldy = LHE[0].Y;
                        }
                    }
                    break;
                case Keys.W:
                    if (f2 == 1)
                    {
                        LHE[0].Y -= 10;
                    }
                    break;
                case Keys.S:
                    if (f2 == 1)
                    {
                        LHE[0].Y += 10;
                    }
                    break;
                case Keys.Enter:
                    
                    //lBmm[0].ID = 1;
                    if (lEN3.Count==0)
                    ldoor[0].ID = 1;
                    break;
                case Keys.R:
                    //Creat_samllshapahh();
                    Creat_HERPoLT();
                    break;
            }
            //DrowDupp(CreateGraphics());
        }
        public int chick_AQPA()
        {
            
            int ct = 0,j=0;
            for (int i=0; i < lrk.Count && j< LHE[0].imgs.Count; i++) 
            {
               /* if ((LHE[0].Y+LHE[0].imgs[j].Height-200)>=(lrk[0].Y+ lrk[0].img.Height-200)&& (LHE[0].X + LHE[0].imgs[j].Width>=lrk[0].X))
                {
                    MessageBox.Show("is okk");
                    ct++;
                    break;
                }
                else
                {
                   
                }*/
                j++;
                if (j == 4)
                {
                    j = 0;
                }
            }
            if (ct > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private void Program_Paint(object sender, PaintEventArgs e)
        {
            DrowDupp(e.Graphics);
        }
        private void Program_Load(object sender, EventArgs e)
        {
            off = new Bitmap(ClientSize.Width, ClientSize.Height);
            Creat_HERO();
            Creat_Garden();
            Creat_ROCK();
            Creat_DARAG();
            Creat_SALAM();
            Creat_ENEMY();
            Creat_ENEMY2();
            Creat_ENEMY3();
            Creat_LAZER();
            Creat_HART();
            Creat_mokap();
            Creat_SALAM2();
            Crear_Door();
            Creat_ACTORR();
            Creat_Bomm();
            wbw = lBmm[0].imgs[0].Width ;
            wbh = lBmm[0].imgs[0].Height ;
            DrowDupp(CreateGraphics());
        }

        public void Creat_ACTORR()
        {
            off = new Bitmap(ClientSize.Width, ClientSize.Height);
            Acotr pnn = new Acotr();
            pnn.XD = 0;
            pnn.YD = 0;
            pnn.XS = 0;
            pnn.YS = 0;
            pnn.img = new Bitmap("A4.png");

            pnn.img.MakeTransparent(Color.White);
            lac.Add(pnn);
        }
        public void Creat_Bomm()
        {
            Bomm pnn = new Bomm();
            pnn.X = 1170;
            pnn.Y = ClientSize.Height - 98;
            for(int i = 0; i < 2; i++)
            {
                Bitmap im = new Bitmap("pm"+(i+1)+".png");
                im.MakeTransparent(im.GetPixel(0, 0));
                im.MakeTransparent(Color.White);
                pnn.imgs.Add(im);
            }
            pnn.ID = 0;
            lBmm.Add(pnn);
        }
        public void Crear_Door()
        {
            Door pnn = new Door();
            pnn.X = -50;
            for(int j = 0; j < 2; j++)
            {
                Bitmap ig = new Bitmap("dr"+(j+1)+".png");
                ig.MakeTransparent(ig.GetPixel(0, 0));
                ig.MakeTransparent(Color.White);
                pnn.imgs.Add(ig);
            }
            pnn.ID = 0;
            pnn.Y = lGN[4].Y - pnn.imgs[pnn.ID].Height+40;
            ldoor.Add(pnn);
        }
        public void Creat_SALAM2()
        {
            SALAM2 pnn = new SALAM2();
            pnn.X = lrk[1].X+53;
            pnn.Y = lrk[1].Y - 155;
            pnn.img = new Bitmap("s2.jpg");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.img.MakeTransparent(Color.White);
            lsm2.Add(pnn);
        }
        public void Creat_mokap()
        {
            MOKAP pnn = new MOKAP();
            pnn.X = 35;
            pnn.Y = ClientSize.Height-110;
            pnn.img = new Bitmap("78.png");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.img.MakeTransparent(Color.White);
            LMO.Add(pnn);

            pnn = new MOKAP();
            pnn.X = 120;
            pnn.Y = ClientSize.Height - 165;
            pnn.img = new Bitmap("78.png");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.img.MakeTransparent(Color.White);
            LMO.Add(pnn);

            pnn = new MOKAP();
            pnn.X = 230;
            pnn.Y = ClientSize.Height - 165;
            pnn.img = new Bitmap("78.png");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.img.MakeTransparent(Color.White);
            LMO.Add(pnn);

            pnn = new MOKAP();
            pnn.X = 325;
            pnn.Y = ClientSize.Height - 115;
            pnn.img = new Bitmap("78.png");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.img.MakeTransparent(Color.White);
            LMO.Add(pnn);

        }
        public void Creat_HART()
        {
            int x = 40;
            for (int i =0;i<3;i++) 
            {
                HART pnn = new HART();
                pnn.X = x;
                pnn.Y = 0;
                pnn.img = new Bitmap("H.png");
                pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                pnn.img.MakeTransparent(Color.White);
                LHart.Add(pnn);
                x +=40;
            }
        }
        public void Creat_ENEMY3()
        {
            ENEMY3 pnn = new ENEMY3();
            pnn.X = lGN[3].X-40;
            pnn.img = new Bitmap("ss.png");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.img.MakeTransparent(Color.White);
            pnn.Y = lGN[3].Y-pnn.img.Height+40;
            lEN3.Add(pnn);
        }
        public void Creat_LAZER()
        {
            LAZiER pnn = new LAZiER();
            pnn.X = 926;
            pnn.Y = (lGN[4].Y + lGN[4].img.Height + 3);
            pnn.img = new Bitmap("ler.png");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0,0));
            pnn.img.MakeTransparent(Color.White);
            pnn.diry = 1;
            lAZIR.Add(pnn);
        }
        public void Creat_ENEMY2()
        {
            ENEMY2 pnn = new ENEMY2();
            pnn.X = 800;
            pnn.Y = lGN[0].Y - 60;
            for(int j = 0; j < 4; j++)
            {
                Bitmap im = new Bitmap("ef" + (j + 1) + ".png");
                im.MakeTransparent(im.GetPixel(0, 0));
                im.MakeTransparent(Color.White);
                pnn.img.Add(im);
            }
            
            pnn.dir = -1;
            pnn.ID = 0;
            lEN2.Add(pnn);
        }
        public void Creat_ENEMY()
        {
            
            ENEMY1 pnn = new ENEMY1();
            pnn.X = 800;
            pnn.Y = lGN[3].Y - 160;
            for(int j = 0; j < 3; j++)
            {
                Bitmap ig = new Bitmap("e"+(j+1)+".jpg");
                ig.MakeTransparent(ig.GetPixel(0, 0));
                ig.MakeTransparent(Color.White);
                pnn.img.Add(ig);
            }
            pnn.ID = 0;
            pnn.dir = -1;
            lEN1.Add(pnn);
            //ENMY/////////// not creat//////;
            /*
            pnn = new ENEMY1();
            pnn.X = 800;
            pnn.Y = lGN[0].Y-40;
            for (int j = 0; j < 2; j++)
            {
                Bitmap ig = new Bitmap("ee" + (j + 1) + ".png");
                ig.MakeTransparent(ig.GetPixel(0, 0));
                ig.MakeTransparent(Color.White);
                pnn.img.Add(ig);
            }
            pnn.ID = 0;
            pnn.dir = -1;
            lEN1.Add(pnn);*/
        }
        public void Creat_DARAG()
        {
            DARAG pnn = new DARAG();
            pnn.img = new Bitmap("d.png");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.img.MakeTransparent(Color.White);
            pnn.X = (ClientSize.Width - pnn.img.Width);
            pnn.Y = lGN[0].Y+17;
            pnn.diry = -1;
            ldarg.Add(pnn);
        }
        public void Creat_SALAM()
        {
            SAlAM pnn = new SAlAM();
           
            pnn.img = new Bitmap("S.png");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.img.MakeTransparent(Color.White);
            pnn.X = (ClientSize.Width- pnn.img.Width+32);
            pnn.Y = lGN[3].Y+12;
            lsm.Add(pnn);
        }
        public void Creat_ROCK()
        {
            Rock pnn = new Rock();
            pnn.X = 170;
            pnn.Y = lGN[0].Y-100;
            pnn.img = new Bitmap("r2.png");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.img.MakeTransparent(Color.White);
            lrk.Add(pnn);

            pnn = new Rock();
            pnn.X = 450;
            pnn.Y = lGN[0].Y - 100;
            pnn.img = new Bitmap("r3.png");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.img.MakeTransparent(Color.White);
            lrk.Add(pnn);
        }
        public void Creat_Garden()
        {
            int x = 0;
            for (int i = 0; i < 3; i++)
            {
                Garden pnn = new Garden();
                pnn.X = x;
                pnn.img = new Bitmap("g4.png");
                pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                pnn.img.MakeTransparent(Color.White);
                pnn.Y = ClientSize.Height - 59;
                lGN.Add(pnn);
                x += pnn.img.Width;
            }
            //Garden  222222  i=3;
            x = 0;
            for (int i = 0; i < 2; i++)
            {
                Garden pnn2 = new Garden();
                pnn2.X = x;
                pnn2.img = new Bitmap("g4.png");
                pnn2.img.MakeTransparent(pnn2.img.GetPixel(0, 0));
                pnn2.Y = ClientSize.Height / 2 + 43;
                lGN.Add(pnn2);
                x += pnn2.img.Width;
            }
        }
        public void Creat_HERO()
        {
            HERO pnn = new HERO();
            pnn.X = 10;
            for(int j = 0; j < 12; j++)
            {
                Bitmap ig = new Bitmap((j+1)+".png");
                ig.MakeTransparent(ig.GetPixel(0, 0));
                ig.MakeTransparent(Color.White);
                pnn.imgs.Add(ig);
            }
            pnn.Y = ClientSize.Height - 126;
            pnn.ID = 0;
            LHE.Add(pnn);
        }
        public void Creat_Tinins()
        {
            int x = 45;
                Tinin pnn = new Tinin();
                pnn.X = x;
                pnn.Y = 15;
                for(int j = 0; j < 3; j++)
                {
                    Bitmap ig = new Bitmap("T"+(j+1)+".PNG");
                    ig.MakeTransparent(ig.GetPixel(0, 0));
                    ig.MakeTransparent(Color.White);
                    pnn.imgs.Add(ig);
                }
                pnn.dir = 1;
                pnn.ID = 0;
                ltinins.Add(pnn);
                x += 300;
        }
        public void DrowDupp(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            Drowscene(g2);
            g.DrawImage(off, 0, 0);
        }
        public void Drowscene(Graphics g)
        {
            g.Clear(Color.White);
            if (flover == 0&&flwin==0)
            {
                for (int i = 0; i < lac.Count; i++)//ACTORR
                {
                    Rectangle RcD = new Rectangle(-100,-500,lac[i].img.Width, lac[i].img.Height);
                    Rectangle RcS = new Rectangle(SSX, 0, lac[i].img.Width, lac[i].img.Height);
                    g.DrawImage(lac[i].img, RcD, RcS, GraphicsUnit.Pixel);
                }
                for (int i = 0; i < LHart.Count; i++)//HART;
                {
                    g.DrawImage(LHart[i].img, LHart[i].X, LHart[i].Y, 25, 25);
                }
                for (int i = 0; i < ltinins.Count; i++)//TININ;
                {
                    g.DrawImage(ltinins[i].imgs[ltinins[i].ID], ltinins[i].X, ltinins[i].Y, 130, 130);
                }
                for (int i = 0; i < lnpol.Count; i++)//TN BOll;
                {
                    g.DrawImage(lnpol[i].img[lnpol[i].ID], lnpol[i].X, lnpol[i].Y, 50, 50);
                }
                for (int i = 0; i < lGN.Count; i++)//GARDEN;
                {
                    g.DrawImage(lGN[i].img, lGN[i].X, lGN[i].Y);
                }
                for (int i = 0; i < LHPOLL.Count; i++)//BOLLHERO;
                {
                    g.DrawImage(LHPOLL[i].img[LHPOLL[i].ID], LHPOLL[i].X, LHPOLL[i].Y);
                }
                for (int i = 0; i < lrk.Count; i++)//ROCK;
                {
                    g.DrawImage(lrk[i].img, lrk[i].X, lrk[i].Y);
                }
                for (int i = 0; i < lsm.Count; i++)//SALAM;
                {
                    g.DrawImage(lsm[i].img, lsm[i].X, lsm[i].Y);
                }
                for (int i = 0; i < ldarg.Count; i++)//darag;
                {
                    g.DrawImage(ldarg[i].img, ldarg[i].X, ldarg[i].Y);
                }
                 g.FillRectangle(Brushes.Black, 970, (lGN[4].Y + lGN[4].img.Height), 4, 260);

                for (int i = 0; i < LMO.Count; i++) //MOKAP;
                {
                    g.DrawImage(LMO[i].img, LMO[i].X, LMO[i].Y);
                }
                for (int i = 0; i < lsm2.Count; i++)//SALAM2;
                {
                    g.DrawImage(lsm2[i].img, lsm2[i].X, lsm2[i].Y);
                }
                for(int i = 0; i < lsmall.Count; i++)// small spahhh;
                {
                    g.DrawImage(lsmall[i].imgs[lsmall[i].ID], lsmall[i].X, lsmall[i].Y);
                }
                for (int i = 0; i < lEN1.Count; i++)//ENEMY1;
                {
                    if (i == 1)
                    {
                        g.DrawImage(lEN1[i].img[lEN1[i].ID], lEN1[i].X, lEN1[i].Y);
                    }
                    else
                    {
                        g.DrawImage(lEN1[i].img[lEN1[i].ID], lEN1[i].X, lEN1[i].Y);
                    }
                }
                for (int i = 0; i < lAZIR.Count; i++)//LAZER;
                {
                    g.DrawImage(lAZIR[i].img, lAZIR[i].X, lAZIR[i].Y);
                }
                for (int i = 0; i < LIT.Count; i++)//LITLAZER;
                {
                    g.DrawImage(LIT[i].img, LIT[i].X, LIT[i].Y);
                }
                for (int i = 0; i < lEN2.Count; i++)//ENEMY2;
                {
                    g.DrawImage(lEN2[i].img[lEN2[i].ID], lEN2[i].X, lEN2[i].Y);
                }
                for (int i = 0; i < lEN3.Count; i++)//ENEMY3;
                {
                    g.DrawImage(lEN3[i].img, lEN3[i].X, lEN3[i].Y);
                }
                for (int i = 0; i < lGWA.Count; i++)//GWHRAA;
                {
                    g.DrawImage(lGWA[i].img, lGWA[i].X, lGWA[i].Y);
                }
                for (int i = 0; i < lSHBoll.Count; i++)//SAHERR BOLLIT;
                {
                    g.DrawImage(lSHBoll[i].imgs[lSHBoll[i].ID], lSHBoll[i].X, lSHBoll[i].Y, 40, 40);
                }
                for (int i = 0; i < lSHPahBLL.Count; i++)//SHAPAH BOLL;
                {
                    g.DrawImage(lSHPahBLL[i].img, lSHPahBLL[i].X, lSHPahBLL[i].Y);
                }
                if (shoow==1)// BOMMMMM
                {
                    for(int i = 0; i < lBmm.Count; i++)
                    {
                        g.DrawImage(lBmm[i].imgs[lBmm[i].ID], lBmm[i].X, lBmm[i].Y,wbw,wbh);
                    }
                }
                if (Win == 1)// HEROO WINNNN;
                {
                    for (int i = 0; i < ldoor.Count; i++)
                    {
                        g.DrawImage(ldoor[i].imgs[ldoor[i].ID], ldoor[i].X, ldoor[i].Y);
                    }
                }
                for (int i = 0; i < LHE.Count; i++)//HERO;
                {
                    g.DrawImage(LHE[i].imgs[LHE[i].ID], LHE[i].X, LHE[i].Y);
                }
            }
            if (flover == 1) // GAME OVERRRR;
            {
                for(int i = 0; i < GAM.Count; i++)
                {
                    g.DrawImage(GAM[i].img, GAM[i].X, GAM[i].Y);
                }
            }
            if (flwin == 1)// WIN IMAG;
            {
                for (int i = 1; i < GAM.Count; i++)
                {
                    g.DrawImage(GAM[i].img, GAM[i].X, GAM[i].Y);
                }
            }
        }
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
        static void Main()
        {
            Program opj = new Program();
            Application.Run(opj);
        }
    }
}
