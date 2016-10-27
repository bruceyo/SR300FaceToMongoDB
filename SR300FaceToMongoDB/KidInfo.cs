//-------------------------------------------﻿﻿﻿
// YU Xinbo  
// bruce.xb.yu@connect.polyu.hk      
// PhD Candidate 
// in the Hong Kong PolyTechnical University   
//-------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DF_FaceTracking.cs
{
    public partial class KidInfo : Form
    {
        public KidInfo()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_id.Text == "" || dtp_birthday.Text == "")
            {
                MessageBox.Show("Please complete the Kid Info.!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MainForm parent = (MainForm)this.Owner;
            try
            {
                parent.kid_name = txt_name.Text;
                parent.kid_stu_id = Int32.Parse(txt_id.Text);
                parent.kid_gender = rdo_boy.Checked ? "B" : "G";
                parent.kid_group = rdo_typical.Checked ? "T" : "S";
                parent.kid_birthday = dtp_birthday.Text;
                //Console.WriteLine(parent.kid_birthday);
                this.Close();
                this.Dispose();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
                parent.kid_name = "";
                parent.kid_stu_id = 0;
                parent.kid_gender = "";
                parent.kid_group = "";
                parent.kid_birthday = "";
            }
        }
    }
}
