using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TPFood
{
    public partial class Form10 : Form
    {
        private List<string> selectedItems;

        public Form10()
        {
            InitializeComponent();
            selectedItems = new List<string>();
        }

        private void UpdateLabelList()
        {
            labelList.Text = string.Join(Environment.NewLine, selectedItems.Select(item => "• " + item));
            labelList.AutoSize = false;
            labelList.Height = selectedItems.Count * 20;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void karaageBox_CheckedChanged(object sender, EventArgs e)
        {
            if (karaageBox.Checked)
            {
                selectedItems.Add(karaageBox.Text);
            }
            else
            {
                selectedItems.Remove(karaageBox.Text);
            }
            UpdateLabelList();
        }

        private void teriyakiBox_CheckedChanged(object sender, EventArgs e)
        {
            if (teriyakiBox.Checked)
            {
                selectedItems.Add(teriyakiBox.Text);
            }
            else
            {
                selectedItems.Remove(teriyakiBox.Text);
            }
            UpdateLabelList();
        }

        private void tonkatsuBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tonkatsuBox.Checked)
            {
                selectedItems.Add(tonkatsuBox.Text);
            }
            else
            {
                selectedItems.Remove(tonkatsuBox.Text);
            }
            UpdateLabelList();
        }

        private void yakitoriBox_CheckedChanged(object sender, EventArgs e)
        {
            if (yakitoriBox.Checked)
            {
                selectedItems.Add(yakitoriBox.Text);
            }
            else
            {
                selectedItems.Remove(yakitoriBox.Text);
            }
            UpdateLabelList();
        }

        private void cokeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cokeBox.Checked)
            {
                selectedItems.Add(cokeBox.Text);
            }
            else
            {
                selectedItems.Remove(cokeBox.Text);
            }
            UpdateLabelList();
        }

        private void fantaBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fantaBox.Checked)
            {
                selectedItems.Add(fantaBox.Text);
            }
            else
            {
                selectedItems.Remove(fantaBox.Text);
            }
            UpdateLabelList();
        }

        private void matchaBox_CheckedChanged(object sender, EventArgs e)
        {
            if (matchaBox.Checked)
            {
                selectedItems.Add(matchaBox.Text);
            }
            else
            {
                selectedItems.Remove(matchaBox.Text);
            }
            UpdateLabelList();
        }

        private void mugichaBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mugichaBox.Checked)
            {
                selectedItems.Add(mugichaBox.Text);
            }
            else
            {
                selectedItems.Remove(mugichaBox.Text);
            }
            UpdateLabelList();
        }

        private void mochiBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mochiBox.Checked)
            {
                selectedItems.Add(mochiBox.Text);
            }
            else
            {
                selectedItems.Remove(mochiBox.Text);
            }
            UpdateLabelList();
        }

        private void cakeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cakeBox.Checked)
            {
                selectedItems.Add(cakeBox.Text);
            }
            else
            {
                selectedItems.Remove(cakeBox.Text);
            }
            UpdateLabelList();
        }

        private void puddingBox_CheckedChanged(object sender, EventArgs e)
        {
            if (puddingBox.Checked)
            {
                selectedItems.Add(puddingBox.Text);
            }
            else
            {
                selectedItems.Remove(puddingBox.Text);
            }
            UpdateLabelList();
        }

        private void mousseBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mousseBox.Checked)
            {
                selectedItems.Add(mousseBox.Text);
            }
            else
            {
                selectedItems.Remove(mousseBox.Text);
            }
            UpdateLabelList();
        }

        private void labelList_Click(object sender, EventArgs e)
        {
        }

        private void labelList_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
        private void totalPrice_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
        }
    }
}
