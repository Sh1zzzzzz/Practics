using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_7
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void label2_Click(object sender, EventArgs e)
        {

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
        if (str[i] == '.' || str[i] == '?' || str[i] == '!')
          count++;
        i++;
      }
      label1.Text = "Количество предложений: " + count.ToString();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
