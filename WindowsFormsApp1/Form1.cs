﻿using System;
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
            int Port = int.Parse(textBox_listen_Port.Text);
            U = new UdpClient(Port);
            // 建立畚箕端點資訊
            IPEndPoint EP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Port);
            while (true)
            {
                byte[] B = U.Receive(ref EP);
                string A = Encoding.Default.GetString(B); //翻譯字串為陣列A
                string[] Q = A.Split('/');
                Point[] R = new Point[Q.Length];
                for(int i = 0; i < Q.Length; i++)
                {
                    string[] K = Q[i].Split(',');
                    R[i].X = int.Parse(K[0]);
                    R[i].Y = int.Parse(K[1]);
                }
                for (int i = 0; i < Q.Length - 1; i++)
                {
                    LineShape L = new LineShape();
                    L.StartPoint = R[i];
                    L.EndPoint = R[i + 1];
                    L.Parent = D;
                }
            }
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

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                LineShape L = new LineShape(); //建立線段物件
                L.StartPoint = stP; //線段起點
                L.EndPoint = e.Location; //線段終點
                L.Parent = C; //線段加入畫布C
                stP = e.Location; //終點變起點
                p += "/" + stP.X.ToString() + "," + stP.Y.ToString(); //持續記錄座標
            }
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int Port = int.Parse(textBox_target_Port.Text);
            UdpClient S = new UdpClient(textBox_target_IP.Text,Port);
            byte[] B = Encoding.Default.GetBytes(p);
            S.Send(B, B.Length);
            S.Close();
        }
    }
}