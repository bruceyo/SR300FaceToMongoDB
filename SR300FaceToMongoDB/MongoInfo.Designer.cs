namespace DF_FaceTracking.cs
{
    partial class MongoInfo
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txt_mongo_ip = new System.Windows.Forms.TextBox();
            this.txt_mongo_port = new System.Windows.Forms.TextBox();
            this.txt_mongo_db = new System.Windows.Forms.TextBox();
            this.txt_mongo_col = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(209, 25);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(89, 37);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Host Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Database:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Collection:";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(209, 85);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(89, 37);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txt_mongo_ip
            // 
            this.txt_mongo_ip.Location = new System.Drawing.Point(83, 22);
            this.txt_mongo_ip.Name = "txt_mongo_ip";
            this.txt_mongo_ip.Size = new System.Drawing.Size(109, 20);
            this.txt_mongo_ip.TabIndex = 6;
            this.txt_mongo_ip.Text = "192.168.142.128";
            // 
            // txt_mongo_port
            // 
            this.txt_mongo_port.Location = new System.Drawing.Point(83, 51);
            this.txt_mongo_port.Name = "txt_mongo_port";
            this.txt_mongo_port.Size = new System.Drawing.Size(109, 20);
            this.txt_mongo_port.TabIndex = 7;
            this.txt_mongo_port.Text = "27017";
            // 
            // txt_mongo_db
            // 
            this.txt_mongo_db.Location = new System.Drawing.Point(83, 80);
            this.txt_mongo_db.Name = "txt_mongo_db";
            this.txt_mongo_db.Size = new System.Drawing.Size(109, 20);
            this.txt_mongo_db.TabIndex = 8;
            this.txt_mongo_db.Text = "test";
            // 
            // txt_mongo_col
            // 
            this.txt_mongo_col.Location = new System.Drawing.Point(83, 109);
            this.txt_mongo_col.Name = "txt_mongo_col";
            this.txt_mongo_col.Size = new System.Drawing.Size(109, 20);
            this.txt_mongo_col.TabIndex = 9;
            this.txt_mongo_col.Text = "asdset";
            // 
            // MongoInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 154);
            this.Controls.Add(this.txt_mongo_col);
            this.Controls.Add(this.txt_mongo_db);
            this.Controls.Add(this.txt_mongo_port);
            this.Controls.Add(this.txt_mongo_ip);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Name = "MongoInfo";
            this.Text = "MongoDB IP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txt_mongo_ip;
        private System.Windows.Forms.TextBox txt_mongo_port;
        private System.Windows.Forms.TextBox txt_mongo_db;
        private System.Windows.Forms.TextBox txt_mongo_col;
    }
}