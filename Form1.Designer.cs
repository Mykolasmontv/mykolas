namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            zaidimopaveikslelis = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)zaidimopaveikslelis).BeginInit();
            SuspendLayout();
            // 
            // zaidimopaveikslelis
            // 
            zaidimopaveikslelis.Location = new Point(12, 12);
            zaidimopaveikslelis.Name = "zaidimopaveikslelis";
            zaidimopaveikslelis.Size = new Size(360, 360);
            zaidimopaveikslelis.TabIndex = 2;
            zaidimopaveikslelis.TabStop = false;
            zaidimopaveikslelis.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 250;
            timer1.Tick += tick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "images.jpg");
            imageList1.Images.SetKeyName(1, "snake.jpg");
            imageList1.Images.SetKeyName(2, "apple.jpg");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 377);
            Controls.Add(zaidimopaveikslelis);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += gyvatezem;
            ((System.ComponentModel.ISupportInitialize)zaidimopaveikslelis).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox zaidimopaveikslelis;
        private System.Windows.Forms.Timer timer1;
        private ImageList imageList1;
    }
}
