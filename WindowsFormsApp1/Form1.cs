using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic.PowerPacks;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        UdpClient U;
        Thread Th;
        ShapeContainer C; //畫布物件
        ShapeContainer D; //畫布物件
        Point stP; //繪圖起點
        string p; //畫筆座標字串
        public Form1()
        {
            InitializeComponent();
        }
        private void Listen()
        {

        }
        private void button_connect_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Th = new Thread(Listen);
            Th.Start();
            button_connect.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Th.Abort(); //關閉監聽執行續
                U.Close(); //關閉監聽器
            }
            catch
            {
                //忽略錯誤
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            C = new ShapeContainer(); //建立畫布
            this.Controls.Add(C);
            D = new ShapeContainer(); //建立畫布
            this.Controls.Add(D);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            stP = e.Location;
            p = stP.X.ToString() + "," + stP.Y.ToString();
        }
    }
}
