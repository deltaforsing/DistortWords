using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<string[]> dic = new List<string[]>
        {
            new string[] {"ожк","озьг"},
            new string[] {"кол","га"},
            new string[] {"ко","га"},
            new string[] {"колгот","гагот"},
            new string[] {"шо","ша"},
            new string[] {"дка","ка"},
            new string[] {"он","онь"},
            new string[] {"б","п"},
            new string[] {"хи","ни"},
            new string[] {"шк","к"},
            new string[] {"тро","го"},
            new string[] {"тка","пка"},
            new string[] {"кров","кав"},
            new string[] {"ра","я"},
            new string[] {"дюк","дю"},
            new string[] {"ойд","анд"},
            new string[] {"дка","та"},
            new string[] {"ро","мо"},
            new string[] {"ны","ни"},
            new string[] {"ре","е"},
            new string[] {"ле","не"},
            new string[] {"ки","ке"},
            new string[] {"ш","ф"},
            new string[] {"шка","вха"},
            new string[] {"гри","ги"},
            new string[] {"ч","щ"},
            new string[] {"ре","ле"},
            new string[] {"го","хо"},
            new string[] {"ль","й"},
            new string[] {"иг","ег"},
            new string[] {"ра","ва"},
            new string[] {"к","г"},
            new string[] {"зо","йо"},
            new string[] {"зо","ё"},
            new string[] {"рё","йо"},
            new string[] {"ск","фк"},
            new string[] {"ры","вы"},
            new string[] {"шо","фо"},
            new string[] {"ло","ле"},
            new string[] {"сы","фи"},
            new string[] {"еня","ея"},
            new string[] {"пель","пюль"},
            new string[] {"а","я"},
            new string[] {"у","ю"},
            new string[] {"о","ё"},
            new string[] {"ща","ся"},
            new string[] {"ы","и"},
            new string[] {"и","й"},
            new string[] {"ри","ви"},
            new string[] {"ло","во"},
            new string[] {"е","и"},
            new string[] {"и","е"},
            new string[] {"а","о"},
            new string[] {"о","а"}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random gen = new Random();
            int prob = 0;
            string tmp = "";
            List<string> words = new List<string>();
            words.AddRange(MainTextBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            MainTextBox.Text = "";
            foreach(string str in words)
            {
                tmp = str;
                foreach (string[] str2 in dic)
                {
                    if(str.Contains(str2[0]))
                    {
                        prob = gen.Next(100);
                        if (prob <= int.Parse(textBoxPercent.Text))
                        {
                            tmp = str.Replace(str2[0], str2[1]);
                            break;
                        }
                    }
                }
                MainTextBox.Text += tmp + " ";
            }
        }
    }
}
