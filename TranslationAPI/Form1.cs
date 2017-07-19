using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslationAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string lang1="auto";
        public static string lang2 = "zh";
        //翻译
        private void translateBtn_Click(object sender, EventArgs e)
        {
            if (fromTxt.Text != String.Empty)
            {
                toTxt.Clear();
                toTxt.Text = TranslationOp.translation(fromTxt.Text, lang1, lang2);
            }
        }

        //清空
        private void clearBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hahaha");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void xiala1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lang1=xiala1.SelectedItem.ToString();
            lang1 = TranslationOp.toEnglish(lang1);
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lang2 = xiala2.SelectedItem.ToString();
            lang2 = TranslationOp.toEnglish(lang2);
            if (lang2 =="auto")
                lang2 = "en";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp;
            temp = lang1;
            lang1 = lang2;
            lang2 = temp;
            xiala1.Text = TranslationOp.toChinese(lang1);
            xiala2.Text = TranslationOp.toChinese(lang2);
        }

        private void fromTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (fromTxt.Text != String.Empty)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    toTxt.Clear();
                    toTxt.Text = TranslationOp.translation(fromTxt.Text, lang1, lang2);
                }
            }
          
        }

        private void fromTxt_TextChanged(object sender, EventArgs e)
        {
            if (fromTxt.Text != String.Empty)
            {
              //  fromTxt.Font = new Font("宋体", 20);  设置字体大小
                int line = fromTxt.GetLineFromCharIndex(fromTxt.TextLength) + 1;//获取textbox行数
                
                button2.Visible = true;
                if (TranslationOp.judgement(fromTxt.Text) == 2)
                {
                    xiala1.Text = "英语";
                    lang1 = "en";
                    xiala2.Text = "中文";
                    lang2 = "zh";
                }
                else if (TranslationOp.judgement(fromTxt.Text) == 1)
                {
                    xiala1.Text = "中文";
                    lang1 = "zh";
                    xiala2.Text = "英语";
                    lang2 = "en";
                }
                if(line>=5)//实现行数变大时字体变小
                {
                    fromTxt.Font = new Font("宋体", 10);
                }
            }
            else
            {
                xiala1.Text = "自动检测";
                lang1 = "auto";
            }
        }
        private void toTxt_TextChanged(object sender, EventArgs e)
        {
            int line = toTxt.GetLineFromCharIndex(toTxt.TextLength) + 1;
            if (line >= 5)//实现行数变大时字体变小
            {
                toTxt.Font = new Font("宋体", 10);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            toTxt.Clear();
            fromTxt.Clear();
            button2.Visible = false;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            translateBtn.Focus();
           
        }
    }
}
