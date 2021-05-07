using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyHW
{
    public partial class Form1 : Form
    {
        #region property
        int index = 0;
        List<string> pathToImage = new List<string>
        {
            "C:/Users/tlvla/source/repos/SurveyHW/SurveyHW/Properties/Photos/image1.jpg",
            "C:/Users/tlvla/source/repos/SurveyHW/SurveyHW/Properties/Photos/image2.jpg",
            "C:/Users/tlvla/source/repos/SurveyHW/SurveyHW/Properties/Photos/image3.jpg",
            "C:/Users/tlvla/source/repos/SurveyHW/SurveyHW/Properties/Photos/image4.jpg"
        };
        #endregion
        public Form1()
        {
            InitializeComponent();
            trackBar1.Scroll += trackBar1_Scroll;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(pathToImage.First());
            pictureBox1.Image = imageList1.Images[0];
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(pathToImage.Last());
            //pictureBox1.Image = imageList1.Images[];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index == pathToImage.Count())
            {
                index = 0;
            }
            //pictureBox1.Image = Image.FromFile(pathToImage[index++]);
            pictureBox1.Image = imageList1.Images[index++];
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                //pictureBox1.Image = Image.FromFile(pathToImage[index--]);
                index--;
            }
            pictureBox1.Image = imageList1.Images[index];
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}", trackBar1.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = String.Format("{0}", trackBar2.Value);
        }
    }
}
