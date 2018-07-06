using System;
using System.Drawing;
using System.Text;

using Emgu.CV;
using Emgu.CV.Structure;

namespace CamSharp
{
    static class Calculations
    {
    
        public static double[] find_coeff(double x1, double y1, double x2, double y2)
        {
            double a, b, c;
            double[] co = new double[2];
            a = y1 - y2;
            b = x2 - x1;
            c = x1 * y2 - x2 * y1;

            if (b != 0)
            {
                co[0] = -1 * a / b;
                co[1] = -1 * c / b;
            }
            else {
                co[0] = -1;
                co[1] = -1;
            }

            return co;
        }


        public static double find_line(int x1, int y1, int x2, int y2)
        {
            int x_s, y_s;
            x_s = x1 - x2;
            y_s = y1 - y2;
            double z = Math.Sqrt(x_s * x_s + y_s * y_s);
            return z;
        }

        public static int[,] find_diag_lines(int[,] max)
        {

            double max_x_min_y = find_line(max[0, 1], max[1, 1], max[0, 2], max[1, 2]);
            double max_x_max_y = find_line(max[0, 0], max[1, 0], max[0, 2], max[1, 2]);



            int[,] c = new int[2, 2];

            if (max_x_min_y < max_x_max_y)
            {
                c[1, 0] = (int)Decimal.Round((max[1, 0] + max[1, 3]) / 2);
                c[0, 0] = (int)Decimal.Round((max[0, 0] + max[0, 3]) / 2);
                c[1, 1] = (int)Decimal.Round((max[1, 1] + max[1, 2]) / 2);
                c[0, 1] = (int)Decimal.Round((max[0, 1] + max[0, 2]) / 2);
            }
            else {
                c[1, 0] = (int)Decimal.Round((max[1, 0] + max[1, 2]) / 2);
                c[0, 0] = (int)Decimal.Round((max[0, 0] + max[0, 2]) / 2);
                c[1, 1] = (int)Decimal.Round((max[1, 1] + max[1, 3]) / 2);
                c[0, 1] = (int)Decimal.Round((max[0, 1] + max[0, 3]) / 2);
            }
            return c;
        }

        public static double[] find_lines(int[,] max)
        {
            double[] g = new double[3];

            g[0] = find_line(max[0, 0], max[1, 0], max[0, 1], max[1, 1]);
            g[1] = find_line(max[0, 2], max[1, 2], max[0, 3], max[1, 3]);

            if (g[1] != 0)
                g[2] = g[0] / g[1];
            else
                g[2] = g[0];
            return g;
        }

        public static int[,] find_dots(Image<Gray, Byte> imageGray, int level)
        {
            int x = imageGray.Width;
            int y = imageGray.Height;
            y = y - 2;
            x = x - 2;
            int[,] max = new int[2, 4];
            for (int i = 0; i < y; i++)
                for (int j = 0; j < x; j++)
                    if (imageGray.Data[i, j, 0] < level)
                    {
                        max[0, 0] = j;
                        max[1, 0] = i;
                        break;
                    }
            for (int i = y; i > 1; i--)
                for (int j = 0; j < x; j++)
                    if (imageGray.Data[i, j, 0] < level)
                    {
                        max[0, 1] = j;
                        max[1, 1] = i;
                        break;
                    }

            for (int i = x; i > 1; i--)
                for (int j = 0; j < y; j++)
                    if (imageGray.Data[j, i, 0] < level)
                    {
                        max[0, 2] = i;
                        max[1, 2] = j;
                        break;
                    }
               
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    if (imageGray[j, i].Intensity < level)
                    {
                        max[0, 3] = i;
                        max[1, 3] = j;
                        break;
                    }
            return max;
        }

        public static Tuple<Image<Bgr, Byte>, Image<Gray, Byte>, Image<Gray, Byte>, Image<Gray, Byte>, string []> geometry(Image<Bgr, Byte> imageBGR, int cut, int level_bin, int m_interations, int h, int b, bool invert, int channel)
        {

            Matrix<byte> kernel2;
            Image<Bgr, Byte> rgbImage;
            Image<Gray, Byte> frame, frame2, im4_t, res_im, im2;
            int x = 0, x1;
            int y = 0, y1;
            double rot_int = 0.3f;
            double pi = 3.141593f;
            int[,] max, cen;
            double res, rot, e_0_1, e_0_2, alpha, pix_len, ac;
            double[] rr, coeff = new double[2];
            int w = 3;
            Gray bg;
            cen = new int[4, 4];
            
            double x_r, y_r;

            Byte[,] kernel_mask = new Byte[m_interations, m_interations];
            for (int i = 0; i < m_interations; i++)
                for (int j = 0; j < m_interations; j++)
                {
                    x_r = i - (m_interations / 2);
                    y_r = j - (m_interations / 2);
                    if (Math.Pow(x_r, 2.0) + Math.Pow(y_r, 2.0) < Math.Pow(m_interations / 2, 2.0))
                        kernel_mask[i, j] = 1;
                    else
                        kernel_mask[i, j] = 0;
                }
            kernel2 = new Matrix<byte>(kernel_mask);



            switch (channel)
            {
                case 1:
                    imageBGR = new Image<Bgr, Byte>(new Image<Gray, Byte>[] {imageBGR[2],
                new Image<Gray, Byte>(imageBGR.Width, imageBGR.Height),
                 new Image<Gray, Byte>(imageBGR.Width, imageBGR.Height)});
                    break;
                case 2:
                    imageBGR = new Image<Bgr, Byte>(new Image<Gray, Byte>[] {
                new Image<Gray, Byte>(imageBGR.Width, imageBGR.Height),imageBGR[1],
                 new Image<Gray, Byte>(imageBGR.Width, imageBGR.Height)});
                    break;
                case 3:
                    imageBGR = new Image<Bgr, Byte>(new Image<Gray, Byte>[] {imageBGR[0],
                new Image<Gray, Byte>(imageBGR.Width, imageBGR.Height),
                 new Image<Gray, Byte>(imageBGR.Width, imageBGR.Height),
                });
                    break;
                default:
                    break;
            }

            frame = imageBGR.Convert<Gray, Byte>();
            frame = 255 * frame.ThresholdBinary(new Gray(level_bin), new Gray(1));
            im2 = frame.Copy();

            frame = frame.SmoothMedian(15);
            frame.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Dilate, kernel2, new System.Drawing.Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar());
            frame.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Close, kernel2, new System.Drawing.Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar());
            frame.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Open, kernel2, new System.Drawing.Point(-1, -1), 2, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar());
            frame = 255 * frame.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Close, kernel2, new System.Drawing.Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar());

            frame = frame.SmoothMedian(3);

            if (invert == true)
            {
                im4_t = frame;
                frame = 255 - frame;
            }
            else
                im4_t = frame;


            ac = Convert.ToSingle(2 * h * Math.Tan((b / 2) * pi / 180));

            x = frame.Width;
            y = frame.Height;
            if (cut > 0)
            {
                Rectangle rect = new Rectangle(cut, cut, x - cut, y - cut);
                frame = frame.Copy(rect);
                im2 = im2.Copy(rect);
                x = frame.Width;
                y = frame.Height;
            }

            alpha = Convert.ToSingle(180 * Math.Atan(x / y) / pi);
            pix_len = Convert.ToSingle(ac * Math.Sin(alpha * pi / 180) / y);
            max = find_dots(frame, 150);
            rr = find_lines(max);
            res = 0;
            rot = 0;

            if (rr[2] > 1 + rot_int)
            {
                res = rr[0];
                rot = 0;
                coeff = find_coeff(max[0, 2], max[1, 2], max[0, 3], max[1, 3]);
            }

            if (rr[2] < 1 - rot_int)
            {
                res = rr[1];
                rot = 90;
                coeff = find_coeff(max[0, 0], max[1, 0], max[0, 1], max[1, 1]);
            }

            int g = 1;

            if (res == 0)
            {
                cen = find_diag_lines(max);
                res = find_line(cen[0, 0], cen[1, 0], cen[0, 1], cen[1, 1]);
                coeff = find_coeff(cen[0, 0], cen[1, 0], cen[0, 1], cen[1, 1]);
                e_0_1 = Math.Abs(cen[1, 0] - cen[1, 1]);
                e_0_2 = Math.Abs(cen[0, 1] - cen[0, 0]);

                if (cen[0, 0] < cen[0, 1])
                    g = -1;

                if (e_0_2 != 0)
                    rot = 90 - Convert.ToSingle(g * 180 * Math.Atan(e_0_1 / e_0_2) / pi);
                else
                    rot = 90;


            }

            if (invert)
            {
                bg = new Gray(0);
            }
            else {
                bg = new Gray(255);
            }

            rot = rot - 90;

            frame = im2.Rotate(rot, bg, false);

            x1 = frame.Width;
            y1 = frame.Height;

            res_im = new Image<Gray, byte>(x, y);

            Point[] p1 = new Point[4];
            p1[0] = new Point(max[0, 0], max[1, 0]);
            p1[1] = new Point(max[0, 1], max[1, 1]);
            p1[2] = new Point(max[0, 2], max[1, 2]);
            p1[3] = new Point(max[0, 3], max[1, 3]);

            Point[] centroids = new Point[2];
            centroids[0] = new Point(cen[0, 0], cen[1, 0]);
            centroids[1] = new Point(cen[0, 1], cen[1, 1]);

            int radius = 15;

            CircleF c1 = new CircleF(p1[0], radius);
            CircleF c2 = new CircleF(p1[1], radius);
            CircleF c3 = new CircleF(p1[2], radius);
            CircleF c4 = new CircleF(p1[3], radius);

            CircleF centr1 = new CircleF(centroids[0], radius);
            CircleF centr2 = new CircleF(centroids[1], radius);


            LineSegment2D d1 = new LineSegment2D(p1[0], p1[1]);
            LineSegment2D d2 = new LineSegment2D(p1[2], p1[3]);

            frame2 = im2;

            for (int j = 0; j < y - 1; j++)
                for (int i = 0; i < x - 1; i++)
                {

                    if (j < (coeff[0] * i + coeff[1] + w) && (j > (coeff[0] * i + coeff[1] - w)))
                    {
                        res_im.Data[j, i, 0] = 250;
                        im2.Data[j, i, 0] = 0;
                    }
                    else
                        res_im.Data[j, i, 0] = im2.Data[j, i, 0];
                }


            Bgr color_r = new Bgr(0, 0, 255);
            Bgr color_g = new Bgr(0, 255, 0);
            rgbImage = new Image<Bgr, Byte>(new Image<Gray, Byte>[] { res_im, im2, im2 });
            rgbImage.Draw(c1, color_r, 2);
            rgbImage.Draw(c2, color_r, 2);
            rgbImage.Draw(c3, color_r, 2);
            rgbImage.Draw(c4, color_r, 2);
            rgbImage.Draw(d1, color_g, 2);
            rgbImage.Draw(d2, color_g, 2);
            rgbImage.Draw(centr1, color_g, 4);
            rgbImage.Draw(centr2, color_g, 4);

            string [] output_s = {Convert.ToString(x), Convert.ToString(y), Convert.ToString(ac), Convert.ToString(alpha), Convert.ToString(pix_len), Convert.ToString(rot)};
           
            var tuple = new Tuple<Image<Bgr, Byte>, Image<Gray, Byte>, Image<Gray, Byte>, Image<Gray, Byte>, string []>(rgbImage, frame2, im4_t, frame, output_s);
            return tuple;



        }

    }
}
