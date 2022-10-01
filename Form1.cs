using System.Diagnostics;
namespace cs_256color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "ͼƬ|*.gif;*.jpg;*.jpeg;*.bmp;*.jfif;*.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
                label_filepath.Text = dialog.FileName;
            else
            {
                label_filepath.Text = "None";
            }
        }

        
        private void button_gen_Click(object sender, EventArgs e)
        {
            string file = label_filepath.Text;
            if (!File.Exists(file))
            {
                MessageBox.Show("请先打开文件!");
                return;
            }

            Bitmap bm = new Bitmap(file);
            int w = bm.Width, h = bm.Height;
            Debug.WriteLine(String.Format("图片大小: {0} x {1}", w, h));

            Bitmap bm_new = new Bitmap(Width = w, Height = h);
            int block = (int)(numericUpDown_block_size.Value);

            //外层逐行
            for(int i = 0; i < h; i+=block)
            { 
                for(int j = 0; j < w; j+=block)
                {
                    //Color col = bm.GetPixel(j, i );
                    //bm_new.SetPixel(j , i , Util.get256Color(col));


                    //计算每个block的平均颜色
                    int col_ct = 0, r = 0, g = 0, b = 0;
                    for(int k = i; k < i + block && k<h; k++)
                    {
                        for(int l=j;l<j+block && l < w; l++)
                        {
                            Color p = bm.GetPixel(l, k);
                            r += p.R;
                            g += p.G;
                            b += p.B;
                            col_ct++;
                        }
                    }
                    Color new_p = Color.FromArgb(r / col_ct, g / col_ct, b / col_ct);

                    //填充
                    for (int k = i; k < i + block && k < h; k++)
                    {
                        for (int l = j; l < j + block && l < w; l++)
                        {
                            bm_new.SetPixel(l, k, Util.get256Color(new_p));
                        }
                    }

                }
            }











            pictureBox1.Image = bm_new;
            //bm_new.Save("D:\\1.jpg");
        }
    }
}