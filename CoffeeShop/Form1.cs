using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            if (comboBoxName.SelectedItem.ToString() == "Latte")
            {
                if (comboBoxType.SelectedItem.ToString() == "Frapp")
                {
                    textBoxPayment.Text = (float.Parse(comboBoxQuantity.Text) * 15).ToString();
                }

                if (comboBoxType.SelectedItem.ToString() == "Ice")
                {
                    textBoxPayment.Text = (float.Parse(comboBoxQuantity.Text) * 12).ToString();
                }

                if (comboBoxType.SelectedItem.ToString() == "Hot")
                {
                    textBoxPayment.Text = (float.Parse(comboBoxQuantity.Text) * 10).ToString();
                }

                dataGridView1.Rows.Add(textBoxID.Text, comboBoxName.Text, comboBoxType.Text, comboBoxQuantity.Text, textBoxPayment.Text);
            }

            if (comboBoxName.SelectedItem.ToString() == "Cappucino")
            {
                if (comboBoxType.SelectedItem.ToString() == "Frapp")
                {
                    textBoxPayment.Text = (float.Parse(comboBoxQuantity.Text) * 17).ToString();
                }

                if (comboBoxType.SelectedItem.ToString() == "Ice")
                {
                    textBoxPayment.Text = (float.Parse(comboBoxQuantity.Text) * 14).ToString();
                }

                if (comboBoxType.SelectedItem.ToString() == "Hot")
                {
                    textBoxPayment.Text = (float.Parse(comboBoxQuantity.Text) * 12).ToString();
                }

                dataGridView1.Rows.Add(textBoxID.Text, comboBoxName.Text, comboBoxType.Text, comboBoxQuantity.Text, textBoxPayment.Text);
            }

            if (comboBoxName.SelectedItem.ToString() == "Chocolate")
            {
                if (comboBoxType.SelectedItem.ToString() == "Frapp")
                {
                    textBoxPayment.Text = (float.Parse(comboBoxQuantity.Text) * 19).ToString();
                }

                if (comboBoxType.SelectedItem.ToString() == "Ice")
                {
                    textBoxPayment.Text = (float.Parse(comboBoxQuantity.Text) * 16).ToString();
                }

                if (comboBoxType.SelectedItem.ToString() == "Hot")
                {
                    textBoxPayment.Text = (float.Parse(comboBoxQuantity.Text) * 14).ToString();
                }

                dataGridView1.Rows.Add(textBoxID.Text, comboBoxName.Text, comboBoxType.Text, comboBoxQuantity.Text, textBoxPayment.Text);
            }
        }

        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }

            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            comboBoxName.Text = "";
            comboBoxType.Text = "";
            comboBoxQuantity.Text = "";
            textBoxPayment.Text = "";

            textBoxID.Focus();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
