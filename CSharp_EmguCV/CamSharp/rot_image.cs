using System;
using System.Drawing;
using System.Text;

using Emgu.CV;
using Emgu.CV.Structure;

namespace CamSharp
{
    static class rot_image
    {
        public static Tuple<Image<Bgr, Byte>, string[]> max_min_counter(Image<Gray, Byte> frame, int gov, bool inverted, double same, double pix_len) {

            double pi = 3.141593;
            double corr = 0.05;
            int W = frame.Width;
            int H = frame.Height;
            int[] cou = new int[W];
            Array.Clear(cou, 0, cou.Length);
            int cou_max = 0;
            Bgr color_r = new Bgr(0, 0, 255);
            Bgr color_g = new Bgr(0, 255, 0);
            int radius = 10;
            int counter_straight = 0;
            double alpha2 = 0;
            for (int i = 0; i < W; i++)
            {
                for (int j = 0; j < H; j++)
                {
                    if (inverted)
                    {
                        if (frame.Data[j, i, 0] < 150)
                        {
                            cou[i] = cou[i] + 1;
                        }
                    }
                    else
                    {
                        if (frame.Data[j, i, 0] > 150)
                        {
                            cou[i] = cou[i] + 1;
                        }
                    }
                }
                if (cou[i] > cou_max)
                    cou_max = cou[i];
            }

            Image<Gray, Byte> t_gray = new Image<Gray, byte>(W, W);

            if (cou_max > 0)
            {
                for (int i = 0; i < W; i++)
                {
                    counter_straight = counter_straight + 1; 
                    cou[i] = (int)Decimal.Round(((W - 1) * cou[i]) / cou_max);
                    t_gray.Data[cou[i], i, 0] = 250;
                }
            }

            
            Image<Bgr, Byte> output = new Image<Bgr, byte>(new Image<Gray, Byte>[] { new Image<Gray, Byte>(W, W), t_gray, new Image<Gray, Byte>(W, W) });

            int[] maxmin = new int[4];

            maxmin = max_min(cou, W, gov, same);
            Point[] extr = new Point[2];
            extr[0] = new Point(maxmin[1], maxmin[0]);
            extr[1] = new Point(maxmin[3], maxmin[2]);

            CircleF max_cir = new CircleF(extr[0], radius);
            CircleF min_cir = new CircleF(extr[1], radius);

            output.Draw(max_cir, color_r, 2);
            output.Draw(min_cir, color_g, 2);

            double z = maxmin[0] - maxmin[2];

            alpha2 = Convert.ToSingle(180 * Math.Atan(z / counter_straight) / pi);
            double real_len = z / Math.Cos(alpha2 * pi / 180);
            double depth_len = z * Math.Tan(alpha2 * pi / 180);
            double real_m_len = real_len * pix_len;
            string[] output_s = { Convert.ToString(maxmin[0]), Convert.ToString(maxmin[2]), Convert.ToString(counter_straight), Convert.ToString(z), Convert.ToString(alpha2), Convert.ToString(real_len), Convert.ToString(depth_len), Convert.ToString(real_m_len)};
            var s = new Tuple<Image<Bgr, Byte>, string[]>(output, output_s);
            return s;

        }

        private static int [] max_min(int [] arr, int len, int gove, double same) {

       
            int step = 0;
            int min_i = 0;
            int max_i = 0;
            int max_c = 0;
            int min_c = int.MaxValue;

            int prev = arr[0];

            for (int i = 1; i < len; i++) {
                if (arr[i] > 0)
                {
                    if ((prev / arr[i] < (1 + same)) && (prev / arr[i] < (1 + same)))
                    {
                        prev = arr[i];
                        step = step + 1;
                    }
                    else {
                        step = 0;
                        prev = arr[i];
                    }
                    if (step == gove)
                    {
                        if (arr[i] > max_c)
                        {
                            max_c = arr[i];
                            max_i = i;
                            step = 0;
                        }

                        if (arr[i] < min_c)
                        {
                            min_c = arr[i];
                            min_i = i;
                            step = 0;
                        }
                        step = 0;
                    }
                }
                else {
                    prev = arr[i];
                    step = 0;
                }
            }

            int[] m_m = new int[4];
            m_m[0] = max_c;
            m_m[1] = max_i;
            m_m[2] = min_c;
            m_m[3] = min_i;

            return m_m;
        }


   
    }
}
