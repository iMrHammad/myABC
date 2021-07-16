using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHNWinProject
{
    //This is the main form here.
    /// <summary>
    /// THis is the summry file
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string InternetCheckBoxResult = "NoVlaue";

            if(chk_Interner.CheckState == CheckState.Checked)
            {
                InternetCheckBoxResult = "Yes I have Internet";
            }
            else
            {
                InternetCheckBoxResult = "No I don't have Internet";

            }
            Form2 myobj = new Form2(txt_Name.Text,txt_FatherName.Text,cmb_City.Text,InternetCheckBoxResult,dtPicker.Text);
            myobj.Show();
            //this is new comment
        }
            
    }
}
