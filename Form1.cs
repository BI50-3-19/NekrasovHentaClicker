using System;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {
        private int score;
        private int zaklik = 1;
        private int zasec;

        public Form1()
        {
            InitializeComponent();
            timer1.Tick += Timer1OnTick;
        }

        private void Timer1OnTick(object? sender, EventArgs e)
        {
            score += zasec;
            textBox7.Text = "Всего кошкодевочек: " + score;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score += zaklik;
            textBox7.Text = "Всего кошкодевочек: " + score;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (score >= Convert.ToInt32(textBox1.Text))
            {
                score -= Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToInt32(Convert.ToDouble(textBox1.Text) * 1.4).ToString();
                zaklik += Convert.ToInt32((sender as Button).Text);
                textBox5.Text = "Кошкодевочек за Клик " + zaklik;
                textBox7.Text = "Всего кошкодевочек: " + score;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (score >= Convert.ToInt32(textBox2.Text))
            {
                score -= Convert.ToInt32(textBox2.Text);
                textBox2.Text = Convert.ToInt32(Convert.ToDouble(textBox2.Text) * 1.4).ToString();
                zaklik += Convert.ToInt32((sender as Button).Text);
                textBox5.Text = "Кошкодевочек за Клик " + zaklik;
                textBox7.Text = "Всего кошкодевочек: " + score;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (score >= Convert.ToInt32(textBox3.Text))
            {
                score -= Convert.ToInt32(textBox3.Text);
                textBox3.Text = Convert.ToInt32(Convert.ToDouble(textBox3.Text) * 1.4).ToString();
                zasec += Convert.ToInt32((sender as Button).Text);
                textBox6.Text = "Кошкодевочек за Автоклик " + zasec;
                textBox7.Text = "Всего кошкодевочек: " + score;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (score >= Convert.ToInt32(textBox4.Text))
            {
                score -= Convert.ToInt32(textBox4.Text);
                textBox4.Text = Convert.ToInt32(Convert.ToDouble(textBox4.Text) * 1.4).ToString();
                zasec += Convert.ToInt32((sender as Button).Text);
                textBox6.Text = "Кошкодевочек за Автоклик " + zasec;
                textBox7.Text = "Всего кошкодевочек: " + score;
            }
        }
    }
}