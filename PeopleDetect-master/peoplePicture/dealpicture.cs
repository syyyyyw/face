using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peoplePicture
{
    public partial class dealpicture : Form
    {
        public dealpicture()
        {
            InitializeComponent();
        }

        Bitmap bitmap;
        Bitmap newbitmap;
    
        OpenFileDialog fdlg = new OpenFileDialog();




        private void button1_Click(object sender, EventArgs e)
        {

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string path = fdlg.FileName;
                bitmap = (Bitmap)Image.FromFile(path);
                pictureBox1.Image = bitmap.Clone() as Image;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                pictureBox2.Refresh();
                Graphics g = pictureBox2.CreateGraphics();
                g.TranslateTransform(100, 100);
                g.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            }
        }
        //灰度处理
        private void button5_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                pictureBox2.Refresh();
                newbitmap = bitmap.Clone() as Bitmap;

                Color pixel;
                int gray;
                for (int x = 0; x < newbitmap.Width; x++)
                {
                    for (int y = 0; y < newbitmap.Height; y++)
                    {
                        pixel = newbitmap.GetPixel(x, y);
                        gray = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
                        newbitmap.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                    }
                }


                pictureBox2.Image = newbitmap.Clone() as Image;
            }

        }
        //边缘检测
        private void button4_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                pictureBox2.Refresh();
                Color c1 = new Color();
                Color c2 = new Color();
                Color c3 = new Color();
                Color c4 = new Color();
                int i, j;
                int rr, gg, bb;//
                int r1, r2, r3, r4, fxr, fyr;//
                int g1, g2, g3, g4, fxg, fyg;//
                int b1, b2, b3, b4, fxb, fyb;//
                                             //把图片中的图片传给一个ＢＩＴＭＡＰ类型
                Bitmap box1 = bitmap.Clone() as Bitmap;
                for (i = 0; i <= bitmap.Width - 2; i++)
                {
                    for (j = 0; j <= bitmap.Height - 2; j++)
                    {
                        c1 = box1.GetPixel(i, j);
                        c2 = box1.GetPixel(i + 1, j + 1);
                        c3 = box1.GetPixel(i + 1, j);
                        c4 = box1.GetPixel(i, j + 1);
                        r1 = c1.R;
                        r2 = c2.R;
                        r3 = c3.R;
                        r4 = c4.R;
                        fxr = r1 - r2;
                        fyr = r3 - r4;
                        rr = Math.Abs(fxr) + Math.Abs(fyr) + 128;
                        if (rr < 0) rr = 0;
                        if (rr > 255) rr = 255;
                        g1 = c1.G;
                        g2 = c2.G;
                        g3 = c3.G;
                        g4 = c4.G;
                        fxg = g1 - g2;
                        fyg = g3 - g4;
                        gg = Math.Abs(fxg) + Math.Abs(fyg) + 128;
                        if (gg < 0) gg = 0;
                        if (gg > 255) gg = 255;
                        b1 = c1.B;
                        b2 = c2.B;
                        b3 = c3.B;
                        b4 = c4.B;
                        fxb = b1 - b2;
                        fyb = b3 - b4;
                        bb = Math.Abs(fxb) + Math.Abs(fyb) + 128;
                        if (bb < 0) bb = 0;
                        if (bb > 255) bb = 255;
                        Color cc = Color.FromArgb(rr, gg, bb);
                        box1.SetPixel(i, j, cc);
                    }
                    

                }
                pictureBox2.Image = box1.Clone() as Image;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                pictureBox2.Refresh();
                Graphics g = pictureBox2.CreateGraphics();
                g.DrawImage(bitmap, 0, 0, bitmap.Width / 2, bitmap.Height / 2);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                newbitmap = bitmap.Clone() as Bitmap;
             
                int RIDIO = 50;//马赛克的尺度，默认为周围两个像素
                for (int h = 0; h < newbitmap.Height; h += RIDIO)
                {
                    for (int w = 0; w < newbitmap.Width; w += RIDIO)
                    {
                        int avgRed = 0, avgGreen = 0, avgBlue = 0;
                        int count = 0;
                        //取周围的像素
                        for (int x = w; (x < w + RIDIO && x < newbitmap.Width); x++)
                        {
                            for (int y = h; (y < h + RIDIO && y < newbitmap.Height); y++)
                            {
                                Color pixel = newbitmap.GetPixel(x, y);
                                avgRed += pixel.R;
                                avgGreen += pixel.G;
                                avgBlue += pixel.B;
                                count++;
                            }
                        }

                        //取平均值
                        avgRed = avgRed / count;
                        avgBlue = avgBlue / count;
                        avgGreen = avgGreen / count;

                        //设置颜色
                        for (int x = w; (x < w + RIDIO && x < newbitmap.Width); x++)
                        {
                            for (int y = h; (y < h + RIDIO && y < newbitmap.Height); y++)
                            {
                                Color newColor = Color.FromArgb(avgRed, avgGreen, avgBlue);
                                newbitmap.SetPixel(x, y, newColor);
                            }
                        }
                    }
                }
               
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
       
        }
    }
}
