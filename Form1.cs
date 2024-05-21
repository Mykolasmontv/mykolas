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
            for(int i=1; i<=10; i++)
            {
                g.DrawImage(imageList1.Images[0], i * 30, 0);
                g.DrawImage(imageList1.Images[0], i * 30, 330);
            }
            for (int i = 0; i <= 11; i++)
            {
                g.DrawImage(imageList1.Images[0], 0, i*30);
                g.DrawImage(imageList1.Images[0], 330, i*30);
            }

            gyvatexy[0].x=5;
            gyvatexy[0].y=5;
            gyvatexy[1].x=5;
            gyvatexy[1].y=6;
            gyvatexy[2].x=5;
            gyvatexy[2].y=7;
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

    }
}