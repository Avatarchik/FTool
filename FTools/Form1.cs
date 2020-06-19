using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        public static string MD5(string text)
        {
            UTF8Encoding utf8Encoding = new UTF8Encoding();
            byte[] bytes = utf8Encoding.GetBytes(text);
            MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
            byte[] array = md5CryptoServiceProvider.ComputeHash(bytes);
            string text2 = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                text2 += Convert.ToString(array[i], 16).PadLeft(2, '0');
            }
            return text2.PadLeft(32, '0');
        }
        

        private void flatButton1_Click(object sender, EventArgs e)
        {


            openFileDialog1.Filter = "DLL (*.dll)|*.dll" +
"|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog2.Filter = "DEX (*.dex)|*.dex" +
"|All files (*.*)|*.*";
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {

                    flatTextBox1.Text = MD5(File.ReadAllBytes(openFileDialog2.FileName).Length +File.ReadAllBytes(openFileDialog1.FileName).Length.ToString());
                }
            }
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "DLL (*.dll)|*.dll" +
"|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Write))
                {
                
                    fileStream.Position = fileStream.Length;
                    byte[] array = new byte[String2Int(flatButton3.Text)];
                    fileStream.Write(array, 0, array.Length);
                    MessageBox.Show(String2Int(flatButton3.Text)+ " bytes added");
                }
            }
        }
        string one = "";
        private void flatTextBox2_DragDrop(object sender, DragEventArgs e)
        {
            string[] test = (string[])e.Data.GetData(DataFormats.FileDrop,false);
            foreach (string tttt in test)
                //MessageBox.Show(File.ReadAllBytes(tttt).Length.ToString());
                flatTextBox2.Text = File.ReadAllBytes(tttt).Length.ToString();

        }

        private void flatTextBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void flatTextBox3_DragDrop(object sender, DragEventArgs e)
        {
            string[] test = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string tt in test)
                flatTextBox3.Text = File.ReadAllBytes(tt).Length.ToString();
        }

        private void flatTextBox3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            flatButton3.Text = (String2Int(flatTextBox2.Text) - String2Int(flatTextBox3.Text)).ToString();
        }
        private static int String2Int(string text)
        {
            return Convert.ToInt32(text);
        }
    }
}
