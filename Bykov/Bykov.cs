using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bykov
{
    public partial class Bykov : Form
    {
        public Bykov()
        {
            InitializeComponent();
        }

        private void pictureGame15_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Exec\\Game15.exe");
            }
            catch
            {
                MessageBox.Show("К сожалению, файл с программой не найден","Ошибка");
            }
        }

        private void picturePassword_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Exec\\Менеджер паролей.exe");
            }
            catch
            {
                MessageBox.Show("К сожалению, файл с программой не найден", "Ошибка");
            }
        }

        private void picture12Mouth_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Exec\\12 месяцев.exe");
            }
            catch
            {
                MessageBox.Show("К сожалению, файл с программой не найден", "Ошибка");
            }
        }

        private void pictureAbout_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.videosharp.info/13850");
        }
    }
}
