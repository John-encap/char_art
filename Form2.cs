using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSconnectChallange
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            
            
            
        }


        //default draw button -> Default_Draw_Click ->
        public void load_text_box(String pixelString, float fontsize)
        {
            richTextBox1.Text = pixelString;
            richTextBox1.Font = new Font(FontFamily.GenericSerif, fontsize);
        }
        //draw button -> Draw_Click ->
        public void load_text_box_sp(String pixelString, float fontsize, String font)
        {
            richTextBox1.Text = pixelString;
            richTextBox1.Font = new Font(font, fontsize);
        }
    }
}
