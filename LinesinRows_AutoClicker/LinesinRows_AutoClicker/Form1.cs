using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinesinRows_AutoClicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        globalKeyboardHook gkh = new globalKeyboardHook();

        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        public const int MOUSEEVENTF_LEFTUP = 0x0004;

        public int X = Cursor.Position.X;
        public int Y = Cursor.Position.Y;

        public int maxSayi;
        public int tiklasay = 1;
        public byte hangiBiri = 1;

        public Form1()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            gkh.HookedKeys.Add(Keys.Oemcomma);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
            textBox_TusAta.Text = "Oemcomma";

            timer1.Enabled = false;
            timer1.Interval = 15;

            if (Properties.Settings.Default.tusAtamax != 0)
            {
                textBox_TusAta.Text = Properties.Settings.Default.tusAtamax.ToString();
                gkh.HookedKeys.Clear();
                gkh.HookedKeys.Add(Properties.Settings.Default.tusAtamax);

            }
        }

        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            // tuşa basınca         
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                label2.Text = "Çalışıyor";
                label2.ForeColor = Color.Green;
                //Bass();
            }
            else
            {
                timer1.Enabled = false;
                label2.Text = "Beklemede";
                label2.ForeColor = Color.Red;
                // Yeniden kaç defa sayacaksa resetledik
                tiklasay = 1;
            }  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MaxTiklaCheck.Checked && tiklasay <= maxSayi)
            {
                if (hangiBiri == 1)
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                }
                else if (hangiBiri == 2)
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                }
                else
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                }

                tiklasay++;
            }

            else if(MaxTiklaCheck.Checked && tiklasay > maxSayi)
            {
                timer1.Enabled = false;
                label2.Text = "Beklemede";
                label2.ForeColor = Color.Red;
                // Yeniden kaç defa sayacaksa resetledik
                tiklasay = 1;
            }

            else
            {
                if (hangiBiri == 1)
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                }
                else if (hangiBiri == 2)
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                }
                else
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                }
            }
        }

        private void checkBoxDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDefault.Checked)
            {
                checkBoxX2.Checked = false;
                checkBoxX3.Checked = false;
                hangiBiri = 1;
            }
        }

        private void checkBoxX2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxX2.Checked)
            {
                checkBoxDefault.Checked = false;
                checkBoxX3.Checked = false;
                hangiBiri = 2;
            }
            
        }

        private void checkBoxX3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxX3.Checked)
            {
                checkBoxDefault.Checked = false;
                checkBoxX2.Checked = false;
                hangiBiri = 3;
            }
            
        }

        private void MaxTiklaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (MaxTiklaCheck.Checked)
            {
                MaxTiklaSayi.Enabled = true;
            }
            else
            {
                MaxTiklaSayi.Enabled = false;
            }
        }

        private void MaxTiklaSayi_TextChanged(object sender, EventArgs e)
        {
            var isNumeric = int.TryParse(MaxTiklaSayi.Text.ToString(), out _);

            if (MaxTiklaSayi.Text.Length > 0 && isNumeric)
            {
                maxSayi = Convert.ToInt32(MaxTiklaSayi.Text);
            }
            else
            {
                maxSayi = 1;
                MaxTiklaSayi.Text = "";
                MessageBox.Show("Sadece rakam girmelisiniz ve boş olmamalı!", "Hata!");   
            }
            
        }

        private void textBox_TusAta_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Yeni ayarlanan tuş: " + e.KeyCode);

            textBox_TusAta.Text = e.KeyCode.ToString();
            gkh.HookedKeys.Clear();
            gkh.HookedKeys.Add(e.KeyCode);
            // Aşağısı artık textbox seçili olmasın diye..
            textBox_TusAta.Enabled = false;
            textBox_TusAta.Enabled = true;

            Properties.Settings.Default.tusAtamax = e.KeyCode;
            Properties.Settings.Default.Save();
        }

    }
}
