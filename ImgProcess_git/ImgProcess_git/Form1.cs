using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devcorp.Controls.Design;

namespace ImgProcess_git
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Bitmap bitmap2;
        Bitmap bitmap_gray;
        Bitmap bitmap_binary;

        bool Isgray = false;
        bool Isbinary = false;
        bool IsfirstHistogram = false;

        double pow = 1;

        int[] med = new int[256];
        int[] histogram = new int[256];
        int[] cdf = new int[256];

        public double sharpenconst;
        public double twistconst;
        public double radius;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;

            bitmap = new Bitmap(dialog.FileName);
            bitmap2 = new Bitmap(bitmap.Width,bitmap.Height);
            bitmap_gray = new Bitmap(bitmap.Width, bitmap.Height);
            bitmap_binary = new Bitmap(bitmap.Width, bitmap.Height);
            pictureBox1.Image = bitmap;
            pictureBox2.Image = bitmap2;

            Histogram(); //use at first show chart
        }

        private void toGray() //灰階
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    int gray = (color.R + color.G + color.B) / 3;
                    color = Color.FromArgb(gray, gray, gray);
                    bitmap_gray.SetPixel(i, j, color);
                    bitmap2.SetPixel(i, j, color);
                }
            }
            Isgray = true;
        }

        private void toBinary() //二值化
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    int gray = (color.R + color.G + color.B) / 3;

                    if (gray > 127) color = Color.White;
                    else color = Color.Black;

                    bitmap_binary.SetPixel(i, j, color);
                    bitmap2.SetPixel(i, j, color);
                }
            }
            Isbinary = true;
        }

        private void GrayOrNot()
        {
            if (Isgray)
            {
                PowerLaw_Gray();
                Histogram();
            }
            else
            {
                PowerLaw();
                Histogram();
            }
        }

        private void BinaryOrNot()
        {
            if (Isbinary)
            { 
            }
            else
            { 
            }
        } //////////

        private void PowerLaw()
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);

                    YUV yuv = ColorSpaceHelper.RGBtoYUV(color);
                    yuv.Y = Math.Pow(yuv.Y, pow);
                    color = ColorSpaceHelper.YUVtoColor(yuv);
                    bitmap2.SetPixel(i, j, color);
                }
            }
        } //////////

        private void PowerLaw_Gray()
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    int gray = (color.R + color.G + color.B) / 3;

                    double power = Math.Pow(gray / 255.0, pow);
                    int gray2 = (int)(power * 255);
                    if (gray2 > 255) gray2 = 255;
                    if (gray2 < 0) gray2 = 0;
                    color = Color.FromArgb(gray2, gray2, gray2);
                    bitmap2.SetPixel(i, j, color);
                }
            }
        } //////////

        private void Sharpen()
        {
            //double count = Convert.ToDouble(sharpenconst);
            for (int i = 1; i < bitmap.Width - 1; i++)
            {
                for (int j = 1; j < bitmap.Height - 1; j++)
                {
                    Color colorM = bitmap.GetPixel(i, j);
                    Color colorU = bitmap.GetPixel(i, j - 1);
                    Color colorD = bitmap.GetPixel(i, j + 1);
                    Color colorL = bitmap.GetPixel(i - 1, j);
                    Color colorR = bitmap.GetPixel(i + 1, j);

                    int grayM = (colorM.R + colorM.G + colorM.B) / 3;
                    int grayU = (colorU.R + colorU.G + colorU.B) / 3;
                    int grayD = (colorD.R + colorD.G + colorD.B) / 3;
                    int grayL = (colorL.R + colorL.G + colorL.B) / 3;
                    int grayR = (colorR.R + colorR.G + colorR.B) / 3;

                    int gray = grayM * ((int)sharpenconst + 4) + grayU * (-1) + grayD * (-1) + grayL * (-1) + grayR * (-1);
                    if (gray > 255) gray = 255;
                    if (gray < 0) gray = 0;
                    Color color = Color.FromArgb(gray, gray, gray);
                    bitmap2.SetPixel(i, j, color);
                }
            }
        }

        private void Smooth()
        {
            for (int i = 1; i < bitmap.Width - 1; i++)
            {
                for (int j = 1; j < bitmap.Height - 1; j++)
                {
                    Color color1 = bitmap.GetPixel(i - 1, j - 1);
                    Color color2 = bitmap.GetPixel(i, j - 1);
                    Color color3 = bitmap.GetPixel(i + 1, j - 1);
                    Color color4 = bitmap.GetPixel(i - 1, j);
                    Color color5 = bitmap.GetPixel(i, j);
                    Color color6 = bitmap.GetPixel(i + 1, j);
                    Color color7 = bitmap.GetPixel(i - 1, j + 1);
                    Color color8 = bitmap.GetPixel(i, j);
                    Color color9 = bitmap.GetPixel(i + 1, j + 1);
                    int gray1 = (color1.R + color1.G + color1.B) / 3;
                    int gray2 = (color2.R + color2.G + color2.B) / 3;
                    int gray3 = (color3.R + color3.G + color3.B) / 3;
                    int gray4 = (color4.R + color4.G + color4.B) / 3;
                    int gray5 = (color5.R + color5.G + color5.B) / 3;
                    int gray6 = (color6.R + color6.G + color6.B) / 3;
                    int gray7 = (color7.R + color7.G + color7.B) / 3;
                    int gray8 = (color8.R + color8.G + color8.B) / 3;
                    int gray9 = (color9.R + color9.G + color9.B) / 3;

                    int gray = (gray1 + gray2 + gray3 + gray4 + gray5 + gray6 + gray7 + gray8 + gray9) / 9;
                    Color color = Color.FromArgb(gray, gray, gray);
                    bitmap2.SetPixel(i, j, color);
                }
            }
        }

        private void Median()
        {
            for (int i = 1; i < bitmap.Width - 1; i++)
            {
                for (int j = 1; j < bitmap.Height - 1; j++)
                {
                    Color color1 = bitmap.GetPixel(i - 1, j - 1);
                    Color color2 = bitmap.GetPixel(i, j - 1);
                    Color color3 = bitmap.GetPixel(i + 1, j - 1);
                    Color color4 = bitmap.GetPixel(i - 1, j);
                    Color color5 = bitmap.GetPixel(i, j);
                    Color color6 = bitmap.GetPixel(i + 1, j);
                    Color color7 = bitmap.GetPixel(i - 1, j + 1);
                    Color color8 = bitmap.GetPixel(i, j);
                    Color color9 = bitmap.GetPixel(i + 1, j + 1);

                    int gray1 = (color1.R + color1.G + color1.B) / 3;
                    int gray2 = (color2.R + color2.G + color2.B) / 3;
                    int gray3 = (color3.R + color3.G + color3.B) / 3;
                    int gray4 = (color4.R + color4.G + color4.B) / 3;
                    int gray5 = (color5.R + color5.G + color5.B) / 3;
                    int gray6 = (color6.R + color6.G + color6.B) / 3;
                    int gray7 = (color7.R + color7.G + color7.B) / 3;
                    int gray8 = (color8.R + color8.G + color8.B) / 3;
                    int gray9 = (color9.R + color9.G + color9.B) / 3;

                    med[0] = gray1;
                    med[1] = gray2;
                    med[2] = gray3;
                    med[3] = gray4;
                    med[4] = gray5;
                    med[5] = gray6;
                    med[6] = gray7;
                    med[7] = gray8;
                    med[8] = gray9;

                    Array.Sort(med);
                    int gray = med[4];
                    Color color = Color.FromArgb(gray, gray, gray);
                    bitmap2.SetPixel(i, j, color);
                }
            }
        }

        private void Sobel()
        {
            for (int i = 1; i < bitmap.Width - 1; i++)
            {
                for (int j = 1; j < bitmap.Height - 1; j++)
                {
                    Color color1 = bitmap.GetPixel(i - 1, j - 1);
                    Color color2 = bitmap.GetPixel(i, j - 1);
                    Color color3 = bitmap.GetPixel(i + 1, j - 1);
                    Color color4 = bitmap.GetPixel(i - 1, j);
                    Color color5 = bitmap.GetPixel(i, j);
                    Color color6 = bitmap.GetPixel(i + 1, j);
                    Color color7 = bitmap.GetPixel(i - 1, j + 1);
                    Color color8 = bitmap.GetPixel(i, j);
                    Color color9 = bitmap.GetPixel(i + 1, j + 1);
                    int gray1 = (color1.R + color1.G + color1.B) / 3;
                    int gray2 = (color2.R + color2.G + color2.B) / 3;
                    int gray3 = (color3.R + color3.G + color3.B) / 3;
                    int gray4 = (color4.R + color4.G + color4.B) / 3;
                    int gray5 = (color5.R + color5.G + color5.B) / 3;
                    int gray6 = (color6.R + color6.G + color6.B) / 3;
                    int gray7 = (color7.R + color7.G + color7.B) / 3;
                    int gray8 = (color8.R + color8.G + color8.B) / 3;
                    int gray9 = (color9.R + color9.G + color9.B) / 3;

                    int grayH = Math.Abs((gray7 * 1 + gray8 * 2 + gray9 * 1) - (gray1 * 1 + gray2 * 2 + gray3 * 1));
                    int grayV = Math.Abs((gray3 * 1 + gray6 * 2 + gray9 * 1) - (gray1 * 1 + gray4 * 2 + gray7 * 1));
                    int gray = grayH + grayV;
                    if (gray > 255) gray = 255;
                    if (gray < 0) gray = 0;
                    Color color = Color.FromArgb(gray, gray, gray);
                    bitmap2.SetPixel(i, j, color);
                }
            }
        }

        private void ZoomOut()
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    int x = i / 2;
                    int y = j / 2;
                    bitmap2.SetPixel(x, y, color);
                }
            }
        }

        private void ZoomIn()
        {
            parameter.ZoomIn zoomin = new parameter.ZoomIn();
            zoomin.pictureBox1.Image = bitmap;
            zoomin.ShowDialog();
        } //////////

        private void Histogram()
        {
            if (IsfirstHistogram)
            {
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        Color color = bitmap.GetPixel(i, j);

                        int gray = (color.R + color.G + color.B) / 3;
                        histogram[gray]++;
                    }
                }
                IsfirstHistogram = false;
            }
            else
            {
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        Color color = bitmap2.GetPixel(i, j);

                        int gray = (color.R + color.G + color.B) / 3;
                        histogram[gray]++;
                    }
                }
                IsfirstHistogram = false;
            }
        }

        private void HistogramClear()
        {
            Array.Clear(histogram, 0, histogram.Length);
        }

        private void cdfCount()
        {
            cdf[0] = histogram[0];
            for (int i = 1; i < 255; i++)
            {
                cdf[i] = cdf[i - 1] + histogram[i];
            }
        }

        private void HistogramEqualization()
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);

                    YUV yuv = ColorSpaceHelper.RGBtoYUV(color);
                    int gray = Convert.ToInt32(Math.Round(yuv.Y * 255));

                    yuv.Y = ((double)cdf[gray] - (double)cdf[0]) / (((double)bitmap.Height * (double)bitmap.Width) - (double)cdf[0]);
                    color = ColorSpaceHelper.YUVtoColor(yuv);

                    //bitmap.SetPixel(i, j, color);
                    bitmap2.SetPixel(i, j, color);
                }
            }
        }

        private void Mirror_Horizontal()
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    int ii = (bitmap.Width - 1) - i;
                    bitmap2.SetPixel(ii, j, color);
                }
            }
        }

        private void Mirror_Vertical()
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    int jj = (bitmap.Height - 1) - j;
                    bitmap2.SetPixel(i, jj, color);
                }
            }
        }

        private void DrawPic()
        {
            pictureBox2.Image = bitmap2;
        } // pic draw in function

        public void DrawChart()
        {
            Chart chart = new Chart();
            for (int i = 0; i < 256; i++)
            {
                chart.chart1.Series[0].Points.AddXY(i, histogram[i]);
            }
            chart.Show();
        } // chart draw in function

        private void Labeling()
        {
            int[,] table = new int[bitmap.Width, bitmap.Height];
            int labelnum = 1;
            int threshold = 50;

            int[,] labeling = new int[bitmap.Width, bitmap.Height];
            List<Point> equivalents = new List<Point>();

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap_binary.GetPixel(i, j);
                    int gray = (color.R + color.G + color.B) / 3;

                    if (i - 1 >= 0 && j - 1 >= 0 && gray < threshold)
                    {
                        if (labeling[i - 1, j] > 0 && labeling[i, j - 1] > 0)
                        {
                            labeling[i, j] = labeling[i - 1, j];
                            if (labeling[i - 1, j] != labeling[i, j - 1])
                            {
                                Point point;
                                if (labeling[i - 1, j] > labeling[i, j - 1])
                                    point = new Point(labeling[i, j - 1], labeling[i - 1, j]);
                                else
                                    point = new Point(labeling[i - 1, j], labeling[i, j - 1]);

                                if (!equivalents.Exists(p => p == point))
                                    equivalents.Add(point);
                            }
                        }
                        else if (labeling[i - 1, j] > 0)
                            labeling[i, j] = labeling[i - 1, j];
                        else if (labeling[i, j - 1] > 0)
                            labeling[i, j] = labeling[i, j - 1];
                        else
                        {
                            labeling[i, j] = labelnum;
                            labelnum++;
                        }
                    }
                }
            }

            for (int i = 0; i < equivalents.Count; i++)
            {
                string str = equivalents[i].X.ToString() + "\t" + equivalents[i].Y.ToString();
                //等值表顯示
            }

            for (int i = 0; i < equivalents.Count; i++)
            {
                for (int j = 0; j < equivalents.Count; j++)
                {
                    if (i != j)
                    {
                        if (equivalents[i].Y == equivalents[j].X)
                        {
                            equivalents[j] = new Point(equivalents[i].X, equivalents[j].Y);
                        }
                        if (equivalents[i].Y == equivalents[j].Y)
                        {
                            equivalents[j] = new Point(equivalents[j].X, equivalents[i].X);
                        }
                    }
                }
            }

            Random rand = new Random();
            List<Color> colorTable = new List<Color>();
            List<int> totalLabel = new List<int>();
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    for (int k = 0; k < equivalents.Count; k++)
                    {
                        if (labeling[i, j] == equivalents[k].Y)
                            labeling[i, j] = equivalents[k].X;
                    }


                    int label = labeling[i, j];
                    if (!totalLabel.Exists(k => k == label))
                    {
                        totalLabel.Add(label);
                        Color randColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                        colorTable.Add(randColor);
                    }

                    int index = totalLabel.FindIndex(k => k == label);
                    bitmap2.SetPixel(i, j, colorTable[index]);
                }
            }
        }

        private void ImageSub()
        {
            OpenFileDialog openfile2 = new OpenFileDialog();
            if (openfile2.ShowDialog() != DialogResult.OK) return;

            Bitmap newbitmap = new Bitmap(openfile2.FileName);

            for (int i = 0; i < newbitmap.Width; i++)
            {
                for (int j = 0; j < newbitmap.Height; j++)
                {
                    Color color;
                    int gray;
                    Color color2 = bitmap.GetPixel(i, j);
                    int gray2 = (color2.R + color2.G + color2.B) / 3;
                    Color color3 = newbitmap.GetPixel(i, j);
                    int gray3 = (color3.R + color3.G + color3.B) / 3;
                    gray = Math.Abs(gray2 - gray3);
                    if (gray < 40)
                    {
                        gray = 0;
                        color = Color.FromArgb(gray, gray, gray);
                    }
                    else
                    {
                        color = Color.FromArgb(255, 255, 255);
                    }

                    bitmap2.SetPixel(i, j, color);
                }
            }
        }

        private void twistTransform()
        {
            parameter.Twist twist = new parameter.Twist(this);
            twist.ShowDialog();

            int addWidth = (int)(bitmap.Height * Math.Tan(twistconst * Math.PI / 180));

            bitmap2 = new Bitmap(bitmap.Width + Math.Abs(addWidth), bitmap.Height);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    int x = i + (int)(j * Math.Tan(twistconst * Math.PI / 180));
                    if (addWidth < 0)
                        x = x + Math.Abs(addWidth);
                    bitmap2.SetPixel(x, j, color);
                }
            }
        }

        private Bitmap erosion(Bitmap bitmap, int radius)
        {
            Bitmap erosionBitmap = new Bitmap(bitmap.Width, bitmap.Height);

            for (int i = radius; i < bitmap.Width - radius; i++)
            {
                for (int j = radius; j < bitmap.Height - radius; j++)
                {
                    bool flag = true;
                    for (int m = i - radius; m <= i + radius; m++)
                    {
                        for (int n = j - radius; n < j + radius; n++)
                        {
                            Color color = bitmap.GetPixel(m, n);
                            int gray = (color.R + color.G + color.B) / 3;
                            if (gray == 0)
                                flag = false;
                        }
                    }

                    if (flag)
                        erosionBitmap.SetPixel(i, j, Color.White);
                    else
                        erosionBitmap.SetPixel(i, j, Color.Black);
                }
            }
            return erosionBitmap;
        }

        private Bitmap dilation(Bitmap bitmap, int radius)
        {
            Bitmap dilationBitmap = new Bitmap(bitmap.Width, bitmap.Height);

            for (int i = radius; i < bitmap.Width - radius; i++)
            {
                for (int j = radius; j < bitmap.Height - radius; j++)
                {
                    bool flag = false;
                    for (int m = i - radius; m <= i + radius; m++)
                    {
                        for (int n = j - radius; n <= j + radius; n++)
                        {
                            Color color = bitmap.GetPixel(m, n);
                            int gray = (color.R + color.G + color.B) / 3;
                            if (gray == 255)
                                flag = true;
                        }
                    }

                    if (flag)
                        dilationBitmap.SetPixel(i, j, Color.White);
                    else
                        dilationBitmap.SetPixel(i, j, Color.Black);
                }
            }
            return dilationBitmap;
        }

        private Bitmap wth()
        {
            Bitmap openingBitmap = dilation(erosion(bitmap_binary, 1), 1);
            Bitmap wthBitmap = new Bitmap(bitmap.Width, bitmap.Height);

            for (int i = 0; i < openingBitmap.Width; i++)
            {
                for (int j = 0; j < openingBitmap.Height; j++)
                {
                    Color color1 = openingBitmap.GetPixel(i, j);
                    int gray1 = (color1.R + color1.G + color1.B) / 3;
                    Color color2 = bitmap_binary.GetPixel(i, j);
                    int gray2 = (color2.R + color2.G + color2.B) / 3;

                    Color color;
                    int gray = Math.Abs(gray1 - gray2);

                    if (gray < 40)
                    {
                        gray = 0;
                        color = Color.FromArgb(gray, gray, gray);
                    }
                    else
                    {
                        color = Color.FromArgb(255, 255, 255);
                    }

                    wthBitmap.SetPixel(i, j, color);
                }
            }
            return wthBitmap;
        }

        private Bitmap bth()
        {
            Bitmap closingBitmap = erosion(dilation(bitmap_binary, 1), 1);
            Bitmap bthBitmap = new Bitmap(bitmap.Width, bitmap.Height);

            for (int i = 0; i < closingBitmap.Width; i++)
            {
                for (int j = 0; j < closingBitmap.Height; j++)
                {
                    Color color1 = closingBitmap.GetPixel(i, j);
                    int gray1 = (color1.R + color1.G + color1.B) / 3;
                    Color color2 = bitmap_binary.GetPixel(i, j);
                    int gray2 = (color2.R + color2.G + color2.B) / 3;

                    Color color;
                    int gray = Math.Abs(gray1 - gray2);

                    if (gray > 40)
                    {
                        gray = 0;
                        color = Color.FromArgb(gray, gray, gray);
                    }
                    else
                    {
                        color = Color.FromArgb(255, 255, 255);
                    }

                    bthBitmap.SetPixel(i, j, color);
                }
            }
            return bthBitmap;
        }

        private void ContrastEnhancement()
        {
            //binary + WTH - BTH
            toBinary();
            Bitmap wthBitmap = wth();
            Bitmap bthBitmap = bth();
            Bitmap ceBitmap = new Bitmap(bitmap.Width, bitmap.Height);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color1 = bitmap_binary.GetPixel(i, j);
                    int gray1 = (color1.R + color1.G + color1.B) / 3;
                    Color color2 = wthBitmap.GetPixel(i, j);
                    int gray2 = (color2.R + color2.G + color2.B) / 3;
                    Color color3 = bthBitmap.GetPixel(i, j);
                    int gray3 = (color3.R + color3.G + color3.B) / 3;

                    Color color;
                    int gray = Math.Abs(gray1 + gray2 - gray3);

                    if (gray > 40)
                    {
                        gray = 0;
                        color = Color.FromArgb(gray, gray, gray);
                    }
                    else
                    {
                        color = Color.FromArgb(255, 255, 255);
                    }

                    ceBitmap.SetPixel(i, j, color);
                }
            }
            pictureBox2.Image = ceBitmap;
        }

        #region button

        private void grayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toGray();
            pictureBox2.Image = bitmap_gray;
        }

        private void binaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toBinary();
            pictureBox2.Image = bitmap_binary;
        }

        private void originToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = bitmap;
        } //////////

        private void hEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cdfCount();
            HistogramEqualization();
            HistogramClear();
            Histogram();
            DrawChart();
            pictureBox2.Image = bitmap2;
        }

        private void labelingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Labeling();
            pictureBox2.Image = bitmap2;
        }

        private void imageSubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageSub();
            pictureBox2.Image = bitmap2;
        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parameter.Bright bright = new parameter.Bright(this);
            pow = bright.trackBar1.Value / 100;
            GrayOrNot();
            pictureBox2.Image = bitmap2;
        } //////////

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sharpen();
            pictureBox2.Image = bitmap2;
        }

        private void smoothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Smooth();
            pictureBox2.Image = bitmap2;
        }

        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Median();
            pictureBox2.Image = bitmap2;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobel();
            pictureBox2.Image = bitmap2;
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parameter.Radius R = new parameter.Radius(this);
            R.ShowDialog();
            toBinary();
            Bitmap erosionBitmap = erosion(bitmap_binary, (int)radius);
            pictureBox2.Image = erosionBitmap;
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parameter.Radius R = new parameter.Radius(this);
            R.ShowDialog();
            toBinary();
            Bitmap dilationBitmap = dilation(bitmap_binary, (int)radius);
            pictureBox2.Image = dilationBitmap;
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parameter.Radius R = new parameter.Radius(this);
            R.ShowDialog();
            toBinary();
            Bitmap openingBitmap = dilation(erosion(bitmap_binary, (int)radius), (int)radius);
            pictureBox2.Image = openingBitmap;
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parameter.Radius R = new parameter.Radius(this);
            R.ShowDialog();
            toBinary();
            Bitmap closingBitmap = erosion(dilation(bitmap_binary, (int)radius), (int)radius);
            pictureBox2.Image = closingBitmap;
        }

        private void wTHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opening - binary
            toBinary();
            Bitmap wthBitmap = wth();

            pictureBox2.Image = wthBitmap;
        }

        private void bTHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //closing - binary
            toBinary();
            Bitmap bthBitmap = bth();

            pictureBox2.Image = bthBitmap;
        }

        private void contrastEnhancementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //binary + WTH - BTH
            toBinary();
            Bitmap wthBitmap = wth();
            Bitmap bthBitmap = bth();
            Bitmap ceBitmap = new Bitmap(bitmap.Width, bitmap.Height);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color1 = bitmap_binary.GetPixel(i, j);
                    int gray1 = (color1.R + color1.G + color1.B) / 3;
                    Color color2 = wthBitmap.GetPixel(i, j);
                    int gray2 = (color2.R + color2.G + color2.B) / 3;
                    Color color3 = bthBitmap.GetPixel(i, j);
                    int gray3 = (color3.R + color3.G + color3.B) / 3;

                    Color color;
                    int gray = Math.Abs(gray1 + gray2 - gray3);

                    if (gray > 40)
                    {
                        gray = 0;
                        color = Color.FromArgb(gray, gray, gray);
                    }
                    else
                    {
                        color = Color.FromArgb(255, 255, 255);
                    }

                    ceBitmap.SetPixel(i, j, color);
                }
            }

            pictureBox2.Image = ceBitmap;
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoomIn();
        } 

        #endregion

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoomOut();
            pictureBox2.Image = bitmap2;
        }

        private void flipHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mirror_Horizontal();
            pictureBox2.Image = bitmap2;
        }

        private void flipVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mirror_Vertical();
            pictureBox2.Image = bitmap2;
        }

        private void twistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            twistTransform();
            pictureBox2.Image = bitmap2;
        }

        private void showChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawChart();
        }
    }
}
