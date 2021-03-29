using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_8
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
      int index = listBox1.SelectedIndex;
      string str = (string)listBox1.Items[index];
      int len = str.Length;
      int countopen = 0;
      int countclosed = 0;
      int i = 0;
      while (i < len)
      {
        // Если нашли пробел, то увеличиваем счетчик пробелов на 1
        if (str[i] == '(')
        {
          countopen++;
        }
          
        if (str[i] == ')')
        {
          countclosed++;
        }
       
        i++;
      }
      if (countopen == countclosed)
        label1.Text = "Правильно";
      else
        label1.Text = "Неправильно";
    }
    }
}
