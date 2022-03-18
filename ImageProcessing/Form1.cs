using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap img;
        Bitmap img_origin;

        public Form1()
        {
            InitializeComponent();
        }

        public void InitForm()
        {
            O_R_Band.Image = null;
            O_G_Band.Image = null;
            O_B_Band.Image = null;
            H_B_img.Image = null;
            H_G_img.Image = null;
            H_R_img.Image = null;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Image File";
            openFileDialog.Filter = "jpg file (*.jpg)|*.jpg|All file(*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                InitForm();
                img = new Bitmap(Image.FromFile(openFileDialog.FileName));
                img_origin = new Bitmap(img);

                original_img.Image = img_origin;

                O_PhotoWH.Text = "" + img.Width.ToString() + "x" + img.Height.ToString();
                
                Bitmap[] rgbbang = ShowBand(img_origin);
                O_R_Band.Image = rgbbang[0];
                O_G_Band.Image = rgbbang[1];
                O_B_Band.Image = rgbbang[2];

                Bitmap[] his = Histogram(img_origin);
                H_R_img.Image = his[0];
                H_G_img.Image = his[1];
                H_B_img.Image = his[2];
            }
        }

        //basic function
        public Bitmap[] ShowBand(Bitmap img)
        {
            int[,,] rgb = GetRGBData(img);
            int height = img.Height;
            int width = img.Width;
            int temp = 0;
            int[,,] RBand = new int[height, width, 3];
            int[,,] GBand = new int[height, width, 3];
            int[,,] BBand = new int[height, width, 3];

            Bitmap[] rgbband = new Bitmap[3];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    //RBand
                    temp = rgb[i, j, 0];
                    RBand[i, j, 0] = temp;
                    RBand[i, j, 1] = temp;
                    RBand[i, j, 2] = temp;
                    //GBand
                    temp = rgb[i, j, 1];
                    GBand[i, j, 0] = temp;
                    GBand[i, j, 1] = temp;
                    GBand[i, j, 2] = temp;
                    //BBand
                    temp = rgb[i, j, 2];
                    BBand[i, j, 0] = temp;
                    BBand[i, j, 1] = temp;
                    BBand[i, j, 2] = temp;
                }
            }
            //RBand setting
            rgbband[0] = SetRGBData(RBand);
            //GBand setting
            rgbband[1] = SetRGBData(GBand);
            //BBand setting
            rgbband[2] = SetRGBData(BBand);

            return rgbband;
        }

        public static int[,,] GetRGBData(Bitmap bitImg)
        {
            int height = bitImg.Height;
            int width = bitImg.Width;
            //鎖住Bitmap整個影像內容
            BitmapData bitmapData = bitImg.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            //取得影像資料的起始位置
            IntPtr imgPtr = bitmapData.Scan0;
            //影像scan的寬度
            int stride = bitmapData.Stride;
            //影像陣列的實際寬度
            int widthByte = width * 3;
            //所Padding的Byte數
            int skipByte = stride - widthByte;
            //設定預定存放的rgb三維陣列
            int[,,] rgbData = new int[height, width, 3];

            #region 讀取RGB資料
            //注意C#的GDI+內的影像資料順序為BGR, 非一般熟悉的順序RGB
            //因此我們把順序調回原來的陣列順序排放BGR->RGB
            unsafe
            {
                byte* p = (byte*)imgPtr;
                for (int j = 0; j < height; j++)
                {
                    for (int i = 0; i < width; i++)
                    {
                        //B Channel
                        rgbData[j, i, 2] = p[0];
                        p++;
                        //G Channel
                        rgbData[j, i, 1] = p[0];
                        p++;
                        //R Channel
                        rgbData[j, i, 0] = p[0];
                        p++;
                    }
                    p += skipByte;
                }
            }

            //解開記憶體鎖
            bitImg.UnlockBits(bitmapData);

            #endregion

            return rgbData;
        }

        public static Bitmap SetRGBData(int[,,] rgbData)
        {
            Bitmap bitImg;
            int height = rgbData.GetLength(0);
            int width = rgbData.GetLength(1);
            bitImg = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            BitmapData bitmapData = bitImg.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            IntPtr imgPtr = bitmapData.Scan0;
            int stride = bitmapData.Stride;
            int widthByte = width * 3;
            int skipByte = stride - widthByte;

            unsafe
            {
                byte* p = (byte*)(void*)imgPtr;
                for (int j = 0; j < height; j++)
                {
                    for (int i = 0; i < width; i++)
                    {
                        //B Channel
                        p[0] = (byte)rgbData[j, i, 2];
                        p++;
                        //G Channel
                        p[0] = (byte)rgbData[j, i, 1];
                        p++;
                        //R Channel
                        p[0] = (byte)rgbData[j, i, 0];
                        p++;
                    }
                    p += skipByte;
                }
            }
            //解開記憶體鎖
            bitImg.UnlockBits(bitmapData);
            return bitImg;
        }

        public Bitmap[] Histogram(Bitmap img)
        {
            int[] origin_r = new int[256];
            int[] origin_g = new int[256];
            int[] origin_b = new int[256];
            int height = img.Height;
            int width = img.Width;
            Bitmap[] his = new Bitmap[3];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixelColor = img.GetPixel(x, y);
                    origin_r[pixelColor.R]++;
                    origin_g[pixelColor.G]++;
                    origin_b[pixelColor.B]++;
                }
            }

            int max_times = 0;
            for (int i = 0; i < 256; i++)
            {
                if (max_times < origin_r[i])
                    max_times = origin_r[i];
                if (max_times < origin_g[i])
                    max_times = origin_g[i];
                if (max_times < origin_b[i])
                    max_times = origin_b[i];
            }

            Bitmap imgR = new Bitmap(256, 100);
            for (int x = 0; x < imgR.Width; x++)
            {
                for (int y = 0; y < (int)(((float)origin_r[x] / max_times) * 100); y++)
                {
                    imgR.SetPixel(x, imgR.Height - y - 1, Color.FromArgb(255, 0, 0));
                }
            }
            his[0] = imgR;

            Bitmap imgG = new Bitmap(256, 100);
            for (int x = 0; x < imgG.Width; x++)
            {
                for (int y = 0; y < (int)(((float)origin_g[x] / max_times) * 100); y++)
                {
                    imgG.SetPixel(x, imgG.Height - y - 1, Color.FromArgb(0, 255, 0));
                }
            }
            his[1] = imgG;

            Bitmap imgB = new Bitmap(256, 100);
            for (int x = 0; x < imgB.Width; x++)
            {
                for (int y = 0; y < (int)(((float)origin_b[x] / max_times) * 100); y++)
                {
                    imgB.SetPixel(x, imgB.Height - y - 1, Color.FromArgb(0, 0, 255));
                }
            }
            his[2] = imgB;

            return his;
        }

        private void save_but_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "save image";
            saveFileDialog.InitialDirectory= @"D:\";
            saveFileDialog.Filter= "jpg file (*.jpg)|*.jpg|All file(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                img.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
            }


        }

        private void original_img_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
