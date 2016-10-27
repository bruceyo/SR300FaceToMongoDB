//-------------------------------------------﻿﻿﻿
// YU Xinbo  
// bruce.xb.yu@connect.polyu.hk      
// PhD Candidate 
// in the Hong Kong PolyTechnical University   
//-------------------------------------------
namespace DF_FaceTracking.cs
{
    partial class KidInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.rdo_boy = new System.Windows.Forms.RadioButton();
            this.rdo_girl = new System.Windows.Forms.RadioButton();
            this.rdo_special = new System.Windows.Forms.RadioButton();
            this.rdo_typical = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(78, 19);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(131, 20);
            this.txt_name.TabIndex = 3;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(78, 45);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(131, 20);
            this.txt_id.TabIndex = 4;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(31, 160);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(74, 21);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(135, 160);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(74, 21);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // rdo_boy
            // 
            this.rdo_boy.AutoSize = true;
            this.rdo_boy.Location = new System.Drawing.Point(58, 5);
            this.rdo_boy.Name = "rdo_boy";
            this.rdo_boy.Size = new System.Drawing.Size(43, 17);
            this.rdo_boy.TabIndex = 7;
            this.rdo_boy.TabStop = true;
            this.rdo_boy.Text = "Boy";
            this.rdo_boy.UseVisualStyleBackColor = true;
            // 
            // rdo_girl
            // 
            this.rdo_girl.AutoSize = true;
            this.rdo_girl.Location = new System.Drawing.Point(123, 5);
            this.rdo_girl.Name = "rdo_girl";
            this.rdo_girl.Size = new System.Drawing.Size(40, 17);
            this.rdo_girl.TabIndex = 8;
            this.rdo_girl.TabStop = true;
            this.rdo_girl.Text = "Girl";
            this.rdo_girl.UseVisualStyleBackColor = true;
            // 
            // rdo_special
            // 
            this.rdo_special.AutoSize = true;
            this.rdo_special.Location = new System.Drawing.Point(123, 3);
            this.rdo_special.Name = "rdo_special";
            this.rdo_special.Size = new System.Drawing.Size(60, 17);
            this.rdo_special.TabIndex = 11;
            this.rdo_special.TabStop = true;
            this.rdo_special.Text = "Special";
            this.rdo_special.UseVisualStyleBackColor = true;
            // 
            // rdo_typical
            // 
            this.rdo_typical.AutoSize = true;
            this.rdo_typical.Location = new System.Drawing.Point(58, 3);
            this.rdo_typical.Name = "rdo_typical";
            this.rdo_typical.Size = new System.Drawing.Size(59, 17);
            this.rdo_typical.TabIndex = 10;
            this.rdo_typical.TabStop = true;
            this.rdo_typical.Text = "Typical";
            this.rdo_typical.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Group:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Birthday:";
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.CustomFormat = "\"dd-MM-yyyy\"";
            this.dtp_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_birthday.Location = new System.Drawing.Point(78, 71);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(131, 20);
            this.dtp_birthday.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdo_girl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rdo_boy);
            this.panel1.Location = new System.Drawing.Point(25, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 28);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdo_special);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rdo_typical);
            this.panel2.Location = new System.Drawing.Point(25, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 25);
            this.panel2.TabIndex = 15;
            // 
            // KidInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 199);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtp_birthday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KidInfo";
            this.Text = "Kid Info.";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.RadioButton rdo_boy;
        private System.Windows.Forms.RadioButton rdo_girl;
        private System.Windows.Forms.RadioButton rdo_special;
        private System.Windows.Forms.RadioButton rdo_typical;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}