using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_caro
{
    public partial class Server : Form
    {
        List<Button> buttonList;
        List<Point1> pointList;
        SimpleTcpServer server;
        int x_return = 0;
        int y_return = 0;
        public Server()
        {
            InitializeComponent();
            LoadPoint();
            //EnableAllbuttonint(1);
        }
        private void LoadPoint()
        {
            panel1.Controls.Clear();
            pointList = new List<Point1>();
            pointList= ListPoint.Instance.LoadPointList();
            int x = 0;
            int y = 0;
            buttonList = new List<Button>();
            foreach(Point1 item in pointList)
            {
                Button btn = new Button() { Width =28 ,Height =28,BackgroundImageLayout =ImageLayout.Stretch };
                btn.Tag = item;
                btn.Click += Btn_Click;
                btn.Location = new Point(x+item.X*29,y+item.Y*29);
                btn.BackColor = Color.Cyan;
                btn.ImageAlign = ContentAlignment.MiddleRight;
                btn.Enabled = false;
                buttonList.Add(btn);
            }
            foreach(Button item in buttonList)
            {
                panel1.Controls.Add(item);
            }
        }
        /*
         private void btnStart_Click(object sender, EventArgs e)
        {
            server.Start();
            textInfo.Text += $"Startting .....{Environment.NewLine}";// create new line when have messsage;
            btnStart.Enabled = false;// cannot click when have this method
            btnSend.Enabled = true;// cannot click when have this method
        }
         */
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = Image.FromFile("D:\\sql\\Valorant Manage\\G2_Esportslogo_square.png");
            int x = ((sender as Button).Tag as Point1).X;   
            int y = ((sender as Button).Tag as Point1).Y;
            textMessage.Text = string.Empty;
            textMessage.Text += x.ToString() + " " + y.ToString();
            EnableAllbuttonint(1);
            //send to client 
            server.Send(textClientIp.Text.ToString(), $"YOUR TURN{x.ToString()}:{y.ToString()}");
            textTurn.Text = string.Empty;
            textTurn.Text += "Client turn";
            panel7.BackgroundImage = Image.FromFile("D:\\sql\\Valorant Manage\\Sentinels_Logo.png");
            x_return = x;y_return = y;
            btnReturn.Enabled = true;
            foreach(Point1 item in pointList)
            {
                if (item.X == x && item.Y == y)
                    item.Check = 1;
            }
            int check = checkWin(x, y);
            ListClientIP.Items.Add(check.ToString());
            if (check == -1)
            {
                server.Send(textClientIp.Text.ToString(),"win");
                MessageBox.Show("SERVER WIN", "MESSAGE", MessageBoxButtons.OK);
                Resetgame();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach(Button item in buttonList)
            {
                if (i  == 25)
                {
                    item.BackgroundImage = Image.FromFile("D:\\sql\\Valorant Manage\\Sentinels_Logo.png");
                }
                i++;
            }
        }
        private void EnableAllbuttonint(int check)
        {
            foreach(Button item in buttonList)
            {
                item.Enabled = (check == 1) ? false:true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Button item in buttonList)
            {
                item.Enabled = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Button item in buttonList)
            {
                item.Enabled = true;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;
            BtnConnect.Enabled = true;
            server.Start();
            textInfo.Text += $"Startting .....{Environment.NewLine}";// create new line when have messsage;
        }
        private void Server_Load(object sender, EventArgs e)
        {
            BtnConnect.Enabled = false;
            server = new SimpleTcpServer(textIP.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataRecceived;
        }
        private void addIconForButon(int x,int y)
        {
            foreach(Button item in buttonList)
            {
                if((item.Tag as Point1).X == x && (item.Tag as Point1).Y == y)
                {
                    item.BackgroundImage = Image.FromFile("D:\\sql\\Valorant Manage\\Sentinels_Logo.png");
                }
                item.Enabled = true;
            }
        }
        //Reser all Table
        private void Resetgame()
        {
            foreach (Point1 item in pointList)
                item.Check = 0;
            foreach (Button item in buttonList)
                item.BackgroundImage = base.BackgroundImage;
        }
        private void checkString(string s)
        {
            if(s.Contains("YOUR TURN"))
            {
                string x = "";
                string y = "";
                int i = 9;
                while (i < s.Length)
                {
                    if (s[i] == ':')
                    {
                        i++;
                        break;
                    }
                    else
                        x += s[i];
                    i++;
                }
                for (; i < s.Length; i++ )
                    y += s[i];
                textMessage.Text += x + ":" + y;
                addIconForButon(Int32.Parse(x), Int32.Parse(y));
                textTurn.Text = string.Empty;
                textTurn.Text += "Server turn";
                panel7.BackgroundImage = Image.FromFile("D:\\sql\\Valorant Manage\\G2_Esportslogo_square.png");
                btnReturn.Enabled = false;
                //addIconForButon(0, 0);
            }
            else if(s.Contains("New game"))
            {
                Resetgame();
                textTurn.Text = string.Empty;
                textTurn.Text = "Server turn";
            }
            else if (s.Contains("Undo"))
            {
                string x = "";
                string y = "";
                int i = 4;
                while (i < s.Length){
                    if (s[i] == ':'){
                        i++;
                        break;
                    }
                    else
                        x += s[i];
                    i++;
                }   
                for (; i < s.Length; i++)
                    y += s[i];
                ServerUndo(Int32.Parse(x), Int32.Parse(y), 0);
            }
            else if (s.Contains("win")){    
                MessageBox.Show("CLIENT WIN", "MESSAGE", MessageBoxButtons.OK);
                Resetgame();    
            }
        }
        private void Events_DataRecceived(object sender, DataReceivedEventArgs e)
        {
            string s = Encoding.UTF8.GetString(e.Data);
            checkString(s);
        }
        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (textClientIp.Text == e.IpPort){
                    LoadPoint();
                }
                textInfo.Text = string.Empty;
                textInfo.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                ListClientIP.Items.Remove(e.IpPort);
                BtnConnect.Enabled = true;
            });
        }
        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                textInfo.Text = string.Empty;
                textInfo.Text += $"{e.IpPort} connected.{Environment.NewLine}";
                ListClientIP.Items.Add(e.IpPort);
            });
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if(ListClientIP.SelectedItem != null)
            {
                BtnConnect.Enabled = false;
                EnableAllbuttonint(0);
                server.Send(ListClientIP.SelectedItem.ToString(), "start");
                textInfo.Text = string.Empty;
                textInfo.Text += "Start game with" + ListClientIP.SelectedItem.ToString();
            }
        }

        private void ListClientIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            textClientIp.Text = string.Empty;
            try
            {
                textClientIp.Text += ListClientIP.SelectedItem.ToString();
            }
            catch { }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            server.Send(textClientIp.Text.ToString(), "New game");
            Resetgame();
            textTurn.Text = string.Empty;
            textTurn.Text = "Server turn";
        }
        private void ServerUndo(int x, int y,int type)
        {
            foreach (Point1 item in pointList)
            {
                if (item.X == x && item.Y == y)
                    item.Check = 0;
            }
            foreach (Button item in buttonList)
            {
                if ((item.Tag as Point1).X == x && (item.Tag as Point1).Y == y)
                    item.BackgroundImage = base.BackgroundImage;
                item.Enabled = (type == 1) ? true : false;
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            server.Send(textClientIp.Text.ToString(),  $"Undo{x_return.ToString()}:{y_return.ToString()}");
            ServerUndo(x_return,y_return,1);
            btnReturn.Enabled = false;
        }
        //check win
        int checkWin1(int x,int y)
        {
            List<Point1> check1 = new List<Point1>();
            List<Point1> check2 = new List<Point1>();
            foreach(Point1 item in pointList)
            {
                if (item.X == x)
                    check1.Add(item);
                if (item.Y == y)
                    check2.Add(item);
            }
            int count = 0;string s = "";
            foreach(Point1 item in check1)
            {
                if (item.Check == 1){
                    count++;
                    if (count == 5) return -1;
                }
                else
                    count = 0;
            }
            count = 0;
            foreach (Point1 item in check2)
            {
                s += $"{item.X},";
                if (item.Check == 1) { 
                    count++;
                    if (count == 5) return -1;
                }
                else
                    count = 0;
            }
            return 0;
        }
        int checkWin2(int x, int y)
        {
            List<Point1> check1 = new List<Point1>();
            List<Point1> check2 = new List<Point1>();
            foreach (Point1 item in pointList)
            {
                if (x != item.X || y != item.Y)
                {
                    if ((x - item.X) == (y - item.Y))
                        check1.Add(item);
                    if ((x - item.X) == -(y - item.Y))
                        check2.Add(item);
                }
                else if(x==item.X && y == item.Y){
                    check1.Add(item);check2.Add(item);
                }
            }
            int count = 0;
            foreach(Point1 item in check1){
                if(item.Check == 1){
                    count++;
                    if (count == 5) return -1;
                }
                else 
                    count = 0;
            }
            foreach (Point1 item in check2)
            {
                if (item.Check == 1) { 
                    count++;
                    if (count == 5) return -1;
                }
                else
                    count = 0;
            }
            return 0;
        }
        int checkWin(int x,int y)
        {
            if (checkWin1(x, y) == -1) return -1;
            else if (checkWin2(x, y) == -1) return -1;
            return 0;
        }
    }
}
