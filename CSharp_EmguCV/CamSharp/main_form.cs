using System;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;


namespace CamSharp
{
    public partial class f_main : Form
    {

        private Capture cap = null;        
        int delay = 2000;
        int camnum;
        StringBuilder mySB = new StringBuilder();
        bool resolution = true;
        Image<Bgr, Byte> frame, frame2;
        Mat mat = new Mat();
        Mat mat2 = new Mat();
        Boolean L = false;


        int m_interations = 1;
        int h = 0;
        int b = 0;
        int index = 0;
        int h_im = 288;
        int w_im = 512;

        public f_main()
        {

            InitializeComponent();

            cb_channel.SelectedIndex = index;
            imageBox1.Height = h_im;
            imageBox1.Width = w_im;
           
        }

        private void cb_channel_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cb_channel.SelectedIndex;
        }


        private void up_numb_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_interations = Convert.ToInt32(up_inters.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = "2.JPG";
            filename = textBox1.Text;
            label1.Text = filename;

            try
            {
                cap = new Capture(filename);

            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
                return;
            }
            imageBox1.ClearOperation();
            imageBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            cap.ImageGrabbed += PassCameraFrame;
            imageBox1.Height = cap.Height;
            imageBox1.Width = cap.Width;
            cap.Start();
        }
       
        void ProcessFrame(object sender, EventArgs e)
        {
            try
            {
                if (cap != null)
                {
                    imageBox1.ClearOperation();
                    imageBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    imageBox1.Image = cap.QueryFrame();
                }
            }
            catch (Exception e2)
            {
                label1.Text = e2.Message;
                return;
            }
        }

        void CamIni(int m)
        {
            if (cap != null) 
            cap.Stop();
            Task.Delay(delay);
            label1.Text = m.ToString();
            try
            {
                cap = new Capture(m);
                imageBox1.ClearOperation();
                imageBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                cap.ImageGrabbed += PassCameraFrame;
                imageBox1.Height = cap.Height;
                imageBox1.Width = cap.Width;
                cap.Start();

            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
                return;
            }

            Task.Delay(delay);
            mySB.Clear();
            mySB.Append("Resolution: ");
            mySB.Append(Convert.ToString(cap.Height));
            mySB.Append(" X ");
            mySB.Append(Convert.ToString(cap.Width));
            label_res.Text = mySB.ToString();


        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                decimal r = numericUpDown1.Value;
                camnum = Convert.ToInt32(r);
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
                return;
            }
            CamIni(camnum);

        }

        private void Change_res(object sender, EventArgs e)
        {
            if (resolution)
            {
                resolution = !resolution;
                imageBox1.Height = 288;
                imageBox1.Width = 512;
            }
            else
            {
                resolution = !resolution;
                imageBox1.Height = 300;
                imageBox1.Width = 400;
            }


        }
        
        private void PassCameraFrame(object sender, EventArgs arg)
        {
            cap.Retrieve(mat, 0);
            frame = mat.ToImage<Bgr, Byte>();
            ProcessFrame(frame);
        }

        private delegate void DisplayImageDelegate(Bitmap Image, PictureBox Target);
        private void DisplayImage(Bitmap Image, PictureBox Target)
        {
            if (Target.InvokeRequired)
            {
                try
                {
                    DisplayImageDelegate DI = new DisplayImageDelegate(DisplayImage);
                    this.BeginInvoke(DI, new object[] { Image, Target });
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                Target.Image = Image;
            }
        }


        private void ProcessFrame(Image<Bgr, Byte> input)
        {
            
            searching();
            DisplayImage(input.ToBitmap(), imageBox1);
        }
        private void ProcessSecFrame(Image<Bgr, Byte> input)
        {
            imageBox2.ClearOperation();
            imageBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            DisplayImage(input.ToBitmap(), imageBox2);
            imageBox3.ClearOperation();
            imageBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void Take_cap_btn_Click(object sender, EventArgs e)
        {
            imageBox2.Height = cap.Height;
            imageBox2.Width = cap.Width;

            cap.Retrieve(mat, 0);
            frame2 = mat.ToImage<Bgr, Byte>();
            ProcessSecFrame(frame2);
        }


        delegate int GetSliderValueCallback();

        private int GetValue_tr_level_dots()
        {
            int sliderValue;
            if (tr_level_dots.InvokeRequired)
            {
                GetSliderValueCallback cb = new GetSliderValueCallback(GetValue_tr_level_dots);
                return (int)tr_level_dots.Invoke(cb);
            }
            else
            {
                l_floor.Text = tr_level_dots.Value.ToString();
                return (int)tr_level_dots.Value;
            }
        }


        private int GetValue_tr_lvl_bin()
        {
            int sliderValue;
            if (tr_lvl_bin.InvokeRequired)
            {
                GetSliderValueCallback cb = new GetSliderValueCallback(GetValue_tr_lvl_bin);
                return (int)tr_lvl_bin.Invoke(cb);
            }
            else
            {
                l_bin.Text = tr_lvl_bin.Value.ToString();
                return (int)tr_lvl_bin.Value;
            }
        }


        private int GetValue_tr_lvl_gov()
        {
            int sliderValue;
            if (tr_lvl_gov.InvokeRequired)
            {
                GetSliderValueCallback cb = new GetSliderValueCallback(GetValue_tr_lvl_gov);
                return (int)tr_lvl_gov.Invoke(cb);
            }
            else
            {
                l_smooth.Text = tr_lvl_gov.Value.ToString();
                return (int)tr_lvl_gov.Value;
            }
        }

        private int GetValue_tr_del_sam()
        {
            int sliderValue;
            if (tr_del_sam.InvokeRequired)
            {
                GetSliderValueCallback cb = new GetSliderValueCallback(GetValue_tr_del_sam);
                return (int)tr_del_sam.Invoke(cb);
            }
            else
            {
                l_zoom.Text = tr_del_sam.Value.ToString();
                return (int)tr_del_sam.Value;
            }
        }

        private int GetText_b()
        {
            if (textBox_b.InvokeRequired)
            {
                GetSliderValueCallback cb = new GetSliderValueCallback(GetText_b);
                return (int)textBox_b.Invoke(cb);
            }
            else
            {
                return (int)textBox_b.TextLength;
            }
        }

        private int GetText_h()
        {
            if (textBox_h.InvokeRequired)
            {
                GetSliderValueCallback cb = new GetSliderValueCallback(GetText_h);
                return (int)textBox_h.Invoke(cb);
            }
            else
            {
                return (int)textBox_h.TextLength;
            }
        }


        private void searching()
        {
            if (L == true)
            {
                if (GetText_b() > 0) 
                    b = Convert.ToInt32(textBox_b.Text);
                if (GetText_h() > 0)
                    h = Convert.ToInt32(textBox_h.Text);
                var result = Calculations.geometry(frame, GetValue_tr_del_sam(), GetValue_tr_lvl_bin(), m_interations, h, b, chk_inverted.Checked, index);

                
                var plot = rot_image.max_min_counter(result.Item4, GetValue_tr_lvl_gov(), chk_inverted.Checked, GetValue_tr_level_dots() / 100, Convert.ToDouble(result.Item5[4]));

                try
                {
                    this.Invoke((MethodInvoker)delegate {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Rows.Insert(0, "Угол найденной линии", result.Item5[5]);
                        

                        dataGridView1.Rows.Insert(1, "Максимум ф-ии", plot.Item2[0]);
                        dataGridView1.Rows.Insert(2, "Минимум ф-ии", plot.Item2[1]);
                        dataGridView1.Rows.Insert(3, "Длина проекции", plot.Item2[2]);
                        dataGridView1.Rows.Insert(4, "Длина в 'глубину'", plot.Item2[3]);
                        dataGridView1.Rows.Insert(5, "Угол в параллельную область", plot.Item2[4]);
                        dataGridView1.Rows.Insert(6, "Восстановленная длина, пикс.", plot.Item2[5]);
                        dataGridView1.Rows.Insert(7, "Восстановленная длина, м", plot.Item2[7]);

                        dataGridView1.Rows.Insert(8, "x", result.Item5[0]);
                        dataGridView1.Rows.Insert(9, "y", result.Item5[1]);
                        dataGridView1.Rows.Insert(10, "Диагональ", result.Item5[2]);
                        dataGridView1.Rows.Insert(11, "Угол диагонали", result.Item5[3]);
                        dataGridView1.Rows.Insert(12, "Длина пикселя", result.Item5[4]);
                    });
                }
                catch (Exception ex)
                {

                }

                imageBox5.ClearOperation();
                imageBox4.ClearOperation();

                DisplayImage(result.Item2.ToBitmap(), imageBox2);
                DisplayImage(result.Item3.ToBitmap(), imageBox4);
                DisplayImage(result.Item4.ToBitmap(), imageBox5);
                DisplayImage(result.Item1.ToBitmap(), imageBox3);
                DisplayImage(plot.Item1.ToBitmap(), im_b_calc);
            }

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            L = !L;
            searching();
        }
        
    }
}
