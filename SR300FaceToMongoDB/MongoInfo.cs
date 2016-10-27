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
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Net.Sockets;

namespace DF_FaceTracking.cs
{
    public partial class MongoInfo : Form
    {
        public MongoInfo()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {

       if (txt_mongo_ip.Text == "" || txt_mongo_port.Text == "" || txt_mongo_db.Text == "") {
                MessageBox.Show("Please complete the MongoDB Info.!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MainForm parent = (MainForm)this.Owner;

            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(txt_mongo_ip.Text, Int32.Parse(txt_mongo_port.Text));

                parent._client = new MongoClient("mongodb://" + txt_mongo_ip.Text + ":" + txt_mongo_port.Text);
                parent._database = parent._client.GetDatabase(txt_mongo_db.Text);
                parent.mongo_collection = txt_mongo_col.Text;
                var collection = parent._database.GetCollection<BsonDocument>(txt_mongo_col.Text);
                var filter = new BsonDocument();
                BsonDocument cursor = collection.Find(filter).First<BsonDocument>();
                Console.WriteLine(parent._client.Cluster.Description.State);
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, excep.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                parent.mongo_collection = "";
                return;
            }
            this.Close();
            this.Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
