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
    public partial class Form2 : Form
    {
        public Form2(string Name, string FatherName, string City, string NetStatus, string DoB)
        {
            InitializeComponent();
            lbl_Name.Text = Name;
            lbl_FatherName.Text = FatherName;
            lbl_City.Text = City;
            lbl_DoB.Text = DoB;
            lbl_Internet.Text = NetStatus;
           
        }
    }
}
