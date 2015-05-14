using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace ccgcscx
{
    public partial class Formhide : Form
    {
        TcpListener listener;
        public delegate void lisdet(string str);
        public Formhide()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textIp.Text == "")
            {
                MessageBox.Show("IP不能为空！");
            }
            else
            {
                try
                {
                    listener = new TcpListener(IPAddress.Parse(textIp.Text), int.Parse("6688"));
                    listener.Start();
                    listBox1.Items.Add("监听开启...");
                    Thread th = new Thread(ReceiveMsg);
                    th.Start();
                    listBox1.Items.Add("开启监听对IP为" + textIp.Text + "的主机的监听成功！");
                    th.IsBackground = true;
                }

                catch
                { }
            }
        }

        public void ReceiveMsg()
        {
            lisdet addlist1 = new lisdet(setlis1);
            while (true)
            {
                try
                {

                    int size = 0;
                    int len = 0;
                    TcpClient client = listener.AcceptTcpClient();

                    if (client.Connected)
                    {
                        //向列表控件中添加一个客户端的Ip和端口，作为发送时客户的唯一标识
                        listBox1.Invoke(addlist1, "客户端连接成功" + client.Client.RemoteEndPoint.ToString());
                    }
                    NetworkStream stream = client.GetStream();
                    if (stream != null)
                    {
                        string fileSavePath = System.AppDomain.CurrentDomain.BaseDirectory + "Receive\\1.zip";
                        //string fileSavePath = "D:\\接收\\1.zip";//获得用户保存文件的路径
                        FileStream fs = new FileStream(fileSavePath, FileMode.Create, FileAccess.Write);

                        byte[] buffer = new byte[512];
                        while ((size = stream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fs.Write(buffer, 0, size);
                            len += size;
                        }
                        fs.Flush();
                        stream.Flush();
                        stream.Close();
                        client.Close();
                        fs.Close();
                        listBox1.Invoke(addlist1,"文件接受成功,保存于" + fileSavePath);

                    }
                }

                catch (Exception ex)
                {
                    listBox1.Invoke(addlist1, "出现异常：" + ex.Message);
                }

            }
        }

        //添加LISTBOX的委托需要的方法
        public void setlis1(string str)
        {
            listBox1.Items.Add(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxtype.Text == "" || textBoxpath.Text == "" || textBoxfont.Text == "")
                {
                    MessageBox.Show("存在空选项，请确认！");
                }
                else
                {
                    string str = "HU" + ";" + textBoxtype.Text + ";" + textIp.Text + ";" + textBoxfont.Text + ";" + textBoxpath.Text;
                    System.Text.UTF8Encoding encode = new System.Text.UTF8Encoding();
                    byte[] fadate = encode.GetBytes(str);
                    UdpClient fa = new UdpClient(5578);
                    IPAddress ipend = IPAddress.Parse(textBoxIpm.Text);
                    IPEndPoint ipp = new IPEndPoint(ipend, 5577);
                    fa.Send(fadate, fadate.Length, ipp);
                    fa.Close();

                }
            }
            catch
            { }
        }


    }
}
