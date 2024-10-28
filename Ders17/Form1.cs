namespace Ders17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sonuç1,sonuç2;
        private void button1_Click(object sender, EventArgs e)
        { 
            button1.Enabled = false;
            button2.Enabled = true;
           int a, b;
           a=rastgele.Next(1,7);
           b=rastgele.Next(1, 7);
           label4.Text = a.ToString();
           label5.Text = b.ToString();
             sonuç1 =  sonuç1 + a + b;
            label12.Text=sonuç1.ToString();
            label15.Text = sonuç1.ToString();
            if (a == 1)
            { 
                pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\1.png";



            }
            if (a == 2)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\2.png";
            }
            if (a == 3) {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\3.png";

            }
            if (a == 4)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\4.png";
            }
            if (a == 5) {


                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\5.png";
            }
            if (a == 6) {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\6.png";
            }
            if (b == 1)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\1.png";



            }
            if (b == 2)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\2.png";
            }
            if (b == 3)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\3.png";

            }
            if (b == 4)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\4.png";
            }
            if (b == 5)
            {


                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\5.png";
            }
            if (b == 6)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\6.png";
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            int a, b;
            a = rastgele.Next(1, 7);
            b = rastgele.Next(1, 7);
            label7.Text = a.ToString();
            label6.Text = b.ToString();
            sonuç2 = sonuç2 + a + b;
            label11.Text = sonuç2.ToString();
            label16.Text = sonuç2.ToString();
            if (a == 1)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\1.png";



            }
            if (a == 2)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\2.png";
            }
            if (a == 3)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\3.png";

            }
            if (a == 4)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\4.png";
            }
            if (a == 5)
            {


                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\5.png";
            }
            if (a == 6)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\6.png";
            }
            if (b == 1)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\1.png";



            }
            if (b == 2)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\2.png";
            }
            if (b == 3)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\3.png";

            }
            if (b == 4)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\4.png";
            }
            if (b == 5)
            {


                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\5.png";
            }
            if (b == 6)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.ImageLocation = "C:\\Users\\acer\\Desktop\\zar\\6.png";
            }

            if (sonuç2 >= 100 && sonuç2>sonuç1 )
            {
                MessageBox.Show("2.Oyuncu kazandý");
            }
            if (sonuç1 >= 100 && sonuç1 > sonuç2)
            {
                MessageBox.Show("1.Oyuncu kazandý");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
