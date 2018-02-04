using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_ChrisZitting
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void btn_aq_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }

        private void tb_aq_width_Validating(object sender, CancelEventArgs e)
        {
            if (tb_aq_width.Text.Length == 0)
                return;

            if(double.Parse(tb_aq_width.Text) < 24 || double.Parse(tb_aq_width.Text) > Desk.MAX_WIDTH)
            {                
                tb_aq_width.ForeColor = System.Drawing.Color.Red;
                tb_aq_width.Focus();
                MessageBox.Show("The value you entered is not within the allowed width, please enter a value between 24 and 96.");
                tb_aq_width.Text = "";
            }
            else
            {
                tb_aq_width.ForeColor = System.Drawing.Color.ForestGreen;
            }
            //try
            //{
            //    int.TryParse(tb_aq_width.Text, out int deskWidth);
            //    if (deskWidth < 24)
            //    {
            //        tb_aq_width.ForeColor = System.Drawing.Color.ForestGreen;
            //    }


                //}
        }
    }
}
