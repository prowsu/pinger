using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;

/*
 * Pinger 1.0
 * 
 * A lightweight tool for infinitely ping 8.8.8.8 IP address.
 * Make a ping.txt file to ping another IP.
 * 
 * Author: Evgenii Bogdanov <admin@prow.su>
 * Fork me on GitHub:
 * https://github.com/prowsu/pinger
 * */

namespace Pinger
{
    public partial class Form1 : Form
    {
        private Thread thread;
        private bool showBalloon = false;
        private bool canClose = false;
        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
        }
        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !canClose;
            this.Visible = false;
        }
        private void ForkMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/prowsu/pinger");
        }
        private void pingInit()
        {
            thread = new Thread(pingProcess);
            thread.IsBackground = true;
            thread.Start();
        }
        private void pingProcess()
        {
            Ping ping = new Ping();
            PingReply reply;
            string replyOut = "";
            string ip = "";
            try
            {
                ip = System.IO.File.ReadAllText("ping.txt");
            }
            catch { }
            ip = ip != "" ? ip : "8.8.8.8";
            while (true)
            {
                try
                {
                    reply = ping.Send(ip,5000);
                    replyOut = reply.RoundtripTime.ToString()+"ms";
                }
                catch (Exception e)
                {
                    replyOut = "(>5000ms) !!!\r\n" + e.Message;
                }
                Thread.Sleep(1000);
                if (showBalloon)
                {
                    this.Invoke((MethodInvoker)delegate
                        {
                            PingerIcon.ShowBalloonTip(0, "Pinger", "IP: "+ip+" timeout: " + replyOut, PingerIcon.BalloonTipIcon);
                        });
                }
                
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Visible = false;
            pingInit();
            MenuItem[] items = new MenuItem[2];
            items[0] = new MenuItem("About",items_0);
            items[1] = new MenuItem("Exit", items_1);
            ContextMenu menu = new ContextMenu(items);
            PingerIcon.ContextMenu = menu;
        }
        private void PingerIcon_MouseClick(object sender, MouseEventArgs e)
        {
            showBalloon = !showBalloon;
        }
        private void PingerIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            showBalloon = false;
        }
        void items_0(object sender, EventArgs e)
        {
            this.Visible = true;
        }
        void items_1(object sender, EventArgs e)
        {
            canClose = true;
            this.Close();
        }
    }
}
