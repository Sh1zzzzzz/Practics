using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_5
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
      label1.Text = "";
      // Получаем номер выделенной строки
      int index = listBox1.SelectedIndex;
      // Считываем строку в перменную str
      string str = (string)listBox1.Items[index];
      // Узнаем количество символов в строке
      int len = str.Length;

      for (int i = len;  i > 0; i--)
      {
        label1.Text += str[i - 1];
      }
    }
    }
}
