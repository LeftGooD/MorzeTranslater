using System;
using System.Drawing;
using System.Windows.Forms;

namespace Translater
{
    public partial class Form1 : Form
    {
        public string str = null;
        public string str2 = null;
        public string strbufer = null;
        public string output = null;
        public string[] split;
        public float timesplit;
        public float time;
        public float timebufer;
        public float timerefresh;
        public int index;
        public bool timestart = false;


        public char[] rus = new char[42] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И',
                                     'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                     'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ','Ъ', 'Ы', 'Ь',
                                     'Э', 'Ю', 'Я', '1', '2', '3', '4', '5', '6', '7',
                                     '8', '9', '0' };

        public string[] morze = new string[42] {"*–", "–***", "*––", "––*",
                                           "–**", "*", "***–", "––**",
                                           "**", "*–––", "–*–", "*–**",
                                           "––", "–*", "–––", "*––*",
                                           "*–*", "***", "–", "**–",
                                           "**–*", "****", "–*–*",
                                           "–––*", "––––", "−−*−", "−−*−−",
                                           "−*−−", "−**−", "**−**",
                                           "**−−", "*−*−", "*−−−−",
                                           "**−−−", "***−−", "****−",
                                           "*****", "−****", "−−***",
                                           "−−−**", "−−−−*", "−−−−−" };

        public Form1()
        {
            InitializeComponent();
            Splitscroll.Value = 3;
            Timespacescroll.Value = 2;
            time = 2f;
            timerefresh = 2f;
            timesplit = 0.3f;
        }

        private void Updatetimer_Tick(object sender, EventArgs e)
        {
            if (timestart == true)//если нажали на Start
            {
                time -= 0.05f;
                label1.Text = time.ToString();
            }
            if (time <= 0)//если нет времени записываем строку из буфера,добавляем запятую,обновляем буфер и время
            {
                if (strbufer != null)
                {
                    str += strbufer;
                    str += ",";
                    strbufer = null;
                    time = timerefresh;
                    timebufer = 0f;
                }
            }
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            timestart = true;
        }

        private void Startbutton_KeyDown(object sender, KeyEventArgs e)
        {
            Presstimer.Enabled = true;
            pictureBox1.BackColor = Color.Green;
        }

        private void Startbutton_KeyUp(object sender, KeyEventArgs e)
        {
            Presstimer.Enabled = false;
            if (timebufer <= timesplit)//если время больше "времени разделения", то ставим в буфер "*", обновляем время
            {
                strbufer += "*";
                time = timerefresh;
                timebufer = 0f;
            }
            else if (timebufer > timesplit)//если время больше 0 но не больше "времени разделения", то ставим в буфер "–", обновляем время
            {
                strbufer += "–";
                time = timerefresh;
                timebufer = 0f;
            }
            pictureBox1.BackColor = Color.White;
        }

        private void Presstimer_Tick(object sender, EventArgs e)
        {
            timebufer += 0.05f;
        }

        private void Translatebut_Click(object sender, EventArgs e)
        {
            try
            {
                split = str.Split(',');//разделяем строку с морзе на массив строк
                foreach (string s in split)//перебираем массив со строками
                {
                    index = Array.IndexOf(morze, s);//записываем индекс совпадающих слов
                    if (index == -1)    //убейте меня
                        continue;      //нужно было 1 слово
                    output += rus[index] + " ";//ставим пробел
                    textBox1.Text = output;//выводим на экран
                    Updatetimer.Enabled = false;
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Пусто");
            }
        }

        private void Restartbut_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Application.Exit();
        }

        private void Splitscroll_Scroll(object sender, EventArgs e)
        {
            float i = Splitscroll.Value / 10f;
            timesplit = i;
            label2.Text = ("Время точки: " + i + " сек");
        }

        private void Timespacescroll_Scroll(object sender, EventArgs e)
        {
            float a = Timespacescroll.Value;
            time = a;
            timerefresh = a;
            label3.Text = ("Время между символами: " + a + " сек");
        }
    }
}
