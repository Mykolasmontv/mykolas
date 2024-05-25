using System.Collections;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        Random rand;
        enum zaidimolangeliai
        {
            tuscias,
            gyvate,
            obuolys
        };
        enum kryptys
        {
            virs,
            apac,
            kair,
            des
        };

        struct gyvateskoordinates
        {
            public int x;
            public int y;
        };

        zaidimolangeliai[,] zaidimolangelis;
        gyvateskoordinates[] gyvatexy;
        int gyvatesilgis;
        kryptys kryptis;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            zaidimolangelis = new zaidimolangeliai[11, 11];
            gyvatexy = new gyvateskoordinates[100];
            rand = new Random();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zaidimopaveikslelis.Image = new Bitmap(360, 360);
            g = Graphics.FromImage(zaidimopaveikslelis.Image);
            g.Clear(Color.White);
            for (int i = 1; i <= 10; i++)
            {
                g.DrawImage(imageList1.Images[0], i * 30, 0);
                g.DrawImage(imageList1.Images[0], i * 30, 330);
            }
            for (int i = 0; i <= 11; i++)
            {
                g.DrawImage(imageList1.Images[0], 0, i * 30);
                g.DrawImage(imageList1.Images[0], 330, i * 30);
            }

            gyvatexy[0].x = 5;
            gyvatexy[0].y = 5;
            gyvatexy[1].x = 5;
            gyvatexy[1].y = 6;
            gyvatexy[2].x = 5;
            gyvatexy[2].y = 7;
            g.DrawImage(imageList1.Images[1], 5 * 30, 5 * 30);
            g.DrawImage(imageList1.Images[1], 5 * 30, 6 * 30);
            g.DrawImage(imageList1.Images[1], 5 * 30, 7 * 30);

            zaidimolangelis[5, 5] = zaidimolangeliai.gyvate;
            zaidimolangelis[5, 6] = zaidimolangeliai.gyvate;
            zaidimolangelis[5, 7] = zaidimolangeliai.gyvate;

            kryptis = kryptys.virs;
            gyvatesilgis = 3;
            obuol();
        }
        void obuol()
        {
            int x, y;
            do
            {
                x = rand.Next(1, 10);
                y = rand.Next(1, 10);
            }
            while (zaidimolangelis[x, y] != zaidimolangeliai.tuscias);

            zaidimolangelis[x, y] = zaidimolangeliai.obuolys;
            g.DrawImage(imageList1.Images[2], x * 30, y * 30);
        }

        private void gyvatezem(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    kryptis = kryptys.virs;
                    break;
                case Keys.Down:
                    kryptis = kryptys.apac;
                    break;
                case Keys.Left:
                    kryptis = kryptys.kair;
                    break;
                case Keys.Right:
                    kryptis = kryptys.des;
                    break;
            }
        }

        void gameover()
        {
            timer1.Enabled = false;
            MessageBox.Show("pralaimejai");
        }

        private void tick(object sender, EventArgs e)
        {
            g.FillRectangle(Brushes.White, gyvatexy[gyvatesilgis - 1].x * 30, gyvatexy[gyvatesilgis - 1].y * 30, 30, 30);
            zaidimolangelis[gyvatexy[gyvatesilgis - 1].x, gyvatexy[gyvatesilgis - 1].y] = zaidimolangeliai.tuscias;

            for (int i = gyvatesilgis; i >= 1; i--)
            {
                gyvatexy[i].x = gyvatexy[i - 1].x;
                gyvatexy[i].y = gyvatexy[i - 1].y;
            }

            g.DrawImage(imageList1.Images[1], gyvatexy[0].x * 30, gyvatexy[0].y * 30);

            switch (kryptis)
            {
                case kryptys.virs:
                    gyvatexy[0].y = gyvatexy[0].y - 1;
                    break;
                case kryptys.apac:
                    gyvatexy[0].y = gyvatexy[0].y + 1;
                    break;
                case kryptys.kair:
                    gyvatexy[0].y = gyvatexy[0].x - 1;
                    break;
                case kryptys.des:
                    gyvatexy[0].y = gyvatexy[0].x + 1;
                    break;
            }

            if (gyvatexy[0].x < 1 || gyvatexy[0].x>10 || gyvatexy[0].y >10 || gyvatexy[0].y < 1)
            {
                gameover();
                zaidimopaveikslelis.Refresh();
                return;
            }
            if (zaidimolangelis[gyvatexy[0].x, gyvatexy[0].y]==zaidimolangeliai.gyvate)
            {
                gameover();
                zaidimopaveikslelis.Refresh();
                return;
            }
            if (zaidimolangelis[gyvatexy[0].x, gyvatexy[0].y] == zaidimolangeliai.obuolys)
            {
                g.DrawImage(imageList1.Images[1], gyvatexy[gyvatesilgis].x * 30, gyvatexy[gyvatesilgis].y * 30);
                zaidimolangelis[gyvatexy[gyvatesilgis].x, gyvatexy[gyvatesilgis].y] = zaidimolangeliai.gyvate;
                gyvatesilgis++;

                if (gyvatesilgis < 96)
                    obuol();
                this.Text = "gyvate - taskai: " + gyvatesilgis;
                
                
            }
        }
    }
}