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
        ArrangeDirection kryptis;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            zaidimolangelis = new zaidimolangeliai[11, 11];
            gyvatexy = new gyvateskoordinates[100];
            Random = new Random();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}