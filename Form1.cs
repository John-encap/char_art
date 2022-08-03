using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Media;
using Color = System.Drawing.Color;
using FontFamily = System.Drawing.FontFamily;

namespace IFSconnectChallange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //
           foreach(FontFamily font in FontFamily.Families)
            {
                fontFam.Items.Add(font.Name.ToString());
            }
            
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            String inputFile = @input.Text;
            String outputFile = @output.Text;
            String font = fontFam.Text;
            float fontSize = 8;
            char startChar = char.Parse(strtChar.Text);
            char endChar = char.Parse(enChar.Text);
            

            string[] Character_range = charSet(startChar, endChar);



            String[] pixelString = { getPixelValueString(loadImage(inputFile), Character_range, Character_range.Length) };
            drawTextFile(pixelString, outputFile);




            Form2 form = new Form2();
            form.Show();
            
            form.load_text_box_sp(pixelString[0], fontSize, font);
        }

        private void Default_Draw_Click(object sender, EventArgs e)
        {
            
            String inputFile = @input.Text;
            String outputFile = @output.Text;
            //FontFamily font = "Consolas";
            float fontSize = 8;
            char startChar = '@';
            char endChar = ' ';
            int CharacterRange = 11;

            string[] Character_range = { "@", "$", "B", "o", "n", "+", "*", ":", "-", ".", " " };
            Character_range[0] = startChar.ToString();
            Character_range[CharacterRange - 1] = endChar.ToString();



            String[] pixelString = { getPixelValueString(loadImage(inputFile), Character_range, CharacterRange) };
            drawTextFile(pixelString, outputFile);

            
            

            Form2 form = new Form2();
            form.Show();

            form.load_text_box(pixelString[0], fontSize);
        }


        private  Bitmap loadImage(String inputFile)
        {
            Bitmap img = new Bitmap(inputFile);
            return img;
        }

        private String getPixelValueString(Bitmap img, string[] Character_range,int CharacterRange)
        {
            int avg;
            int Matching_char_index;
            Color pixel;
            Color pixelValue;
            String pixelString = "";


            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    

                    pixel = img.GetPixel(j, i);
                    avg = (pixel.R + pixel.G + pixel.B) / 3;
                    pixelValue = Color.FromArgb(avg, avg, avg);
                    Matching_char_index = (pixelValue.R * (CharacterRange-1)) / 255;
                    pixelString += Character_range[Matching_char_index] + " ";


                }
                pixelString += "\x0A";
            }

            return pixelString; 
        }


        private void drawTextFile(string[] pixelString, String outputFile)
        {
            File.WriteAllLines(outputFile, pixelString);
        }

        private String[] charSet(char fChar,char enChar)
        {
            int first = (char)fChar;
            int end = (char)enChar;
            int range = end - first + 1;
            String[] arr = new String[range];
            if (range > 0)
            {
                for(int i= 0; i < range; i++)
                {
                    arr[i] = ((char)(i + first)).ToString();
                }
            }
            else
            {
                for (int i = 0; i < range; i++)
                {
                    arr[i] = ((char)(i + enChar)).ToString();
                }
            }
            
            return arr;
        }

        
    }
}