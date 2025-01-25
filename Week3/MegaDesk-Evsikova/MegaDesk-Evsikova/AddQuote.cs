using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Evsikova
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void CloseAddQuote_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        private void width_TextChanged(object sender, EventArgs e)
        {

        }

        private void width_Validating(object sender, CancelEventArgs e)
        {
            string widthText = width.Text;

            bool allDigits = true;
            foreach (char c in widthText)
            {
                if (!char.IsDigit(c))
                {
                    allDigits = false;
                    MessageBox.Show("Width can contain only digits");

                    break;
                }
            }
            if (allDigits)
            {
                try
                {
                    int width = int.Parse(this.width.Text);
                    if (width < Desk.minwidth || width > Desk.maxwidth)
                    {
                        MessageBox.Show($"Please enter a valid width between {Desk.minwidth} & {Desk.maxwidth}");
                        this.width.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Please enter a valid width between {Desk.minwidth} & {Desk.maxwidth}");
                    this.width.Focus();
                }
            }
        }
        private void depth_TextChanged(object sender, EventArgs e)
        {

        }

        private void depth_Validating(object sender, CancelEventArgs e)
        {
                try
                {
                    int depth = int.Parse(this.depth.Text);
                    if (depth < Desk.mindepth || depth > Desk.maxdepth)
                    {
                        MessageBox.Show($"Please enter a valid depth between {Desk.mindepth} & {Desk.maxdepth}");
                        this.depth.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Please enter a valid depth between {Desk.mindepth} & {Desk.maxdepth}");
                    this.depth.Focus();
                }
            }
            

        private void Depth_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (char.IsControl(e.KeyChar))
                {
                    return;
                }
                if (!Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            
        }
    }
}
