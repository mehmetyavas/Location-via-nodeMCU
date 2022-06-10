using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{


    public partial class Form1 : Form
    {
        public double mouseX;
        public double mouseY;
        public double _ab=0;
        public double _bc=0;

        PictureBox pictureBox;

        public Form1()
        {
            InitializeComponent();
            pictureBox = new PictureBox();
            richTxtBoxRSSI1.Visible = false;
            richTxtBoxRSSI2.Visible = false;


        }

      

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


            //Kare

            int lineX = Convert.ToInt16(txtBoxLineX.Text),//x-a değeri
            lineY = Convert.ToInt16(txtBoxLineY.Text);

            Graphics g = e.Graphics;

                Pen mypen = new Pen(Color.Black);
            

            try
            {
                if (txtBoxLineX.Text==null&& txtBoxLineX.Text == null)
                {

                }
                else
                {
                    //üst çizgi
                    g.DrawLine(mypen,
                        0,
                        0,
                        lineX,
                        0);
                    //alt çizgi
                    g.DrawLine(mypen, 
                        0,
                        lineX,
                        lineX,
                        lineX);
                    //sağ dikey çizgi
                     g.DrawLine(mypen,
                         0,
                         0,
                         0,
                         lineY);
                     g.DrawLine(mypen,
                         lineY, 
                         0,
                         lineY,
                         lineY);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("En boy gir");
            }
            


         
            try
            {
                
                mypen = new Pen(Color.Green);
                g.DrawLine(mypen,
                    lineX,
                    0,
                    (float)_ab,
                     (float)_bc
                     );
                mypen = new Pen(Color.Orange);
                g.DrawLine(mypen,
                    0,
                    0,
                     (float)_ab,
                     (float)_bc
                     );
                mypen = new Pen(Color.Black);
            
                //h degeri
                g.DrawLine(mypen,
                    (float)_ab,
                    0,
                    (float)_ab,
                    (float)_bc
                    );
               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Invalidate();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
           

            int lineX= Convert.ToInt16(txtBoxLineX.Text),
               lineY= Convert.ToInt16(txtBoxLineY.Text);
               

            try
            {


                pictureBox.Name = "pictureBox1";
                pictureBox.Size = new Size(3, 3);
                pictureBox.BackColor = Color.Red;
                this.Controls.Add(pictureBox);
            }
            catch (Exception)
            {
                MessageBox.Show("x ve y değerini doğru girin.");
            }
            Invalidate();

            

            
            //_ab, _bc
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            if (txtBoxIP.Text == "")
            {
                MessageBox.Show("ip gir");
            }
            else
            {
               timer1.Start();
                richTxtBoxRSSI1.Visible = true;
                richTxtBoxRSSI2.Visible = true;
                btnStart.Enabled = false;
            }
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {

                timer1.Interval = 600;
                HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load(txtBoxIP.Text);
                foreach (var item in doc.DocumentNode.SelectNodes("//div[@class='rssi']"))
                {
                    richTxtBoxRSSI1.Text = item.InnerText;
                }
                foreach (var item in doc.DocumentNode.SelectNodes("//div[@class='rssi1']"))
                {
                    richTxtBoxRSSI2.Text = item.InnerText;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("İP Adresi girin");
                timer1.Stop();
            }
           
            string ab = richTxtBoxRSSI1.Text;
            string bc = richTxtBoxRSSI2.Text;
            double _abUzaklik = Convert.ToInt32(ab.Substring(9, 2));
            double _bcUzaklik = Convert.ToInt32(bc.Substring(9, 2));
            
                        string[] valueAB = ab.Split('-');
                         _abUzaklik = Convert.ToInt32(valueAB[1]);
                        string[] valueBC = bc.Split('-');
                         _bcUzaklik = Convert.ToInt32(valueAB[1]);

            _ab = _abUzaklik;
            _bc = _bcUzaklik;

 
           
            double lineX = Convert.ToInt16(txtBoxLineX.Text) ,
              lineY = Convert.ToInt16(txtBoxLineY.Text) ;
            double x = Convert.ToInt16(txtBoxPointX.Text);//metre cinsinden
            double y = Convert.ToInt16(txtBoxPointY.Text);//metre cinsinden
           
            
            if ((_ab >= 0 && _ab <= 55) && (_bc >= 0 && _bc <= 55))
            {
                x = 1;

            }
            if ((_ab >= 56 && _ab <= 62) && (_bc >= 56 && _bc <= 62))
            {
                x = 5;

            }
            if ((_ab >= 63 && _ab <= 67 )&& (_bc >= 63 && _bc <= 67))
            {
                x = 7;

            }
            if ((_ab >= 68 && _ab <= 69 ) && (_bc >= 68 && _bc <= 69))
            {
                x = 8;

            }
            if ((_ab >= 70 && _ab <= 72) && (_bc >= 70 && _bc <= 72))
            {
                x = 11;

            }
            if ((_ab >= 73 && _ab <= 75) && (_bc >= 73 && _bc <= 75))
            {
                x = 15;

            }
            if ((_ab >= 76 && _ab <= 80 )&& (_bc >= 76 && _bc <= 80))
            {
                x = 18;

            }
            if ((_ab >= 81 && _ab <= 120) && (_bc >= 81 && _bc <= 120))
            {
                x = 20;

            }
            
            x = Convert.ToDouble(txtBoxPointX.Text);
            y = Convert.ToDouble(txtBoxPointY.Text);
            double a = 0;
            
            long z = (long)lineX;
            long zKare=(long)Math.Pow(z,2); 
            long xKare= (long)Math.Pow(x,2);
            long yKare= (long)Math.Pow(y,2);
            double x_z_y_kare = Math.Pow(((xKare - zKare - yKare)/-2*z),2 );
            double h = Math.Pow((yKare - x_z_y_kare),-2);
            string h_deger = h.ToString();
            int hInt = Convert.ToInt32(h_deger.Substring(0,1))*10;
            double hKare = Math.Pow(hInt, 2);
             a = Math.Pow((yKare - hKare),-2);

            string a_deger = a.ToString();
            a = Convert.ToDouble(a_deger.Substring(0, 4))*10;
            /*
            double h = Math.Sqrt((yKare -x_z_y_kare) / (-2 * z)); 
            double hKare = Math.Pow(h,2);
            double a=Math.Sqrt(yKare-hKare);
            double z_eksi_a = z - a;
            */
            a = (int)a;

            pictureBox.Location = new Point((int)x,(int)y);
            
           
            _ab =x;
            _bc = y;
            
        }

       
    }
}
