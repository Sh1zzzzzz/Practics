using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_11
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
      int index = listBox1.SelectedIndex;
      string str = (string)listBox1.Items[index];
      int len = str.Length;
      int count = 0;
      int i = 0;
      while (i < len)
      {

        if (str[i] == '0' ^ str[i] == '1' ^ str[i] == '2' ^ str[i] == '3' ^ str[i] == '4' ^ str[i] == '5' ^ str[i] == '6' ^ str[i] == '7' ^ str[i] == '8' ^ str[i] == '9' )
          count++;
        i++;
      }
      label1.Text = "Количество цифр = " + count.ToString();
    }
    }
}
